using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Management_UI
{

    public partial class ColumnPermission : Form
    {
        private string _tableName { get; set; }
        private string _userName { get; set; }

        private bool _type { get; set; }
        private string DataC { get; set; }
        private string DataView { get; set; }
        private HashSet<string> Column { get; set; } = new HashSet<string>();

        public ColumnPermission()
        {
            InitializeComponent();
        }
        public ColumnPermission(string tabelname, string _nameuser, bool type)
        {
            _tableName = tabelname;
            _userName = _nameuser;
            InitializeComponent();
            this._type = type;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ColumnPermission_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column", "Column");
            label1.Text = "Table: " + _tableName;
            MessageBox.Show(_tableName);
            MessageBox.Show(_userName);
            this.dataGridTableInfoSelect.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT column_name FROM user_tab_cols WHERE table_name = '{_tableName}'");
            this.dataGridTableViewsSelect.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT TABLE_NAME,GRANTABLE  FROM all_tab_privs WHERE privilege = 'SELECT' AND type = 'VIEW' AND GRANTEE='{_userName}'");
            this.dataGridViewUpdateInfo.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '{_tableName}'");
            this.dataGridViewUpdatePrivs.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"select * from DBA_COL_PRIVS WHERE GRANTEE = '{_userName}' AND TABLE_NAME = '{_tableName}'");
        }

        private void dataGridTableInfoSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataC = dataGridTableInfoSelect.Rows[e.RowIndex].Cells["column_name"].Value.ToString();

            Column.Add(DataC);
            dataGridView1.Rows.Clear();
            foreach (string col in Column)
            {
                this.dataGridView1.Rows.Add("Column", col);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Column.Clear();
            dataGridView1.Rows.Clear();
        }

        private void grantSelectBtn_Click(object sender, EventArgs e)
        {
            string sqlColumn = "";
            foreach (string col in Column)
            {
                sqlColumn = sqlColumn + col + ",";
            }
            sqlColumn = sqlColumn.Remove(sqlColumn.Length - 1);
            string sqlRe = "CREATE OR REPLACE VIEW " + viewNameSelectTextBox.Text + " AS " + " SELECT " + sqlColumn + " FROM " + _tableName;
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            string grantUser;
            if (withOptionSelectCheckbox.Checked == false) {
                 grantUser = "Grant SELECT ON " + viewNameSelectTextBox.Text + " TO " + _userName;
            }
            else
            {
                grantUser = "Grant SELECT ON " + viewNameSelectTextBox.Text + " TO " + _userName+" with grant option ";
            }
          
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(grantUser);
            this.dataGridTableViewsSelect.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT TABLE_NAME,GRANTABLE FROM all_tab_privs WHERE privilege = 'SELECT' AND type = 'VIEW' AND GRANTEE='{_userName}'");

        }

        private void dataGridTableViewsSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView = dataGridTableViewsSelect.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();
            viewSelectResult.Text = DataView;
            dataGridTableViewSelectUsers.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT * FROM {DataView}");
        }

        private void revokeSelectBtn_Click(object sender, EventArgs e)
        {
            string RevokeUser = "REVOKE SELECT ON " + DataView + " FROM " + _userName;
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(RevokeUser);
            this.dataGridTableViewsSelect.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT TABLE_NAME,GRANTABLE FROM all_tab_privs WHERE privilege = 'SELECT' AND type = 'VIEW' AND GRANTEE='{_userName}'");
        }

        private void dataGridViewUpdateInfo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUpdateInfo.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewUpdateInfo.Columns.Count)
            {
                string col = dataGridViewUpdateInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                attributeUpdateLabel.Text = col;
            }
        }

        private void withOptionSelectCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_type == false)
            {
                MessageBox.Show("Khong the dung with grant option voi role");
                withOptionSelectCheckbox.Checked = false;
            }
        }

        private void withOptionUpdateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_type == false)
            {
                MessageBox.Show("Khong the dung with grant option voi role");
                withOptionUpdateCheckbox.Checked = false;
            }
        }

        private void grantUpdateBtn_Click(object sender, EventArgs e)
        {

            int row = dataGridViewUpdateInfo.CurrentCell.RowIndex;
            int col = dataGridViewUpdateInfo.CurrentCell.ColumnIndex;

            string value = dataGridViewUpdateInfo.Rows[row].Cells[col].Value.ToString();
           
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery($"GRANT UPDATE({value}) ON {_tableName} TO {_userName}");
            this.dataGridViewUpdatePrivs.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"select * from DBA_COL_PRIVS WHERE GRANTEE = '{_userName}' AND TABLE_NAME = '{_tableName}'");

        }

        private void dataGridViewUpdatePrivs_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUpdatePrivs.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewUpdatePrivs.Columns.Count)
            {
                string col = dataGridViewUpdatePrivs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                attributeUpdateLabel2.Text = col;
            }
        }

        private void revokeUpdateBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridViewUpdatePrivs.CurrentCell.RowIndex;

            string value = dataGridViewUpdatePrivs.Rows[row].Cells[2].Value.ToString();
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery($"REVOKE UPDATE ON {_tableName} FROM {_userName}");
            this.dataGridViewUpdatePrivs.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"select * from DBA_COL_PRIVS WHERE GRANTEE = '{_userName}' AND TABLE_NAME = '{_tableName}'");
        }
    }
}

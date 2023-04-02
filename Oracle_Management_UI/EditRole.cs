using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Management_UI
{
    public partial class EditRole : Form
    {

        string roleNow = "ADMIN_DBA";
        public EditRole()
        {
            InitializeComponent();
        }

        private void EditRole_Load(object sender, EventArgs e)
        {

            try
            { 
                dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT USERNAME as \"Tên tài khoản\" FROM all_users");
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 230;
                dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT ROLE as \"Vai trò\" FROM DBA_ROLES");
                DataGridViewColumn column1 = dataGridView4.Columns[0];
                column1.Width = 230;
                dataGridView6.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT privilege as \"Quyền\" FROM SYS.SESSION_PRIVS");
                DataGridViewColumn column2 = dataGridView6.Columns[0];
                column2.Width = 230;
                dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT grantee as \"Tên tài khoản\" FROM DBA_ROLE_PRIVS WHERE granted_role = '{roleNow}'");
                DataGridViewColumn column3 = dataGridView2.Columns[0];
                column3.Width = 230;
                dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT granted_role as \"Vai trò\" FROM ROLE_ROLE_PRIVS WHERE ROLE = '{roleNow}'");
                DataGridViewColumn column4 = dataGridView3.Columns[0];
                column4.Width = 230;
                dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT privilege as \"Quyền\" FROM ROLE_SYS_PRIVS WHERE ROLE = '{roleNow}'");
                DataGridViewColumn column5 = dataGridView5.Columns[0];
                column5.Width = 230;
            }
            catch (Exception ex)
            {

            }
        }

        private void printLabel(DataGridView dataGridView,Label label,int row,int col)
        {
            int rowM = dataGridView.Rows.Count;
            int colM = dataGridView.Columns.Count;
            Debug.WriteLine(rowM);
            Debug.WriteLine(colM);
            Debug.WriteLine(row);
            Debug.WriteLine(col);

            if (row < rowM && col < colM && row >=0 && col >=0)
                label.Text = "User: " + dataGridView.Rows[row].Cells[col].Value.ToString();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Debug.WriteLine(e.RowIndex);
            Debug.WriteLine(e.ColumnIndex);
            this.printLabel(dataGridView1, label1, e.RowIndex, e.ColumnIndex);
        }

        private void dataGridView4_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView4, label4, e.RowIndex, e.ColumnIndex);
        }

        private void dataGridView6_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView6, label7, e.RowIndex, e.ColumnIndex);

        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView2, label2, e.RowIndex, e.ColumnIndex);
            
        }

        private void dataGridView5_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           this.printLabel(dataGridView5, label6, e.RowIndex, e.ColumnIndex);

        }

        private void tabPage_users_Click(object sender, EventArgs e)
        {

        }

    }
}

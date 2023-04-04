using Oracle_Management_UI.Components;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Oracle_Management_UI
{
    public partial class EditRole : Form
    {

        //string roleNow = "QLTTIEP";
        private string _roleName { get; set; }
        private string _userName { get; set; }
   

        public EditRole(string userName, string roleName)
        {
            InitializeComponent();
            this._roleName = roleName;
            this._userName = userName;
        }

        private void EditRole_Load(object sender, EventArgs e)
        {

            try
            { 
                dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT USERNAME as \"Tên tài khoản\" FROM all_users");
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 230;
                dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT ROLE as \"Vai trò\",PASSWORD_REQUIRED FROM DBA_ROLES");
                dataGridView6.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT privilege as \"Quyền\" FROM SYS.SESSION_PRIVS ORDER BY privilege");
                DataGridViewColumn column2 = dataGridView6.Columns[0];
                column2.Width = 230;
                dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT grantee as \"Tên tài khoản\",ADMIN_OPTION FROM DBA_ROLE_PRIVS WHERE granted_role = '{_roleName}'");
                DataGridViewColumn column3 = dataGridView2.Columns[0];
                column3.Width = 230;
                dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT granted_role as \"Vai trò\",ADMIN_OPTION FROM ROLE_ROLE_PRIVS WHERE ROLE = '{_roleName}'");
                //DataGridViewColumn column4 = dataGridView3.Columns[0];
                //column4.Width = 230;
                dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT privilege as \"Quyền\",ADMIN_OPTION FROM ROLE_SYS_PRIVS WHERE ROLE = '{_roleName}' ORDER BY privilege");
                DataGridViewColumn column5 = dataGridView5.Columns[0];
                column5.Width = 230;
 
                dataGridView8.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT table_name as \"Bảng\" FROM all_tables WHERE OWNER = 'MY_PROJECT_PLUG_USER'");
                DataGridViewColumn column6 = dataGridView8.Columns[0];
                column6.Width = 230;
                dataGridView7.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT GRANTEE AS \"VAI TRÒ\" , TABLE_NAME AS \"BẢNG\",privilege as \"Quyền\" FROM USER_TAB_PRIVS where grantee = 'MY_PROJECT_PLUG_USER' AND TYPE = 'TABLE'");
                //DataGridViewColumn column7 = dataGridView7.Columns[0];
                //column7.Width = 230;
            }
            catch (Exception ex)
            {

            }
        }

        private int rowL { get; set; }
        private int colL { get; set; }
        private int rowR { get; set; }
        private int colR { get; set; }


        private void printLabel(DataGridView dataGridView, Label label, int row, int col,string text)
        {
            int rowM = dataGridView.Rows.Count;
            int colM = dataGridView.Columns.Count;



            if (row < rowM && col < colM && row >= 0 && col >= 0)
                label.Text = text + dataGridView.Rows[row].Cells[col].Value.ToString();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Debug.WriteLine(e.RowIndex);
            Debug.WriteLine(e.ColumnIndex);



            this.printLabel(dataGridView1, label1, e.RowIndex, e.ColumnIndex,"User: ");
        }

        private void dataGridView4_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView4, label4, e.RowIndex, e.ColumnIndex, "Role: ");
        }

        private void dataGridView6_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView6, label7, e.RowIndex, e.ColumnIndex, "Permission: ");

        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView2, label2, e.RowIndex, e.ColumnIndex, "User: ");
            
        }

        private void dataGridView5_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           this.printLabel(dataGridView5, label6, e.RowIndex, e.ColumnIndex, "Permission: ");
        }

        private void tabPage_users_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView8, label10, e.RowIndex, e.ColumnIndex, "Table: ");

        }

        private void checkBox_wgo_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(checkBox_user.Checked.ToString());

            
            //MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            string userName = dataGridView1.CurrentCell.Value.ToString();
            string check = checkBox_user.Checked.ToString();
            if (check == "True")
            {
                //MessageBox.Show(check);
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {_roleName } TO {userName} WITH ADMIN OPTION");
                dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT grantee as \"Tên tài khoản\",ADMIN_OPTION FROM DBA_ROLE_PRIVS WHERE granted_role = '{_roleName}'");
            }
            else
            {
                //MessageBox.Show("1111");
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {_roleName } TO {userName}");
                dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT grantee as \"Tên tài khoản\",ADMIN_OPTION FROM DBA_ROLE_PRIVS WHERE granted_role = '{_roleName}'");

            }
            //Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {_roleName } TO {userName}");
            //dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT grantee as \"Tên tài khoản\" FROM DBA_ROLE_PRIVS WHERE granted_role = '{_roleName}'");

            //MessageBox.Show(dataGridView1.Rows[row].Cells[col].Value.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = dataGridView2.CurrentCell.Value.ToString();
            //MessageBox.Show(userName);
            //MessageBox.Show(_userName);

            if (userName != _userName)
            {
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"REVOKE {_roleName} FROM {userName}");
                dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT grantee as \"Tên tài khoản\",ADMIN_OPTION FROM DBA_ROLE_PRIVS WHERE granted_role = '{_roleName}'");
            }
            else
            {
                MessageBox.Show("Can't revoke yourself");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string check = checkBox_role.Checked.ToString();
            int row = dataGridView4.CurrentCell.RowIndex;
            string role = dataGridView4.CurrentCell.Value.ToString();
            if (check == "True")
            {

                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {role} TO {_roleName} WITH ADMIN OPTION");
                dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT granted_role as \"Vai trò\",ADMIN_OPTION FROM ROLE_ROLE_PRIVS WHERE ROLE = '{_roleName}'");
            }
            else
            {

                //MessageBox.Show("1111");
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {role} TO {_roleName}");
                dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT granted_role as \"Vai trò\",ADMIN_OPTION FROM ROLE_ROLE_PRIVS WHERE ROLE = '{_roleName}'");

            }

        }

        private void dataGridView3_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.printLabel(dataGridView3, label3, e.RowIndex, e.ColumnIndex, "Role: ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string role = dataGridView3.CurrentCell.Value.ToString();
            Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"REVOKE {role} FROM {_roleName}");
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT granted_role as \"Vai trò\",ADMIN_OPTION FROM ROLE_ROLE_PRIVS WHERE ROLE = '{_roleName}'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string check = checkBox_privs.Checked.ToString();
            //int row = dataGridView6.CurrentCell.RowIndex;
            string priv = dataGridView6.CurrentCell.Value.ToString();
            if (check == "True")
            {

                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {priv} TO {_roleName} WITH ADMIN OPTION");
                dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT privilege as \"Quyền\",ADMIN_OPTION FROM ROLE_SYS_PRIVS WHERE ROLE = '{_roleName}' ORDER BY privilege");
            }
            else
            {

                //MessageBox.Show("1111");
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"GRANT {priv} TO {_roleName}");
                dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT privilege as \"Quyền\",ADMIN_OPTION FROM ROLE_SYS_PRIVS WHERE ROLE = '{_roleName}' ORDER BY privilege");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string priv = dataGridView5.CurrentCell.Value.ToString();
            Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"REVOKE {priv} FROM {_roleName}");
            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT privilege as \"Quyền\",ADMIN_OPTION FROM ROLE_SYS_PRIVS WHERE ROLE = '{_roleName}' ORDER BY privilege");

        }
    }
}

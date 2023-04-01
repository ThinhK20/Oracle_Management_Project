using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle_Management_Library.DataAccess;

namespace Oracle_Management_UI
{
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }
        private void loadUserInsys()
        {
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from dba_users");



        }
        private void loadSystemPriOfUser()
        {
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from DBA_SYS_PRIVS");

        }
        private void loadRolePriOfUser()
        {
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_ROLE_PRIVS");

        }
        private void loadTablePriOfUser()
        {
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_TAB_PRIVS");

        }
        private void loadColPriOfUser()
        {
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_COL_PRIVS");

        }
        private void loadSysPriOfRole()
        {
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from role_sys_privs");

        }
        private void loadTablePriOfRole()
        {
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from role_tab_privs");

        }
        private void loadRolePriOfRole()
        {
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from role_role_privs");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            loadUserInsys();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadSystemPriOfUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadRolePriOfUser();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadTablePriOfUser();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadColPriOfUser();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadSysPriOfRole();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadTablePriOfRole();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadRolePriOfRole();
        }
    }
}

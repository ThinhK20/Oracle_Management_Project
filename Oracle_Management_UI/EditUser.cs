using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Management_UI
{
    public partial class EditUser : Form
    {
        string RoleData;
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            this.dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT privilege FROM SESSION_PRIVS");
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoleData = dataGridView4.Rows[e.RowIndex].Cells["privilege"].Value.ToString();
            label4.Text = "Role: " + RoleData;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string sqlRe= "Grant" + RoleData + "Select to";
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery(" ");
            }
            else
            {
                Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT privilege FROM SESSION_PRIVS");
            }
        }
    }
}

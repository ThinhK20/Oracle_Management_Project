using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Company
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.PHONGBAN");
            dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.DEAN");
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.NHANVIEN");
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.PHANCONG");
            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.VIEW_FOR_UPDATE");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView5.CurrentCell.Selected = true;
                int columnIndex = dataGridView5.CurrentCell.ColumnIndex;
                string columnName = dataGridView5.Columns[columnIndex].Name;
                textBox3.Text = columnName;
                if (columnName.Trim() == "NGAYSINH")
                {
                    textBox6.Text = "Hãy nhập theo định dạng DD/MM/YYYY";
                }
                else
                {
                    textBox6.Text = "";
                }
                textBox4.Text = dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = textBox1.Text;
            string column = textBox3.Text;
            string query;
            if (textBox3.Text.Trim() == "NGAYSINH")
            {
                query = "UPDATE ADMIN_DBMS.NHANVIEN SET " + column + " = " + " TO_DATE('" + content + "','DD/MM/YYYY" + "')" +
                    " WHERE trim(MANV) = trim(sys_context(" + "'userenv" + "', " + "'session_user" + "'))";

            }
            else
            {
                query = "UPDATE ADMIN_DBMS.NHANVIEN SET " + column + " = " + " N'" + content + "' WHERE trim(MANV) = trim(sys_context(" +
                    "'userenv" + "', " + "'session_user" + "'))";
            }
            textBox5.Text = query;
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            string query2 = "commit work";
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query2);

            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.VIEW_FOR_UPDATE");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

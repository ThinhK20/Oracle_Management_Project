using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Oracle_Company
{
    public partial class TruongDeAn : Form
    {
        public TruongDeAn()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
                if (columnName.Trim() == "NGAYBD")
                {
                    textBox6.Text = "Hãy nhập theo định dạng DD/MM/YYYY";
                }

                else
                {
                    textBox6.Text = "";
                }
                if (columnName.Trim() == "MADA")
                {
                    textBox4.Text = "KHÔNG ĐƯỢC CHỈNH SỬA DỮ LIỆU NÀY";
                }
                else
                {
                    textBox4.Text = dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                }
                textBox7.Text = dataGridView5.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textBox1.Text = "";
            }
        }

        private void TruongDeAn_Load(object sender, EventArgs e)
        {
            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.DEAN");
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.DEAN");
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.DEAN");
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.PHONGBAN");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = textBox1.Text;
            string column = textBox3.Text;
            string mada = textBox7.Text;
            string query;
            if (column.Trim() == "MADA")
            {
                return;
            }
            if (textBox3.Text.Trim() == "NGAYBD")
            {
                query = "UPDATE ADMIN_DBMS.DEAN SET " + column + " = " + " TO_DATE('" + content + "','DD/MM/YYYY" + "')" +
                    " WHERE trim(MADA) = '" + mada.Trim() + "'";

            }
            else
            {
                query = "UPDATE ADMIN_DBMS.DEAN SET " + column + " = " + " N'" + content + "' WHERE trim(MADA) = '" + mada.Trim() + "'";
            }
            MessageBox.Show(query);

            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mada = textBox5.Text.Trim().ToUpper();
            string tenda = textBox8.Text.Trim();
            string ngaybd = textBox9.Text.Trim();
            string mapb = textBox10.Text.Trim().ToUpper();
            string query = "INSERT INTO ADMIN_DBMS.DEAN VALUES('" + mada + "', N'" + tenda + "', " + "TO_DATE('" + ngaybd + "', 'DD/MM/YYYY'), '" + mapb + "')";

            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");


        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox11.Text = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            dataGridView2.CurrentRow.Selected = true;
        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mada = textBox11.Text.Trim();
            string query = "DELETE FROM ADMIN_DBMS.DEAN WHERE MADA = '" + mada + "'";

            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("ALTER TABLE ADMIN_DBMS.PHANCONG DISABLE CONSTRAINT FK_PC_DA");
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
            dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.DEAN");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

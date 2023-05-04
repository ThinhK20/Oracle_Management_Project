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

namespace Oracle_Company
{
    public partial class TruongPhongcs : Form
    {
        public TruongPhongcs()
        {
            InitializeComponent();
        }
        private Dictionary<int, Tuple<string, string>> originalValues = new Dictionary<int, Tuple<string, string>>();
        private string dean { get; set; }
        private string nhanvien { get; set; }
        private string da { get; set; }
        private string nv { get; set; }
        private void TruongPhongcs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from admin_dbms.truongphong_view");
            phong.Text = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select PHG from admin_dbms.truongphong_view  WHERE ROWNUM <= 1").Rows[0]["PHG"].ToString();

            label2.Text = phong.Text;
            label5.Text = "Nhân viên" + phong.Text;
            dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * from admin_dbms.dean");
            dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select MANV,TENNV,VAITRO from admin_dbms.truongphong_view");
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * from admin_dbms.TRUONGPHONG_PHANCONG_VIEW");
            DataTable dt = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * from admin_dbms.TRUONGPHONG_PHANCONG_VIEW");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string manv = dt.Rows[i]["MANV"].ToString();
                string mada = dt.Rows[i]["MADA"].ToString();
                originalValues[i] = new Tuple<string, string>(manv, mada);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dean = dataGridView2.Rows[e.RowIndex].Cells["mada"].Value.ToString();
            label6.Text = "Phân công đề án:" + dean;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nhanvien = dataGridView4.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
            label7.Text = "cho nhân viên:     " + nhanvien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string query = $"INSERT INTO ADMIN_DBMS.PHANCONG VALUES ('{nhanvien}','{dean}',TO_DATE('{date}', 'DD/MM/YYYY'))";
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
            MessageBox.Show("Bạn đã thêm phân công thành công " + query);
            dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * from admin_dbms.TRUONGPHONG_PHANCONG_VIEW");

        }


        private void resetDatsa3(object sender, EventArgs e)
        {

        }

        private void updateData(object sender, DataGridViewCellEventArgs e)
        {
            Tuple<string, string> tuple = originalValues[e.RowIndex];
            string old_manv_value = tuple.Item1;
            string old_mada_value = tuple.Item2;
            string new_time = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            // Lấy giá trị của cột MANV trong DataGridView
            string manv = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            // Lấy giá trị của cột MADA trong DataGridView
            string mada = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            string query = $"UPDATE ADMIN_DBMS.PHANCONG SET THOIGIAN = TO_DATE('{new_time}', 'DD/MM/YYYY hh:mi:ss AM'),MANV='{manv}',MADA='{mada}' WHERE MANV = '{old_manv_value}' AND MADA = '{old_mada_value}'";
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
            MessageBox.Show(query);

        }

        private void gridview3_click(object sender, DataGridViewCellEventArgs e)
        {
            nv = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            // Lấy giá trị của cột MADA trong DataGridView
            da = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            label8.Text = "Nhân Viên " + nv + " Đề Án " + da;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM ADMIN_DBMS.phancong WHERE MADA='{da}' AND MANV='{nv}'";
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
        }
    }
}

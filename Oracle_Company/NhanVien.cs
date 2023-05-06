using Oracle.ManagedDataAccess.Client;
using Oracle_Management_Library;
using System.Configuration;

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
			qlda.Hide();
			qlnv.Hide();
			NS.Hide();
			TC.Hide();
			QLP.Hide();
			var vt = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT vaitro FROM  ADMIN_DBMS.NHANVIEN_VIEW_PROFILE").Rows[0]["vaitro"].ToString();
			if (vt == "QL trực tiếp") qlnv.Show();
			if (vt == "Trưởng phòng") QLP.Show();
			if (vt == "Tài chính") TC.Show();
			if (vt == "Nhân sự") NS.Show();
			if (vt == "Trưởng đề án") qlda.Show();
			dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.PHONGBAN");
			dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.DEAN");
			dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.NHANVIEN_VIEW_PROFILE");
			dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.NHANVIEN_VIEW_PC");
			dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  ADMIN_DBMS.VIEW_FOR_UPDATE");
			TBGrid.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT MOTA FROM  ADMIN_DBMS.THONGBAO");
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
				textBox1.Text = "";
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
					" WHERE trim(MANV) = trim(sys_context('userenv', 'session_user'))";

			}
			else
			{
				query = "UPDATE ADMIN_DBMS.NHANVIEN SET " + column + " = " + " N'" + content + "' WHERE trim(MANV) = trim(sys_context('userenv', 'session_user'))";
			}

			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
			dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM ADMIN_DBMS.VIEW_FOR_UPDATE");


		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}
		private void button2_Click_1(object sender, EventArgs e)
		{
			textBox4.Text = "";
			textBox3.Text = "";

		}



		private void qlnv_Click(object sender, EventArgs e)
		{
			QLTT qLTT = new QLTT();
			qLTT.Show();
		}

		private void NS_Click(object sender, EventArgs e)
		{
			NhanSuForm nhanSuForm = new NhanSuForm();
			nhanSuForm.Show();
		}

		private void qlda_Click(object sender, EventArgs e)
		{
			TruongDeAn truongDeAn = new TruongDeAn();
			truongDeAn.Show();
		}

		private void TC_Click(object sender, EventArgs e)
		{
			TaiChinhForm taiChinhForm = new TaiChinhForm();
			taiChinhForm.Show();
		}

		private void TB_Click(object sender, EventArgs e)
		{
			TinNhan tn = new TinNhan();
			tn.Show();
		}

		private void QLP_Click(object sender, EventArgs e)
		{
			TruongPhongcs truongPhongcs = new TruongPhongcs();
			truongPhongcs.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String oldCnnStr = GlobalConfig.CnnString("OracleConnection");
			var b = oldCnnStr.Split(new string[] { ";User" }, StringSplitOptions.None);
			String seperate = ";User ID=;Password=;Persist Security Info=True;";
			String newCnnStr = b[0] + seperate;

			try
			{
				Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				config.ConnectionStrings.ConnectionStrings.Remove("OracleConnection");
				config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("OracleConnection", newCnnStr));
				config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection("connectionStrings");
				var nav = new Login();
				this.Hide();
				nav.ShowDialog();
			}
			catch (OracleException ex)
			{
				MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
			}
		}
	}
}

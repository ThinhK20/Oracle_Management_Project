namespace Oracle_Company
{
	public partial class NhanSuForm : Form
	{
		public NhanSuForm()
		{
			InitializeComponent();
		}

		// PHONG BAN
		private string _selectMaTruongPB { get; set; }
		private string _selectCapNhatMaTruongPB { get; set; }
		private string _selectCapNhatTenPB { get; set; }
		private string _selectCapNhatMaPB { get; set; }


		// NHANVIEN
		private string _selectCapNhatTenNV { get; set; }
		private string _selectCapNhatPhaiNV { get; set; }
		private string _selectCapNhatNgaySinhNV { get; set; }
		private string _selectCapNhatDiaChiNV { get; set; }
		private string _selectCapNhatSDTNV { get; set; }
		private string _selectCapNhatVaiTroNV { get; set; }
		private string _selectCapNhatMaNQLNV { get; set; }
		private string _selectCapNhatPHGNV { get; set; }
		private string _selectCapNhatMaNV { get; set; }



		private void NhanSuForm_Load(object sender, EventArgs e)
		{
			NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
			PhongBanTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
			ThemNhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
			ThemPhongBanTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
			ThemMaTruongPhongBanTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
			CapNhatPBTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
			CapNhatPBMaTPTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
			CapNhatNhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void ThemNhanVienBtn_Click_1(object sender, EventArgs e)
		{
			try
			{
				string tenNV = TenNhanVienTextBox.Text;
				string phai = PhaiComboBox.Text;
				string ngaySinh = NgaySinhDatetime.Text.ToString().Split(' ')[0];
				string diaChi = DiaChiTextBox.Text;
				string SDT = SdtTextBox.Text;
				string vaiTro = VaiTroComboBox.Text;
				string maNQL = MaNQLTextBox.Text;
				string phg = PHGTextBox.Text;

				var allNhanVien = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
				if (allNhanVien != null)
				{
					int maxId = allNhanVien.Rows.Count + 1;
					string newId = "NV";
					if (maxId <= 9)
					{
						newId += "00" + maxId.ToString();
					}
					else if (maxId <= 99)
					{
						newId += "0" + maxId.ToString();
					}
					else if (maxId <= 999)
					{
						newId += maxId.ToString();
					}
					string query = "INSERT INTO ADMIN_DBMS.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG) " +
						$"VALUES ('{newId}', '{tenNV}', '{phai}', TO_DATE('{ngaySinh}', 'MM/DD/YYYY'), '{diaChi}', '{SDT}', N'{vaiTro}', '{maNQL}', '{phg}' )";
					Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
					Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
					ThemNhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void TaiChinhTab_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ThemNhanVienTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void TenNhanVienTextBox_TextChanged(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void PhaiComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string tenPB = TenPhongBanTextBox.Text.Trim();

		}

		private void label5_Click(object sender, EventArgs e)
		{
		}

		private void NgaySinhDatetime_ValueChanged(object sender, EventArgs e)
		{
		}

		private void ThemPhongBanBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string tenPB = TenPhongBanTextBox.Text;


				var allPB = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
				if (allPB != null)
				{
					int maxId = allPB.Rows.Count + 1;
					string newId = "PB";
					if (maxId <= 9)
					{
						newId += "00" + maxId.ToString();
					}
					else if (maxId <= 99)
					{
						newId += "0" + maxId.ToString();
					}
					else if (maxId <= 999)
					{
						newId += maxId.ToString();
					}
					string query = $"insert into ADMIN_DBMS.PHONGBAN values('{newId}', '{tenPB}', '{_selectMaTruongPB}')";
					Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
					Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
					ThemPhongBanTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
					PhongBanTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ThemMaTruongPhongBanTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_selectMaTruongPB = this.ThemMaTruongPhongBanTable.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
			maTruongPBLabel.Text = _selectMaTruongPB;
		}

		private void CapNhatPBMaTPTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_selectCapNhatMaTruongPB = this.CapNhatPBMaTPTable.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
			CapNhatPBLabel.Text = _selectCapNhatMaTruongPB;
		}

		private void CapNhatPBTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_selectCapNhatMaPB = this.CapNhatPBTable.Rows[e.RowIndex].Cells["MAPB"].Value.ToString();
			_selectCapNhatMaTruongPB = this.CapNhatPBTable.Rows[e.RowIndex].Cells["TRPHG"].Value.ToString();
			_selectCapNhatTenPB = this.CapNhatPBTable.Rows[e.RowIndex].Cells["TENPB"].Value.ToString();
			CapNhatPBTextBox.Text = _selectCapNhatTenPB;
			CapNhatPBLabel.Text = _selectCapNhatMaTruongPB;
		}

		private void CapNhatPBBtn_Click(object sender, EventArgs e)
		{
			if (_selectCapNhatTenPB == null || _selectCapNhatMaTruongPB == null || _selectCapNhatMaPB == null)
			{
				MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
				return;
			}
			string query = $"UPDATE ADMIN_DBMS.PHONGBAN SET TENPB = '{_selectCapNhatTenPB}', MANV = '{_selectCapNhatMaTruongPB}' WHERE MAPB = '{_selectCapNhatMaPB}'";
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
			CapNhatPBTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
			PhongBanTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.PHONGBAN");
		}

		private void CapNhatPBTextBox_TextChanged(object sender, EventArgs e)
		{
			_selectCapNhatTenPB = CapNhatPBTextBox.Text.Trim();
		}

		private void CapNhatNhanVienTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_selectCapNhatMaNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
			_selectCapNhatTenNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["TENNV"].Value.ToString();
			_selectCapNhatPhaiNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["PHAI"].Value.ToString();
			_selectCapNhatNgaySinhNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["NGAYSINH"].Value.ToString();
			_selectCapNhatDiaChiNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["DIACHI"].Value.ToString();
			_selectCapNhatSDTNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["SODT"].Value.ToString();
			_selectCapNhatVaiTroNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["VAITRO"].Value.ToString();
			_selectCapNhatMaNQLNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["MANQL"].Value.ToString();
			_selectCapNhatPHGNV = this.CapNhatNhanVienTable.Rows[e.RowIndex].Cells["PHG"].Value.ToString();

			CapNhatTenNhanVienTB.Text = _selectCapNhatTenNV;
			CapNhatPhaiCB.Text = _selectCapNhatPhaiNV;
			CapNhatNgaySinhDP.Text = _selectCapNhatNgaySinhNV;
			CapNhatDiaChiTB.Text = _selectCapNhatDiaChiNV;
			CapNhatSDTTB.Text = _selectCapNhatSDTNV;
			CapNhatVaiTroCB.Text = _selectCapNhatVaiTroNV;
			CapNhatMaNQLTB.Text = _selectCapNhatMaNQLNV;
			CapNhatPHGTextBox.Text = _selectCapNhatPHGNV;

		}

		private void CapNhatNhanVienBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string ngaySinh = CapNhatNgaySinhDP.Text.ToString().Split(' ')[0];
				string query = $"UPDATE ADMIN_DBMS.NHANVIEN " +
					$"SET TENNV = '{CapNhatTenNhanVienTB.Text}', PHAI='{CapNhatPhaiCB.Text}', NGAYSINH = TO_DATE('{ngaySinh}', 'MM/DD/YYYY'), " +
					$"DIACHI= '{CapNhatDiaChiTB.Text}', SODT = '{CapNhatSDTTB.Text}', VAITRO = '{CapNhatVaiTroCB.Text}', MANQL = '{CapNhatMaNQLTB.Text}', PHG = '{CapNhatPHGTextBox.Text}' " +
					$"WHERE MANV = '{_selectCapNhatMaNV}'";
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(query);
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
				CapNhatNhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
				NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ADMIN_DBMS.NHANVIEN");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

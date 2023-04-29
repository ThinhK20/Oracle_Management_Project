namespace Oracle_Company
{
	public partial class TaiChinhForm : Form
	{
		public TaiChinhForm()
		{
			InitializeComponent();
		}

		private void NhanVienTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void TaiChinhForm_Load(object sender, EventArgs e)
		{
			try
			{
				NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM NHANVIEN");
				PhanCongTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM PHANCONG");

			}
			catch (Exception)
			{

			}
		}

		private void PhanCongTabPage_Click(object sender, EventArgs e)
		{

		}

		private void NhanVienTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

			}
			catch (Exception)
			{

			}
		}
	}
}

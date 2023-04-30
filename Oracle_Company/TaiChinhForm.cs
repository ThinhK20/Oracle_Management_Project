using Oracle_Management_UI.Components;

namespace Oracle_Company
{
	public partial class TaiChinhForm : Form
	{
		private string _selectedUserId { get; set; }


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
				NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM MY_PROJECT_PLUG_USER.NHANVIEN");
				PhanCongTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  MY_PROJECT_PLUG_USER.PHANCONG");

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
				_selectedUserId = this.NhanVienTable.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
			}
			catch (Exception)
			{

			}
		}

		private void ThayDoiLuongBtn_Click(object sender, EventArgs e)
		{
			if (_selectedUserId == null || _selectedUserId == "") return;

			PromptDialog promptDialog = new PromptDialog();
			promptDialog.ShowDialog("Nhập lương mới", "Thay đổi lương của " + _selectedUserId);
			if (promptDialog.Value1 == "") return;
			string queryString = "UPDATE MY_PROJECT_PLUG_USER.NHANVIEN SET LUONG= " + promptDialog.Value1 + " where MANV = '" + _selectedUserId + "'";
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
			NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM MY_PROJECT_PLUG_USER.NHANVIEN");
		}

		private void ThayDoiPhuCapBtn_Click(object sender, EventArgs e)
		{
			if (_selectedUserId == null || _selectedUserId == "") return;
			try
			{
				PromptDialog promptDialog = new PromptDialog();
				promptDialog.ShowDialog("Nhập phụ cấp mới", "Thay đổi phụ cấp của " + _selectedUserId);
				if (promptDialog.Value1 == "") return;
				string queryString = "UPDATE MY_PROJECT_PLUG_USER.NHANVIEN SET PHUCAP= " + promptDialog.Value1 + " where MANV = '" + _selectedUserId + "'";
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
				NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM MY_PROJECT_PLUG_USER.NHANVIEN");
			}
			catch (Exception)
			{

			}
		}
	}
}

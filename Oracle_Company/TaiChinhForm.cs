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

		private void TaiChinhForm_Load(object sender, EventArgs e)
		{
			try
			{
				NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.INFO_TAICHINH_DECRYPT");
				PhanCongTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM  admin_dbms.PHANCONG");

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
			string queryString = "ADMIN_DBMS.LUONG_ENCRYPTION";
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteStoredProcedureLuong(queryString, _selectedUserId, promptDialog.Value1);
			Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
			NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.INFO_TAICHINH_DECRYPT");
		}

		private void ThayDoiPhuCapBtn_Click(object sender, EventArgs e)
		{
			if (_selectedUserId == null || _selectedUserId == "") return;
			try
			{
				PromptDialog promptDialog = new PromptDialog();
				promptDialog.ShowDialog("Nhập phụ cấp mới", "Thay đổi phụ cấp của " + _selectedUserId);
				if (promptDialog.Value1 == "") return;
				string queryString = "ADMIN_DBMS.PHUCAP_ENCRYPTION";
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteStoredProcedurePhuCap(queryString, _selectedUserId, promptDialog.Value1);
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
				NhanVienTable.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM admin_dbms.INFO_TAICHINH_DECRYPT");
			}
			catch (Exception)
			{

			}
		}
	}
}

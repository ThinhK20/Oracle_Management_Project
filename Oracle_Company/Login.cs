using Oracle.ManagedDataAccess.Client;
using Oracle_Management_Library;
using System.Configuration;

namespace Oracle_Company
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			String username = usernameTextBox.Text;
			String password = passwordTextBox.Text;
			String oldCnnStr = GlobalConfig.CnnString("OracleConnection");
			var b = oldCnnStr.Split(new string[] { ";User" }, StringSplitOptions.None);
			String seperate = ";User ID=" + username + ";Password=" + password + ";Persist Security Info=True;";
			String newCnnStr = b[0] + seperate;
			using (OracleConnection connection = new OracleConnection(newCnnStr))
			{
				try
				{
					connection.Open();

					Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
					config.ConnectionStrings.ConnectionStrings.Remove("OracleConnection");
					config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("OracleConnection", newCnnStr));
					config.Save(ConfigurationSaveMode.Modified);
					ConfigurationManager.RefreshSection("connectionStrings");
					this.Hide();
					var nav = new NhanVien();
					nav.ShowDialog();
					//Hide();
				}
				catch (OracleException ex)
				{
					MessageBox.Show("Sai tài khoản đăng nhập hoặc tài khoản đăng nhập không tồn tại.");
				}
			}
		}
	}
}

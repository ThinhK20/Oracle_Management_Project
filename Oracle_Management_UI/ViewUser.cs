using Oracle_Management_UI.Components;

namespace Oracle_Management_UI
{
	public partial class ViewUser : Form
	{
		private string search_user { get; set; }
		private string search_role { get; set; }

		public ViewUser()
		{
			InitializeComponent();
		}
		private void loadUserInsys()
		{
			dataGridView1.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from dba_users");

		}
		private void loadSystemPriOfUser()
		{
			dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from DBA_SYS_PRIVS");

		}
		private void loadRolePriOfUser()
		{
			dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_ROLE_PRIVS");

		}
		private void loadTablePriOfUser()
		{
			dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_TAB_PRIVS");

		}
		private void loadColPriOfUser()
		{
			dataGridView2.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_COL_PRIVS");

		}
		private void loadSysPriOfRole()
		{
			dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from role_sys_privs");

		}
		private void loadTablePriOfRole()
		{
			dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from role_tab_privs");

		}
		private void loadRolePriOfRole()
		{
			dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from role_role_privs");

		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ViewUser_Load(object sender, EventArgs e)
		{
			loadUserInsys();
			dataGridView16.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM all_views");
			dataGridView15.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM all_tables");
			dataGridView14.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * FROM DBA_ROLES");
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			loadSystemPriOfUser();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			loadRolePriOfUser();
		}

		private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			loadTablePriOfUser();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			loadColPriOfUser();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			loadSysPriOfRole();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			loadTablePriOfRole();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			loadRolePriOfRole();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			search_user = textBox2.Text;
			dataGridView6.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from DBA_TAB_PRIVS WHERE GRANTEE like '%" + search_user.ToUpper() + "%'");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			search_role = textBox4.Text;
			dataGridView7.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from ROLE_TAB_PRIVS WHERE ROLE like '%" + search_role.ToUpper() + "%'");
		}

		private void tabPage6_Click(object sender, EventArgs e)
		{

		}

		private void Table_Click(object sender, EventArgs e)
		{

		}

		private void tabPage6_Click_1(object sender, EventArgs e)
		{

		}

		private void button12_Click(object sender, EventArgs e)
		{
			string search_role_new = textBox3.Text;
			dataGridView8.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from ROLE_TAB_PRIVS where ROLE like '%" + search_role_new.ToUpper() + "%'");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			string search_user_new = textBox1.Text;
			dataGridView9.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("select * from DBA_COL_PRIVS WHERE GRANTEE like '%" + search_user_new.ToUpper() + "%'");
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button13_Click(object sender, EventArgs e)
		{
			string search_new_role = textBox5.Text;
			dataGridView12.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from DBA_ROLE_PRIVS where GRANTED_ROLE Like '%" + search_new_role.ToUpper() + "%'");
		}

		private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void button14_Click_1(object sender, EventArgs e)
		{
			ManageRole nav = new ManageRole();
			nav.ShowDialog();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			try
			{
				PromptDialog promptValue = new PromptDialog();
				promptValue.ShowDialog("Nhập key mới", "Thay đổi key");
				if (promptValue.Value1 == "")
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
					return;
				}
				string query = "MY_PROJECT_PLUG_USER.GENERATE_KEY";

				Oracle_Management_Library.GlobalConfig.Connection.ExecuteStoredProcedure(query, promptValue.Value1);
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery($"COMMIT WORK");
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteStoredProcedure($"MY_PROJECT_PLUG_USER.change_data_newkey", "");
				Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery($"COMMIT WORK");
				MessageBox.Show("Đổi key thành công.");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			dataGridView17.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT OBJECT_SCHEMA, OBJECT_NAME, ACTION_NAME, SQL_TEXT, CURRENT_USER, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL  WHERE OBJECT_NAME = 'PHANCONG' AND ACTION_NAME = 'UPDATE' ORDER BY(EVENT_TIMESTAMP) DESC");
		}
		private void button17_Click(object sender, EventArgs e)
		{
			dataGridView17.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT OBJECT_SCHEMA, OBJECT_NAME, ACTION_NAME, SQL_TEXT, CURRENT_USER, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL  WHERE OBJECT_NAME = 'NHANVIEN' AND ACTION_NAME = 'SELECT' ORDER BY(EVENT_TIMESTAMP) DESC");
		}
		private void button18_Click(object sender, EventArgs e)
		{
			dataGridView17.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT OBJECT_SCHEMA, OBJECT_NAME, ACTION_NAME, SQL_TEXT, CURRENT_USER, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL  WHERE OBJECT_NAME = 'NHANVIEN' AND ACTION_NAME = 'UPDATE' ORDER BY(EVENT_TIMESTAMP) DESC");
		}

		private void button19_Click(object sender, EventArgs e)
		{
			dataGridView17.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT OBJECT_SCHEMA, OBJECT_NAME, ACTION_NAME, SQL_TEXT, CURRENT_USER, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL ORDER BY(EVENT_TIMESTAMP) DESC");

		}
	}
}

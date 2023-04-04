using Oracle_Management_UI.Components;
using System.Configuration;

namespace Oracle_Management_UI
{
    public partial class ManageRole : Form
    {
        private string _userName { get; set; }
        private string _roleName { get; set; }

        public ManageRole()
        {
            InitializeComponent();
        }

        public ManageRole(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }


        private void ManageRole_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataGridViewUsers.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT * from all_users");
                this.DataGridViewRoles.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select * from DBA_ROLES");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PromptDialog promptValue = new PromptDialog();
                promptValue.ShowDialog("Nhập username", "Tạo user", "Nhập mật khẩu");
                if (promptValue.Value1 == "" || promptValue.Value2 == "") return;
                string queryString = "Create user " + promptValue.Value1 + " identified by " + promptValue.Value2;
                string grantQueryString = "Grant create session to " + promptValue.Value1;
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(grantQueryString);
                MessageBox.Show("Tạo user thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userName == "" || _userName is null) return;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa user " + _userName + " ?", "Xóa user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                string queryString = "Drop user " + _userName;
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
                MessageBox.Show("Xóa user thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedUser = this.DataGridViewUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                if (selectedUser == "" || selectedUser == null) return;
                _userName = selectedUser;
            }
            catch (Exception ex)
            {
                _userName = "";
                MessageBox.Show(ex.ToString());
            }

        }

        private void refreshUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridViewUsers.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT USERNAME from all_users");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void DataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedRole = this.DataGridViewRoles.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                if (selectedRole == "" || selectedRole == null) return;
                _roleName = selectedRole;
                EditRole nav = new EditRole(_userName, _roleName);
            }
            catch (Exception ex)
            {
                _roleName = "";
                MessageBox.Show(ex.ToString());
            }

        }

        private void createRoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PromptDialog promptValue = new PromptDialog();
                promptValue.ShowDialog("Nhập tên role", "Tạo role", "Nhập mật khẩu (nếu cần)");
                if (promptValue.Value1 == "") return;
                string queryString = "Create role " + promptValue.Value1;
                if (promptValue.Value2 != "")
                {
                    queryString += " identified by " + promptValue.Value2;
                }
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
                MessageBox.Show("Tạo role thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteRoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_roleName == "" || _roleName is null) return;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa role " + _roleName + " ?", "Xóa role", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                string queryString = "Drop role " + _roleName;
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
                MessageBox.Show("Xóa role thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (_roleName == "" || _roleName is null) return;

            EditRole editRoleForm = new EditRole(_userName, _roleName);
            editRoleForm.ShowDialog();
        }

        private void refreshRoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridViewRoles.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select ROLE from DBA_ROLES");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (_userName == "" || _userName is null) return;
            EditUser editUserForm = new EditUser(_userName);
            editUserForm.ShowDialog();

        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát tài khoản này không ?", "Thoát kết nối", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string newCnnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB2)));User ID=<username>;Password=<password>;Persist Security Info=True";
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Remove("OracleConnection");
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("OracleConnection", newCnnStr));
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Thoát tài khoản thành công");
            }
        }

        private void rolesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void manageRolesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

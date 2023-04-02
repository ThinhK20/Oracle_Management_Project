namespace Oracle_Management_UI
{
    public partial class EditUser : Form
    {
        private string _username { get; set; } = String.Empty;
        private string _newPassword { get; set; } = String.Empty;
        private string _confirmPassword { get; set; } = String.Empty;

        public EditUser()
        {
            InitializeComponent();
        }

        public EditUser(string username)
        {
            this._username = username;
            InitializeComponent();

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            username_Result.Text = _username;
        }

        private void newPassword_TextBox_TextChanged(object sender, EventArgs e)
        {
            _newPassword = newPassword_TextBox.Text;
        }

        private void confirmPassword_TextBox_TextChanged(object sender, EventArgs e)
        {
            _confirmPassword = confirmPassword_TextBox.Text;
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            if (_newPassword == "" || _confirmPassword == "" || _newPassword is null || _confirmPassword is null) return;
            if (!_newPassword.Equals(_confirmPassword))
            {
                MessageBox.Show("Password và confirm password phải giống nhau.");
                return;
            }
            string queryString = "alter user " + _username + " identified by " + _newPassword;
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(queryString);
            newPassword_TextBox.Text = "";
            confirmPassword_TextBox.Text = "";
            _confirmPassword = "";
            _newPassword = "";
            MessageBox.Show("Đổi mật khẩu thành công.");
        }

        private void resetChangePassword_btn_Click(object sender, EventArgs e)
        {
            newPassword_TextBox.Text = "";
            confirmPassword_TextBox.Text = "";
            _confirmPassword = "";
            _newPassword = "";
        }


    }
}

namespace Oracle_Management_UI
{
    public partial class EditUser : Form
    {

        private string Data_Grid { get; set; } = String.Empty;
        private string Temp { get; set; } = String.Empty;

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
            this.dataGridView4.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT privilege FROM SESSION_PRIVS");
            this.dataGridView3.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT * FROM dba_sys_privs  where grantee = '{_username}'");
            this.dataGridView5.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{_username}'");
            this.dataGridView6.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT ROLE FROM DBA_ROLES");
            this.dataGridView7.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery($"SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '{_username}'");
            this.dataGridView8.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("SELECT OWNER, TABLE_NAME FROM ALL_TABLES WHERE TABLESPACE_NAME = 'USERS'");
            label5.Text = "User " + _username;
            label8.Text = "User " + _username;
            label11.Text = "User " + _username;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Grid = dataGridView4.Rows[e.RowIndex].Cells["privilege"].Value.ToString();
            label4.Text = "Privileges: " + Data_Grid;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string sqlRe = "Grant " + Data_Grid + " to " + _username + " with grant option";
                MessageBox.Show(sqlRe);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            }
            else
            {

                string sqlRe = "Grant " + Data_Grid + " to " + _username;
                MessageBox.Show(sqlRe);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            }
            EditUser_Load(sender, e);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Grid = dataGridView6.Rows[e.RowIndex].Cells["ROLE"].Value.ToString();
            label7.Text = "Role: " + Data_Grid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                string sqlRe = "Grant " + Data_Grid + " to " + _username + " with grant option";
                MessageBox.Show(sqlRe);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            }
            else
            {

                string sqlRe = "Grant " + Data_Grid + " to " + _username;
                MessageBox.Show(sqlRe);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            }
            EditUser_Load(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Grid = dataGridView8.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();
            label10.Text = "Table: " + Data_Grid;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                string sqlRe = "Grant " + comboBox1.SelectedItem + " on " + Data_Grid + " to " + _username + " with grant option";
                MessageBox.Show(sqlRe);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            }
            else
            {
                string sqlRe = "Grant " + comboBox1.SelectedItem + " on " + Data_Grid + " to " + _username;
                MessageBox.Show(sqlRe);
                Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            }
            EditUser_Load(sender, e);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColumnPermission Column = new ColumnPermission(Data_Grid, _username);
            Column.ShowDialog();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Grid = dataGridView5.Rows[e.RowIndex].Cells["GRANTED_ROLE"].Value.ToString();
            label6.Text = "Role: " + Data_Grid;
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Grid = dataGridView7.Rows[e.RowIndex].Cells["privilege"].Value.ToString();
            Temp = dataGridView7.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();
            label9.Text = "Table: " + Temp + " và Privilege: " + Data_Grid;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Grid = dataGridView3.Rows[e.RowIndex].Cells["privilege"].Value.ToString();

            label3.Text = "Privileges: " + Data_Grid;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlRe = "REVOKE " + Data_Grid + " FROM " + _username;
            MessageBox.Show(sqlRe);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            EditUser_Load(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqlRe = "REVOKE " + Data_Grid + " FROM " + _username;
            MessageBox.Show(sqlRe);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            EditUser_Load(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sqlRe = "REVOKE " + Data_Grid + " on " + Temp + " FROM " + _username;
            MessageBox.Show(sqlRe);
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery(sqlRe);
            EditUser_Load(sender, e);
        }
    }
}

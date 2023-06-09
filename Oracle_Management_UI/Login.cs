﻿using Oracle.ManagedDataAccess.Client;
using Oracle_Management_Library;
using System.Configuration;

namespace Oracle_Management_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

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
                    ViewUser nav = new ViewUser();
                    nav.ShowDialog();
                    Hide();
                    MessageBox.Show("Đăng nhập thành công");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Sai tài khoản đăng nhập hoặc tài khoản đăng nhập không tồn tại.");
                }
            }

          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click_1(object sender, EventArgs e)
        {

        }

    }
}

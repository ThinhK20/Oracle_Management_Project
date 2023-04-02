using Oracle_Management_Library;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Xml.Linq;

namespace Oracle_Management_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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
            

        }
    }
}

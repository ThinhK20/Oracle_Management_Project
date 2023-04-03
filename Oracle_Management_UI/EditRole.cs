namespace Oracle_Management_UI
{
    public partial class EditRole : Form
    {
        public string _roleName { get; set; }
        public string _userName { get; set; }
        public EditRole()
        {
            InitializeComponent();
        }

        public EditRole(string userName, string roleName)
        {
            InitializeComponent();
            this._roleName = roleName;
            this._userName = userName;
        }


        private void EditRole_Load(object sender, EventArgs e)
        {
            username_Result.Text = _userName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_users_Click(object sender, EventArgs e)
        {

        }

    }
}

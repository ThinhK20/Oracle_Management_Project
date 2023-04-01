namespace Oracle_Management_UI
{
    public partial class ManageRole : Form
    {
        public ManageRole()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageRole_Load(object sender, EventArgs e)
        {
            try
            {

                DataGridViewUsers.DataSource = Oracle_Management_Library.GlobalConfig.Connection.GetSQLQuery("Select MaNV, TenNV from NHANVIEN");
            }
            catch (Exception ex)
            {

            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

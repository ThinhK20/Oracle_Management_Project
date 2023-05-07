namespace Oracle_Company
{
    public partial class TinNhan : Form
    {
        private string role { get; set; }
        private string loai { get; set; }
        private string diadiem { get; set; }
        public TinNhan()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (checkedListBox1.CheckedItems[i].ToString().Equals("NHÂN VIÊN")) role = "NV_LV";
                else if (checkedListBox1.CheckedItems[i].ToString().Equals("TRƯỞNG PHÒNG")) role += "TP_LV";
                else if (checkedListBox1.CheckedItems[i].ToString().Equals("GIÁM ĐỐC")) role = "GD_LV";
            }
            if (role == "")
            {
                MessageBox.Show("Please select Receiver");
                return;
            }
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                if (checkedListBox2.CheckedItems[i].ToString().Equals("MUA BÁN")) loai += "MB_C,";
                else if (checkedListBox2.CheckedItems[i].ToString().Equals("SẢN XUẤT")) loai += "SX_C,";
                else if (checkedListBox2.CheckedItems[i].ToString().Equals("GIA CÔNG")) loai += "GC_C,";
               

            }
            if (loai != "")
            {
                loai = loai.Substring(0, loai.Length - 1);
            }
            
            for (int i = 0; i < checkedListBox3.CheckedItems.Count; i++)
            {
                if (checkedListBox3.CheckedItems[i].ToString().Equals("ĐỊA ĐIỂM Ở MIỀN BẮC")) diadiem += "MB_G,";
                else if (checkedListBox3.CheckedItems[i].ToString().Equals("ĐỊA ĐIỂM Ở MIỀN TRUNG")) diadiem += "MT_G,";
                else if (checkedListBox3.CheckedItems[i].ToString().Equals("ĐỊA ĐIỂM Ở MIỀN NAM")) diadiem += "MN_G,";
            }
            if (diadiem != "")
            {
                diadiem = diadiem.Substring(0, diadiem.Length - 1);
            }
            string TONG;
            if (diadiem != "")
            {
                if (loai != "")
                {
                    TONG = role + ":" + loai + ":" + diadiem;
                }
            }
            else
            {
                if (loai == "")
                {
                    TONG = role;
                }
                else
                {
                    TONG = role + ":" + loai;
                }
            }
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            string newCode = "TB" + randomNumber.ToString();
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery($" INSERT INTO ADMIN_DBMS.THONGBAO VALUES('{newCode}','{textBox1.Text}',CHAR_TO_LABEL('region_policy','{TONG}'));");
            Oracle_Management_Library.GlobalConfig.Connection.ExecuteSQLTextQuery("COMMIT WORK");
            MessageBox.Show(TONG + textBox1.Text);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkbok1(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

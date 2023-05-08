using Oracle.ManagedDataAccess.Client;
using Oracle_Management_Library;

namespace Oracle_Company
{
	public partial class TinNhan : Form
	{
		public TinNhan()
		{
			InitializeComponent();
		}


		private void button_Click(object sender, EventArgs e)
		{
			string role = null;
			string loai = null;
			string diadiem = null;
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
			if (loai != null)
			{
				loai = loai.Substring(0, loai.Length - 1);
			}

			for (int i = 0; i < checkedListBox3.CheckedItems.Count; i++)
			{
				if (checkedListBox3.CheckedItems[i].ToString().Equals("ĐỊA ĐIỂM Ở MIỀN BẮC")) diadiem += "MB_G,";
				else if (checkedListBox3.CheckedItems[i].ToString().Equals("ĐỊA ĐIỂM Ở MIỀN TRUNG")) diadiem += "MT_G,";
				else if (checkedListBox3.CheckedItems[i].ToString().Equals("ĐỊA ĐIỂM Ở MIỀN NAM")) diadiem += "MN_G,";
			}
			if (diadiem != null)
			{
				diadiem = diadiem.Substring(0, diadiem.Length - 1);
			}
			string TONG = role + ":" + loai + ":" + diadiem;
			Random random = new Random();
			int randomNumber = random.Next(100, 1001);
			string newCode = "TB" + randomNumber.ToString();
			//string query = "INSERT INTO PHONGBAN (MAPB,TENPB,TRPHG) VALUES ('PB005',N'Gia công','NV006');";
			string connectionString = GlobalConfig.CnnString("OracleConnection");
			OracleConnection connection = new OracleConnection(connectionString);
			connection.Open();
			string query = "INSERT INTO ADMIN_DBMS.THONGBAO VALUES(:newcode,:content,CHAR_TO_LABEL('region_policy',:tong))";
			OracleCommand command = new OracleCommand(query, connection);
			command.Parameters.Add(":newcode", newCode.ToString());
			command.Parameters.Add(":content", textBox1.Text.ToString());
			command.Parameters.Add(":tong", TONG.ToString());
			command.ExecuteNonQuery();
			OracleCommand command2 = new OracleCommand("COMMIT WORK", connection);
			command2.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show($"INSERT INTO ADMIN_DBMS.THONGBAO VALUES('{newCode}','{textBox1.Text}',CHAR_TO_LABEL('region_policy','{TONG}'));");

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
				if (ix != e.Index)
				{
					checkedListBox1.SetItemChecked(ix, false);

				}
		}

		private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

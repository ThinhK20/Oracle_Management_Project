using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace Oracle_Company
{
	partial class NhanSuForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;



		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NhanVienTable = new DataGridView();
			TaiChinhTab = new TabControl();
			NhanVienTabPage = new TabPage();
			PhongBanTabPage = new TabPage();
			PhongBanTable = new DataGridView();
			ThemNhanVienTabPage = new TabPage();
			PHGTextBox = new TextBox();
			ThemNhanVienBtn = new Button();
			label9 = new Label();
			MaNQLTextBox = new TextBox();
			label8 = new Label();
			VaiTroComboBox = new ComboBox();
			label7 = new Label();
			SdtTextBox = new TextBox();
			label4 = new Label();
			DiaChiTextBox = new TextBox();
			label6 = new Label();
			NgaySinhDatetime = new DateTimePicker();
			label5 = new Label();
			PhaiComboBox = new ComboBox();
			label3 = new Label();
			TenNhanVienTextBox = new TextBox();
			label2 = new Label();
			label1 = new Label();
			ThemNhanVienTable = new DataGridView();
			CapNhatNhanVien = new TabPage();
			CapNhatNhanVienBtn = new Button();
			CapNhatPHGTextBox = new TextBox();
			label13 = new Label();
			CapNhatMaNQLTB = new TextBox();
			label17 = new Label();
			CapNhatVaiTroCB = new ComboBox();
			label18 = new Label();
			CapNhatSDTTB = new TextBox();
			label19 = new Label();
			CapNhatDiaChiTB = new TextBox();
			label20 = new Label();
			CapNhatNgaySinhDP = new DateTimePicker();
			label21 = new Label();
			CapNhatPhaiCB = new ComboBox();
			label22 = new Label();
			CapNhatTenNhanVienTB = new TextBox();
			label23 = new Label();
			label24 = new Label();
			CapNhatNhanVienTable = new DataGridView();
			ThemPhongBanTabPage = new TabPage();
			ThemMaTruongPhongBanTable = new DataGridView();
			maTruongPBLabel = new Label();
			ThemPhongBanBtn = new Button();
			label12 = new Label();
			TenPhongBanTextBox = new TextBox();
			label10 = new Label();
			label11 = new Label();
			ThemPhongBanTable = new DataGridView();
			CapNhatPhongBanTabPage = new TabPage();
			CapNhatPBMaTPTable = new DataGridView();
			CapNhatPBLabel = new Label();
			CapNhatPBBtn = new Button();
			label14 = new Label();
			CapNhatPBTextBox = new TextBox();
			label15 = new Label();
			label16 = new Label();
			CapNhatPBTable = new DataGridView();
			((System.ComponentModel.ISupportInitialize)NhanVienTable).BeginInit();
			TaiChinhTab.SuspendLayout();
			NhanVienTabPage.SuspendLayout();
			PhongBanTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)PhongBanTable).BeginInit();
			ThemNhanVienTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ThemNhanVienTable).BeginInit();
			CapNhatNhanVien.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CapNhatNhanVienTable).BeginInit();
			ThemPhongBanTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ThemMaTruongPhongBanTable).BeginInit();
			((System.ComponentModel.ISupportInitialize)ThemPhongBanTable).BeginInit();
			CapNhatPhongBanTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CapNhatPBMaTPTable).BeginInit();
			((System.ComponentModel.ISupportInitialize)CapNhatPBTable).BeginInit();
			SuspendLayout();
			// 
			// NhanVienTable
			// 
			NhanVienTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			NhanVienTable.Location = new Point(21, 18);
			NhanVienTable.Name = "NhanVienTable";
			NhanVienTable.RowHeadersWidth = 51;
			NhanVienTable.RowTemplate.Height = 29;
			NhanVienTable.Size = new Size(1321, 593);
			NhanVienTable.TabIndex = 0;
			// 
			// TaiChinhTab
			// 
			TaiChinhTab.Controls.Add(NhanVienTabPage);
			TaiChinhTab.Controls.Add(PhongBanTabPage);
			TaiChinhTab.Controls.Add(ThemNhanVienTabPage);
			TaiChinhTab.Controls.Add(CapNhatNhanVien);
			TaiChinhTab.Controls.Add(ThemPhongBanTabPage);
			TaiChinhTab.Controls.Add(CapNhatPhongBanTabPage);
			TaiChinhTab.Location = new Point(11, 28);
			TaiChinhTab.Name = "TaiChinhTab";
			TaiChinhTab.SelectedIndex = 0;
			TaiChinhTab.ShowToolTips = true;
			TaiChinhTab.Size = new Size(1374, 659);
			TaiChinhTab.TabIndex = 2;
			// 
			// NhanVienTabPage
			// 
			NhanVienTabPage.Controls.Add(NhanVienTable);
			NhanVienTabPage.Location = new Point(4, 29);
			NhanVienTabPage.Name = "NhanVienTabPage";
			NhanVienTabPage.Padding = new Padding(3);
			NhanVienTabPage.Size = new Size(1366, 626);
			NhanVienTabPage.TabIndex = 0;
			NhanVienTabPage.Text = "NhanVien";
			NhanVienTabPage.UseVisualStyleBackColor = true;
			// 
			// PhongBanTabPage
			// 
			PhongBanTabPage.Controls.Add(PhongBanTable);
			PhongBanTabPage.Location = new Point(4, 29);
			PhongBanTabPage.Name = "PhongBanTabPage";
			PhongBanTabPage.Padding = new Padding(3);
			PhongBanTabPage.Size = new Size(1366, 626);
			PhongBanTabPage.TabIndex = 1;
			PhongBanTabPage.Text = "PhongBan";
			PhongBanTabPage.UseVisualStyleBackColor = true;
			// 
			// PhongBanTable
			// 
			PhongBanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PhongBanTable.Location = new Point(26, 6);
			PhongBanTable.Name = "PhongBanTable";
			PhongBanTable.RowHeadersWidth = 51;
			PhongBanTable.RowTemplate.Height = 29;
			PhongBanTable.Size = new Size(1321, 614);
			PhongBanTable.TabIndex = 5;
			// 
			// ThemNhanVienTabPage
			// 
			ThemNhanVienTabPage.Controls.Add(PHGTextBox);
			ThemNhanVienTabPage.Controls.Add(ThemNhanVienBtn);
			ThemNhanVienTabPage.Controls.Add(label9);
			ThemNhanVienTabPage.Controls.Add(MaNQLTextBox);
			ThemNhanVienTabPage.Controls.Add(label8);
			ThemNhanVienTabPage.Controls.Add(VaiTroComboBox);
			ThemNhanVienTabPage.Controls.Add(label7);
			ThemNhanVienTabPage.Controls.Add(SdtTextBox);
			ThemNhanVienTabPage.Controls.Add(label4);
			ThemNhanVienTabPage.Controls.Add(DiaChiTextBox);
			ThemNhanVienTabPage.Controls.Add(label6);
			ThemNhanVienTabPage.Controls.Add(NgaySinhDatetime);
			ThemNhanVienTabPage.Controls.Add(label5);
			ThemNhanVienTabPage.Controls.Add(PhaiComboBox);
			ThemNhanVienTabPage.Controls.Add(label3);
			ThemNhanVienTabPage.Controls.Add(TenNhanVienTextBox);
			ThemNhanVienTabPage.Controls.Add(label2);
			ThemNhanVienTabPage.Controls.Add(label1);
			ThemNhanVienTabPage.Controls.Add(ThemNhanVienTable);
			ThemNhanVienTabPage.Location = new Point(4, 29);
			ThemNhanVienTabPage.Name = "ThemNhanVienTabPage";
			ThemNhanVienTabPage.Padding = new Padding(3);
			ThemNhanVienTabPage.Size = new Size(1366, 626);
			ThemNhanVienTabPage.TabIndex = 2;
			ThemNhanVienTabPage.Text = "ThemNhanVien";
			ThemNhanVienTabPage.UseVisualStyleBackColor = true;
			// 
			// PHGTextBox
			// 
			PHGTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			PHGTextBox.Location = new Point(628, 484);
			PHGTextBox.Name = "PHGTextBox";
			PHGTextBox.Size = new Size(493, 34);
			PHGTextBox.TabIndex = 23;
			// 
			// ThemNhanVienBtn
			// 
			ThemNhanVienBtn.Location = new Point(787, 542);
			ThemNhanVienBtn.Name = "ThemNhanVienBtn";
			ThemNhanVienBtn.Size = new Size(129, 52);
			ThemNhanVienBtn.TabIndex = 22;
			ThemNhanVienBtn.Text = "Thêm";
			ThemNhanVienBtn.UseVisualStyleBackColor = true;
			ThemNhanVienBtn.Click += ThemNhanVienBtn_Click_1;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(483, 490);
			label9.Name = "label9";
			label9.Size = new Size(49, 25);
			label9.TabIndex = 19;
			label9.Text = "PHG";
			// 
			// MaNQLTextBox
			// 
			MaNQLTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			MaNQLTextBox.Location = new Point(628, 428);
			MaNQLTextBox.Name = "MaNQLTextBox";
			MaNQLTextBox.Size = new Size(493, 34);
			MaNQLTextBox.TabIndex = 18;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(483, 430);
			label8.Name = "label8";
			label8.Size = new Size(81, 25);
			label8.TabIndex = 17;
			label8.Text = "Mã NQL";
			// 
			// VaiTroComboBox
			// 
			VaiTroComboBox.FormattingEnabled = true;
			VaiTroComboBox.Items.AddRange(new object[] { "Nhân viên", "QL trực tiếp", "Trưởng phòng", "Tài chính", "Nhân sự", "Trưởng đề án", "Ban giám đốc" });
			VaiTroComboBox.Location = new Point(628, 367);
			VaiTroComboBox.Name = "VaiTroComboBox";
			VaiTroComboBox.Size = new Size(151, 28);
			VaiTroComboBox.TabIndex = 16;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(483, 370);
			label7.Name = "label7";
			label7.Size = new Size(67, 25);
			label7.TabIndex = 15;
			label7.Text = "Vai trò";
			// 
			// SdtTextBox
			// 
			SdtTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			SdtTextBox.Location = new Point(628, 305);
			SdtTextBox.Name = "SdtTextBox";
			SdtTextBox.Size = new Size(493, 34);
			SdtTextBox.TabIndex = 14;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(483, 307);
			label4.Name = "label4";
			label4.Size = new Size(45, 25);
			label4.TabIndex = 13;
			label4.Text = "SĐT";
			// 
			// DiaChiTextBox
			// 
			DiaChiTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			DiaChiTextBox.Location = new Point(628, 246);
			DiaChiTextBox.Name = "DiaChiTextBox";
			DiaChiTextBox.Size = new Size(493, 34);
			DiaChiTextBox.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(483, 248);
			label6.Name = "label6";
			label6.Size = new Size(70, 25);
			label6.TabIndex = 11;
			label6.Text = "Địa chỉ";
			// 
			// NgaySinhDatetime
			// 
			NgaySinhDatetime.CustomFormat = "";
			NgaySinhDatetime.Format = DateTimePickerFormat.Short;
			NgaySinhDatetime.Location = new Point(628, 184);
			NgaySinhDatetime.Name = "NgaySinhDatetime";
			NgaySinhDatetime.Size = new Size(263, 27);
			NgaySinhDatetime.TabIndex = 10;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(483, 184);
			label5.Name = "label5";
			label5.Size = new Size(96, 25);
			label5.TabIndex = 9;
			label5.Text = "Ngày sinh";
			// 
			// PhaiComboBox
			// 
			PhaiComboBox.FormattingEnabled = true;
			PhaiComboBox.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
			PhaiComboBox.Location = new Point(628, 128);
			PhaiComboBox.Name = "PhaiComboBox";
			PhaiComboBox.Size = new Size(151, 28);
			PhaiComboBox.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(483, 131);
			label3.Name = "label3";
			label3.Size = new Size(49, 25);
			label3.TabIndex = 4;
			label3.Text = "Phái";
			// 
			// TenNhanVienTextBox
			// 
			TenNhanVienTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			TenNhanVienTextBox.Location = new Point(628, 71);
			TenNhanVienTextBox.Name = "TenNhanVienTextBox";
			TenNhanVienTextBox.Size = new Size(493, 34);
			TenNhanVienTextBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(483, 73);
			label2.Name = "label2";
			label2.Size = new Size(129, 25);
			label2.TabIndex = 2;
			label2.Text = "Tên nhân viên";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(787, 18);
			label1.Name = "label1";
			label1.Size = new Size(191, 35);
			label1.TabIndex = 1;
			label1.Text = "Thêm nhân viên";
			// 
			// ThemNhanVienTable
			// 
			ThemNhanVienTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ThemNhanVienTable.Location = new Point(24, 18);
			ThemNhanVienTable.Name = "ThemNhanVienTable";
			ThemNhanVienTable.RowHeadersWidth = 51;
			ThemNhanVienTable.RowTemplate.Height = 29;
			ThemNhanVienTable.Size = new Size(435, 592);
			ThemNhanVienTable.TabIndex = 0;
			ThemNhanVienTable.CellClick += ThemNhanVienTable_CellContentClick;
			// 
			// CapNhatNhanVien
			// 
			CapNhatNhanVien.Controls.Add(CapNhatNhanVienBtn);
			CapNhatNhanVien.Controls.Add(CapNhatPHGTextBox);
			CapNhatNhanVien.Controls.Add(label13);
			CapNhatNhanVien.Controls.Add(CapNhatMaNQLTB);
			CapNhatNhanVien.Controls.Add(label17);
			CapNhatNhanVien.Controls.Add(CapNhatVaiTroCB);
			CapNhatNhanVien.Controls.Add(label18);
			CapNhatNhanVien.Controls.Add(CapNhatSDTTB);
			CapNhatNhanVien.Controls.Add(label19);
			CapNhatNhanVien.Controls.Add(CapNhatDiaChiTB);
			CapNhatNhanVien.Controls.Add(label20);
			CapNhatNhanVien.Controls.Add(CapNhatNgaySinhDP);
			CapNhatNhanVien.Controls.Add(label21);
			CapNhatNhanVien.Controls.Add(CapNhatPhaiCB);
			CapNhatNhanVien.Controls.Add(label22);
			CapNhatNhanVien.Controls.Add(CapNhatTenNhanVienTB);
			CapNhatNhanVien.Controls.Add(label23);
			CapNhatNhanVien.Controls.Add(label24);
			CapNhatNhanVien.Controls.Add(CapNhatNhanVienTable);
			CapNhatNhanVien.Location = new Point(4, 29);
			CapNhatNhanVien.Name = "CapNhatNhanVien";
			CapNhatNhanVien.Padding = new Padding(3);
			CapNhatNhanVien.Size = new Size(1366, 626);
			CapNhatNhanVien.TabIndex = 5;
			CapNhatNhanVien.Text = "CapNhatNhanVien";
			CapNhatNhanVien.UseVisualStyleBackColor = true;
			// 
			// CapNhatNhanVienBtn
			// 
			CapNhatNhanVienBtn.Location = new Point(778, 544);
			CapNhatNhanVienBtn.Name = "CapNhatNhanVienBtn";
			CapNhatNhanVienBtn.Size = new Size(145, 52);
			CapNhatNhanVienBtn.TabIndex = 43;
			CapNhatNhanVienBtn.Text = "Cập nhật";
			CapNhatNhanVienBtn.UseVisualStyleBackColor = true;
			CapNhatNhanVienBtn.Click += CapNhatNhanVienBtn_Click;
			// 
			// CapNhatPHGTextBox
			// 
			CapNhatPHGTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatPHGTextBox.Location = new Point(619, 482);
			CapNhatPHGTextBox.Name = "CapNhatPHGTextBox";
			CapNhatPHGTextBox.Size = new Size(493, 34);
			CapNhatPHGTextBox.TabIndex = 42;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label13.Location = new Point(474, 488);
			label13.Name = "label13";
			label13.Size = new Size(49, 25);
			label13.TabIndex = 40;
			label13.Text = "PHG";
			// 
			// CapNhatMaNQLTB
			// 
			CapNhatMaNQLTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatMaNQLTB.Location = new Point(619, 426);
			CapNhatMaNQLTB.Name = "CapNhatMaNQLTB";
			CapNhatMaNQLTB.Size = new Size(493, 34);
			CapNhatMaNQLTB.TabIndex = 39;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label17.Location = new Point(474, 428);
			label17.Name = "label17";
			label17.Size = new Size(81, 25);
			label17.TabIndex = 38;
			label17.Text = "Mã NQL";
			// 
			// CapNhatVaiTroCB
			// 
			CapNhatVaiTroCB.FormattingEnabled = true;
			CapNhatVaiTroCB.Items.AddRange(new object[] { "Nhân viên", "QL trực tiếp", "Trưởng phòng", "Tài chính", "Nhân sự", "Trưởng đề án", "Ban giám đốc" });
			CapNhatVaiTroCB.Location = new Point(619, 365);
			CapNhatVaiTroCB.Name = "CapNhatVaiTroCB";
			CapNhatVaiTroCB.Size = new Size(151, 28);
			CapNhatVaiTroCB.TabIndex = 37;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label18.Location = new Point(474, 368);
			label18.Name = "label18";
			label18.Size = new Size(67, 25);
			label18.TabIndex = 36;
			label18.Text = "Vai trò";
			// 
			// CapNhatSDTTB
			// 
			CapNhatSDTTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatSDTTB.Location = new Point(619, 303);
			CapNhatSDTTB.Name = "CapNhatSDTTB";
			CapNhatSDTTB.Size = new Size(493, 34);
			CapNhatSDTTB.TabIndex = 35;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label19.Location = new Point(474, 305);
			label19.Name = "label19";
			label19.Size = new Size(45, 25);
			label19.TabIndex = 34;
			label19.Text = "SĐT";
			// 
			// CapNhatDiaChiTB
			// 
			CapNhatDiaChiTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatDiaChiTB.Location = new Point(619, 244);
			CapNhatDiaChiTB.Name = "CapNhatDiaChiTB";
			CapNhatDiaChiTB.Size = new Size(493, 34);
			CapNhatDiaChiTB.TabIndex = 33;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label20.Location = new Point(474, 246);
			label20.Name = "label20";
			label20.Size = new Size(70, 25);
			label20.TabIndex = 32;
			label20.Text = "Địa chỉ";
			// 
			// CapNhatNgaySinhDP
			// 
			CapNhatNgaySinhDP.CustomFormat = "";
			CapNhatNgaySinhDP.Format = DateTimePickerFormat.Short;
			CapNhatNgaySinhDP.Location = new Point(619, 182);
			CapNhatNgaySinhDP.Name = "CapNhatNgaySinhDP";
			CapNhatNgaySinhDP.Size = new Size(263, 27);
			CapNhatNgaySinhDP.TabIndex = 31;
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label21.Location = new Point(474, 182);
			label21.Name = "label21";
			label21.Size = new Size(96, 25);
			label21.TabIndex = 30;
			label21.Text = "Ngày sinh";
			// 
			// CapNhatPhaiCB
			// 
			CapNhatPhaiCB.FormattingEnabled = true;
			CapNhatPhaiCB.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
			CapNhatPhaiCB.Location = new Point(619, 126);
			CapNhatPhaiCB.Name = "CapNhatPhaiCB";
			CapNhatPhaiCB.Size = new Size(151, 28);
			CapNhatPhaiCB.TabIndex = 29;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label22.Location = new Point(474, 129);
			label22.Name = "label22";
			label22.Size = new Size(49, 25);
			label22.TabIndex = 28;
			label22.Text = "Phái";
			// 
			// CapNhatTenNhanVienTB
			// 
			CapNhatTenNhanVienTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatTenNhanVienTB.Location = new Point(619, 69);
			CapNhatTenNhanVienTB.Name = "CapNhatTenNhanVienTB";
			CapNhatTenNhanVienTB.Size = new Size(493, 34);
			CapNhatTenNhanVienTB.TabIndex = 27;
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label23.Location = new Point(474, 71);
			label23.Name = "label23";
			label23.Size = new Size(129, 25);
			label23.TabIndex = 26;
			label23.Text = "Tên nhân viên";
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label24.Location = new Point(778, 16);
			label24.Name = "label24";
			label24.Size = new Size(228, 35);
			label24.TabIndex = 25;
			label24.Text = "Cập nhật nhân viên";
			// 
			// CapNhatNhanVienTable
			// 
			CapNhatNhanVienTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CapNhatNhanVienTable.Location = new Point(15, 16);
			CapNhatNhanVienTable.Name = "CapNhatNhanVienTable";
			CapNhatNhanVienTable.RowHeadersWidth = 51;
			CapNhatNhanVienTable.RowTemplate.Height = 29;
			CapNhatNhanVienTable.Size = new Size(435, 592);
			CapNhatNhanVienTable.TabIndex = 24;
			CapNhatNhanVienTable.CellClick += CapNhatNhanVienTable_CellClick;
			// 
			// ThemPhongBanTabPage
			// 
			ThemPhongBanTabPage.Controls.Add(ThemMaTruongPhongBanTable);
			ThemPhongBanTabPage.Controls.Add(maTruongPBLabel);
			ThemPhongBanTabPage.Controls.Add(ThemPhongBanBtn);
			ThemPhongBanTabPage.Controls.Add(label12);
			ThemPhongBanTabPage.Controls.Add(TenPhongBanTextBox);
			ThemPhongBanTabPage.Controls.Add(label10);
			ThemPhongBanTabPage.Controls.Add(label11);
			ThemPhongBanTabPage.Controls.Add(ThemPhongBanTable);
			ThemPhongBanTabPage.Location = new Point(4, 29);
			ThemPhongBanTabPage.Name = "ThemPhongBanTabPage";
			ThemPhongBanTabPage.Padding = new Padding(3);
			ThemPhongBanTabPage.Size = new Size(1366, 626);
			ThemPhongBanTabPage.TabIndex = 3;
			ThemPhongBanTabPage.Text = "ThemPhongBan";
			ThemPhongBanTabPage.UseVisualStyleBackColor = true;
			// 
			// ThemMaTruongPhongBanTable
			// 
			ThemMaTruongPhongBanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ThemMaTruongPhongBanTable.Location = new Point(719, 195);
			ThemMaTruongPhongBanTable.Name = "ThemMaTruongPhongBanTable";
			ThemMaTruongPhongBanTable.RowHeadersWidth = 51;
			ThemMaTruongPhongBanTable.RowTemplate.Height = 29;
			ThemMaTruongPhongBanTable.Size = new Size(493, 236);
			ThemMaTruongPhongBanTable.TabIndex = 26;
			ThemMaTruongPhongBanTable.CellClick += ThemMaTruongPhongBanTable_CellClick;
			// 
			// maTruongPBLabel
			// 
			maTruongPBLabel.AutoSize = true;
			maTruongPBLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			maTruongPBLabel.Location = new Point(719, 148);
			maTruongPBLabel.Name = "maTruongPBLabel";
			maTruongPBLabel.Size = new Size(194, 25);
			maTruongPBLabel.TabIndex = 25;
			maTruongPBLabel.Text = "<Chọn mã bên dưới>";
			// 
			// ThemPhongBanBtn
			// 
			ThemPhongBanBtn.Location = new Point(778, 457);
			ThemPhongBanBtn.Name = "ThemPhongBanBtn";
			ThemPhongBanBtn.Size = new Size(151, 52);
			ThemPhongBanBtn.TabIndex = 24;
			ThemPhongBanBtn.Text = "Thêm phòng ban";
			ThemPhongBanBtn.UseVisualStyleBackColor = true;
			ThemPhongBanBtn.Click += ThemPhongBanBtn_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(474, 148);
			label12.Name = "label12";
			label12.Size = new Size(198, 25);
			label12.TabIndex = 8;
			label12.Text = "Mã trưởng phòng ban";
			// 
			// TenPhongBanTextBox
			// 
			TenPhongBanTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			TenPhongBanTextBox.Location = new Point(719, 70);
			TenPhongBanTextBox.Name = "TenPhongBanTextBox";
			TenPhongBanTextBox.Size = new Size(493, 34);
			TenPhongBanTextBox.TabIndex = 7;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(474, 70);
			label10.Name = "label10";
			label10.Size = new Size(138, 25);
			label10.TabIndex = 6;
			label10.Text = "Tên phòng ban";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(778, 15);
			label11.Name = "label11";
			label11.Size = new Size(206, 35);
			label11.TabIndex = 5;
			label11.Text = "Thêm phòng ban";
			// 
			// ThemPhongBanTable
			// 
			ThemPhongBanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ThemPhongBanTable.Location = new Point(15, 15);
			ThemPhongBanTable.Name = "ThemPhongBanTable";
			ThemPhongBanTable.RowHeadersWidth = 51;
			ThemPhongBanTable.RowTemplate.Height = 29;
			ThemPhongBanTable.Size = new Size(435, 592);
			ThemPhongBanTable.TabIndex = 4;
			// 
			// CapNhatPhongBanTabPage
			// 
			CapNhatPhongBanTabPage.Controls.Add(CapNhatPBMaTPTable);
			CapNhatPhongBanTabPage.Controls.Add(CapNhatPBLabel);
			CapNhatPhongBanTabPage.Controls.Add(CapNhatPBBtn);
			CapNhatPhongBanTabPage.Controls.Add(label14);
			CapNhatPhongBanTabPage.Controls.Add(CapNhatPBTextBox);
			CapNhatPhongBanTabPage.Controls.Add(label15);
			CapNhatPhongBanTabPage.Controls.Add(label16);
			CapNhatPhongBanTabPage.Controls.Add(CapNhatPBTable);
			CapNhatPhongBanTabPage.Location = new Point(4, 29);
			CapNhatPhongBanTabPage.Name = "CapNhatPhongBanTabPage";
			CapNhatPhongBanTabPage.Padding = new Padding(3);
			CapNhatPhongBanTabPage.Size = new Size(1366, 626);
			CapNhatPhongBanTabPage.TabIndex = 4;
			CapNhatPhongBanTabPage.Text = "CapNhatPhongBan";
			CapNhatPhongBanTabPage.UseVisualStyleBackColor = true;
			// 
			// CapNhatPBMaTPTable
			// 
			CapNhatPBMaTPTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CapNhatPBMaTPTable.Location = new Point(728, 196);
			CapNhatPBMaTPTable.Name = "CapNhatPBMaTPTable";
			CapNhatPBMaTPTable.RowHeadersWidth = 51;
			CapNhatPBMaTPTable.RowTemplate.Height = 29;
			CapNhatPBMaTPTable.Size = new Size(493, 236);
			CapNhatPBMaTPTable.TabIndex = 34;
			CapNhatPBMaTPTable.CellClick += CapNhatPBMaTPTable_CellClick;
			// 
			// CapNhatPBLabel
			// 
			CapNhatPBLabel.AutoSize = true;
			CapNhatPBLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatPBLabel.Location = new Point(728, 149);
			CapNhatPBLabel.Name = "CapNhatPBLabel";
			CapNhatPBLabel.Size = new Size(194, 25);
			CapNhatPBLabel.TabIndex = 33;
			CapNhatPBLabel.Text = "<Chọn mã bên dưới>";
			// 
			// CapNhatPBBtn
			// 
			CapNhatPBBtn.Location = new Point(787, 458);
			CapNhatPBBtn.Name = "CapNhatPBBtn";
			CapNhatPBBtn.Size = new Size(169, 52);
			CapNhatPBBtn.TabIndex = 32;
			CapNhatPBBtn.Text = "Cập nhật phòng ban";
			CapNhatPBBtn.UseVisualStyleBackColor = true;
			CapNhatPBBtn.Click += CapNhatPBBtn_Click;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label14.Location = new Point(483, 149);
			label14.Name = "label14";
			label14.Size = new Size(198, 25);
			label14.TabIndex = 31;
			label14.Text = "Mã trưởng phòng ban";
			// 
			// CapNhatPBTextBox
			// 
			CapNhatPBTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			CapNhatPBTextBox.Location = new Point(728, 71);
			CapNhatPBTextBox.Name = "CapNhatPBTextBox";
			CapNhatPBTextBox.Size = new Size(493, 34);
			CapNhatPBTextBox.TabIndex = 30;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label15.Location = new Point(483, 71);
			label15.Name = "label15";
			label15.Size = new Size(175, 25);
			label15.TabIndex = 29;
			label15.Text = "Tên phòng ban mới";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label16.Location = new Point(787, 16);
			label16.Name = "label16";
			label16.Size = new Size(243, 35);
			label16.TabIndex = 28;
			label16.Text = "Cập nhật phòng ban";
			// 
			// CapNhatPBTable
			// 
			CapNhatPBTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CapNhatPBTable.Location = new Point(24, 16);
			CapNhatPBTable.Name = "CapNhatPBTable";
			CapNhatPBTable.RowHeadersWidth = 51;
			CapNhatPBTable.RowTemplate.Height = 29;
			CapNhatPBTable.Size = new Size(435, 592);
			CapNhatPBTable.TabIndex = 27;
			CapNhatPBTable.CellClick += CapNhatPBTable_CellClick;
			// 
			// NhanSuForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1397, 714);
			Controls.Add(TaiChinhTab);
			Name = "NhanSuForm";
			Text = "NhanSuForm";
			Load += NhanSuForm_Load;
			((System.ComponentModel.ISupportInitialize)NhanVienTable).EndInit();
			TaiChinhTab.ResumeLayout(false);
			NhanVienTabPage.ResumeLayout(false);
			PhongBanTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)PhongBanTable).EndInit();
			ThemNhanVienTabPage.ResumeLayout(false);
			ThemNhanVienTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ThemNhanVienTable).EndInit();
			CapNhatNhanVien.ResumeLayout(false);
			CapNhatNhanVien.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CapNhatNhanVienTable).EndInit();
			ThemPhongBanTabPage.ResumeLayout(false);
			ThemPhongBanTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ThemMaTruongPhongBanTable).EndInit();
			((System.ComponentModel.ISupportInitialize)ThemPhongBanTable).EndInit();
			CapNhatPhongBanTabPage.ResumeLayout(false);
			CapNhatPhongBanTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CapNhatPBMaTPTable).EndInit();
			((System.ComponentModel.ISupportInitialize)CapNhatPBTable).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView NhanVienTable;
		private TabControl TaiChinhTab;
		private TabPage NhanVienTabPage;
		private TabPage PhongBanTabPage;
		private DataGridView PhongBanTable;
		private TabPage ThemNhanVienTabPage;
		private Label label1;
		private DataGridView ThemNhanVienTable;
		private TextBox DiaChiTextBox;
		private Label label6;
		private DateTimePicker NgaySinhDatetime;
		private Label label5;
		private ComboBox PhaiComboBox;
		private Label label3;
		private TextBox TenNhanVienTextBox;
		private Label label2;
		private Button ThemNhanVienBtn;
		private Label label9;
		private TextBox MaNQLTextBox;
		private Label label8;
		private ComboBox VaiTroComboBox;
		private Label label7;
		private TextBox SdtTextBox;
		private Label label4;
		private TextBox PHGTextBox;
		private TabPage ThemPhongBanTabPage;
		private Button ThemPhongBanBtn;
		private Label label12;
		private TextBox TenPhongBanTextBox;
		private Label label10;
		private Label label11;
		private DataGridView ThemPhongBanTable;
		private DataGridView ThemMaTruongPhongBanTable;
		private Label maTruongPBLabel;
		private TabPage CapNhatPhongBanTabPage;
		private DataGridView CapNhatPBMaTPTable;
		private Label CapNhatPBLabel;
		private Button CapNhatPBBtn;
		private Label label14;
		private TextBox CapNhatPBTextBox;
		private Label label15;
		private Label label16;
		private DataGridView CapNhatPBTable;
		private TabPage CapNhatNhanVien;
		private Button CapNhatNhanVienBtn;
		private TextBox CapNhatPHGTextBox;
		private Label label13;
		private TextBox CapNhatMaNQLTB;
		private Label label17;
		private ComboBox CapNhatVaiTroCB;
		private Label label18;
		private TextBox CapNhatSDTTB;
		private Label label19;
		private TextBox CapNhatDiaChiTB;
		private Label label20;
		private DateTimePicker CapNhatNgaySinhDP;
		private Label label21;
		private ComboBox CapNhatPhaiCB;
		private Label label22;
		private TextBox CapNhatTenNhanVienTB;
		private Label label23;
		private Label label24;
		private DataGridView CapNhatNhanVienTable;
	}
}
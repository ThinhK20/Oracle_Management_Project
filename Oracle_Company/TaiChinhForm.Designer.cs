namespace Oracle_Company
{
	partial class TaiChinhForm
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
			TaiChinhTab = new TabControl();
			NhanVienTabPage = new TabPage();
			ThayDoiPhuCapBtn = new Button();
			ThayDoiLuongBtn = new Button();
			NhanVienTable = new DataGridView();
			PhanCongTabPage = new TabPage();
			PhanCongTable = new DataGridView();
			TaiChinhTab.SuspendLayout();
			NhanVienTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)NhanVienTable).BeginInit();
			PhanCongTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)PhanCongTable).BeginInit();
			SuspendLayout();
			// 
			// TaiChinhTab
			// 
			TaiChinhTab.Controls.Add(NhanVienTabPage);
			TaiChinhTab.Controls.Add(PhanCongTabPage);
			TaiChinhTab.Location = new Point(22, 12);
			TaiChinhTab.Name = "TaiChinhTab";
			TaiChinhTab.SelectedIndex = 0;
			TaiChinhTab.Size = new Size(1374, 659);
			TaiChinhTab.TabIndex = 1;
			// 
			// NhanVienTabPage
			// 
			NhanVienTabPage.Controls.Add(ThayDoiPhuCapBtn);
			NhanVienTabPage.Controls.Add(ThayDoiLuongBtn);
			NhanVienTabPage.Controls.Add(NhanVienTable);
			NhanVienTabPage.Location = new Point(4, 29);
			NhanVienTabPage.Name = "NhanVienTabPage";
			NhanVienTabPage.Padding = new Padding(3);
			NhanVienTabPage.Size = new Size(1366, 626);
			NhanVienTabPage.TabIndex = 0;
			NhanVienTabPage.Text = "NhanVien";
			NhanVienTabPage.UseVisualStyleBackColor = true;
			// 
			// ThayDoiPhuCapBtn
			// 
			ThayDoiPhuCapBtn.Location = new Point(773, 21);
			ThayDoiPhuCapBtn.Name = "ThayDoiPhuCapBtn";
			ThayDoiPhuCapBtn.Size = new Size(145, 52);
			ThayDoiPhuCapBtn.TabIndex = 4;
			ThayDoiPhuCapBtn.Text = "Thay đổi phụ cấp";
			ThayDoiPhuCapBtn.UseVisualStyleBackColor = true;
			ThayDoiPhuCapBtn.Click += ThayDoiPhuCapBtn_Click;
			// 
			// ThayDoiLuongBtn
			// 
			ThayDoiLuongBtn.Location = new Point(422, 21);
			ThayDoiLuongBtn.Name = "ThayDoiLuongBtn";
			ThayDoiLuongBtn.Size = new Size(129, 52);
			ThayDoiLuongBtn.TabIndex = 3;
			ThayDoiLuongBtn.Text = "Thay đổi lương";
			ThayDoiLuongBtn.UseVisualStyleBackColor = true;
			ThayDoiLuongBtn.Click += ThayDoiLuongBtn_Click;
			// 
			// NhanVienTable
			// 
			NhanVienTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			NhanVienTable.Location = new Point(25, 90);
			NhanVienTable.Name = "NhanVienTable";
			NhanVienTable.RowHeadersWidth = 51;
			NhanVienTable.RowTemplate.Height = 29;
			NhanVienTable.Size = new Size(1321, 530);
			NhanVienTable.TabIndex = 0;
			NhanVienTable.CellClick += NhanVienTable_CellClick;
			// 
			// PhanCongTabPage
			// 
			PhanCongTabPage.Controls.Add(PhanCongTable);
			PhanCongTabPage.Location = new Point(4, 29);
			PhanCongTabPage.Name = "PhanCongTabPage";
			PhanCongTabPage.Padding = new Padding(3);
			PhanCongTabPage.Size = new Size(1366, 626);
			PhanCongTabPage.TabIndex = 1;
			PhanCongTabPage.Text = "PhanCong";
			PhanCongTabPage.UseVisualStyleBackColor = true;
			// 
			// PhanCongTable
			// 
			PhanCongTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PhanCongTable.Location = new Point(26, 21);
			PhanCongTable.Name = "PhanCongTable";
			PhanCongTable.RowHeadersWidth = 51;
			PhanCongTable.RowTemplate.Height = 29;
			PhanCongTable.Size = new Size(1314, 587);
			PhanCongTable.TabIndex = 3;
			// 
			// TaiChinhForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1408, 690);
			Controls.Add(TaiChinhTab);
			Name = "TaiChinhForm";
			Text = "TaiChinhForm";
			Load += TaiChinhForm_Load;
			TaiChinhTab.ResumeLayout(false);
			NhanVienTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)NhanVienTable).EndInit();
			PhanCongTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)PhanCongTable).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl TaiChinhTab;
		private TabPage NhanVienTabPage;
		private DataGridView NhanVienTable;
		private TabPage PhanCongTabPage;
		private DataGridView PhanCongTable;
		private Button ThayDoiPhuCapBtn;
		private Button ThayDoiLuongBtn;
	}
}
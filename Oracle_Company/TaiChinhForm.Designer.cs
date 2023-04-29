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
			NhanVienSearchBtn = new Button();
			NhanVienSearch = new TextBox();
			NhanVienTable = new DataGridView();
			PhanCongTabPage = new TabPage();
			PhanCongSearchBtn = new Button();
			PhanCongSearch = new TextBox();
			PhanCongTable = new DataGridView();
			ThayDoiLuongBtn = new Button();
			ThayDoiPhuCapBtn = new Button();
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
			NhanVienTabPage.Controls.Add(NhanVienSearchBtn);
			NhanVienTabPage.Controls.Add(NhanVienSearch);
			NhanVienTabPage.Controls.Add(NhanVienTable);
			NhanVienTabPage.Location = new Point(4, 29);
			NhanVienTabPage.Name = "NhanVienTabPage";
			NhanVienTabPage.Padding = new Padding(3);
			NhanVienTabPage.Size = new Size(1366, 626);
			NhanVienTabPage.TabIndex = 0;
			NhanVienTabPage.Text = "NhanVien";
			NhanVienTabPage.UseVisualStyleBackColor = true;
			// 
			// NhanVienSearchBtn
			// 
			NhanVienSearchBtn.BackColor = SystemColors.ActiveBorder;
			NhanVienSearchBtn.ForeColor = Color.Black;
			NhanVienSearchBtn.Location = new Point(825, 22);
			NhanVienSearchBtn.Name = "NhanVienSearchBtn";
			NhanVienSearchBtn.Size = new Size(120, 43);
			NhanVienSearchBtn.TabIndex = 2;
			NhanVienSearchBtn.Text = "Search";
			NhanVienSearchBtn.UseVisualStyleBackColor = false;
			// 
			// NhanVienSearch
			// 
			NhanVienSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			NhanVienSearch.Location = new Point(25, 28);
			NhanVienSearch.Name = "NhanVienSearch";
			NhanVienSearch.PlaceholderText = "Search...";
			NhanVienSearch.Size = new Size(764, 34);
			NhanVienSearch.TabIndex = 1;
			// 
			// NhanVienTable
			// 
			NhanVienTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			NhanVienTable.Location = new Point(25, 147);
			NhanVienTable.Name = "NhanVienTable";
			NhanVienTable.RowHeadersWidth = 51;
			NhanVienTable.RowTemplate.Height = 29;
			NhanVienTable.Size = new Size(1321, 386);
			NhanVienTable.TabIndex = 0;
			NhanVienTable.CellClick += NhanVienTable_CellClick;
			NhanVienTable.CellContentClick += NhanVienTable_CellContentClick;
			// 
			// PhanCongTabPage
			// 
			PhanCongTabPage.Controls.Add(PhanCongSearchBtn);
			PhanCongTabPage.Controls.Add(PhanCongSearch);
			PhanCongTabPage.Controls.Add(PhanCongTable);
			PhanCongTabPage.Location = new Point(4, 29);
			PhanCongTabPage.Name = "PhanCongTabPage";
			PhanCongTabPage.Padding = new Padding(3);
			PhanCongTabPage.Size = new Size(1366, 626);
			PhanCongTabPage.TabIndex = 1;
			PhanCongTabPage.Text = "PhanCong";
			PhanCongTabPage.UseVisualStyleBackColor = true;
			PhanCongTabPage.Click += PhanCongTabPage_Click;
			// 
			// PhanCongSearchBtn
			// 
			PhanCongSearchBtn.BackColor = SystemColors.ActiveBorder;
			PhanCongSearchBtn.ForeColor = Color.Black;
			PhanCongSearchBtn.Location = new Point(827, 25);
			PhanCongSearchBtn.Name = "PhanCongSearchBtn";
			PhanCongSearchBtn.Size = new Size(120, 43);
			PhanCongSearchBtn.TabIndex = 5;
			PhanCongSearchBtn.Text = "Search";
			PhanCongSearchBtn.UseVisualStyleBackColor = false;
			// 
			// PhanCongSearch
			// 
			PhanCongSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			PhanCongSearch.Location = new Point(27, 31);
			PhanCongSearch.Name = "PhanCongSearch";
			PhanCongSearch.PlaceholderText = "Search...";
			PhanCongSearch.Size = new Size(764, 34);
			PhanCongSearch.TabIndex = 4;
			// 
			// PhanCongTable
			// 
			PhanCongTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PhanCongTable.Location = new Point(27, 150);
			PhanCongTable.Name = "PhanCongTable";
			PhanCongTable.RowHeadersWidth = 51;
			PhanCongTable.RowTemplate.Height = 29;
			PhanCongTable.Size = new Size(1314, 386);
			PhanCongTable.TabIndex = 3;
			// 
			// ThayDoiLuongBtn
			// 
			ThayDoiLuongBtn.Location = new Point(393, 80);
			ThayDoiLuongBtn.Name = "ThayDoiLuongBtn";
			ThayDoiLuongBtn.Size = new Size(129, 52);
			ThayDoiLuongBtn.TabIndex = 3;
			ThayDoiLuongBtn.Text = "Thay đổi lương";
			ThayDoiLuongBtn.UseVisualStyleBackColor = true;
			// 
			// ThayDoiPhuCapBtn
			// 
			ThayDoiPhuCapBtn.Location = new Point(564, 80);
			ThayDoiPhuCapBtn.Name = "ThayDoiPhuCapBtn";
			ThayDoiPhuCapBtn.Size = new Size(145, 52);
			ThayDoiPhuCapBtn.TabIndex = 4;
			ThayDoiPhuCapBtn.Text = "Thay đổi phụ cấp";
			ThayDoiPhuCapBtn.UseVisualStyleBackColor = true;
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
			NhanVienTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)NhanVienTable).EndInit();
			PhanCongTabPage.ResumeLayout(false);
			PhanCongTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)PhanCongTable).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl TaiChinhTab;
		private TabPage NhanVienTabPage;
		private Button NhanVienSearchBtn;
		private TextBox NhanVienSearch;
		private DataGridView NhanVienTable;
		private TabPage PhanCongTabPage;
		private Button PhanCongSearchBtn;
		private TextBox PhanCongSearch;
		private DataGridView PhanCongTable;
		private Button ThayDoiPhuCapBtn;
		private Button ThayDoiLuongBtn;
	}
}
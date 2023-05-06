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
            this.TaiChinhTab = new System.Windows.Forms.TabControl();
            this.NhanVienTabPage = new System.Windows.Forms.TabPage();
            this.ThayDoiPhuCapBtn = new System.Windows.Forms.Button();
            this.ThayDoiLuongBtn = new System.Windows.Forms.Button();
            this.NhanVienSearchBtn = new System.Windows.Forms.Button();
            this.NhanVienSearch = new System.Windows.Forms.TextBox();
            this.NhanVienTable = new System.Windows.Forms.DataGridView();
            this.PhanCongTabPage = new System.Windows.Forms.TabPage();
            this.PhanCongSearchBtn = new System.Windows.Forms.Button();
            this.PhanCongSearch = new System.Windows.Forms.TextBox();
            this.PhanCongTable = new System.Windows.Forms.DataGridView();
            this.TaiChinhTab.SuspendLayout();
            this.NhanVienTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienTable)).BeginInit();
            this.PhanCongTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhanCongTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TaiChinhTab
            // 
            this.TaiChinhTab.Controls.Add(this.NhanVienTabPage);
            this.TaiChinhTab.Controls.Add(this.PhanCongTabPage);
            this.TaiChinhTab.Location = new System.Drawing.Point(22, 12);
            this.TaiChinhTab.Name = "TaiChinhTab";
            this.TaiChinhTab.SelectedIndex = 0;
            this.TaiChinhTab.Size = new System.Drawing.Size(1374, 659);
            this.TaiChinhTab.TabIndex = 1;
            // 
            // NhanVienTabPage
            // 
            this.NhanVienTabPage.Controls.Add(this.ThayDoiPhuCapBtn);
            this.NhanVienTabPage.Controls.Add(this.ThayDoiLuongBtn);
            this.NhanVienTabPage.Controls.Add(this.NhanVienSearchBtn);
            this.NhanVienTabPage.Controls.Add(this.NhanVienSearch);
            this.NhanVienTabPage.Controls.Add(this.NhanVienTable);
            this.NhanVienTabPage.Location = new System.Drawing.Point(4, 29);
            this.NhanVienTabPage.Name = "NhanVienTabPage";
            this.NhanVienTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NhanVienTabPage.Size = new System.Drawing.Size(1366, 626);
            this.NhanVienTabPage.TabIndex = 0;
            this.NhanVienTabPage.Text = "NhanVien";
            this.NhanVienTabPage.UseVisualStyleBackColor = true;
            // 
            // ThayDoiPhuCapBtn
            // 
            this.ThayDoiPhuCapBtn.Location = new System.Drawing.Point(564, 80);
            this.ThayDoiPhuCapBtn.Name = "ThayDoiPhuCapBtn";
            this.ThayDoiPhuCapBtn.Size = new System.Drawing.Size(145, 52);
            this.ThayDoiPhuCapBtn.TabIndex = 4;
            this.ThayDoiPhuCapBtn.Text = "Thay đổi phụ cấp";
            this.ThayDoiPhuCapBtn.UseVisualStyleBackColor = true;
            this.ThayDoiPhuCapBtn.Click += new System.EventHandler(this.ThayDoiPhuCapBtn_Click);
            // 
            // ThayDoiLuongBtn
            // 
            this.ThayDoiLuongBtn.Location = new System.Drawing.Point(393, 80);
            this.ThayDoiLuongBtn.Name = "ThayDoiLuongBtn";
            this.ThayDoiLuongBtn.Size = new System.Drawing.Size(129, 52);
            this.ThayDoiLuongBtn.TabIndex = 3;
            this.ThayDoiLuongBtn.Text = "Thay đổi lương";
            this.ThayDoiLuongBtn.UseVisualStyleBackColor = true;
            this.ThayDoiLuongBtn.Click += new System.EventHandler(this.ThayDoiLuongBtn_Click);
            // 
            // NhanVienSearchBtn
            // 
            this.NhanVienSearchBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NhanVienSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.NhanVienSearchBtn.Location = new System.Drawing.Point(825, 22);
            this.NhanVienSearchBtn.Name = "NhanVienSearchBtn";
            this.NhanVienSearchBtn.Size = new System.Drawing.Size(120, 43);
            this.NhanVienSearchBtn.TabIndex = 2;
            this.NhanVienSearchBtn.Text = "Search";
            this.NhanVienSearchBtn.UseVisualStyleBackColor = false;
            // 
            // NhanVienSearch
            // 
            this.NhanVienSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NhanVienSearch.Location = new System.Drawing.Point(25, 28);
            this.NhanVienSearch.Name = "NhanVienSearch";
            this.NhanVienSearch.PlaceholderText = "Search...";
            this.NhanVienSearch.Size = new System.Drawing.Size(764, 34);
            this.NhanVienSearch.TabIndex = 1;
            // 
            // NhanVienTable
            // 
            this.NhanVienTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NhanVienTable.Location = new System.Drawing.Point(25, 147);
            this.NhanVienTable.Name = "NhanVienTable";
            this.NhanVienTable.RowHeadersWidth = 51;
            this.NhanVienTable.RowTemplate.Height = 29;
            this.NhanVienTable.Size = new System.Drawing.Size(1321, 386);
            this.NhanVienTable.TabIndex = 0;
            this.NhanVienTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanVienTable_CellClick);
            // 
            // PhanCongTabPage
            // 
            this.PhanCongTabPage.Controls.Add(this.PhanCongSearchBtn);
            this.PhanCongTabPage.Controls.Add(this.PhanCongSearch);
            this.PhanCongTabPage.Controls.Add(this.PhanCongTable);
            this.PhanCongTabPage.Location = new System.Drawing.Point(4, 29);
            this.PhanCongTabPage.Name = "PhanCongTabPage";
            this.PhanCongTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PhanCongTabPage.Size = new System.Drawing.Size(1366, 626);
            this.PhanCongTabPage.TabIndex = 1;
            this.PhanCongTabPage.Text = "PhanCong";
            this.PhanCongTabPage.UseVisualStyleBackColor = true;
            // 
            // PhanCongSearchBtn
            // 
            this.PhanCongSearchBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PhanCongSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.PhanCongSearchBtn.Location = new System.Drawing.Point(827, 25);
            this.PhanCongSearchBtn.Name = "PhanCongSearchBtn";
            this.PhanCongSearchBtn.Size = new System.Drawing.Size(120, 43);
            this.PhanCongSearchBtn.TabIndex = 5;
            this.PhanCongSearchBtn.Text = "Search";
            this.PhanCongSearchBtn.UseVisualStyleBackColor = false;
            // 
            // PhanCongSearch
            // 
            this.PhanCongSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhanCongSearch.Location = new System.Drawing.Point(27, 31);
            this.PhanCongSearch.Name = "PhanCongSearch";
            this.PhanCongSearch.PlaceholderText = "Search...";
            this.PhanCongSearch.Size = new System.Drawing.Size(764, 34);
            this.PhanCongSearch.TabIndex = 4;
            // 
            // PhanCongTable
            // 
            this.PhanCongTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhanCongTable.Location = new System.Drawing.Point(27, 150);
            this.PhanCongTable.Name = "PhanCongTable";
            this.PhanCongTable.RowHeadersWidth = 51;
            this.PhanCongTable.RowTemplate.Height = 29;
            this.PhanCongTable.Size = new System.Drawing.Size(1314, 386);
            this.PhanCongTable.TabIndex = 3;
            // 
            // TaiChinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1408, 690);
            this.Controls.Add(this.TaiChinhTab);
            this.Name = "TaiChinhForm";
            this.Text = "TaiChinhForm";
            this.Load += new System.EventHandler(this.TaiChinhForm_Load);
            this.TaiChinhTab.ResumeLayout(false);
            this.NhanVienTabPage.ResumeLayout(false);
            this.NhanVienTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienTable)).EndInit();
            this.PhanCongTabPage.ResumeLayout(false);
            this.PhanCongTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhanCongTable)).EndInit();
            this.ResumeLayout(false);

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
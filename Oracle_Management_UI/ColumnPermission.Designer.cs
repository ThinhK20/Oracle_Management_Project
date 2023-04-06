namespace Oracle_Management_UI
{
    partial class ColumnPermission
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
            this.components = new System.ComponentModel.Container();
            this.selectControlTab = new System.Windows.Forms.TabControl();
            this.selectTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Colunb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revokeSelectBtn = new System.Windows.Forms.Button();
            this.viewSelectResult = new System.Windows.Forms.Label();
            this.viewSelectLabel = new System.Windows.Forms.Label();
            this.dataGridTableViewSelectUsers = new System.Windows.Forms.DataGridView();
            this.dataGridTableViewsSelect = new System.Windows.Forms.DataGridView();
            this.withOptionSelectCheckbox = new System.Windows.Forms.CheckBox();
            this.grantSelectBtn = new System.Windows.Forms.Button();
            this.viewNameSelectTextBox = new System.Windows.Forms.TextBox();
            this.viewNameSelectLabel = new System.Windows.Forms.Label();
            this.dataGridTableInfoSelect = new System.Windows.Forms.DataGridView();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.attributeUpdateLabel2 = new System.Windows.Forms.Label();
            this.columnUpdateLabel2 = new System.Windows.Forms.Label();
            this.withOptionUpdateCheckbox = new System.Windows.Forms.CheckBox();
            this.grantUpdateBtn = new System.Windows.Forms.Button();
            this.revokeUpdateBtn = new System.Windows.Forms.Button();
            this.attributeUpdateLabel = new System.Windows.Forms.Label();
            this.columnUpdateLabel = new System.Windows.Forms.Label();
            this.dataGridViewUpdatePrivs = new System.Windows.Forms.DataGridView();
            this.dataGridViewUpdateInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectControlTab.SuspendLayout();
            this.selectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableViewSelectUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableViewsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableInfoSelect)).BeginInit();
            this.updateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdatePrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // selectControlTab
            // 
            this.selectControlTab.Controls.Add(this.selectTabPage);
            this.selectControlTab.Controls.Add(this.updateTabPage);
            this.selectControlTab.Location = new System.Drawing.Point(14, 77);
            this.selectControlTab.Name = "selectControlTab";
            this.selectControlTab.SelectedIndex = 0;
            this.selectControlTab.Size = new System.Drawing.Size(795, 593);
            this.selectControlTab.TabIndex = 0;
            // 
            // selectTabPage
            // 
            this.selectTabPage.Controls.Add(this.button1);
            this.selectTabPage.Controls.Add(this.dataGridView1);
            this.selectTabPage.Controls.Add(this.revokeSelectBtn);
            this.selectTabPage.Controls.Add(this.viewSelectResult);
            this.selectTabPage.Controls.Add(this.viewSelectLabel);
            this.selectTabPage.Controls.Add(this.dataGridTableViewSelectUsers);
            this.selectTabPage.Controls.Add(this.dataGridTableViewsSelect);
            this.selectTabPage.Controls.Add(this.withOptionSelectCheckbox);
            this.selectTabPage.Controls.Add(this.grantSelectBtn);
            this.selectTabPage.Controls.Add(this.viewNameSelectTextBox);
            this.selectTabPage.Controls.Add(this.viewNameSelectLabel);
            this.selectTabPage.Controls.Add(this.dataGridTableInfoSelect);
            this.selectTabPage.Location = new System.Drawing.Point(4, 29);
            this.selectTabPage.Name = "selectTabPage";
            this.selectTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.selectTabPage.Size = new System.Drawing.Size(787, 560);
            this.selectTabPage.TabIndex = 0;
            this.selectTabPage.Text = "Select";
            this.selectTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(715, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colunb});
            this.dataGridView1.Location = new System.Drawing.Point(449, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(330, 175);
            this.dataGridView1.TabIndex = 19;
            // 
            // Colunb
            // 
            this.Colunb.HeaderText = "Column";
            this.Colunb.MinimumWidth = 6;
            this.Colunb.Name = "Colunb";
            this.Colunb.ReadOnly = true;
            this.Colunb.Visible = false;
            this.Colunb.Width = 125;
            // 
            // revokeSelectBtn
            // 
            this.revokeSelectBtn.Location = new System.Drawing.Point(665, 491);
            this.revokeSelectBtn.Name = "revokeSelectBtn";
            this.revokeSelectBtn.Size = new System.Drawing.Size(107, 39);
            this.revokeSelectBtn.TabIndex = 18;
            this.revokeSelectBtn.Text = "Revoke";
            this.revokeSelectBtn.UseVisualStyleBackColor = true;
            // 
            // viewSelectResult
            // 
            this.viewSelectResult.AutoSize = true;
            this.viewSelectResult.Location = new System.Drawing.Point(503, 491);
            this.viewSelectResult.Name = "viewSelectResult";
            this.viewSelectResult.Size = new System.Drawing.Size(18, 20);
            this.viewSelectResult.TabIndex = 17;
            this.viewSelectResult.Text = "...";
            // 
            // viewSelectLabel
            // 
            this.viewSelectLabel.AutoSize = true;
            this.viewSelectLabel.Location = new System.Drawing.Point(438, 491);
            this.viewSelectLabel.Name = "viewSelectLabel";
            this.viewSelectLabel.Size = new System.Drawing.Size(44, 20);
            this.viewSelectLabel.TabIndex = 16;
            this.viewSelectLabel.Text = "View:";
            // 
            // dataGridTableViewSelectUsers
            // 
            this.dataGridTableViewSelectUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTableViewSelectUsers.Location = new System.Drawing.Point(438, 299);
            this.dataGridTableViewSelectUsers.Name = "dataGridTableViewSelectUsers";
            this.dataGridTableViewSelectUsers.RowHeadersWidth = 51;
            this.dataGridTableViewSelectUsers.RowTemplate.Height = 29;
            this.dataGridTableViewSelectUsers.Size = new System.Drawing.Size(334, 177);
            this.dataGridTableViewSelectUsers.TabIndex = 15;
            // 
            // dataGridTableViewsSelect
            // 
            this.dataGridTableViewsSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTableViewsSelect.Location = new System.Drawing.Point(17, 299);
            this.dataGridTableViewsSelect.Name = "dataGridTableViewsSelect";
            this.dataGridTableViewsSelect.RowHeadersWidth = 51;
            this.dataGridTableViewsSelect.RowTemplate.Height = 29;
            this.dataGridTableViewsSelect.Size = new System.Drawing.Size(401, 231);
            this.dataGridTableViewsSelect.TabIndex = 14;
            // 
            // withOptionSelectCheckbox
            // 
            this.withOptionSelectCheckbox.AutoSize = true;
            this.withOptionSelectCheckbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withOptionSelectCheckbox.Location = new System.Drawing.Point(570, 257);
            this.withOptionSelectCheckbox.Name = "withOptionSelectCheckbox";
            this.withOptionSelectCheckbox.Size = new System.Drawing.Size(123, 27);
            this.withOptionSelectCheckbox.TabIndex = 13;
            this.withOptionSelectCheckbox.Text = "With option";
            this.withOptionSelectCheckbox.UseVisualStyleBackColor = true;
            this.withOptionSelectCheckbox.CheckedChanged += new System.EventHandler(this.withOptionSelectCheckbox_CheckedChanged);
            // 
            // grantSelectBtn
            // 
            this.grantSelectBtn.Location = new System.Drawing.Point(438, 252);
            this.grantSelectBtn.Name = "grantSelectBtn";
            this.grantSelectBtn.Size = new System.Drawing.Size(115, 41);
            this.grantSelectBtn.TabIndex = 12;
            this.grantSelectBtn.Text = "Grant";
            this.grantSelectBtn.UseVisualStyleBackColor = true;
            // 
            // viewNameSelectTextBox
            // 
            this.viewNameSelectTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewNameSelectTextBox.Location = new System.Drawing.Point(550, 212);
            this.viewNameSelectTextBox.Name = "viewNameSelectTextBox";
            this.viewNameSelectTextBox.Size = new System.Drawing.Size(222, 30);
            this.viewNameSelectTextBox.TabIndex = 11;
            // 
            // viewNameSelectLabel
            // 
            this.viewNameSelectLabel.AutoSize = true;
            this.viewNameSelectLabel.Location = new System.Drawing.Point(438, 229);
            this.viewNameSelectLabel.Name = "viewNameSelectLabel";
            this.viewNameSelectLabel.Size = new System.Drawing.Size(85, 20);
            this.viewNameSelectLabel.TabIndex = 10;
            this.viewNameSelectLabel.Text = "View name:";
            // 
            // dataGridTableInfoSelect
            // 
            this.dataGridTableInfoSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTableInfoSelect.Location = new System.Drawing.Point(17, 32);
            this.dataGridTableInfoSelect.Name = "dataGridTableInfoSelect";
            this.dataGridTableInfoSelect.RowHeadersWidth = 51;
            this.dataGridTableInfoSelect.RowTemplate.Height = 29;
            this.dataGridTableInfoSelect.Size = new System.Drawing.Size(401, 231);
            this.dataGridTableInfoSelect.TabIndex = 8;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Controls.Add(this.attributeUpdateLabel2);
            this.updateTabPage.Controls.Add(this.columnUpdateLabel2);
            this.updateTabPage.Controls.Add(this.withOptionUpdateCheckbox);
            this.updateTabPage.Controls.Add(this.grantUpdateBtn);
            this.updateTabPage.Controls.Add(this.revokeUpdateBtn);
            this.updateTabPage.Controls.Add(this.attributeUpdateLabel);
            this.updateTabPage.Controls.Add(this.columnUpdateLabel);
            this.updateTabPage.Controls.Add(this.dataGridViewUpdatePrivs);
            this.updateTabPage.Controls.Add(this.dataGridViewUpdateInfo);
            this.updateTabPage.Location = new System.Drawing.Point(4, 29);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateTabPage.Size = new System.Drawing.Size(787, 560);
            this.updateTabPage.TabIndex = 1;
            this.updateTabPage.Text = "Update";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // attributeUpdateLabel2
            // 
            this.attributeUpdateLabel2.AutoSize = true;
            this.attributeUpdateLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attributeUpdateLabel2.Location = new System.Drawing.Point(537, 296);
            this.attributeUpdateLabel2.Name = "attributeUpdateLabel2";
            this.attributeUpdateLabel2.Size = new System.Drawing.Size(22, 23);
            this.attributeUpdateLabel2.TabIndex = 27;
            this.attributeUpdateLabel2.Text = "...";
            // 
            // columnUpdateLabel2
            // 
            this.columnUpdateLabel2.AutoSize = true;
            this.columnUpdateLabel2.Location = new System.Drawing.Point(447, 299);
            this.columnUpdateLabel2.Name = "columnUpdateLabel2";
            this.columnUpdateLabel2.Size = new System.Drawing.Size(63, 20);
            this.columnUpdateLabel2.TabIndex = 26;
            this.columnUpdateLabel2.Text = "Column:";
            // 
            // withOptionUpdateCheckbox
            // 
            this.withOptionUpdateCheckbox.AutoSize = true;
            this.withOptionUpdateCheckbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withOptionUpdateCheckbox.Location = new System.Drawing.Point(600, 85);
            this.withOptionUpdateCheckbox.Name = "withOptionUpdateCheckbox";
            this.withOptionUpdateCheckbox.Size = new System.Drawing.Size(129, 29);
            this.withOptionUpdateCheckbox.TabIndex = 25;
            this.withOptionUpdateCheckbox.Text = "With option";
            this.withOptionUpdateCheckbox.UseVisualStyleBackColor = true;
            this.withOptionUpdateCheckbox.CheckedChanged += new System.EventHandler(this.withOptionUpdateCheckbox_CheckedChanged);
            // 
            // grantUpdateBtn
            // 
            this.grantUpdateBtn.Location = new System.Drawing.Point(447, 79);
            this.grantUpdateBtn.Name = "grantUpdateBtn";
            this.grantUpdateBtn.Size = new System.Drawing.Size(112, 36);
            this.grantUpdateBtn.TabIndex = 24;
            this.grantUpdateBtn.Text = "Grant";
            this.grantUpdateBtn.UseVisualStyleBackColor = true;
            this.grantUpdateBtn.Click += new System.EventHandler(this.grantUpdateBtn_Click);
            // 
            // revokeUpdateBtn
            // 
            this.revokeUpdateBtn.Location = new System.Drawing.Point(453, 345);
            this.revokeUpdateBtn.Name = "revokeUpdateBtn";
            this.revokeUpdateBtn.Size = new System.Drawing.Size(107, 39);
            this.revokeUpdateBtn.TabIndex = 23;
            this.revokeUpdateBtn.Text = "Revoke";
            this.revokeUpdateBtn.UseVisualStyleBackColor = true;
            this.revokeUpdateBtn.Click += new System.EventHandler(this.revokeUpdateBtn_Click);
            // 
            // attributeUpdateLabel
            // 
            this.attributeUpdateLabel.AutoSize = true;
            this.attributeUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attributeUpdateLabel.Location = new System.Drawing.Point(537, 29);
            this.attributeUpdateLabel.Name = "attributeUpdateLabel";
            this.attributeUpdateLabel.Size = new System.Drawing.Size(22, 23);
            this.attributeUpdateLabel.TabIndex = 22;
            this.attributeUpdateLabel.Text = "...";
            // 
            // columnUpdateLabel
            // 
            this.columnUpdateLabel.AutoSize = true;
            this.columnUpdateLabel.Location = new System.Drawing.Point(447, 32);
            this.columnUpdateLabel.Name = "columnUpdateLabel";
            this.columnUpdateLabel.Size = new System.Drawing.Size(63, 20);
            this.columnUpdateLabel.TabIndex = 21;
            this.columnUpdateLabel.Text = "Column:";
            // 
            // dataGridViewUpdatePrivs
            // 
            this.dataGridViewUpdatePrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdatePrivs.Location = new System.Drawing.Point(17, 299);
            this.dataGridViewUpdatePrivs.Name = "dataGridViewUpdatePrivs";
            this.dataGridViewUpdatePrivs.RowHeadersWidth = 51;
            this.dataGridViewUpdatePrivs.RowTemplate.Height = 29;
            this.dataGridViewUpdatePrivs.Size = new System.Drawing.Size(401, 231);
            this.dataGridViewUpdatePrivs.TabIndex = 20;
            this.dataGridViewUpdatePrivs.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUpdatePrivs_CellMouseUp);
            // 
            // dataGridViewUpdateInfo
            // 
            this.dataGridViewUpdateInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateInfo.Location = new System.Drawing.Point(17, 32);
            this.dataGridViewUpdateInfo.Name = "dataGridViewUpdateInfo";
            this.dataGridViewUpdateInfo.RowHeadersWidth = 51;
            this.dataGridViewUpdateInfo.RowTemplate.Height = 29;
            this.dataGridViewUpdateInfo.Size = new System.Drawing.Size(401, 231);
            this.dataGridViewUpdateInfo.TabIndex = 19;
            this.dataGridViewUpdateInfo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUpdateInfo_CellMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table:...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ColumnPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectControlTab);
            this.Name = "ColumnPermission";
            this.Text = "ColumnPermission";
            this.Load += new System.EventHandler(this.ColumnPermission_Load);
            this.selectControlTab.ResumeLayout(false);
            this.selectTabPage.ResumeLayout(false);
            this.selectTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableViewSelectUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableViewsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableInfoSelect)).EndInit();
            this.updateTabPage.ResumeLayout(false);
            this.updateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdatePrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl selectControlTab;
        private TabPage selectTabPage;
        private Button revokeSelectBtn;
        private Label viewSelectResult;
        private Label viewSelectLabel;
        private DataGridView dataGridTableViewSelectUsers;
        private CheckBox withOptionSelectCheckbox;
        private Button grantSelectBtn;
        private TextBox viewNameSelectTextBox;
        private Label viewNameSelectLabel;
        private DataGridView dataGridTableInfoSelect;
        private TabPage updateTabPage;
        private Label attributeUpdateLabel2;
        private Label columnUpdateLabel2;
        private CheckBox withOptionUpdateCheckbox;
        private Button grantUpdateBtn;
        private Button revokeUpdateBtn;
        private Label attributeUpdateLabel;
        private Label columnUpdateLabel;
        private DataGridView dataGridViewUpdatePrivs;
        private DataGridView dataGridViewUpdateInfo;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Colunb;
        private Button button1;
        private DataGridView dataGridTableViewsSelect;
        private ContextMenuStrip contextMenuStrip1;
    }
}
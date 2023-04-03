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
            components = new System.ComponentModel.Container();
            selectControlTab = new TabControl();
            selectTabPage = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Colunb = new DataGridViewTextBoxColumn();
            revokeSelectBtn = new Button();
            viewSelectResult = new Label();
            viewSelectLabel = new Label();
            dataGridTableViewSelectUsers = new DataGridView();
            dataGridTableViewsSelect = new DataGridView();
            withOptionSelectCheckbox = new CheckBox();
            grantSelectBtn = new Button();
            viewNameSelectTextBox = new TextBox();
            viewNameSelectLabel = new Label();
            dataGridTableInfoSelect = new DataGridView();
            updateTabPage = new TabPage();
            attributeUpdateLabel2 = new Label();
            columnUpdateLabel2 = new Label();
            withOptionUpdateCheckbox = new CheckBox();
            grantUpdateBtn = new Button();
            revokeUpdateBtn = new Button();
            attributeUpdateLabel = new Label();
            columnUpdateLabel = new Label();
            dataGridViewUpdatePrivs = new DataGridView();
            dataGridViewUpdateInfo = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            selectControlTab.SuspendLayout();
            selectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewSelectUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewsSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableInfoSelect).BeginInit();
            updateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdatePrivs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdateInfo).BeginInit();
            SuspendLayout();
            // 
            // selectControlTab
            // 
            selectControlTab.Controls.Add(selectTabPage);
            selectControlTab.Controls.Add(updateTabPage);
            selectControlTab.Location = new Point(12, 58);
            selectControlTab.Margin = new Padding(3, 2, 3, 2);
            selectControlTab.Name = "selectControlTab";
            selectControlTab.SelectedIndex = 0;
            selectControlTab.Size = new Size(696, 445);
            selectControlTab.TabIndex = 0;
            // 
            // selectTabPage
            // 
            selectTabPage.Controls.Add(button1);
            selectTabPage.Controls.Add(dataGridView1);
            selectTabPage.Controls.Add(revokeSelectBtn);
            selectTabPage.Controls.Add(viewSelectResult);
            selectTabPage.Controls.Add(viewSelectLabel);
            selectTabPage.Controls.Add(dataGridTableViewSelectUsers);
            selectTabPage.Controls.Add(dataGridTableViewsSelect);
            selectTabPage.Controls.Add(withOptionSelectCheckbox);
            selectTabPage.Controls.Add(grantSelectBtn);
            selectTabPage.Controls.Add(viewNameSelectTextBox);
            selectTabPage.Controls.Add(viewNameSelectLabel);
            selectTabPage.Controls.Add(dataGridTableInfoSelect);
            selectTabPage.Location = new Point(4, 24);
            selectTabPage.Margin = new Padding(3, 2, 3, 2);
            selectTabPage.Name = "selectTabPage";
            selectTabPage.Padding = new Padding(3, 2, 3, 2);
            selectTabPage.Size = new Size(688, 417);
            selectTabPage.TabIndex = 0;
            selectTabPage.Text = "Select";
            selectTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Location = new Point(626, 132);
            button1.Name = "button1";
            button1.Size = new Size(56, 23);
            button1.TabIndex = 20;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Colunb });
            dataGridView1.Location = new Point(393, 24);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(289, 131);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Colunb
            // 
            Colunb.HeaderText = "Column";
            Colunb.Name = "Colunb";
            Colunb.ReadOnly = true;
            Colunb.Visible = false;
            // 
            // revokeSelectBtn
            // 
            revokeSelectBtn.Location = new Point(582, 368);
            revokeSelectBtn.Margin = new Padding(3, 2, 3, 2);
            revokeSelectBtn.Name = "revokeSelectBtn";
            revokeSelectBtn.Size = new Size(94, 29);
            revokeSelectBtn.TabIndex = 18;
            revokeSelectBtn.Text = "Revoke";
            revokeSelectBtn.UseVisualStyleBackColor = true;
            revokeSelectBtn.Click += revokeSelectBtn_Click;
            // 
            // viewSelectResult
            // 
            viewSelectResult.AutoSize = true;
            viewSelectResult.Location = new Point(440, 368);
            viewSelectResult.Name = "viewSelectResult";
            viewSelectResult.Size = new Size(16, 15);
            viewSelectResult.TabIndex = 17;
            viewSelectResult.Text = "...";
            // 
            // viewSelectLabel
            // 
            viewSelectLabel.AutoSize = true;
            viewSelectLabel.Location = new Point(383, 368);
            viewSelectLabel.Name = "viewSelectLabel";
            viewSelectLabel.Size = new Size(35, 15);
            viewSelectLabel.TabIndex = 16;
            viewSelectLabel.Text = "View:";
            // 
            // dataGridTableViewSelectUsers
            // 
            dataGridTableViewSelectUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTableViewSelectUsers.Location = new Point(383, 224);
            dataGridTableViewSelectUsers.Margin = new Padding(3, 2, 3, 2);
            dataGridTableViewSelectUsers.Name = "dataGridTableViewSelectUsers";
            dataGridTableViewSelectUsers.RowHeadersWidth = 51;
            dataGridTableViewSelectUsers.RowTemplate.Height = 29;
            dataGridTableViewSelectUsers.Size = new Size(292, 133);
            dataGridTableViewSelectUsers.TabIndex = 15;
            // 
            // dataGridTableViewsSelect
            // 
            dataGridTableViewsSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTableViewsSelect.Location = new Point(15, 224);
            dataGridTableViewsSelect.Margin = new Padding(3, 2, 3, 2);
            dataGridTableViewsSelect.Name = "dataGridTableViewsSelect";
            dataGridTableViewsSelect.RowHeadersWidth = 51;
            dataGridTableViewsSelect.RowTemplate.Height = 29;
            dataGridTableViewsSelect.Size = new Size(351, 173);
            dataGridTableViewsSelect.TabIndex = 14;
            dataGridTableViewsSelect.CellClick += dataGridTableViewsSelect_CellContentClick;
            // 
            // withOptionSelectCheckbox
            // 
            withOptionSelectCheckbox.AutoSize = true;
            withOptionSelectCheckbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            withOptionSelectCheckbox.Location = new Point(499, 193);
            withOptionSelectCheckbox.Margin = new Padding(3, 2, 3, 2);
            withOptionSelectCheckbox.Name = "withOptionSelectCheckbox";
            withOptionSelectCheckbox.Size = new Size(101, 23);
            withOptionSelectCheckbox.TabIndex = 13;
            withOptionSelectCheckbox.Text = "With option";
            withOptionSelectCheckbox.UseVisualStyleBackColor = true;
            // 
            // grantSelectBtn
            // 
            grantSelectBtn.Location = new Point(383, 189);
            grantSelectBtn.Margin = new Padding(3, 2, 3, 2);
            grantSelectBtn.Name = "grantSelectBtn";
            grantSelectBtn.Size = new Size(101, 31);
            grantSelectBtn.TabIndex = 12;
            grantSelectBtn.Text = "Grant";
            grantSelectBtn.UseVisualStyleBackColor = true;
            grantSelectBtn.Click += grantSelectBtn_Click;
            // 
            // viewNameSelectTextBox
            // 
            viewNameSelectTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            viewNameSelectTextBox.Location = new Point(481, 159);
            viewNameSelectTextBox.Margin = new Padding(3, 2, 3, 2);
            viewNameSelectTextBox.Name = "viewNameSelectTextBox";
            viewNameSelectTextBox.Size = new Size(195, 26);
            viewNameSelectTextBox.TabIndex = 11;
            // 
            // viewNameSelectLabel
            // 
            viewNameSelectLabel.AutoSize = true;
            viewNameSelectLabel.Location = new Point(383, 172);
            viewNameSelectLabel.Name = "viewNameSelectLabel";
            viewNameSelectLabel.Size = new Size(68, 15);
            viewNameSelectLabel.TabIndex = 10;
            viewNameSelectLabel.Text = "View name:";
            // 
            // dataGridTableInfoSelect
            // 
            dataGridTableInfoSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTableInfoSelect.Location = new Point(15, 24);
            dataGridTableInfoSelect.Margin = new Padding(3, 2, 3, 2);
            dataGridTableInfoSelect.Name = "dataGridTableInfoSelect";
            dataGridTableInfoSelect.RowHeadersWidth = 51;
            dataGridTableInfoSelect.RowTemplate.Height = 29;
            dataGridTableInfoSelect.Size = new Size(351, 173);
            dataGridTableInfoSelect.TabIndex = 8;
            dataGridTableInfoSelect.CellClick += dataGridTableInfoSelect_CellContentClick;
            // 
            // updateTabPage
            // 
            updateTabPage.Controls.Add(attributeUpdateLabel2);
            updateTabPage.Controls.Add(columnUpdateLabel2);
            updateTabPage.Controls.Add(withOptionUpdateCheckbox);
            updateTabPage.Controls.Add(grantUpdateBtn);
            updateTabPage.Controls.Add(revokeUpdateBtn);
            updateTabPage.Controls.Add(attributeUpdateLabel);
            updateTabPage.Controls.Add(columnUpdateLabel);
            updateTabPage.Controls.Add(dataGridViewUpdatePrivs);
            updateTabPage.Controls.Add(dataGridViewUpdateInfo);
            updateTabPage.Location = new Point(4, 24);
            updateTabPage.Margin = new Padding(3, 2, 3, 2);
            updateTabPage.Name = "updateTabPage";
            updateTabPage.Padding = new Padding(3, 2, 3, 2);
            updateTabPage.Size = new Size(688, 417);
            updateTabPage.TabIndex = 1;
            updateTabPage.Text = "Update";
            updateTabPage.UseVisualStyleBackColor = true;
            // 
            // attributeUpdateLabel2
            // 
            attributeUpdateLabel2.AutoSize = true;
            attributeUpdateLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            attributeUpdateLabel2.Location = new Point(470, 222);
            attributeUpdateLabel2.Name = "attributeUpdateLabel2";
            attributeUpdateLabel2.Size = new Size(18, 19);
            attributeUpdateLabel2.TabIndex = 27;
            attributeUpdateLabel2.Text = "...";
            // 
            // columnUpdateLabel2
            // 
            columnUpdateLabel2.AutoSize = true;
            columnUpdateLabel2.Location = new Point(391, 224);
            columnUpdateLabel2.Name = "columnUpdateLabel2";
            columnUpdateLabel2.Size = new Size(53, 15);
            columnUpdateLabel2.TabIndex = 26;
            columnUpdateLabel2.Text = "Column:";
            // 
            // withOptionUpdateCheckbox
            // 
            withOptionUpdateCheckbox.AutoSize = true;
            withOptionUpdateCheckbox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            withOptionUpdateCheckbox.Location = new Point(525, 64);
            withOptionUpdateCheckbox.Margin = new Padding(3, 2, 3, 2);
            withOptionUpdateCheckbox.Name = "withOptionUpdateCheckbox";
            withOptionUpdateCheckbox.Size = new Size(107, 24);
            withOptionUpdateCheckbox.TabIndex = 25;
            withOptionUpdateCheckbox.Text = "With option";
            withOptionUpdateCheckbox.UseVisualStyleBackColor = true;
            // 
            // grantUpdateBtn
            // 
            grantUpdateBtn.Location = new Point(391, 59);
            grantUpdateBtn.Margin = new Padding(3, 2, 3, 2);
            grantUpdateBtn.Name = "grantUpdateBtn";
            grantUpdateBtn.Size = new Size(98, 27);
            grantUpdateBtn.TabIndex = 24;
            grantUpdateBtn.Text = "Grant";
            grantUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // revokeUpdateBtn
            // 
            revokeUpdateBtn.Location = new Point(396, 259);
            revokeUpdateBtn.Margin = new Padding(3, 2, 3, 2);
            revokeUpdateBtn.Name = "revokeUpdateBtn";
            revokeUpdateBtn.Size = new Size(94, 29);
            revokeUpdateBtn.TabIndex = 23;
            revokeUpdateBtn.Text = "Revoke";
            revokeUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // attributeUpdateLabel
            // 
            attributeUpdateLabel.AutoSize = true;
            attributeUpdateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            attributeUpdateLabel.Location = new Point(470, 22);
            attributeUpdateLabel.Name = "attributeUpdateLabel";
            attributeUpdateLabel.Size = new Size(18, 19);
            attributeUpdateLabel.TabIndex = 22;
            attributeUpdateLabel.Text = "...";
            // 
            // columnUpdateLabel
            // 
            columnUpdateLabel.AutoSize = true;
            columnUpdateLabel.Location = new Point(391, 24);
            columnUpdateLabel.Name = "columnUpdateLabel";
            columnUpdateLabel.Size = new Size(53, 15);
            columnUpdateLabel.TabIndex = 21;
            columnUpdateLabel.Text = "Column:";
            // 
            // dataGridViewUpdatePrivs
            // 
            dataGridViewUpdatePrivs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdatePrivs.Location = new Point(15, 224);
            dataGridViewUpdatePrivs.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUpdatePrivs.Name = "dataGridViewUpdatePrivs";
            dataGridViewUpdatePrivs.RowHeadersWidth = 51;
            dataGridViewUpdatePrivs.RowTemplate.Height = 29;
            dataGridViewUpdatePrivs.Size = new Size(351, 173);
            dataGridViewUpdatePrivs.TabIndex = 20;
            // 
            // dataGridViewUpdateInfo
            // 
            dataGridViewUpdateInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdateInfo.Location = new Point(15, 24);
            dataGridViewUpdateInfo.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUpdateInfo.Name = "dataGridViewUpdateInfo";
            dataGridViewUpdateInfo.RowHeadersWidth = 51;
            dataGridViewUpdateInfo.RowTemplate.Height = 29;
            dataGridViewUpdateInfo.Size = new Size(351, 173);
            dataGridViewUpdateInfo.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Table:...";
            label1.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ColumnPermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 527);
            Controls.Add(label1);
            Controls.Add(selectControlTab);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ColumnPermission";
            Text = "ColumnPermission";
            Load += ColumnPermission_Load;
            selectControlTab.ResumeLayout(false);
            selectTabPage.ResumeLayout(false);
            selectTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewSelectUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewsSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableInfoSelect).EndInit();
            updateTabPage.ResumeLayout(false);
            updateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdatePrivs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdateInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
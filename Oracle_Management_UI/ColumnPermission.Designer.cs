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
            selectControlTab = new TabControl();
            selectTabPage = new TabPage();
            updateTabPage = new TabPage();
            dataGridTableViewSelectUsers = new DataGridView();
            dataGridTableViewsSelect = new DataGridView();
            withOptionSelectCheckbox = new CheckBox();
            grantSelectBtn = new Button();
            viewNameSelectTextBox = new TextBox();
            viewNameSelectLabel = new Label();
            richTextBoxViewSelect = new RichTextBox();
            dataGridTableInfoSelect = new DataGridView();
            viewSelectLabel = new Label();
            viewSelectResult = new Label();
            revokeSelectBtn = new Button();
            revokeUpdateBtn = new Button();
            attributeUpdateLabel = new Label();
            columnUpdateLabel = new Label();
            dataGridViewUpdatePrivs = new DataGridView();
            dataGridViewUpdateInfo = new DataGridView();
            grantUpdateBtn = new Button();
            withOptionUpdateCheckbox = new CheckBox();
            attributeUpdateLabel2 = new Label();
            columnUpdateLabel2 = new Label();
            selectControlTab.SuspendLayout();
            selectTabPage.SuspendLayout();
            updateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewSelectUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewsSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableInfoSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdatePrivs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdateInfo).BeginInit();
            SuspendLayout();
            // 
            // selectControlTab
            // 
            selectControlTab.Controls.Add(selectTabPage);
            selectControlTab.Controls.Add(updateTabPage);
            selectControlTab.Location = new Point(22, 24);
            selectControlTab.Name = "selectControlTab";
            selectControlTab.SelectedIndex = 0;
            selectControlTab.Size = new Size(796, 593);
            selectControlTab.TabIndex = 0;
            // 
            // selectTabPage
            // 
            selectTabPage.Controls.Add(revokeSelectBtn);
            selectTabPage.Controls.Add(viewSelectResult);
            selectTabPage.Controls.Add(viewSelectLabel);
            selectTabPage.Controls.Add(dataGridTableViewSelectUsers);
            selectTabPage.Controls.Add(dataGridTableViewsSelect);
            selectTabPage.Controls.Add(withOptionSelectCheckbox);
            selectTabPage.Controls.Add(grantSelectBtn);
            selectTabPage.Controls.Add(viewNameSelectTextBox);
            selectTabPage.Controls.Add(viewNameSelectLabel);
            selectTabPage.Controls.Add(richTextBoxViewSelect);
            selectTabPage.Controls.Add(dataGridTableInfoSelect);
            selectTabPage.Location = new Point(4, 29);
            selectTabPage.Name = "selectTabPage";
            selectTabPage.Padding = new Padding(3);
            selectTabPage.Size = new Size(788, 560);
            selectTabPage.TabIndex = 0;
            selectTabPage.Text = "Select";
            selectTabPage.UseVisualStyleBackColor = true;
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
            updateTabPage.Location = new Point(4, 29);
            updateTabPage.Name = "updateTabPage";
            updateTabPage.Padding = new Padding(3);
            updateTabPage.Size = new Size(788, 560);
            updateTabPage.TabIndex = 1;
            updateTabPage.Text = "Update";
            updateTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridTableViewSelectUsers
            // 
            dataGridTableViewSelectUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTableViewSelectUsers.Location = new Point(438, 298);
            dataGridTableViewSelectUsers.Name = "dataGridTableViewSelectUsers";
            dataGridTableViewSelectUsers.RowHeadersWidth = 51;
            dataGridTableViewSelectUsers.RowTemplate.Height = 29;
            dataGridTableViewSelectUsers.Size = new Size(334, 177);
            dataGridTableViewSelectUsers.TabIndex = 15;
            // 
            // dataGridTableViewsSelect
            // 
            dataGridTableViewsSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTableViewsSelect.Location = new Point(17, 298);
            dataGridTableViewsSelect.Name = "dataGridTableViewsSelect";
            dataGridTableViewsSelect.RowHeadersWidth = 51;
            dataGridTableViewsSelect.RowTemplate.Height = 29;
            dataGridTableViewsSelect.Size = new Size(401, 231);
            dataGridTableViewsSelect.TabIndex = 14;
            // 
            // withOptionSelectCheckbox
            // 
            withOptionSelectCheckbox.AutoSize = true;
            withOptionSelectCheckbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            withOptionSelectCheckbox.Location = new Point(590, 229);
            withOptionSelectCheckbox.Name = "withOptionSelectCheckbox";
            withOptionSelectCheckbox.Size = new Size(123, 27);
            withOptionSelectCheckbox.TabIndex = 13;
            withOptionSelectCheckbox.Text = "With option";
            withOptionSelectCheckbox.UseVisualStyleBackColor = true;
            // 
            // grantSelectBtn
            // 
            grantSelectBtn.Location = new Point(438, 222);
            grantSelectBtn.Name = "grantSelectBtn";
            grantSelectBtn.Size = new Size(115, 41);
            grantSelectBtn.TabIndex = 12;
            grantSelectBtn.Text = "Grant";
            grantSelectBtn.UseVisualStyleBackColor = true;
            // 
            // viewNameSelectTextBox
            // 
            viewNameSelectTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            viewNameSelectTextBox.Location = new Point(541, 145);
            viewNameSelectTextBox.Name = "viewNameSelectTextBox";
            viewNameSelectTextBox.Size = new Size(231, 30);
            viewNameSelectTextBox.TabIndex = 11;
            // 
            // viewNameSelectLabel
            // 
            viewNameSelectLabel.AutoSize = true;
            viewNameSelectLabel.Location = new Point(438, 150);
            viewNameSelectLabel.Name = "viewNameSelectLabel";
            viewNameSelectLabel.Size = new Size(85, 20);
            viewNameSelectLabel.TabIndex = 10;
            viewNameSelectLabel.Text = "View name:";
            // 
            // richTextBoxViewSelect
            // 
            richTextBoxViewSelect.Location = new Point(438, 32);
            richTextBoxViewSelect.Name = "richTextBoxViewSelect";
            richTextBoxViewSelect.Size = new Size(334, 90);
            richTextBoxViewSelect.TabIndex = 9;
            richTextBoxViewSelect.Text = "";
            // 
            // dataGridTableInfoSelect
            // 
            dataGridTableInfoSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTableInfoSelect.Location = new Point(17, 32);
            dataGridTableInfoSelect.Name = "dataGridTableInfoSelect";
            dataGridTableInfoSelect.RowHeadersWidth = 51;
            dataGridTableInfoSelect.RowTemplate.Height = 29;
            dataGridTableInfoSelect.Size = new Size(401, 231);
            dataGridTableInfoSelect.TabIndex = 8;
            // 
            // viewSelectLabel
            // 
            viewSelectLabel.AutoSize = true;
            viewSelectLabel.Location = new Point(438, 490);
            viewSelectLabel.Name = "viewSelectLabel";
            viewSelectLabel.Size = new Size(44, 20);
            viewSelectLabel.TabIndex = 16;
            viewSelectLabel.Text = "View:";
            // 
            // viewSelectResult
            // 
            viewSelectResult.AutoSize = true;
            viewSelectResult.Location = new Point(503, 490);
            viewSelectResult.Name = "viewSelectResult";
            viewSelectResult.Size = new Size(18, 20);
            viewSelectResult.TabIndex = 17;
            viewSelectResult.Text = "...";
            // 
            // revokeSelectBtn
            // 
            revokeSelectBtn.Location = new Point(665, 490);
            revokeSelectBtn.Name = "revokeSelectBtn";
            revokeSelectBtn.Size = new Size(107, 39);
            revokeSelectBtn.TabIndex = 18;
            revokeSelectBtn.Text = "Revoke";
            revokeSelectBtn.UseVisualStyleBackColor = true;
            // 
            // revokeUpdateBtn
            // 
            revokeUpdateBtn.Location = new Point(452, 345);
            revokeUpdateBtn.Name = "revokeUpdateBtn";
            revokeUpdateBtn.Size = new Size(107, 39);
            revokeUpdateBtn.TabIndex = 23;
            revokeUpdateBtn.Text = "Revoke";
            revokeUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // attributeUpdateLabel
            // 
            attributeUpdateLabel.AutoSize = true;
            attributeUpdateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            attributeUpdateLabel.Location = new Point(537, 30);
            attributeUpdateLabel.Name = "attributeUpdateLabel";
            attributeUpdateLabel.Size = new Size(22, 23);
            attributeUpdateLabel.TabIndex = 22;
            attributeUpdateLabel.Text = "...";
            // 
            // columnUpdateLabel
            // 
            columnUpdateLabel.AutoSize = true;
            columnUpdateLabel.Location = new Point(447, 32);
            columnUpdateLabel.Name = "columnUpdateLabel";
            columnUpdateLabel.Size = new Size(63, 20);
            columnUpdateLabel.TabIndex = 21;
            columnUpdateLabel.Text = "Column:";
            // 
            // dataGridViewUpdatePrivs
            // 
            dataGridViewUpdatePrivs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdatePrivs.Location = new Point(17, 298);
            dataGridViewUpdatePrivs.Name = "dataGridViewUpdatePrivs";
            dataGridViewUpdatePrivs.RowHeadersWidth = 51;
            dataGridViewUpdatePrivs.RowTemplate.Height = 29;
            dataGridViewUpdatePrivs.Size = new Size(401, 231);
            dataGridViewUpdatePrivs.TabIndex = 20;
            // 
            // dataGridViewUpdateInfo
            // 
            dataGridViewUpdateInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdateInfo.Location = new Point(17, 32);
            dataGridViewUpdateInfo.Name = "dataGridViewUpdateInfo";
            dataGridViewUpdateInfo.RowHeadersWidth = 51;
            dataGridViewUpdateInfo.RowTemplate.Height = 29;
            dataGridViewUpdateInfo.Size = new Size(401, 231);
            dataGridViewUpdateInfo.TabIndex = 19;
            // 
            // grantUpdateBtn
            // 
            grantUpdateBtn.Location = new Point(447, 79);
            grantUpdateBtn.Name = "grantUpdateBtn";
            grantUpdateBtn.Size = new Size(112, 36);
            grantUpdateBtn.TabIndex = 24;
            grantUpdateBtn.Text = "Grant";
            grantUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // withOptionUpdateCheckbox
            // 
            withOptionUpdateCheckbox.AutoSize = true;
            withOptionUpdateCheckbox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            withOptionUpdateCheckbox.Location = new Point(600, 86);
            withOptionUpdateCheckbox.Name = "withOptionUpdateCheckbox";
            withOptionUpdateCheckbox.Size = new Size(129, 29);
            withOptionUpdateCheckbox.TabIndex = 25;
            withOptionUpdateCheckbox.Text = "With option";
            withOptionUpdateCheckbox.UseVisualStyleBackColor = true;
            // 
            // attributeUpdateLabel2
            // 
            attributeUpdateLabel2.AutoSize = true;
            attributeUpdateLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            attributeUpdateLabel2.Location = new Point(537, 296);
            attributeUpdateLabel2.Name = "attributeUpdateLabel2";
            attributeUpdateLabel2.Size = new Size(22, 23);
            attributeUpdateLabel2.TabIndex = 27;
            attributeUpdateLabel2.Text = "...";
            // 
            // columnUpdateLabel2
            // 
            columnUpdateLabel2.AutoSize = true;
            columnUpdateLabel2.Location = new Point(447, 298);
            columnUpdateLabel2.Name = "columnUpdateLabel2";
            columnUpdateLabel2.Size = new Size(63, 20);
            columnUpdateLabel2.TabIndex = 26;
            columnUpdateLabel2.Text = "Column:";
            // 
            // ColumnPermission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 646);
            Controls.Add(selectControlTab);
            Name = "ColumnPermission";
            Text = "ColumnPermission";
            selectControlTab.ResumeLayout(false);
            selectTabPage.ResumeLayout(false);
            selectTabPage.PerformLayout();
            updateTabPage.ResumeLayout(false);
            updateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewSelectUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableViewsSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTableInfoSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdatePrivs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdateInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl selectControlTab;
        private TabPage selectTabPage;
        private Button revokeSelectBtn;
        private Label viewSelectResult;
        private Label viewSelectLabel;
        private DataGridView dataGridTableViewSelectUsers;
        private DataGridView dataGridTableViewsSelect;
        private CheckBox withOptionSelectCheckbox;
        private Button grantSelectBtn;
        private TextBox viewNameSelectTextBox;
        private Label viewNameSelectLabel;
        private RichTextBox richTextBoxViewSelect;
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
    }
}
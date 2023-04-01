namespace Oracle_Management_UI
{
    partial class ManageRole
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
            RoleLabel = new Label();
            createRoleBtn = new Button();
            editRoleBtn = new Button();
            deleteRoleBtn = new Button();
            refreshRoleBtn = new Button();
            manageRoleTab = new TabPage();
            userGroupBox = new GroupBox();
            refreshUserBtn = new Button();
            manageUsersLabel = new Label();
            DataGridViewUsers = new DataGridView();
            editUserBtn = new Button();
            deleteUserBtn = new Button();
            createUserBtn = new Button();
            rolesGroupBox = new GroupBox();
            manageRolesLabel = new Label();
            DataGridViewRoles = new DataGridView();
            tabManageRole = new TabControl();
            manageRoleTab.SuspendLayout();
            userGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).BeginInit();
            rolesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRoles).BeginInit();
            tabManageRole.SuspendLayout();
            SuspendLayout();
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(10, -22);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(168, 15);
            RoleLabel.TabIndex = 2;
            RoleLabel.Text = "Danh sách role trong hệ thống";
            // 
            // createRoleBtn
            // 
            createRoleBtn.Location = new Point(335, 69);
            createRoleBtn.Margin = new Padding(3, 2, 3, 2);
            createRoleBtn.Name = "createRoleBtn";
            createRoleBtn.Size = new Size(136, 39);
            createRoleBtn.TabIndex = 5;
            createRoleBtn.Text = "Tạo role";
            createRoleBtn.UseVisualStyleBackColor = true;
            // 
            // editRoleBtn
            // 
            editRoleBtn.Location = new Point(335, 202);
            editRoleBtn.Margin = new Padding(3, 2, 3, 2);
            editRoleBtn.Name = "editRoleBtn";
            editRoleBtn.Size = new Size(136, 39);
            editRoleBtn.TabIndex = 6;
            editRoleBtn.Text = "Chỉnh sửa role";
            editRoleBtn.UseVisualStyleBackColor = true;
            // 
            // deleteRoleBtn
            // 
            deleteRoleBtn.Location = new Point(335, 130);
            deleteRoleBtn.Margin = new Padding(3, 2, 3, 2);
            deleteRoleBtn.Name = "deleteRoleBtn";
            deleteRoleBtn.Size = new Size(136, 39);
            deleteRoleBtn.TabIndex = 7;
            deleteRoleBtn.Text = "Xóa role";
            deleteRoleBtn.UseVisualStyleBackColor = true;
            // 
            // refreshRoleBtn
            // 
            refreshRoleBtn.Location = new Point(335, 274);
            refreshRoleBtn.Margin = new Padding(3, 2, 3, 2);
            refreshRoleBtn.Name = "refreshRoleBtn";
            refreshRoleBtn.Size = new Size(136, 39);
            refreshRoleBtn.TabIndex = 8;
            refreshRoleBtn.Text = "Refresh";
            refreshRoleBtn.UseVisualStyleBackColor = true;
            // 
            // manageRoleTab
            // 
            manageRoleTab.Controls.Add(userGroupBox);
            manageRoleTab.Controls.Add(rolesGroupBox);
            manageRoleTab.ForeColor = SystemColors.ControlText;
            manageRoleTab.Location = new Point(4, 24);
            manageRoleTab.Margin = new Padding(3, 2, 3, 2);
            manageRoleTab.Name = "manageRoleTab";
            manageRoleTab.Padding = new Padding(3, 2, 3, 2);
            manageRoleTab.Size = new Size(1005, 473);
            manageRoleTab.TabIndex = 0;
            manageRoleTab.Text = "Quản lý roles";
            manageRoleTab.UseVisualStyleBackColor = true;
            // 
            // userGroupBox
            // 
            userGroupBox.Controls.Add(refreshUserBtn);
            userGroupBox.Controls.Add(manageUsersLabel);
            userGroupBox.Controls.Add(DataGridViewUsers);
            userGroupBox.Controls.Add(editUserBtn);
            userGroupBox.Controls.Add(deleteUserBtn);
            userGroupBox.Controls.Add(createUserBtn);
            userGroupBox.Location = new Point(21, 4);
            userGroupBox.Margin = new Padding(3, 2, 3, 2);
            userGroupBox.Name = "userGroupBox";
            userGroupBox.Padding = new Padding(3, 2, 3, 2);
            userGroupBox.Size = new Size(476, 460);
            userGroupBox.TabIndex = 10;
            userGroupBox.TabStop = false;
            // 
            // refreshUserBtn
            // 
            refreshUserBtn.Location = new Point(322, 274);
            refreshUserBtn.Margin = new Padding(3, 2, 3, 2);
            refreshUserBtn.Name = "refreshUserBtn";
            refreshUserBtn.Size = new Size(136, 39);
            refreshUserBtn.TabIndex = 8;
            refreshUserBtn.Text = "Refresh";
            refreshUserBtn.UseVisualStyleBackColor = true;
            // 
            // manageUsersLabel
            // 
            manageUsersLabel.AutoSize = true;
            manageUsersLabel.Location = new Point(17, 20);
            manageUsersLabel.Name = "manageUsersLabel";
            manageUsersLabel.Size = new Size(196, 15);
            manageUsersLabel.TabIndex = 4;
            manageUsersLabel.Text = "Danh sách các users trong hệ thống";
            // 
            // DataGridViewUsers
            // 
            DataGridViewUsers.AllowUserToOrderColumns = true;
            DataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsers.Location = new Point(17, 52);
            DataGridViewUsers.Margin = new Padding(3, 2, 3, 2);
            DataGridViewUsers.Name = "DataGridViewUsers";
            DataGridViewUsers.RowHeadersWidth = 51;
            DataGridViewUsers.RowTemplate.Height = 29;
            DataGridViewUsers.Size = new Size(284, 395);
            DataGridViewUsers.TabIndex = 3;
            DataGridViewUsers.CellContentClick += DataGridViewUsers_CellContentClick;
            // 
            // editUserBtn
            // 
            editUserBtn.Location = new Point(322, 202);
            editUserBtn.Margin = new Padding(3, 2, 3, 2);
            editUserBtn.Name = "editUserBtn";
            editUserBtn.Size = new Size(136, 39);
            editUserBtn.TabIndex = 6;
            editUserBtn.Text = "Chỉnh sửa user";
            editUserBtn.UseVisualStyleBackColor = true;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.Location = new Point(322, 130);
            deleteUserBtn.Margin = new Padding(3, 2, 3, 2);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(136, 39);
            deleteUserBtn.TabIndex = 7;
            deleteUserBtn.Text = "Xóa user";
            deleteUserBtn.UseVisualStyleBackColor = true;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // createUserBtn
            // 
            createUserBtn.Location = new Point(322, 69);
            createUserBtn.Margin = new Padding(3, 2, 3, 2);
            createUserBtn.Name = "createUserBtn";
            createUserBtn.Size = new Size(136, 39);
            createUserBtn.TabIndex = 5;
            createUserBtn.Text = "Tạo user";
            createUserBtn.UseVisualStyleBackColor = true;
            createUserBtn.Click += createUserBtn_Click;
            // 
            // rolesGroupBox
            // 
            rolesGroupBox.Controls.Add(refreshRoleBtn);
            rolesGroupBox.Controls.Add(manageRolesLabel);
            rolesGroupBox.Controls.Add(DataGridViewRoles);
            rolesGroupBox.Controls.Add(editRoleBtn);
            rolesGroupBox.Controls.Add(deleteRoleBtn);
            rolesGroupBox.Controls.Add(createRoleBtn);
            rolesGroupBox.Location = new Point(518, 4);
            rolesGroupBox.Margin = new Padding(3, 2, 3, 2);
            rolesGroupBox.Name = "rolesGroupBox";
            rolesGroupBox.Padding = new Padding(3, 2, 3, 2);
            rolesGroupBox.Size = new Size(476, 460);
            rolesGroupBox.TabIndex = 9;
            rolesGroupBox.TabStop = false;
            // 
            // manageRolesLabel
            // 
            manageRolesLabel.AutoSize = true;
            manageRolesLabel.Location = new Point(15, 28);
            manageRolesLabel.Name = "manageRolesLabel";
            manageRolesLabel.Size = new Size(189, 15);
            manageRolesLabel.TabIndex = 4;
            manageRolesLabel.Text = "Danh sách các role trong hệ thống";
            // 
            // DataGridViewRoles
            // 
            DataGridViewRoles.AllowUserToOrderColumns = true;
            DataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRoles.Location = new Point(15, 52);
            DataGridViewRoles.Margin = new Padding(3, 2, 3, 2);
            DataGridViewRoles.Name = "DataGridViewRoles";
            DataGridViewRoles.RowHeadersWidth = 51;
            DataGridViewRoles.RowTemplate.Height = 29;
            DataGridViewRoles.Size = new Size(304, 395);
            DataGridViewRoles.TabIndex = 3;
            // 
            // tabManageRole
            // 
            tabManageRole.Controls.Add(manageRoleTab);
            tabManageRole.Location = new Point(10, 9);
            tabManageRole.Margin = new Padding(3, 2, 3, 2);
            tabManageRole.Name = "tabManageRole";
            tabManageRole.SelectedIndex = 0;
            tabManageRole.Size = new Size(1013, 501);
            tabManageRole.TabIndex = 9;
            // 
            // ManageRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 519);
            Controls.Add(tabManageRole);
            Controls.Add(RoleLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageRole";
            Text = "Manage Role";
            Load += ManageRole_Load;
            manageRoleTab.ResumeLayout(false);
            userGroupBox.ResumeLayout(false);
            userGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).EndInit();
            rolesGroupBox.ResumeLayout(false);
            rolesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRoles).EndInit();
            tabManageRole.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RoleLabel;
        private Label manageRoleLabel;
        private Button createRoleBtn;
        private Button editRoleBtn;
        private Button deleteRoleBtn;
        private Button refreshRoleBtn;
        private TabPage tabPage2;
        private DataGridView dataGridManageRole;
        private TabPage manageRoleTab;
        private DataGridView DataGridViewRoles;
        private TabControl tabManageRole;
        private Label manageRolesLabel;
        private GroupBox userGroupBox;
        private Button refreshUserBtn;
        private Label manageUsersLabel;
        private DataGridView DataGridViewUsers;
        private Button editUserBtn;
        private Button deleteUserBtn;
        private Button createUserBtn;
        private GroupBox rolesGroupBox;
    }
}
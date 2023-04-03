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
            disconnect_Btn = new Button();
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
            RoleLabel.Location = new Point(11, -29);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(210, 20);
            RoleLabel.TabIndex = 2;
            RoleLabel.Text = "Danh sách role trong hệ thống";
            // 
            // createRoleBtn
            // 
            createRoleBtn.Location = new Point(444, 69);
            createRoleBtn.Name = "createRoleBtn";
            createRoleBtn.Size = new Size(155, 52);
            createRoleBtn.TabIndex = 5;
            createRoleBtn.Text = "Tạo role";
            createRoleBtn.UseVisualStyleBackColor = true;
            createRoleBtn.Click += createRoleBtn_Click;
            // 
            // editRoleBtn
            // 
            editRoleBtn.Location = new Point(444, 257);
            editRoleBtn.Name = "editRoleBtn";
            editRoleBtn.Size = new Size(155, 52);
            editRoleBtn.TabIndex = 6;
            editRoleBtn.Text = "Chỉnh sửa role";
            editRoleBtn.UseVisualStyleBackColor = true;
            editRoleBtn.Click += editRoleBtn_Click;
            // 
            // deleteRoleBtn
            // 
            deleteRoleBtn.Location = new Point(444, 166);
            deleteRoleBtn.Name = "deleteRoleBtn";
            deleteRoleBtn.Size = new Size(155, 52);
            deleteRoleBtn.TabIndex = 7;
            deleteRoleBtn.Text = "Xóa role";
            deleteRoleBtn.UseVisualStyleBackColor = true;
            deleteRoleBtn.Click += deleteRoleBtn_Click;
            // 
            // refreshRoleBtn
            // 
            refreshRoleBtn.Location = new Point(444, 359);
            refreshRoleBtn.Name = "refreshRoleBtn";
            refreshRoleBtn.Size = new Size(155, 52);
            refreshRoleBtn.TabIndex = 8;
            refreshRoleBtn.Text = "Refresh";
            refreshRoleBtn.UseVisualStyleBackColor = true;
            refreshRoleBtn.Click += refreshRoleBtn_Click;
            // 
            // manageRoleTab
            // 
            manageRoleTab.Controls.Add(userGroupBox);
            manageRoleTab.Controls.Add(rolesGroupBox);
            manageRoleTab.ForeColor = SystemColors.ControlText;
            manageRoleTab.Location = new Point(4, 29);
            manageRoleTab.Name = "manageRoleTab";
            manageRoleTab.Padding = new Padding(3, 3, 3, 3);
            manageRoleTab.Size = new Size(1297, 635);
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
            userGroupBox.Location = new Point(24, 5);
            userGroupBox.Name = "userGroupBox";
            userGroupBox.Size = new Size(612, 613);
            userGroupBox.TabIndex = 10;
            userGroupBox.TabStop = false;
            // 
            // refreshUserBtn
            // 
            refreshUserBtn.Location = new Point(350, 360);
            refreshUserBtn.Margin = new Padding(3, 4, 3, 4);
            refreshUserBtn.Name = "refreshUserBtn";
            refreshUserBtn.Size = new Size(155, 52);
            refreshUserBtn.TabIndex = 8;
            refreshUserBtn.Text = "Refresh";
            refreshUserBtn.UseVisualStyleBackColor = true;
            refreshUserBtn.Click += refreshUserBtn_Click;
            // 
            // manageUsersLabel
            // 
            manageUsersLabel.AutoSize = true;
            manageUsersLabel.Location = new Point(19, 27);
            manageUsersLabel.Name = "manageUsersLabel";
            manageUsersLabel.Size = new Size(243, 20);
            manageUsersLabel.TabIndex = 4;
            manageUsersLabel.Text = "Danh sách các users trong hệ thống";
            // 
            // DataGridViewUsers
            // 
            DataGridViewUsers.AllowUserToOrderColumns = true;
            DataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsers.Location = new Point(19, 69);
            DataGridViewUsers.Name = "DataGridViewUsers";
            DataGridViewUsers.RowHeadersWidth = 150;
            DataGridViewUsers.RowTemplate.Height = 29;
            DataGridViewUsers.Size = new Size(310, 527);
            DataGridViewUsers.TabIndex = 3;
            DataGridViewUsers.CellClick += DataGridViewUsers_CellClick;
            // 
            // editUserBtn
            // 
            editUserBtn.Location = new Point(350, 258);
            editUserBtn.Margin = new Padding(3, 4, 3, 4);
            editUserBtn.Name = "editUserBtn";
            editUserBtn.Size = new Size(155, 52);
            editUserBtn.TabIndex = 6;
            editUserBtn.Text = "Chỉnh sửa user";
            editUserBtn.UseVisualStyleBackColor = true;
            editUserBtn.Click += editUserBtn_Click;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.Location = new Point(350, 167);
            deleteUserBtn.Margin = new Padding(3, 4, 3, 4);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(155, 52);
            deleteUserBtn.TabIndex = 7;
            deleteUserBtn.Text = "Xóa user";
            deleteUserBtn.UseVisualStyleBackColor = true;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // createUserBtn
            // 
            createUserBtn.Location = new Point(350, 69);
            createUserBtn.Margin = new Padding(3, 4, 3, 4);
            createUserBtn.Name = "createUserBtn";
            createUserBtn.Size = new Size(155, 52);
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
            rolesGroupBox.Location = new Point(652, 6);
            rolesGroupBox.Name = "rolesGroupBox";
            rolesGroupBox.Size = new Size(627, 612);
            rolesGroupBox.TabIndex = 9;
            rolesGroupBox.TabStop = false;
            rolesGroupBox.Enter += rolesGroupBox_Enter;
            // 
            // manageRolesLabel
            // 
            manageRolesLabel.AutoSize = true;
            manageRolesLabel.Location = new Point(17, 16);
            manageRolesLabel.Name = "manageRolesLabel";
            manageRolesLabel.Size = new Size(236, 20);
            manageRolesLabel.TabIndex = 4;
            manageRolesLabel.Text = "Danh sách các role trong hệ thống";
            manageRolesLabel.Click += manageRolesLabel_Click;
            // 
            // DataGridViewRoles
            // 
            DataGridViewRoles.AllowUserToOrderColumns = true;
            DataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRoles.Location = new Point(17, 69);
            DataGridViewRoles.Name = "DataGridViewRoles";
            DataGridViewRoles.RowHeadersWidth = 51;
            DataGridViewRoles.RowTemplate.Height = 29;
            DataGridViewRoles.Size = new Size(399, 526);
            DataGridViewRoles.TabIndex = 3;
            DataGridViewRoles.CellClick += DataGridViewRoles_CellClick;
            // 
            // tabManageRole
            // 
            tabManageRole.Controls.Add(manageRoleTab);
            tabManageRole.Location = new Point(11, 12);
            tabManageRole.Name = "tabManageRole";
            tabManageRole.SelectedIndex = 0;
            tabManageRole.Size = new Size(1305, 668);
            tabManageRole.TabIndex = 9;
            // 
            // disconnect_Btn
            // 
            disconnect_Btn.BackColor = Color.Red;
            disconnect_Btn.ForeColor = Color.Snow;
            disconnect_Btn.Location = new Point(1387, 12);
            disconnect_Btn.Margin = new Padding(3, 4, 3, 4);
            disconnect_Btn.Name = "disconnect_Btn";
            disconnect_Btn.Size = new Size(141, 60);
            disconnect_Btn.TabIndex = 10;
            disconnect_Btn.Text = "Disconnect";
            disconnect_Btn.UseVisualStyleBackColor = false;
            disconnect_Btn.Click += disconnect_btn_Click;
            // 
            // ManageRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1552, 714);
            Controls.Add(disconnect_Btn);
            Controls.Add(tabManageRole);
            Controls.Add(RoleLabel);
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
        private Button disconnect_Btn;
    }
}
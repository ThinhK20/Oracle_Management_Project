namespace Oracle_Management_UI
{
    partial class ViewUser
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
            label1 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            USERNAME = new DataGridViewTextBoxColumn();
            USER_ID = new DataGridViewTextBoxColumn();
            CREATED = new DataGridViewTextBoxColumn();
            COMMON = new DataGridViewTextBoxColumn();
            ORACLE_MAINTAINED = new DataGridViewTextBoxColumn();
            INHERITED = new DataGridViewTextBoxColumn();
            DEFAULT_COLLATION = new DataGridViewTextBoxColumn();
            IMPLICIT = new DataGridViewTextBoxColumn();
            ALL_SHARD = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            USERNAME_SYSTEMPRIS = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            tabPage4 = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(81, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ\r\n";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(1006, 30);
            button1.Name = "button1";
            button1.Size = new Size(101, 32);
            button1.TabIndex = 1;
            button1.Text = "Đăng xuất";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(81, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1026, 518);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            tabPage2.ForeColor = Color.LightSkyBlue;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1018, 490);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Người dùng hệ thống";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { USERNAME, USER_ID, CREATED, COMMON, ORACLE_MAINTAINED, INHERITED, DEFAULT_COLLATION, IMPLICIT, ALL_SHARD });
            dataGridView1.Location = new Point(-4, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1026, 494);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // USERNAME
            // 
            USERNAME.HeaderText = "USERNAME";
            USERNAME.Name = "USERNAME";
            // 
            // USER_ID
            // 
            USER_ID.HeaderText = "USER_ID";
            USER_ID.Name = "USER_ID";
            // 
            // CREATED
            // 
            CREATED.HeaderText = "CREATED";
            CREATED.Name = "CREATED";
            // 
            // COMMON
            // 
            COMMON.HeaderText = "COMMON";
            COMMON.Name = "COMMON";
            // 
            // ORACLE_MAINTAINED
            // 
            ORACLE_MAINTAINED.HeaderText = "ORACLE_MAINTAINED";
            ORACLE_MAINTAINED.Name = "ORACLE_MAINTAINED";
            ORACLE_MAINTAINED.Width = 150;
            // 
            // INHERITED
            // 
            INHERITED.HeaderText = "INHERITED";
            INHERITED.Name = "INHERITED";
            // 
            // DEFAULT_COLLATION
            // 
            DEFAULT_COLLATION.HeaderText = "DEFAULT_COLLATION";
            DEFAULT_COLLATION.Name = "DEFAULT_COLLATION";
            DEFAULT_COLLATION.Width = 150;
            // 
            // IMPLICIT
            // 
            IMPLICIT.HeaderText = "IMPLICIT";
            IMPLICIT.Name = "IMPLICIT";
            // 
            // ALL_SHARD
            // 
            ALL_SHARD.HeaderText = "ALL_SHARD";
            ALL_SHARD.Name = "ALL_SHARD";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1018, 490);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Thông tin quyền";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1105, 500);
            tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1097, 472);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "User";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { USERNAME_SYSTEMPRIS });
            dataGridView2.Location = new Point(0, 86);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1011, 381);
            dataGridView2.TabIndex = 7;
            // 
            // USERNAME_SYSTEMPRIS
            // 
            USERNAME_SYSTEMPRIS.HeaderText = "USERNAME";
            USERNAME_SYSTEMPRIS.Name = "USERNAME_SYSTEMPRIS";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.FlatAppearance.BorderColor = Color.Blue;
            button5.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.MenuHighlight;
            button5.Location = new Point(815, 21);
            button5.Name = "button5";
            button5.Size = new Size(101, 42);
            button5.TabIndex = 6;
            button5.Text = "Column Privileges";
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.MenuHighlight;
            button4.Location = new Point(578, 21);
            button4.Name = "button4";
            button4.Size = new Size(101, 42);
            button4.TabIndex = 5;
            button4.Text = "Table          Privileges";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(300, 21);
            button3.Name = "button3";
            button3.Size = new Size(92, 42);
            button3.TabIndex = 4;
            button3.Text = "Role Privileges";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(103, 21);
            button2.Name = "button2";
            button2.Size = new Size(98, 42);
            button2.TabIndex = 3;
            button2.Text = "System Privileges";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button6);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1097, 472);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Role";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridView3.Location = new Point(0, 82);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1011, 381);
            dataGridView3.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "USERNAME";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.FlatAppearance.BorderColor = Color.Blue;
            button8.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.MenuHighlight;
            button8.Location = new Point(721, 18);
            button8.Name = "button8";
            button8.Size = new Size(101, 42);
            button8.TabIndex = 6;
            button8.Text = "Table          Privileges";
            button8.TextImageRelation = TextImageRelation.TextBeforeImage;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.FlatAppearance.BorderColor = Color.Blue;
            button7.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.MenuHighlight;
            button7.Location = new Point(440, 18);
            button7.Name = "button7";
            button7.Size = new Size(92, 42);
            button7.TabIndex = 5;
            button7.Text = "Role Privileges";
            button7.TextImageRelation = TextImageRelation.TextBeforeImage;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.FlatAppearance.BorderColor = Color.Blue;
            button6.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.MenuHighlight;
            button6.Location = new Point(175, 18);
            button6.Name = "button6";
            button6.Size = new Size(98, 42);
            button6.TabIndex = 4;
            button6.Text = "System Privileges";
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = false;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1199, 635);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ViewUser";
            Text = "ViewUser";
            Load += ViewUser_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage1;
        private DataGridViewTextBoxColumn USERNAME;
        private DataGridViewTextBoxColumn USER_ID;
        private DataGridViewTextBoxColumn CREATED;
        private DataGridViewTextBoxColumn COMMON;
        private DataGridViewTextBoxColumn ORACLE_MAINTAINED;
        private DataGridViewTextBoxColumn INHERITED;
        private DataGridViewTextBoxColumn DEFAULT_COLLATION;
        private DataGridViewTextBoxColumn IMPLICIT;
        private DataGridViewTextBoxColumn ALL_SHARD;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn USERNAME_SYSTEMPRIS;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}
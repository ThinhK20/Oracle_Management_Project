using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;
using System.Drawing;

namespace Oracle_Management_UI
{
    partial class EditRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        OracleConnection con = null;

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








        //private void Window_Loaded(object sender, EventArgs e)
        //{
        //    this.updateDataGrid();
        //}


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage_sec = new TabPage();
            label12 = new Label();
            button9 = new Button();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button8 = new Button();
            label9 = new Label();
            label10 = new Label();
            dataGridView7 = new DataGridView();
            dataGridView8 = new DataGridView();
            label11 = new Label();
            tabPage_sys = new TabPage();
            button5 = new Button();
            button6 = new Button();
            checkBox_privs = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            dataGridView5 = new DataGridView();
            dataGridView6 = new DataGridView();
            label8 = new Label();
            tabPage_roles = new TabPage();
            button3 = new Button();
            button4 = new Button();
            checkBox_role = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            label5 = new Label();
            tabPage_users = new TabPage();
            button2 = new Button();
            button1 = new Button();
            checkBox_user = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label_role = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            tabPage_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            tabPage_sys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabPage_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage_sec
            // 
            tabPage_sec.Controls.Add(label12);
            tabPage_sec.Controls.Add(button9);
            tabPage_sec.Controls.Add(comboBox1);
            tabPage_sec.Controls.Add(button7);
            tabPage_sec.Controls.Add(button8);
            tabPage_sec.Controls.Add(label9);
            tabPage_sec.Controls.Add(label10);
            tabPage_sec.Controls.Add(dataGridView7);
            tabPage_sec.Controls.Add(dataGridView8);
            tabPage_sec.Controls.Add(label11);
            tabPage_sec.Location = new Point(4, 24);
            tabPage_sec.Name = "tabPage_sec";
            tabPage_sec.Size = new Size(732, 484);
            tabPage_sec.TabIndex = 4;
            tabPage_sec.Text = "Securable";
            tabPage_sec.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(440, 328);
            label12.Name = "label12";
            label12.Size = new Size(114, 21);
            label12.TabIndex = 20;
            label12.Text = "Permission: ...";
            // 
            // button9
            // 
            button9.Location = new Point(305, 446);
            button9.Name = "button9";
            button9.Size = new Size(133, 39);
            button9.TabIndex = 19;
            button9.Text = "Column Permission";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Select", "Insert", "Update", "Delete" });
            comboBox1.Location = new Point(28, 338);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(440, 365);
            button7.Name = "button7";
            button7.Size = new Size(270, 61);
            button7.TabIndex = 15;
            button7.Text = "Revoke";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(28, 365);
            button8.Name = "button8";
            button8.Size = new Size(270, 61);
            button8.TabIndex = 14;
            button8.Text = "Grant";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(440, 296);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 12;
            label9.Text = "Table: ...";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 296);
            label10.Name = "label10";
            label10.Size = new Size(71, 21);
            label10.TabIndex = 11;
            label10.Text = "Table: ...";
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(440, 43);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.RowTemplate.Height = 25;
            dataGridView7.Size = new Size(270, 239);
            dataGridView7.TabIndex = 10;
            dataGridView7.CellMouseUp += dataGridView7_CellMouseUp;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(28, 43);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 51;
            dataGridView8.RowTemplate.Height = 25;
            dataGridView8.Size = new Size(270, 239);
            dataGridView8.TabIndex = 9;
            dataGridView8.CellMouseUp += dataGridView8_CellMouseUp;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 28);
            label11.TabIndex = 8;
            label11.Text = "Table";
            label11.Click += label11_Click;
            // 
            // tabPage_sys
            // 
            tabPage_sys.Controls.Add(button5);
            tabPage_sys.Controls.Add(button6);
            tabPage_sys.Controls.Add(checkBox_privs);
            tabPage_sys.Controls.Add(label6);
            tabPage_sys.Controls.Add(label7);
            tabPage_sys.Controls.Add(dataGridView5);
            tabPage_sys.Controls.Add(dataGridView6);
            tabPage_sys.Controls.Add(label8);
            tabPage_sys.Location = new Point(4, 24);
            tabPage_sys.Name = "tabPage_sys";
            tabPage_sys.Padding = new Padding(3, 3, 3, 3);
            tabPage_sys.Size = new Size(732, 484);
            tabPage_sys.TabIndex = 3;
            tabPage_sys.Text = "System Privileges";
            tabPage_sys.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(443, 368);
            button5.Name = "button5";
            button5.Size = new Size(270, 61);
            button5.TabIndex = 15;
            button5.Text = "Revoke";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(31, 368);
            button6.Name = "button6";
            button6.Size = new Size(270, 61);
            button6.TabIndex = 14;
            button6.Text = "Grant";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // checkBox_privs
            // 
            checkBox_privs.AutoSize = true;
            checkBox_privs.Location = new Point(31, 343);
            checkBox_privs.Name = "checkBox_privs";
            checkBox_privs.Size = new Size(102, 19);
            checkBox_privs.TabIndex = 13;
            checkBox_privs.Text = "Admin Option";
            checkBox_privs.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(443, 299);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 12;
            label6.Text = "Permission: ...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 299);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 11;
            label7.Text = "Permission: ...";
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(443, 46);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(270, 239);
            dataGridView5.TabIndex = 10;
            dataGridView5.CellMouseUp += dataGridView5_CellMouseUp;
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.AllowUserToDeleteRows = false;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(31, 46);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new Size(270, 239);
            dataGridView6.TabIndex = 9;
            dataGridView6.CellMouseUp += dataGridView6_CellMouseUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 3);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 8;
            label8.Text = "Permission";
            // 
            // tabPage_roles
            // 
            tabPage_roles.Controls.Add(button3);
            tabPage_roles.Controls.Add(button4);
            tabPage_roles.Controls.Add(checkBox_role);
            tabPage_roles.Controls.Add(label3);
            tabPage_roles.Controls.Add(label4);
            tabPage_roles.Controls.Add(dataGridView3);
            tabPage_roles.Controls.Add(dataGridView4);
            tabPage_roles.Controls.Add(label5);
            tabPage_roles.Location = new Point(4, 24);
            tabPage_roles.Name = "tabPage_roles";
            tabPage_roles.Padding = new Padding(3, 3, 3, 3);
            tabPage_roles.Size = new Size(732, 484);
            tabPage_roles.TabIndex = 2;
            tabPage_roles.Text = "Roles";
            tabPage_roles.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(443, 368);
            button3.Name = "button3";
            button3.Size = new Size(270, 61);
            button3.TabIndex = 15;
            button3.Text = "Revoke";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(31, 368);
            button4.Name = "button4";
            button4.Size = new Size(270, 61);
            button4.TabIndex = 14;
            button4.Text = "Grant";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox_role
            // 
            checkBox_role.AutoSize = true;
            checkBox_role.Location = new Point(31, 343);
            checkBox_role.Name = "checkBox_role";
            checkBox_role.Size = new Size(102, 19);
            checkBox_role.TabIndex = 13;
            checkBox_role.Text = "Admin Option";
            checkBox_role.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(443, 299);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 12;
            label3.Text = "User: ...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 299);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 11;
            label4.Text = "User: ...";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(443, 46);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(270, 239);
            dataGridView3.TabIndex = 10;
            dataGridView3.CellMouseUp += dataGridView3_CellMouseUp;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(31, 46);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(270, 239);
            dataGridView4.TabIndex = 9;
            dataGridView4.CellMouseUp += dataGridView4_CellMouseUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 8;
            label5.Text = "Role:";
            // 
            // tabPage_users
            // 
            tabPage_users.Controls.Add(button2);
            tabPage_users.Controls.Add(button1);
            tabPage_users.Controls.Add(checkBox_user);
            tabPage_users.Controls.Add(label2);
            tabPage_users.Controls.Add(label1);
            tabPage_users.Controls.Add(dataGridView2);
            tabPage_users.Controls.Add(dataGridView1);
            tabPage_users.Controls.Add(label_role);
            tabPage_users.Location = new Point(4, 24);
            tabPage_users.Name = "tabPage_users";
            tabPage_users.Padding = new Padding(3, 3, 3, 3);
            tabPage_users.Size = new Size(732, 484);
            tabPage_users.TabIndex = 1;
            tabPage_users.Text = "Users";
            tabPage_users.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(443, 368);
            button2.Name = "button2";
            button2.Size = new Size(270, 61);
            button2.TabIndex = 7;
            button2.Text = "Revoke";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(31, 368);
            button1.Name = "button1";
            button1.Size = new Size(270, 61);
            button1.TabIndex = 6;
            button1.Text = "Grant";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox_user
            // 
            checkBox_user.AutoSize = true;
            checkBox_user.Location = new Point(31, 343);
            checkBox_user.Name = "checkBox_user";
            checkBox_user.Size = new Size(102, 19);
            checkBox_user.TabIndex = 5;
            checkBox_user.Text = "Admin Option";
            checkBox_user.UseVisualStyleBackColor = true;
            checkBox_user.CheckedChanged += checkBox_wgo_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(443, 299);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 4;
            label2.Text = "User: ...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 299);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 3;
            label1.Text = "User: ...";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(443, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(270, 239);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellMouseUp += dataGridView2_CellMouseUp;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(270, 239);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseUp += dataGridView1_CellMouseUp;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_role.Location = new Point(6, 3);
            label_role.Name = "label_role";
            label_role.Size = new Size(55, 28);
            label_role.TabIndex = 0;
            label_role.Text = "User:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage_users);
            tabControl1.Controls.Add(tabPage_roles);
            tabControl1.Controls.Add(tabPage_sys);
            tabControl1.Controls.Add(tabPage_sec);
            tabControl1.Location = new Point(13, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(740, 512);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(732, 484);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Role";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(215, 40);
            label14.Name = "label14";
            label14.Size = new Size(62, 28);
            label14.TabIndex = 2;
            label14.Text = "ROLE:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(82, 40);
            label13.Name = "label13";
            label13.Size = new Size(62, 28);
            label13.TabIndex = 1;
            label13.Text = "ROLE:";
            label13.Click += label13_Click_1;
            // 
            // EditRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 545);
            Controls.Add(tabControl1);
            Name = "EditRole";
            Text = "EditRole";
            Load += EditRole_Load;
            tabPage_sec.ResumeLayout(false);
            tabPage_sec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            tabPage_sys.ResumeLayout(false);
            tabPage_sys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabPage_roles.ResumeLayout(false);
            tabPage_roles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage_users.ResumeLayout(false);
            tabPage_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage_sec;
        private TabPage tabPage_sys;
        private TabPage tabPage_roles;
        private TabPage tabPage_users;
        private Label username_label;
        private Label label1;
        private Label label2;
        private Label label_role;

        private Button button1;
        private Button button2;
        private CheckBox checkBox_user;

        private TabControl tabControl1;
        private Button button7;
        private Button button8;
        private CheckBox checkBox_table;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView7;
        private DataGridView dataGridView8;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label11;
        private Button button5;
        private Button button6;
        private CheckBox checkBox_privs;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private Label label8;
        private Button button3;
        private Button button4;
        private CheckBox checkBox_adm;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Label label5;
        private TabPage tabPage1;
        private ComboBox comboBox1;
        private CheckBox checkBox_role;
        private Button button9;
        private Label label12;
        private Label label14;
        private Label label13;
    }
}
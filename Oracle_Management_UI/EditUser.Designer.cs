﻿using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Drawing;
namespace Oracle_Management_UI
{
    partial class EditUser
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



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            button6 = new Button();
            checkBox2 = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            dataGridView5 = new DataGridView();
            label8 = new Label();
            button7 = new Button();
            button8 = new Button();
            checkBox3 = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            dataGridView7 = new DataGridView();
            dataGridView6 = new DataGridView();
            label11 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView8 = new DataGridView();
            tabPage_users = new TabPage();
            resetChangePassword_btn = new Button();
            changePassword_btn = new Button();
            confirmPassword_TextBox = new TextBox();
            username_Label = new Label();
            newPassword_TextBox = new TextBox();
            newPassword_Label = new Label();
            username_Result = new Label();
            confirmPassword_Label = new Label();
            tabPage_roles = new TabPage();
            label5 = new Label();
            tabPage_sys = new TabPage();
            tabPage_sec = new TabPage();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            tabPage_users.SuspendLayout();
            tabPage_roles.SuspendLayout();
            tabPage_sys.SuspendLayout();
            tabPage_sec.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(34, 346);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Admin Option";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(446, 302);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 12;
            label3.Text = "Privileges: ...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 302);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 11;
            label4.Text = "Privileges: ...";
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
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(34, 346);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 19);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Admin Option";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(446, 302);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 12;
            label6.Text = "Role: ...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 302);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 11;
            label7.Text = "Role:..";
            label7.Click += label7_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(443, 46);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(319, 239);
            dataGridView5.TabIndex = 10;
            dataGridView5.CellClick += dataGridView5_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 6);
            label8.Name = "label8";
            label8.Size = new Size(67, 28);
            label8.TabIndex = 8;
            label8.Text = "User:...";
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
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(28, 297);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 19);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Admin Option";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(440, 273);
            label9.Name = "label9";
            label9.Size = new Size(192, 21);
            label9.TabIndex = 12;
            label9.Text = "Table: ... và Privileges: ...";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 273);
            label10.Name = "label10";
            label10.Size = new Size(71, 21);
            label10.TabIndex = 11;
            label10.Text = "Table: ...";
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(440, 31);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.RowTemplate.Height = 25;
            dataGridView7.Size = new Size(325, 239);
            dataGridView7.TabIndex = 10;
            dataGridView7.CellClick += dataGridView7_CellContentClick;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(31, 46);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new Size(361, 239);
            dataGridView6.TabIndex = 9;
            dataGridView6.CellClick += dataGridView6_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 28);
            label11.TabIndex = 8;
            label11.Text = "User: ...";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(443, 46);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(319, 239);
            dataGridView3.TabIndex = 10;
            dataGridView3.CellClick += dataGridView3_CellContentClick;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(31, 46);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(366, 239);
            dataGridView4.TabIndex = 9;
            dataGridView4.CellClick += dataGridView4_CellContentClick;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(28, 31);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 51;
            dataGridView8.RowTemplate.Height = 25;
            dataGridView8.Size = new Size(372, 239);
            dataGridView8.TabIndex = 9;
            dataGridView8.CellClick += dataGridView8_CellContentClick;
            // 
            // tabPage_users
            // 
            tabPage_users.Controls.Add(resetChangePassword_btn);
            tabPage_users.Controls.Add(changePassword_btn);
            tabPage_users.Controls.Add(confirmPassword_TextBox);
            tabPage_users.Controls.Add(username_Label);
            tabPage_users.Controls.Add(newPassword_TextBox);
            tabPage_users.Controls.Add(newPassword_Label);
            tabPage_users.Controls.Add(username_Result);
            tabPage_users.Controls.Add(confirmPassword_Label);
            tabPage_users.Location = new Point(4, 24);
            tabPage_users.Name = "tabPage_users";
            tabPage_users.Padding = new Padding(3);
            tabPage_users.Size = new Size(768, 482);
            tabPage_users.TabIndex = 1;
            tabPage_users.Text = "Users";
            tabPage_users.UseVisualStyleBackColor = true;
            // 
            // resetChangePassword_btn
            // 
            resetChangePassword_btn.BackColor = Color.Transparent;
            resetChangePassword_btn.ForeColor = SystemColors.ActiveCaptionText;
            resetChangePassword_btn.Location = new Point(475, 227);
            resetChangePassword_btn.Margin = new Padding(3, 2, 3, 2);
            resetChangePassword_btn.Name = "resetChangePassword_btn";
            resetChangePassword_btn.Size = new Size(136, 41);
            resetChangePassword_btn.TabIndex = 13;
            resetChangePassword_btn.Text = "Reset";
            resetChangePassword_btn.UseVisualStyleBackColor = false;
            resetChangePassword_btn.Click += resetChangePassword_btn_Click;
            // 
            // changePassword_btn
            // 
            changePassword_btn.BackColor = SystemColors.MenuHighlight;
            changePassword_btn.ForeColor = Color.Transparent;
            changePassword_btn.Location = new Point(304, 227);
            changePassword_btn.Margin = new Padding(3, 2, 3, 2);
            changePassword_btn.Name = "changePassword_btn";
            changePassword_btn.Size = new Size(136, 41);
            changePassword_btn.TabIndex = 12;
            changePassword_btn.Text = "Đổi mật khẩu";
            changePassword_btn.UseVisualStyleBackColor = false;
            changePassword_btn.Click += changePassword_btn_Click;
            // 
            // confirmPassword_TextBox
            // 
            confirmPassword_TextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassword_TextBox.Location = new Point(234, 148);
            confirmPassword_TextBox.Margin = new Padding(3, 2, 3, 2);
            confirmPassword_TextBox.Name = "confirmPassword_TextBox";
            confirmPassword_TextBox.Size = new Size(378, 32);
            confirmPassword_TextBox.TabIndex = 11;
            confirmPassword_TextBox.UseSystemPasswordChar = true;
            confirmPassword_TextBox.TextChanged += confirmPassword_TextBox_TextChanged;
            // 
            // username_Label
            // 
            username_Label.AutoSize = true;
            username_Label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            username_Label.Location = new Point(27, 24);
            username_Label.Name = "username_Label";
            username_Label.Size = new Size(103, 28);
            username_Label.TabIndex = 6;
            username_Label.Text = "Username:";
            // 
            // newPassword_TextBox
            // 
            newPassword_TextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword_TextBox.Location = new Point(234, 82);
            newPassword_TextBox.Margin = new Padding(3, 2, 3, 2);
            newPassword_TextBox.Name = "newPassword_TextBox";
            newPassword_TextBox.Size = new Size(378, 32);
            newPassword_TextBox.TabIndex = 10;
            newPassword_TextBox.UseSystemPasswordChar = true;
            newPassword_TextBox.TextChanged += newPassword_TextBox_TextChanged;
            // 
            // newPassword_Label
            // 
            newPassword_Label.AutoSize = true;
            newPassword_Label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword_Label.Location = new Point(27, 84);
            newPassword_Label.Name = "newPassword_Label";
            newPassword_Label.Size = new Size(137, 28);
            newPassword_Label.TabIndex = 7;
            newPassword_Label.Text = "New Password";
            // 
            // username_Result
            // 
            username_Result.AutoSize = true;
            username_Result.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            username_Result.Location = new Point(234, 24);
            username_Result.Name = "username_Result";
            username_Result.Size = new Size(59, 28);
            username_Result.TabIndex = 9;
            username_Result.Text = "Syros";
            // 
            // confirmPassword_Label
            // 
            confirmPassword_Label.AutoSize = true;
            confirmPassword_Label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassword_Label.Location = new Point(27, 150);
            confirmPassword_Label.Name = "confirmPassword_Label";
            confirmPassword_Label.Size = new Size(168, 28);
            confirmPassword_Label.TabIndex = 8;
            confirmPassword_Label.Text = "Confirm Password";
            // 
            // tabPage_roles
            // 
            tabPage_roles.Controls.Add(button3);
            tabPage_roles.Controls.Add(button4);
            tabPage_roles.Controls.Add(checkBox1);
            tabPage_roles.Controls.Add(label3);
            tabPage_roles.Controls.Add(label4);
            tabPage_roles.Controls.Add(dataGridView3);
            tabPage_roles.Controls.Add(dataGridView4);
            tabPage_roles.Controls.Add(label5);
            tabPage_roles.Location = new Point(4, 24);
            tabPage_roles.Name = "tabPage_roles";
            tabPage_roles.Padding = new Padding(3);
            tabPage_roles.Size = new Size(768, 482);
            tabPage_roles.TabIndex = 2;
            tabPage_roles.Text = "System Privileges";
            tabPage_roles.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 6);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 8;
            label5.Text = "User: ...";
            label5.Click += label5_Click;
            // 
            // tabPage_sys
            // 
            tabPage_sys.Controls.Add(button5);
            tabPage_sys.Controls.Add(button6);
            tabPage_sys.Controls.Add(checkBox2);
            tabPage_sys.Controls.Add(label6);
            tabPage_sys.Controls.Add(label7);
            tabPage_sys.Controls.Add(dataGridView5);
            tabPage_sys.Controls.Add(dataGridView6);
            tabPage_sys.Controls.Add(label8);
            tabPage_sys.Location = new Point(4, 24);
            tabPage_sys.Name = "tabPage_sys";
            tabPage_sys.Padding = new Padding(3);
            tabPage_sys.Size = new Size(768, 482);
            tabPage_sys.TabIndex = 3;
            tabPage_sys.Text = "Roles";
            tabPage_sys.UseVisualStyleBackColor = true;
            // 
            // tabPage_sec
            // 
            tabPage_sec.Controls.Add(button1);
            tabPage_sec.Controls.Add(label1);
            tabPage_sec.Controls.Add(comboBox1);
            tabPage_sec.Controls.Add(button7);
            tabPage_sec.Controls.Add(button8);
            tabPage_sec.Controls.Add(checkBox3);
            tabPage_sec.Controls.Add(label9);
            tabPage_sec.Controls.Add(label10);
            tabPage_sec.Controls.Add(dataGridView7);
            tabPage_sec.Controls.Add(dataGridView8);
            tabPage_sec.Controls.Add(label11);
            tabPage_sec.Location = new Point(4, 24);
            tabPage_sec.Name = "tabPage_sec";
            tabPage_sec.Size = new Size(768, 482);
            tabPage_sec.TabIndex = 4;
            tabPage_sec.Text = "Securable";
            tabPage_sec.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(302, 440);
            button1.Name = "button1";
            button1.Size = new Size(133, 39);
            button1.TabIndex = 18;
            button1.Text = "Column Permission";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 330);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 17;
            label1.Text = "Permission";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Select", "Insert", "Update", "Delete" });
            comboBox1.Location = new Point(131, 333);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_users);
            tabControl1.Controls.Add(tabPage_roles);
            tabControl1.Controls.Add(tabPage_sys);
            tabControl1.Controls.Add(tabPage_sec);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 510);
            tabControl1.TabIndex = 1;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(tabControl1);
            Name = "EditUser";
            Text = "EditUser";
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            tabPage_users.ResumeLayout(false);
            tabPage_users.PerformLayout();
            tabPage_roles.ResumeLayout(false);
            tabPage_roles.PerformLayout();
            tabPage_sys.ResumeLayout(false);
            tabPage_sys.PerformLayout();
            tabPage_sec.ResumeLayout(false);
            tabPage_sec.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
        private Button button6;
        private CheckBox checkBox2;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView5;
        private Label label8;
        private Button button7;
        private Button button8;
        private CheckBox checkBox3;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView7;
        private DataGridView dataGridView6;
        private Label label11;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView8;
        private TabPage tabPage_users;
        private TabPage tabPage_roles;
        private Label label5;
        private TabPage tabPage_sys;
        private TabPage tabPage_sec;
        private TabControl tabControl1;
        private TextBox confirmPassword_TextBox;
        private Label username_Label;
        private TextBox newPassword_TextBox;
        private Label newPassword_Label;
        private Label username_Result;
        private Label confirmPassword_Label;
        private Button resetChangePassword_btn;
        private Button changePassword_btn;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}
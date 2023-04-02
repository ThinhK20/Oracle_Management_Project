using Oracle.ManagedDataAccess.Client;
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
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_wgo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_role = new System.Windows.Forms.Label();
            this.tabPage_users = new System.Windows.Forms.TabPage();
            this.tabPage_roles = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_sys = new System.Windows.Forms.TabPage();
            this.tabPage_sec = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_users.SuspendLayout();
            this.tabPage_roles.SuspendLayout();
            this.tabPage_sys.SuspendLayout();
            this.tabPage_sec.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(506, 491);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(309, 81);
            this.button5.TabIndex = 15;
            this.button5.Text = "Revoke";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(506, 491);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 81);
            this.button3.TabIndex = 15;
            this.button3.Text = "Revoke";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(35, 491);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(309, 81);
            this.button4.TabIndex = 14;
            this.button4.Text = "Grant";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 461);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Grant Option";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(510, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "User: ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "User: ...";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(35, 491);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(309, 81);
            this.button6.TabIndex = 14;
            this.button6.Text = "Grant";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(39, 461);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Grant Option";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "User: ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "User: ...";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(506, 61);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(309, 319);
            this.dataGridView5.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 35);
            this.label8.TabIndex = 8;
            this.label8.Text = "Role:";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(503, 487);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(309, 81);
            this.button7.TabIndex = 15;
            this.button7.Text = "Revoke";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(32, 487);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(309, 81);
            this.button8.TabIndex = 14;
            this.button8.Text = "Grant";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(32, 453);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(117, 24);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Grant Option";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(503, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "User: ...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(32, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Table: ...";
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(503, 57);
            this.dataGridView7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 25;
            this.dataGridView7.Size = new System.Drawing.Size(309, 319);
            this.dataGridView7.TabIndex = 10;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(35, 61);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(309, 319);
            this.dataGridView6.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 35);
            this.label11.TabIndex = 8;
            this.label11.Text = "User: ...";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(506, 61);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(309, 319);
            this.dataGridView3.TabIndex = 10;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(35, 61);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(309, 319);
            this.dataGridView4.TabIndex = 9;
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(32, 57);
            this.dataGridView8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 25;
            this.dataGridView8.Size = new System.Drawing.Size(309, 319);
            this.dataGridView8.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(506, 491);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 81);
            this.button2.TabIndex = 7;
            this.button2.Text = "Revoke";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(35, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "Grant";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox_wgo
            // 
            this.checkBox_wgo.AutoSize = true;
            this.checkBox_wgo.Location = new System.Drawing.Point(39, 461);
            this.checkBox_wgo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_wgo.Name = "checkBox_wgo";
            this.checkBox_wgo.Size = new System.Drawing.Size(117, 24);
            this.checkBox_wgo.TabIndex = 5;
            this.checkBox_wgo.Text = "Grant Option";
            this.checkBox_wgo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(510, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "User: ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "User: ...";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(506, 61);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(309, 319);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(309, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_role.Location = new System.Drawing.Point(10, 8);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(92, 35);
            this.label_role.TabIndex = 0;
            this.label_role.Text = "User: ...";
            // 
            // tabPage_users
            // 
            this.tabPage_users.Controls.Add(this.button2);
            this.tabPage_users.Controls.Add(this.button1);
            this.tabPage_users.Controls.Add(this.checkBox_wgo);
            this.tabPage_users.Controls.Add(this.label2);
            this.tabPage_users.Controls.Add(this.label1);
            this.tabPage_users.Controls.Add(this.dataGridView2);
            this.tabPage_users.Controls.Add(this.dataGridView1);
            this.tabPage_users.Controls.Add(this.label_role);
            this.tabPage_users.Location = new System.Drawing.Point(4, 29);
            this.tabPage_users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_users.Name = "tabPage_users";
            this.tabPage_users.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_users.Size = new System.Drawing.Size(879, 647);
            this.tabPage_users.TabIndex = 1;
            this.tabPage_users.Text = "Users";
            this.tabPage_users.UseVisualStyleBackColor = true;
            // 
            // tabPage_roles
            // 
            this.tabPage_roles.Controls.Add(this.button3);
            this.tabPage_roles.Controls.Add(this.button4);
            this.tabPage_roles.Controls.Add(this.checkBox1);
            this.tabPage_roles.Controls.Add(this.label3);
            this.tabPage_roles.Controls.Add(this.label4);
            this.tabPage_roles.Controls.Add(this.dataGridView3);
            this.tabPage_roles.Controls.Add(this.dataGridView4);
            this.tabPage_roles.Controls.Add(this.label5);
            this.tabPage_roles.Location = new System.Drawing.Point(4, 29);
            this.tabPage_roles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_roles.Name = "tabPage_roles";
            this.tabPage_roles.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_roles.Size = new System.Drawing.Size(879, 647);
            this.tabPage_roles.TabIndex = 2;
            this.tabPage_roles.Text = "Roles";
            this.tabPage_roles.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "User: ...";
            // 
            // tabPage_sys
            // 
            this.tabPage_sys.Controls.Add(this.button5);
            this.tabPage_sys.Controls.Add(this.button6);
            this.tabPage_sys.Controls.Add(this.checkBox2);
            this.tabPage_sys.Controls.Add(this.label6);
            this.tabPage_sys.Controls.Add(this.label7);
            this.tabPage_sys.Controls.Add(this.dataGridView5);
            this.tabPage_sys.Controls.Add(this.dataGridView6);
            this.tabPage_sys.Controls.Add(this.label8);
            this.tabPage_sys.Location = new System.Drawing.Point(4, 29);
            this.tabPage_sys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_sys.Name = "tabPage_sys";
            this.tabPage_sys.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_sys.Size = new System.Drawing.Size(879, 647);
            this.tabPage_sys.TabIndex = 3;
            this.tabPage_sys.Text = "System Privileges";
            this.tabPage_sys.UseVisualStyleBackColor = true;
            // 
            // tabPage_sec
            // 
            this.tabPage_sec.Controls.Add(this.button7);
            this.tabPage_sec.Controls.Add(this.button8);
            this.tabPage_sec.Controls.Add(this.checkBox3);
            this.tabPage_sec.Controls.Add(this.label9);
            this.tabPage_sec.Controls.Add(this.label10);
            this.tabPage_sec.Controls.Add(this.dataGridView7);
            this.tabPage_sec.Controls.Add(this.dataGridView8);
            this.tabPage_sec.Controls.Add(this.label11);
            this.tabPage_sec.Location = new System.Drawing.Point(4, 29);
            this.tabPage_sec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_sec.Name = "tabPage_sec";
            this.tabPage_sec.Size = new System.Drawing.Size(879, 647);
            this.tabPage_sec.TabIndex = 4;
            this.tabPage_sec.Text = "Securable";
            this.tabPage_sec.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_users);
            this.tabControl1.Controls.Add(this.tabPage_roles);
            this.tabControl1.Controls.Add(this.tabPage_sys);
            this.tabControl1.Controls.Add(this.tabPage_sec);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 680);
            this.tabControl1.TabIndex = 1;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 712);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditUser";
            this.Text = "EditUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_users.ResumeLayout(false);
            this.tabPage_users.PerformLayout();
            this.tabPage_roles.ResumeLayout(false);
            this.tabPage_roles.PerformLayout();
            this.tabPage_sys.ResumeLayout(false);
            this.tabPage_sys.PerformLayout();
            this.tabPage_sec.ResumeLayout(false);
            this.tabPage_sec.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button button2;
        private Button button1;
        private CheckBox checkBox_wgo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label_role;
        private TabPage tabPage_users;
        private TabPage tabPage_roles;
        private Label label5;
        private TabPage tabPage_sys;
        private TabPage tabPage_sec;
        private TabControl tabControl1;
    }
}
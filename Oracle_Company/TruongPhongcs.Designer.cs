namespace Oracle_Company
{
    partial class TruongPhongcs
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
            dataGridView1 = new DataGridView();
            phong = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            label8 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            dataGridView3 = new DataGridView();
            tabPage2 = new TabPage();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 58);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(742, 333);
            dataGridView1.TabIndex = 0;
            // 
            // phong
            // 
            phong.AutoSize = true;
            phong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phong.Location = new Point(18, 12);
            phong.Name = "phong";
            phong.Size = new Size(66, 21);
            phong.TabIndex = 1;
            phong.Text = "Phong : ";
            phong.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cornsilk;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(307, 30);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 2;
            label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.ImeMode = ImeMode.Disable;
            tabControl1.Location = new Point(10, 17);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 431);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(phong);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(852, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Xem Thông Tin Nhân Viên";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(852, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Xem và chỉnh sửa Phân Công";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(513, 184);
            label8.Name = "label8";
            label8.Size = new Size(240, 30);
            label8.TabIndex = 5;
            label8.Text = "Nhân Viên ..... Đề Án .....";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(562, 239);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(208, 58);
            button2.TabIndex = 4;
            button2.Text = "XÓA PHÂN CÔNG";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cornsilk;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 22);
            label3.Name = "label3";
            label3.Size = new Size(241, 28);
            label3.TabIndex = 3;
            label3.Text = "DANH SÁCH PHÂN CÔNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 14);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 2;
            label2.Text = "Phong : ";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(31, 69);
            dataGridView3.Margin = new Padding(3, 2, 3, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(459, 311);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellClick += gridview3_click;
            dataGridView3.CellEndEdit += updateData;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView4);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(852, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thêm Phân Công";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += resetDatsa3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(439, 282);
            label7.Name = "label7";
            label7.Size = new Size(158, 28);
            label7.TabIndex = 6;
            label7.Text = "cho nhân viên .....";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(312, 320);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(207, 60);
            button1.TabIndex = 5;
            button1.Text = "Phân công";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(149, 282);
            label6.Name = "label6";
            label6.Size = new Size(187, 28);
            label6.TabIndex = 4;
            label6.Text = "Phân công đề án  .....";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 45);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 45);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Đề Án";
            label4.Click += label4_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(439, 62);
            dataGridView4.Margin = new Padding(3, 2, 3, 2);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(409, 197);
            dataGridView4.TabIndex = 1;
            dataGridView4.CellClick += dataGridView4_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(5, 62);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(411, 197);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            // 
            // TruongPhongcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 458);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TruongPhongcs";
            Text = "TruongPhongcs";
            Load += TruongPhongcs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label phong;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView4;
        private Label label5;
        private Label label4;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}
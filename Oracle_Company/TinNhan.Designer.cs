namespace Oracle_Company
{
    partial class TinNhan
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
            TabControl tabControl1;
            tabPage1 = new TabPage();
            button = new Button();
            checkedListBox3 = new CheckedListBox();
            label1 = new Label();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(45, 21);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(812, 548);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button);
            tabPage1.Controls.Add(checkedListBox3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(checkedListBox2);
            tabPage1.Controls.Add(checkedListBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(804, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GỬI TIN NHẮN";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            button.BackColor = SystemColors.HotTrack;
            button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = SystemColors.ButtonHighlight;
            button.Location = new Point(304, 429);
            button.Name = "button";
            button.Size = new Size(170, 72);
            button.TabIndex = 9;
            button.Text = "SEND";
            button.UseVisualStyleBackColor = false;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "ĐỊA ĐIỂM Ở MIỀN BẮC", "ĐỊA ĐIỂM Ở MIỀN TRUNG", "ĐỊA ĐIỂM Ở MIỀN NAM" });
            checkedListBox3.Location = new Point(475, 340);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(165, 76);
            checkedListBox3.TabIndex = 8;
            checkedListBox3.SelectedIndexChanged += checkedListBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(356, 3);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 10;
            label1.Text = "TIN NHẮN";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "MUA BÁN", "SẢN XUẤT", "GIA CÔNG" });
            checkedListBox2.Location = new Point(344, 340);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(101, 76);
            checkedListBox2.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "NHÂN VIÊN", "TRƯỞNG PHÒNG", "GIÁM ĐỐC" });
            checkedListBox1.Location = new Point(170, 340);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(141, 76);
            checkedListBox1.TabIndex = 6;
            checkedListBox1.ItemCheck += checkbok1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(170, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 298);
            textBox1.TabIndex = 5;
            // 
            // TinNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 598);
            Controls.Add(tabControl1);
            Name = "TinNhan";
            Text = "TinNhan";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage1;
    }
}
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
            button = new Button();
            checkedListBox3 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button
            // 
            button.BackColor = SystemColors.HotTrack;
            button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = SystemColors.ButtonHighlight;
            button.Location = new Point(414, 445);
            button.Name = "button";
            button.Size = new Size(170, 72);
            button.TabIndex = 9;
            button.Text = "SEND";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "ĐỊA ĐIỂM Ở MIỀN BẮC", "ĐỊA ĐIỂM Ở MIỀN TRUNG", "ĐỊA ĐIỂM Ở MIỀN NAM" });
            checkedListBox3.Location = new Point(569, 331);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(165, 58);
            checkedListBox3.TabIndex = 8;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "MUA BÁN", "SẢN XUẤT", "GIA CÔNG" });
            checkedListBox2.Location = new Point(438, 331);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(86, 58);
            checkedListBox2.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "NHÂN VIÊN", "TRƯỞNG PHÒNG", "GIÁM ĐỐC" });
            checkedListBox1.Location = new Point(246, 331);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(118, 58);
            checkedListBox1.TabIndex = 6;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(246, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(488, 284);
            textBox1.TabIndex = 5;
            // 
            // TinNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 552);
            Controls.Add(button);
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            Name = "TinNhan";
            Text = "TinNhan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
    }
}
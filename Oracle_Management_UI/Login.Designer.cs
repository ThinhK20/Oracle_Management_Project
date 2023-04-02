namespace Oracle_Management_UI
{
    partial class Login
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
            loginLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            passwordLabel = new Label();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = SystemColors.MenuHighlight;
            loginLabel.Location = new Point(364, 25);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(115, 51);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(160, 132);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(136, 37);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(364, 132);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(294, 43);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(364, 232);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(294, 43);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(160, 232);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(128, 37);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.MenuHighlight;
            loginBtn.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            loginBtn.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            loginBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(323, 346);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(178, 50);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(815, 421);
            Controls.Add(loginBtn);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(loginLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private Label passwordLabel;
        private Button loginBtn;
    }
}
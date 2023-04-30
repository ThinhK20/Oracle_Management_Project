namespace Oracle_Management_UI.Components
{
    public class PromptDialog
    {
        public string Value1 { get; set; } = String.Empty;
        public string Value2 { get; set; } = String.Empty;

        public void ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, Height = 200 };
            Button confirmation = new Button() { Text = "Submit", Left = 250, Width = 80, Height = 40, Top = 100, DialogResult = DialogResult.OK };
            Button cancelBtn = new Button() { Text = "Cancel", Left = 350, Width = 80, Height = 40, Top = 100, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancelBtn.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelBtn);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                Value1 = textBox.Text;
            }
            else
            {
                Value1 = "";
            }
        }


        public void ShowDialog(string text1, string caption, string text2)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 280,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
            };
            Label textLabel1 = new Label() { Left = 50, Top = 20, Text = text1, Width = 500 };
            Label textLabel2 = new Label() { Left = 50, Top = 100, Text = text2, Width = 500 };
            TextBox textBox1 = new TextBox() { Left = 50, Top = 50, Width = 400, Height = 200 };
            TextBox textBox2 = new TextBox() { Left = 50, Top = 130, Width = 400, Height = 200 };
            Button confirmation = new Button() { Text = "Submit", Left = 250, Width = 80, Height = 40, Top = 180, DialogResult = DialogResult.OK };
            Button cancelBtn = new Button() { Text = "Cancel", Left = 350, Width = 80, Height = 40, Top = 180, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancelBtn.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox1);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelBtn);
            prompt.Controls.Add(textLabel1);
            prompt.Controls.Add(textLabel2);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                Value1 = textBox1.Text;
                Value2 = textBox2.Text;
            }
            else
            {
                Value1 = "";
                Value2 = "";
            }

        }
    }
}

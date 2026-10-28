namespace WinFormsApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameTextBox = new Label();
            textBox1 = new TextBox();
            loginButton = new Button();
            textBox2 = new TextBox();
            passWordTextBox = new Label();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.AutoSize = true;
            userNameTextBox.Location = new Point(40, 37);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(70, 20);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.Text = "نام کاربری";
            userNameTextBox.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Location = new Point(40, 164);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(336, 48);
            loginButton.TabIndex = 2;
            loginButton.Text = "ورود به پنل";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // passWordTextBox
            // 
            passWordTextBox.AutoSize = true;
            passWordTextBox.Location = new Point(49, 92);
            passWordTextBox.Name = "passWordTextBox";
            passWordTextBox.Size = new Size(61, 20);
            passWordTextBox.TabIndex = 3;
            passWordTextBox.Text = "رمز عبور";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 240);
            Controls.Add(textBox2);
            Controls.Add(passWordTextBox);
            Controls.Add(loginButton);
            Controls.Add(textBox1);
            Controls.Add(userNameTextBox);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameTextBox;
        private TextBox textBox1;
        private Button loginButton;
        private TextBox textBox2;
        private Label passWordTextBox;
    }
}

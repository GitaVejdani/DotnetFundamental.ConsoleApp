namespace WinFormsApp1
{
    partial class Form1
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
            usernameLabel = new Label();
            paswordLabel = new Label();
            loginButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(30, 70);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // paswordLabel
            // 
            paswordLabel.AutoSize = true;
            paswordLabel.Location = new Point(30, 149);
            paswordLabel.Name = "paswordLabel";
            paswordLabel.Size = new Size(87, 25);
            paswordLabel.TabIndex = 1;
            paswordLabel.Text = "Password";
            paswordLabel.Click += label2_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(221, 239);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(146, 48);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(208, 70);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(411, 31);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(208, 149);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(411, 31);
            passwordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            registerButton.DialogResult = DialogResult.Ignore;
            registerButton.Location = new Point(459, 239);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(146, 48);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 334);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(loginButton);
            Controls.Add(paswordLabel);
            Controls.Add(usernameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label paswordLabel;
        private Button loginButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
    }
}

namespace FinalProject
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
            userNameLabel = new Label();
            passwordLable = new Label();
            loginButton = new Button();
            registerButton = new Button();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(47, 35);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(91, 25);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username";
            // 
            // passwordLable
            // 
            passwordLable.AutoSize = true;
            passwordLable.Location = new Point(47, 88);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(87, 25);
            passwordLable.TabIndex = 1;
            passwordLable.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(374, 164);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(175, 47);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(374, 235);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(175, 42);
            registerButton.TabIndex = 3;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(179, 29);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(501, 31);
            userNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(179, 82);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(501, 31);
            passwordTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 310);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLable);
            Controls.Add(userNameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLable;
        private Button loginButton;
        private Button registerButton;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
    }
}

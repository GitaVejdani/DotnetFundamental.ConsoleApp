
using System.Data.SqlClient;
using System.Text;

namespace FinalProject
{
    internal class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Button saveButton;
            firstNameLable = new Label();
            lastNameLable = new Label();
            nationalCodeLable = new Label();
            fatherNameLable = new Label();
            userNameLable = new Label();
            passwordLable = new Label();
            confirmPasswordLable = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nationalCodeTextBox = new TextBox();
            fatherNameTextBox = new TextBox();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            phoneNumberLable = new Label();
            phoneNumberTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.BackColor = Color.Transparent;
            firstNameLable.Location = new Point(38, 46);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(89, 25);
            firstNameLable.TabIndex = 0;
            firstNameLable.Text = "Firstname";
            // 
            // lastNameLable
            // 
            lastNameLable.AutoSize = true;
            lastNameLable.Location = new Point(38, 120);
            lastNameLable.Name = "lastNameLable";
            lastNameLable.Size = new Size(87, 25);
            lastNameLable.TabIndex = 1;
            lastNameLable.Text = "Lastname";
            // 
            // nationalCodeLable
            // 
            nationalCodeLable.AutoSize = true;
            nationalCodeLable.Location = new Point(38, 197);
            nationalCodeLable.Name = "nationalCodeLable";
            nationalCodeLable.Size = new Size(120, 25);
            nationalCodeLable.TabIndex = 2;
            nationalCodeLable.Text = "NationalCode";
            // 
            // fatherNameLable
            // 
            fatherNameLable.AutoSize = true;
            fatherNameLable.Location = new Point(38, 280);
            fatherNameLable.Name = "fatherNameLable";
            fatherNameLable.Size = new Size(104, 25);
            fatherNameLable.TabIndex = 3;
            fatherNameLable.Text = "Fathername";
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Location = new Point(690, 126);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(91, 25);
            userNameLable.TabIndex = 4;
            userNameLable.Text = "Username";
            // 
            // passwordLable
            // 
            passwordLable.AutoSize = true;
            passwordLable.Location = new Point(690, 197);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(87, 25);
            passwordLable.TabIndex = 5;
            passwordLable.Text = "Password";
            // 
            // confirmPasswordLable
            // 
            confirmPasswordLable.AutoSize = true;
            confirmPasswordLable.Location = new Point(690, 274);
            confirmPasswordLable.Name = "confirmPasswordLable";
            confirmPasswordLable.Size = new Size(158, 25);
            confirmPasswordLable.TabIndex = 6;
            confirmPasswordLable.Text = "Confirm password";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(167, 43);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(366, 31);
            firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(167, 120);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(366, 31);
            lastNameTextBox.TabIndex = 8;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(167, 191);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(366, 31);
            nationalCodeTextBox.TabIndex = 9;
            // 
            // fatherNameTextBox
            // 
            fatherNameTextBox.Location = new Point(167, 274);
            fatherNameTextBox.Name = "fatherNameTextBox";
            fatherNameTextBox.Size = new Size(366, 31);
            fatherNameTextBox.TabIndex = 10;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(929, 114);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(366, 31);
            userNameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(929, 197);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(366, 31);
            passwordTextBox.TabIndex = 12;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(929, 268);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(366, 31);
            confirmPasswordTextBox.TabIndex = 13;
            // 
            // phoneNumberLable
            // 
            phoneNumberLable.AutoSize = true;
            phoneNumberLable.Location = new Point(690, 41);
            phoneNumberLable.Name = "phoneNumberLable";
            phoneNumberLable.Size = new Size(127, 25);
            phoneNumberLable.TabIndex = 14;
            phoneNumberLable.Text = "PhoneNumber";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(929, 38);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(366, 31);
            phoneNumberTextBox.TabIndex = 15;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1191, 343);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(104, 64);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // Form3
            // 
            ClientSize = new Size(1343, 466);
            Controls.Add(saveButton);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(phoneNumberLable);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(fatherNameTextBox);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(confirmPasswordLable);
            Controls.Add(passwordLable);
            Controls.Add(userNameLable);
            Controls.Add(fatherNameLable);
            Controls.Add(nationalCodeLable);
            Controls.Add(lastNameLable);
            Controls.Add(firstNameLable);
            Name = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();

        }
        private Label firstNameLable;
        private Label lastNameLable;
        private Label nationalCodeLable;
        private Label fatherNameLable;
        private Label userNameLable;
        private Label passwordLable;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox nationalCodeTextBox;
        private TextBox fatherNameTextBox;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
        private Label phoneNumberLable;
        private TextBox phoneNumberTextBox;
        private Button saveButton;
        private Label confirmPasswordLable;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
        string.IsNullOrWhiteSpace(nationalCodeTextBox.Text) ||
        string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
        string.IsNullOrWhiteSpace(userNameTextBox.Text) ||
        string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
        string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text)
               )
            {
                MessageBox.Show("please fill all required fields");
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password doesn't match");
                return;
            }

            string path = @"C:\Users\Public\users.txt";

            string line =
            firstNameTextBox.Text + "|" +
            lastNameTextBox.Text + "|" +
            nationalCodeTextBox.Text + "|" +
            fatherNameTextBox.Text + "|" +
            phoneNumberTextBox.Text + "|" +
            userNameTextBox.Text + "|" +
            passwordTextBox.Text + "|" +
            confirmPasswordTextBox.Text;

            File.AppendAllText(path, line + Environment.NewLine);

            MessageBox.Show("Saved Successfully");
        }
    }
}
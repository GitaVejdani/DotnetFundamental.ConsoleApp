using System.IO;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Public\users.txt"; ;

            if (!File.Exists(path))
            {
                MessageBox.Show("User database not found!");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');

                string username = data[5];
                string password = data[6];

                if (userNameTextBox.Text == username && passwordTextBox.Text == password)
                {
                    MessageBox.Show("Login successful!");
                    return;
                }
            }

            MessageBox.Show("Incorrect username or password!");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form3 registerForm = new Form3();
            registerForm.Show();
        }

        
    }
    }



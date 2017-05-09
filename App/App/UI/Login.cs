using App.Controller;
using App.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    public partial class Login : Form
    {
        Form parentForm;
        Conference activeConference;
        LoginController loginController;

        public Login(Conference activeConference, Form parentForm, LoginController loginController)
        {
            InitializeComponent();

            this.activeConference = activeConference;
            this.parentForm = parentForm;
            this.loginController = loginController;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.UserNameTextBox.Text;
            string password = this.PasswordTextBox.Text;

            User user = loginController.findByUsername(username);
            Role chairRole = new Role("Chair", "chair");

            try
            {
                loginController.areCredentialsValid(username, password);

                if (loginController.isConferenceActive() == true)
                {
                    //redirect user to phase active page;
                    this.Close();
                }
                else
                {
                    if (loginController.getUserRole(user).Contains(chairRole.Title))
                    {
                        //redirect chairs to preliminary page
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Restrict aces for non chairs");
                    }
                }
            }
            catch
            {
                MessageBox.Show("The credentials are not valid");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            parentForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

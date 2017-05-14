using App.Controller;
using App.Entity;
using App.UI;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;

            try
            {
                //TO DO
                //MODIFY THIS WITH GetUser(username, password) from login controller when is ready
                User user = new User("dummy", "dummy", "dummy", "dummy", "dummy");

                if (loginController.isConferenceActive() == true)
                {
                    //TO DO
                    //redirect user to phase active page;
                    Application.Exit();
                }
                else
                {
                    if (loginController.getUserRole(user).Contains("Chair"))
                    {
                        PreliminaryPhase preliminaryPhase = new PreliminaryPhase(user);
                        preliminaryPhase.Location = new System.Drawing.Point(Location.X, Location.Y);
                        preliminaryPhase.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("There is no active conference for the moment!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid credentials!");
            }
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

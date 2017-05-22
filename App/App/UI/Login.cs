using App.Controller;
using App.Entity;
using App.UI;
using System;
using System.Windows.Forms;

namespace App
{
    /// <summary>
    /// 
    /// Login Form
    /// Author: Dezsi Razvan
    /// 
    /// </summary>
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
            
            User user = loginController.GetUser(username, password);
            if (user == null)
            {
                MessageBox.Show("The credentials are not valid");
            }
            else
            {
                if (loginController.IsConferenceActive() == true)
                {
                    //TO DO
                    //redirect user to active phase page;
                    Application.Exit();
                }
                else
                {
                    if (loginController.GetUserRoles(user).Contains(new Role("Chair", "chair")))
                    {
                        //User is a chair and is shown the preliminary phase
                        PreliminaryPhase preliminaryPhase = new PreliminaryPhase(user);
                        preliminaryPhase.Location = new System.Drawing.Point(Location.X, Location.Y);
                        preliminaryPhase.Show();
                        Hide();
                    }
                    else
                    {
                        //User is a non-chair member and is restricted to access the website
                        MessageBox.Show("There is no active conference for the moment!");
                    }
                }
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

        private void resetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPasswordForm = new ResetPassword(this,loginController);
            resetPasswordForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            resetPasswordForm.Show();
        }
    }
}

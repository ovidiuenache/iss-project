using App.Controller;
using App.Entity;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class ConferenceDetails : Form
    {
        Conference conference;

        public ConferenceDetails()
        {
            InitializeComponent();

            //conference = cevaController.getActiveConference();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            Login loginForm = new Login(conference, this, loginController);
            loginForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            loginForm.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(this);
            registerForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            registerForm.Show();
        }

        private void ConferenceDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
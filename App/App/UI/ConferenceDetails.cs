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
            Login loginForm = new Login(conference, this);
            loginForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            loginForm.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(conference, this);
            registerForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            registerForm.Show();
        }
    }
}
using App.Controller;
using App.Entity;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class ConferenceDetails : Form
    {
        Conference conference;
        LoginController loginController;
        PreliminaryPhaseController preliminaryController;

        public ConferenceDetails(LoginController loginController, PreliminaryPhaseController preliminaryController)
        {
            InitializeComponent();

            this.loginController = loginController;
            this.preliminaryController = preliminaryController;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(conference, this, loginController);
            loginForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            loginForm.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(this, preliminaryController);
            registerForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            registerForm.Show();
        }

        private void ConferenceDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
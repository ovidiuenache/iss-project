using System;
using System.Windows.Forms;

namespace App
{
    /// <summary>
    /// Author: Ioan Ovidiu Enache
    /// </summary>
    public partial class ConferenceDetails : Form
    {
        private Form loginChild;
        private Form registerChild;

        public ConferenceDetails()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (loginChild == null)
            {
                loginChild = new Login(this);
            }

            loginChild.Location = new System.Drawing.Point(Location.X, Location.Y);
            loginChild.Show();
            Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (registerChild == null)
            {
                registerChild = new Register(this);
            }

            registerChild.Location = new System.Drawing.Point(Location.X, Location.Y);
            registerChild.Show();
            Hide();
        }

        private void ConferenceDetails_Load(object sender, EventArgs e)
        {
        }
    }
}
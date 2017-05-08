using App.Entity;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Register : Form
    {
        Form parentForm;
        Conference activeConference;

        public Register(Conference activeConference, Form parentForm)
        {
            InitializeComponent();

            this.activeConference = activeConference;
            this.parentForm = parentForm;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            parentForm.Show();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
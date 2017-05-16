using App.Entity;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Login : Form
    {
        Form parentForm;
        Conference activeConference;

        public Login(Conference activeConference, Form parentForm)
        {
            InitializeComponent();

            this.activeConference = activeConference;
            this.parentForm = parentForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

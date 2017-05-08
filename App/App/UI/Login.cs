using App.Controller;
using App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    /// <summary>
    /// Class Login
    /// Author: Vancea Vlad
    /// </summary>
    public partial class Login : Form
    {
        LoginController controllerLogin;
        public Login(LoginController controllerLogin)
        {
            InitializeComponent();
            this.controllerLogin = controllerLogin;
       
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

            User user = controllerLogin.findByUsername(username);
            Role chairRole = new Role("Chair", "chair");

            try
            {
                controllerLogin.areCredentialsValid(username, password);

                if (controllerLogin.isConferenceActive() == true)
                {
                    //redirect user to phase active page;
                    this.Close();
                }
                else
                {
                    if (controllerLogin.getUserRole(user).Contains(chairRole.Title))
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
    }
}

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
    public partial class Login : Form
    {
        ControllerServiceLogin controllerLogin;
        public Login(ControllerServiceLogin controllerLogin)
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
            string userName = this.UserNameTextBox.Text;
            string password = this.PasswordTextBox.Text;

            User user = controllerLogin.findByUsername(userName);
            Role chairRole = new Role("Chair", "chair");

            if (!userName.Equals("") && !password.Equals(""))
            {
                if (controllerLogin.areCredentialsValid(userName,password) == true)
                {
                    if(controllerLogin.getRoleOfUser(user).Contains(chairRole.Title))
                    {
                        if (controllerLogin.isConferenceActive()==true)
                        {
                            //redirect user to phase1 page;
                            this.Close();
                        }
                        else
                        {
                            //redirect chairs to prelimianry page
                            this.Close();
                        }
                    }
                    else                    
                        if (controllerLogin.isConferenceActive() == false)                        
                            MessageBox.Show("Restrict acces", "This conference is not active");                       
                }
                else
                    MessageBox.Show("The data are not valid");                
            }
            else
                MessageBox.Show("The textboxes can not be empty");
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

using App.Controller;
using App.Entity;
using App.UI;
using System;
using System.Windows.Forms;
using System.Linq;
using App.Factory;
using App.UI.PhaseThree;
using App.UI.PhaseTwo;
using ListenerMain = App.UI.PhaseTwo.ListenerMain;

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
        private LoginController loginController;
        private Form parentForm;

        public Login(Form parentForm)
        {
            InitializeComponent();

            loginController = ApplicationFactory.getLoginController();
            this.parentForm = parentForm;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;

            User loggedUser = loginController.GetUser(username, password);
            if (loggedUser == null)
            {
                MessageBox.Show("The credentials are not valid");
            }
            else
            {
                if (loginController.IsConferenceActive() == true)
                {
                    string activePhaseName = loginController.ActiveConference().ActivePhase.Name;
                    Form toBeShown = null;
                    switch (activePhaseName)
                    {
                        case "PRELIMINARY":
                            if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("chair") ||
                                loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("reviewer"))
                            {
                                toBeShown = new PreliminaryPhase(this, loggedUser);
                            }
                            else
                            {
                                //User is a non-chair member and is restricted to access the website
                                MessageBox.Show("The conference is yet in preliminary phase!\nPlease wait until the set up is complete!");
                                return;
                            }
                            break;
                        case "PHASEONE":
                            toBeShown = new UserAccount(this, loggedUser);
                            break;
                        case "PHASETWO":
                            if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("chair"))
                            {
                                toBeShown = new ChairMain(this, loggedUser);
                            }
                            else if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("reviewer"))
                            {
                                toBeShown = new PCMemberMain(this, loggedUser);
                            }
                            else if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("author")
                                || loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("speaker"))
                            {
                                toBeShown = new AuthorMain(this, loggedUser);
                            }
                            else if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("listner"))
                            {
                                toBeShown = new ListenerMain(this, loggedUser);
                            }
                            break;
                        case "PHASETHREE":
                            if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("listner"))
                            {
                                toBeShown = new UI.PhaseThree.ListenerMain(this, loggedUser);
                            }
                            else if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("chair"))
                            {
                                toBeShown = new RoomsDistribution(this);
                            }
                            else
                            {
                                MessageBox.Show("Conference is current commencing", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                    }
                    if (toBeShown != null)
                    {
                        toBeShown.Location = new System.Drawing.Point(Location.X, Location.Y);
                        toBeShown.Show();
                        Hide();
                    }
                }
                else
                {
                    if (loginController.GetUserRoles(loggedUser).Select(role => role.Slug).ToArray().Contains("chair"))
                    {
                        //User is a chair and is shown the preliminary phase
                        PreliminaryPhase preliminaryPhase = new PreliminaryPhase(this, loggedUser);
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
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = LoginButton;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetPassword resetPasswordForm = new ResetPassword(this, loginController);
            resetPasswordForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            resetPasswordForm.Show();
        }
    }
}

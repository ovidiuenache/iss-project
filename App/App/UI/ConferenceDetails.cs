using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Windows.Forms;

namespace App
{
    /// <summary>
    /// Author: Ioan Ovidiu Enache
    /// </summary>
    public partial class ConferenceDetails : Form
    {
        private Conference activeConference;

        public ConferenceDetails()
        {
            InitializeComponent();
            PreliminaryPhaseController preliminaryController = ApplicationFactory.getPreliminaryPhaseController();

            activeConference = preliminaryController.ActiveConference();
            if (activeConference == null)
            {
                richTextBox1.Text = "Currently, there is no active conference!";
            }
            else
            {
                richTextBox1.Text = "Conference details:\n\n";
                richTextBox1.Text += "Conference name: " + activeConference.Name + "\n\n";
                richTextBox1.Text += "Conference fee: " + activeConference.ConferenceFee + "\n\n";
                richTextBox1.Text += "Conference commitee:\n";

                foreach (ConferenceUser confUser in activeConference.Users)
                {
                    User user = preliminaryController.FindUserById(confUser.UserId);
                    richTextBox1.Text += user.LastName + " " + user.FirstName + "\n";
                }

                richTextBox1.Text += "Conference topics:\n";

                foreach (Topic topic in activeConference.Topics)
                {
                    richTextBox1.Text += topic.Name + "\n";
                }

                switch (activeConference.ActivePhase.Name)
                {
                    case "PRELIMINARY":
                        richTextBox1.Text += "Conference is currently in PRELIMINARY phase!";
                        richTextBox1.Text += "Deadline for this phase: " + activeConference.ActivePhase.Deadline.ToString() + "\n";
                        break;
                    case "PHASEONE":
                        richTextBox1.Text += "Conference is currently in PRELIMINARY phase!";
                        richTextBox1.Text += "Deadline for this phase: " + activeConference.ActivePhase.Deadline.ToString() + "\n";
                        break;
                    case "PHASETWO":
                        richTextBox1.Text += "Conference is currently in PRELIMINARY phase!";
                        richTextBox1.Text += "Deadline for this phase: " + activeConference.ActivePhase.Deadline.ToString() + "\n";
                        break;
                    case "PHASETHREE":
                        richTextBox1.Text += "Conference is currently in PRELIMINARY phase!";
                        richTextBox1.Text += "Deadline for this phase: " + activeConference.ActivePhase.Deadline.ToString() + "\n";
                        break;
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form loginChild = new Login(this);

            loginChild.Location = new System.Drawing.Point(Location.X, Location.Y);
            loginChild.Show();
            Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Form registerChild = new Register(this);

            registerChild.Location = new System.Drawing.Point(Location.X, Location.Y);
            registerChild.Show();
            Hide();
        }

        private void ConferenceDetails_Load(object sender, EventArgs e)
        {
        }
    }
}
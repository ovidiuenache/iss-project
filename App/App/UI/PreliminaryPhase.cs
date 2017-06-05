using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Windows.Forms;

namespace App.UI
{
    /// <summary>
    /// 
    /// Class Conference
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public partial class PreliminaryPhase : Form
    {
        private PreliminaryPhaseController preliminaryController;
        private User loggedUser;
        private Form parentForm;

        public PreliminaryPhase(Form parentForm, User loggedUser)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;
            this.parentForm = parentForm;
            preliminaryController = ApplicationFactory.getPreliminaryPhaseController();

            updateStatus();
        }

        private void Preliminary_Load(object sender, EventArgs e)
        {
        }

        public void updateStatus()
        {
            Conference conference = preliminaryController.ActiveConference();
            if (conference == null)
            {
                Size = new System.Drawing.Size(347, 194);
                buttonCreateConference.Visible = true;
                labelConferenceDetails.Text = "No conference has been created!";
            }
            else
            {
                Size = new System.Drawing.Size(347, 262);
                buttonUpdateConference.Visible = true;
                buttonStartConference.Visible = true;
                labelConferenceDetails.Text = "A conference has been created is waiting to be submitted!";
            }

            labelWelcome.Text = "Welcome " + loggedUser.LastName + " " + loggedUser.FirstName;
        }

        private void buttonUpdateConference_Click(object sender, EventArgs e)
        {
            Form updateConferenceUI = new UpdateConference(this, Location.X, Location.Y);

            updateConferenceUI.Location = Location;
            updateConferenceUI.Show();
            Hide();
        }

        private void buttonCreateConference_Click(object sender, EventArgs e)
        {
            Form createConferenceUI = new CreateConference(this, Location.X, Location.Y);

            createConferenceUI.Location = Location;
            createConferenceUI.Show();
            Hide();
        }

        private void PreliminaryPhase_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
        }

        private void buttonStartConference_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to start the conference?", "Start Conference", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Conference activeConference = preliminaryController.ActiveConference();

                Phase nextPhase = new Phase();
                nextPhase.Deadline = activeConference.EndDate;
                nextPhase.Name = "PHASEONE";

                activeConference.ActivePhase = nextPhase;

                preliminaryController.UpdateConference(activeConference);

                MessageBox.Show("Conference has successfully started!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
            Close();
        }
    }
}

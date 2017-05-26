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
        private CreateConference createConferenceUI;
        private UpdateConference updateConferenceUI;
        private PreliminaryPhaseController preliminaryController;
        private User loggedUser;

        public PreliminaryPhase(User loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            preliminaryController = ApplicationFactory.getPreliminaryPhaseController();

            //TO DO!!!
            //GET HERE THE ACTIVE CONFERENCE
            Conference conference = new Conference();
            if (conference.ActivePhase == null)
            {
                buttonCreateConference.Visible = true;
                labelConferenceDetails.Text = "No conference has been created!";
            }
            else
            {
                buttonUpdateConference.Visible = true;
                labelConferenceDetails.Text = "A conference has been created is waiting to be submitted!";
            }

            labelWelcome.Text = "Welcome " + loggedUser.LastName + " " + loggedUser.FirstName;
        }

        private void Preliminary_Load(object sender, EventArgs e)
        {
        }

        private void buttonUpdateConference_Click(object sender, EventArgs e)
        {
            if (updateConferenceUI == null)
            {
                updateConferenceUI = new UpdateConference(this, Location.X, Location.Y);
            }

            updateConferenceUI.Location = Location;
            updateConferenceUI.Show();
            Hide();
        }

        private void buttonCreateConference_Click(object sender, EventArgs e)
        {
            if (createConferenceUI == null)
            {
                createConferenceUI = new CreateConference(this, Location.X, Location.Y);
            }

            createConferenceUI.Location = Location;
            createConferenceUI.Show();
            Hide();
        }
    }
}

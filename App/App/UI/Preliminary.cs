using App.Entity;
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
    public partial class Preliminary : Form
    {
        CreateConferenceUI createConferenceUI;
        UpdateConferenceUI updateConferenceUI;
        IUser loggedUser;

        public Preliminary(IUser loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;

            //TO DO: CHANGE THIS WITH A QUERY TO DATABASE TO GET THE ACTIVE CONFERENCE
            //OR SEND THE CONFERENCE VIA CONSTRUCTOR FROM INITIAL PAGE
            Conference conference = new Conference();
            if (conference.getActivePhase() == null)
            {
                buttonCreateConference.Visible = true;
                labelConferenceDetails.Text = "No conference has been created!";
            }
            else
            {
                buttonUpdateConference.Visible = true;
                labelConferenceDetails.Text = "A conference has been created is waiting to be submitted!";
            }

            labelWelcome.Text = "Welcome " + loggedUser.getLastName() + " " + loggedUser.getFirstName();
        }

        private void Preliminary_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdateConference_Click(object sender, EventArgs e)
        {
            if(updateConferenceUI == null)
            {
                updateConferenceUI = new UpdateConferenceUI(this, Location.X, Location.Y);
            }

            updateConferenceUI.Location = Location;
            updateConferenceUI.Show();
            Hide();
        }

        private void buttonCreateConference_Click(object sender, EventArgs e)
        {
            if (createConferenceUI == null)
            {
                createConferenceUI = new CreateConferenceUI(this, Location.X, Location.Y);
            }

            createConferenceUI.Location = Location;
            createConferenceUI.Show();
            Hide();
        }
    }
}

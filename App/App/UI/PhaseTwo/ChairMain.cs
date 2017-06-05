using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author: Andu Popa
    /// Author: Ioan Ovidiu Enache
    /// </summary>
    public partial class ChairMain : Form
    {
        private PhaseTwoController phaseTwoController;
        private Form parentForm;
        private User loggedUser;

        public ChairMain(Form parentForm, User loggedUser)
        {
            phaseTwoController = ApplicationFactory.getPhaseTwoController();
            this.parentForm = parentForm;
            this.loggedUser = loggedUser;

            InitializeComponent();
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            ChairToAcceptedAuthors sendMailView = new ChairToAcceptedAuthors(this);
            sendMailView.Location = new System.Drawing.Point(Location.X, Location.Y);
            sendMailView.Show();
            Hide();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            ChairAssignementToReviewer assignmentView = new ChairAssignementToReviewer(this);
            assignmentView.Location = new System.Drawing.Point(Location.X, Location.Y);
            assignmentView.Show();
            Hide();
        }

        private void ChairMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to end this phase and start the next one?", "Start Next Phase", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Conference activeConference = phaseTwoController.ActiveConference();

                Phase nextPhase = new Phase();
                nextPhase.Deadline = activeConference.EndDate;
                nextPhase.Name = "PHASETHREE";

                activeConference.ActivePhase = nextPhase;

                phaseTwoController.UpdateConference(activeConference);
                phaseTwoController.deleteRejectedProposals();

                MessageBox.Show("Switch to the next phase has been done successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ChairMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            phaseTwoController.saveChanges();
        }
    }
}

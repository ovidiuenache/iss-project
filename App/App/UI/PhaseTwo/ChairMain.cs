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
            phaseTwoController = ApplicationFactory.GetPhaseTwoController();
            this.parentForm = parentForm;
            this.loggedUser = loggedUser;

            InitializeComponent();
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            var sendMailView = new ChairToAcceptedAuthors(this);
            sendMailView.Location = new System.Drawing.Point(Location.X, Location.Y);
            sendMailView.Show();
            Hide();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            var assignmentView = new ChairAssignementToReviewer(this);
            assignmentView.Location = new System.Drawing.Point(Location.X, Location.Y);
            assignmentView.Show();
            Hide();
        }

        private void ChairMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to end this phase and start the next one?", "Start Next Phase", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var activeConference = phaseTwoController.ActiveConference();

                var nextPhase = new Phase();
                nextPhase.Deadline = activeConference.EndDate;
                nextPhase.Name = "PHASETHREE";

                activeConference.ActivePhase = nextPhase;

                phaseTwoController.UpdateConference(activeConference);
                phaseTwoController.DeleteRejectedProposals();

                MessageBox.Show("Switch to the next phase has been done successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
                parentForm.Show();
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
        }
    }
}

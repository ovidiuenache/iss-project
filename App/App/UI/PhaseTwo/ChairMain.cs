using App.Controller;
using System;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author: Andu Popa
    /// </summary>
    public partial class ChairMain : Form
    {
        private PhaseTwoController phaseTwoController;
        public ChairMain(PhaseTwoController phaseTwoController)
        {
            this.phaseTwoController = phaseTwoController;
            InitializeComponent();
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            ChairToAcceptedAuthors sendMailView = new ChairToAcceptedAuthors(this,phaseTwoController, phaseTwoController.getMailSender);
            this.Hide();
            sendMailView.SetDesktopLocation(this.Location.X, this.Location.Y);
            sendMailView.Show();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            ChairAssignementToReviewer assignmentView = new ChairAssignementToReviewer(this,phaseTwoController);
            this.Hide();
            assignmentView.SetDesktopLocation(this.Location.X, this.Location.Y);
            assignmentView.Show();
        }
    }
}

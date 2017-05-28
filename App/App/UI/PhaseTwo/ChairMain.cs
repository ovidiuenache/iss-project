using App.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
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
            ChairToAcceptedAuthors sendMailView = new ChairToAcceptedAuthors(phaseTwoController, phaseTwoController.getMailSender);
            sendMailView.Show();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            ChairAssignementToReviewer assignmentView = new ChairAssignementToReviewer(phaseTwoController);
            assignmentView.Show();
        }
    }
}

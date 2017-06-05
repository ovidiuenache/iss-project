using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author: Andu Popa
    /// </summary>
    public partial class PCMemberMain : Form
    {
        private User reviewer;
        private PhaseTwoController phaseTwoController;
        private Form parentForm;

        public PCMemberMain(Form parentForm, User reviewer)
        {
            phaseTwoController = ApplicationFactory.GetPhaseTwoController();
            this.reviewer = reviewer;
            this.parentForm = parentForm;

            InitializeComponent();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            PCMemberRateProposals rateView = new PCMemberRateProposals(this, phaseTwoController.GetReviewsByIdReviewer(reviewer.UserId), reviewer, phaseTwoController);
            this.Hide();
            rateView.SetDesktopLocation(this.Location.X, this.Location.Y);
            rateView.Show();
        }

        private void buttonRefreshReviews_Click(object sender, EventArgs e)
        {
            if (phaseTwoController.GetReviewsByIdReviewer(reviewer.UserId).Count > 0)
            {
                InitRatingsGridView();
            }
        }

        private void InitRatingsGridView()
        {
            var bindingList = new BindingList<Review>(phaseTwoController.GetReviewsByIdReviewer(reviewer.UserId));
            var source = new BindingSource(bindingList, null);
            ratingsGridView.DataSource = source;
        }

        private void bidButton_Click(object sender, EventArgs e)
        {
            var bidView = new PCMemberBidProposals(this, phaseTwoController, reviewer);
            this.Hide();
            bidView.SetDesktopLocation(this.Location.X, this.Location.Y);
            bidView.Show();
        }

        private void PCMemberMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Location = new Point(Location.X, Location.Y);
            parentForm.Show();
            Close();
        }

        private void PCMemberMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

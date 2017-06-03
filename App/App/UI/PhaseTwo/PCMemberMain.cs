using App.Controller;
using App.Entity;
using App.Factory;
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
            phaseTwoController = ApplicationFactory.getPhaseTwoController();
            this.reviewer = reviewer;
            this.parentForm = parentForm;

            InitializeComponent();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            PCMemberRateProposals rateView = new PCMemberRateProposals(this,phaseTwoController.getReviewsByIdReviewer(reviewer.UserId), reviewer, phaseTwoController);
            this.Hide();
            rateView.SetDesktopLocation(this.Location.X,this.Location.Y);
            rateView.Show();
        }

        private void buttonRefreshReviews_Click(object sender, EventArgs e)
        {
            if(phaseTwoController.getReviewsByIdReviewer(reviewer.UserId).Count > 0)
            {
                initRatingsGridView();
            }
        }

        private void initRatingsGridView()
        {
            BindingList<Review> bindingList = new BindingList<Review>(phaseTwoController.getReviewsByIdReviewer(reviewer.UserId));
            BindingSource source = new BindingSource(bindingList, null);
            ratingsGridView.DataSource = source;
        }

        private void bidButton_Click(object sender, EventArgs e)
        {
            PCMemberBidProposals bidView = new PCMemberBidProposals(this,phaseTwoController, reviewer);
            this.Hide();
            bidView.SetDesktopLocation(this.Location.X,this.Location.Y);
            bidView.Show();
        }

        private void PCMemberMain_Load(object sender, EventArgs e)
        {

        }
    }
}

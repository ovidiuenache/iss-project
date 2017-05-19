using App.Entity;
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
    public partial class PCMemberMain : Form
    {

        private User reviewer;
        private ReviewController reviewController;
        private ProposalController proposalController;

        public PCMemberMain(ReviewController reviewController, ProposalController proposalController, User reviewer)
        {
            this.reviewController = reviewController;
            this.proposalController = proposalController;
            this.reviewer = reviewer;
            InitializeComponent();
        }

        /// <summary>
        /// Author: Andu Popa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rateButton_Click(object sender, EventArgs e)
        {
            PCMemberRateProposals rateView = new PCMemberRateProposals(proposalController.findByIdUser(reviewer.UserId), reviewer);
            rateView.Show();
        }
        /// <summary>
        /// Author: Andu Popa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshReviews_Click(object sender, EventArgs e)
        {
            if(reviewController.findByIdUser(reviewer.UserId).Count > 0)
            {
                initRatingsGridView();
            }
        }
        /// <summary>
        /// Author: Andu Popa
        /// </summary>
        private void initRatingsGridView()
        {
            BindingList<Review> bindingList = new BindingList<Review>(reviewController.findByIdUser(reviewer.UserId));
            BindingSource source = new BindingSource(bindingList, null);
            ratingsGridView.DataSource = source;
        }
    }
}

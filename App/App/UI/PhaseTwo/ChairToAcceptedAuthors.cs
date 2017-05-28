using App.Controller;
using App.Entity;
using App.Utils;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

/// <summary>
/// Author : Diana Gociu
/// </summary>

namespace App.UI.PhaseTwo
{
    public partial class ChairToAcceptedAuthors : Form
    {
        private PhaseTwoController phaseTwoController;
        private MailSender mailSender;
        public ChairToAcceptedAuthors(PhaseTwoController phaseTwoController,MailSender mailSender)
        {
            this.phaseTwoController = phaseTwoController;
            this.mailSender = new MailSender();
            InitializeComponent();
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            List<Proposal> proposals;
            List<Review> reviews;
            ProposalMetaInformation mIProposal;
            List<User> authors = new List<User>();
            

            proposals = phaseTwoController.getAllProposals();
            foreach(Proposal proposal in proposals)
            {
                String result = "";
                reviews = phaseTwoController.getReviewsByProposalId(proposal.ProposalId);
                foreach(Review review in reviews)
                {
                    result += review.Qualifier + " " + review.Comment;
                }
                mIProposal = proposal.MetaInformation;
                foreach(User author in mIProposal.Authors)
                {
                    authors.Add(author);
                }
                foreach(User author in authors)
                {
                    MailAddress senderM = new MailAddress("iss.cmsmailer@gmail.com");
                    MailAddress receiver = new MailAddress(author.Email);
                    string mailBody = "Thank you for your application. \n Here are your results: \n" + result;                    
                    string mailSubject = "Proposal Review";
                    mailSender.sendMail(senderM, receiver, mailBody, mailSubject);
                }
            }
        }
    }
}

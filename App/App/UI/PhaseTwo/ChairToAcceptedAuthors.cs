using App.Controller;
using App.Entity;
using App.Factory;
using App.Utils;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author : Diana Gociu
    /// </summary>
    public partial class ChairToAcceptedAuthors : Form
    {
        private ChairMain parent;
        private PhaseTwoController phaseTwoController;
        private MailSender mailSender;

        public ChairToAcceptedAuthors(ChairMain parent)
        {
            this.parent = parent;
            phaseTwoController = ApplicationFactory.GetPhaseTwoController();
            mailSender = new MailSender();
            InitializeComponent();
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            List<Proposal> proposals;
            List<Review> reviews;
            var authors = new List<User>();


            proposals = phaseTwoController.GetProposals();
            foreach (var proposal in proposals)
            {
                var result = "";
                reviews = phaseTwoController.GetReviewsByProposalId(proposal.ProposalId);
                foreach (var review in reviews)
                {
                    result += review.Qualifier + " " + review.Comment;
                }

                foreach (var author in proposal.Authors)
                {
                    authors.Add(author);
                }
                foreach (var author in authors)
                {
                    var senderM = new MailAddress("iss.cmsmailer@gmail.com");
                    var receiver = new MailAddress(author.Email);
                    var mailBody = "Thank you for your application. \n Here are your results: \n" + result;
                    var mailSubject = "Proposal Review";
                    mailSender.SendMail(receiver, mailBody, mailSubject);
                }
            }

            MessageBox.Show("Mails have been sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChairToAcceptedAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = new System.Drawing.Point(Location.X, Location.Y);
            parent.Show();
            Close();
        }

        private void ChairToAcceptedAuthors_Load(object sender, EventArgs e)
        {

        }
    }
}

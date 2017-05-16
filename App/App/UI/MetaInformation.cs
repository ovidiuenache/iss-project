using App.Controller;
using App.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.UI
{
    /// <summary>
    /// Author: Alexandru Popa 
    /// </summary>
    public partial class MetaInformation : Form
    {
        private Proposal proposal;
        private PhaseOneController controller;
        private bool fullPaper;
        private string paperLink;
        
        public MetaInformation(Proposal proposal, PhaseOneController controller, bool fullPaper, string paperLink)
        {
            InitializeComponent();
            this.proposal = proposal;
            this.controller = controller;
            this.fullPaper = fullPaper;
            this.paperLink = paperLink;
            if (this.proposal != null)
            {
                textBoxName.Text = proposal.MetaInformation.Title;
                textBoxKeywords.Text = proposal.MetaInformation.Description;
                textBoxTopics.Text = proposal.MetaInformation.Description;
                string authorsNames = "";
                foreach (User us in proposal.MetaInformation.Authors)
                {
                    authorsNames += us.FirstName + " " + us.LastName;
                }
                textBoxAuthors.Text = authorsNames;
                dateTimePickerAnPublicare.Value = DateTime.Parse(proposal.MetaInformation.Year.ToString("yyyyMMdd"));
            }
            else
            {
                textBoxName.Text = "";
                textBoxKeywords.Text = "";
                textBoxTopics.Text = "";
                textBoxAuthors.Text = "";
                dateTimePickerAnPublicare.Value = DateTime.Now;
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(proposal == null)
            {
                proposal.MetaInformation = new ProposalMetaInformation();
                proposal.MetaInformation.Title = textBoxName.Text;
                proposal.MetaInformation.Year = int.Parse(dateTimePickerAnPublicare.Value.ToString("yyyyMMdd"));
                proposal.MetaInformation.Description = textBoxKeywords.Text;
                List<User> authors = new List<User>();
                string[] authorsNames = textBoxAuthors.Text.Split(',');
                for(int i=0; i<authorsNames.Length;i++)
                {
                    authors.Add(controller.getUserByName(authorsNames[i]));
                }
                proposal.MetaInformation.Authors = authors;
                if (!fullPaper)
                {
                    proposal.AbstractPaper = paperLink;
                }
                else
                {
                    proposal.FullPaper = paperLink;
                }
            }
            else
            {
                if (!fullPaper)
                {
                    proposal.AbstractPaper = paperLink;
                }
                else
                {
                    proposal.FullPaper = paperLink;
                }
            }
            controller.updateProposal(proposal);
        }



    }

    
}

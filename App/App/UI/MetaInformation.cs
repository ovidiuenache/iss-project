using App.Controller;
using App.Entity;
using App.Factory;
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
        
        public MetaInformation(Proposal proposal, bool fullPaper, string paperLink)
        {
            InitializeComponent();

            controller = ApplicationFactory.getPhaseOneController();
            this.proposal = proposal;
            this.fullPaper = fullPaper;
            this.paperLink = paperLink;
            if (this.proposal != null)
            {
                textBoxName.Text = proposal.Title;
                textBoxKeywords.Text = proposal.Description;
                string authorsNames = "";
                foreach (User us in proposal.Authors)
                {
                    authorsNames += us.FirstName + " " + us.LastName;
                }
                textBoxAuthors.Text = authorsNames;
                dateTimePickerAnPublicare.Value = new DateTime(proposal.Year);
            }
            else
            {
                textBoxName.Text = "";
                textBoxKeywords.Text = "";
                textBoxAuthors.Text = "";
                dateTimePickerAnPublicare.Value = DateTime.Now;
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(proposal == null)
            {
                proposal = new Proposal();
                proposal.Title = textBoxName.Text;
                proposal.Year = int.Parse(dateTimePickerAnPublicare.Value.ToString("yyyyMMdd"));
                proposal.Description = textBoxKeywords.Text;

                //TO DO
                //CHANGE THIS TO THE MULTIPLE SELECTION COMBOBOX
                List<User> authors = new List<User>();
                string[] authorsNames = textBoxAuthors.Text.Split(',');
                for(int i=0; i<authorsNames.Length;i++)
                {
                    //authors.Add(controller.getUserByName(authorsNames[i]));
                }
                proposal.Authors = authors;

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

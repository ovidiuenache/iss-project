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

namespace App.UI
{
    /// <summary>
    /// Author: Alexandru Popa 
    /// </summary>
    public partial class MetaInformation : Form
    {

        private Proposal proposal;
        private ProposalController controller;
        private bool fullPaper;
        private string paperLink;
        
        public MetaInformation(Proposal proposal, ProposalController controller, bool fullPaper, string paperLink)
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
            }
            else
            {
                textBoxName.Text = "";
                textBoxKeywords.Text = "";
                textBoxTopics.Text = "";
                textBoxAuthors.Text = "";
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(proposal == null)
            {
                proposal.MetaInformation = new ProposalMetaInformation();
                proposal.MetaInformation.Title = textBoxName.Text;
                proposal.MetaInformation.Year = DateTime.Now.Year;
                proposal.MetaInformation.Description = textBoxKeywords.Text;
                List<User> authors = new List<User>();
                string[] authorsNames = textBoxAuthors.Text.Split(',');
                for(int i=0; i<authorsNames.Length;i++)
                {
                    authors.Add(UserController.getUserByName(authorsNames[i])); //vom avea un getUserByName/getUserByName static dupa un nume complet(firstName + lastName)
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

    internal class UserController
    {
        internal static User getUserByName(string v)
        {
            MessageBox.Show("User found");
            return null;
        }
    }

    public class ProposalController
    {
        public void updateProposal(Proposal proposal)
        {
            MessageBox.Show("Update made");
        }

        public Proposal getProposal(int v)
        {
            MessageBox.Show("Proposal found");
            return null;
        }


    }
}

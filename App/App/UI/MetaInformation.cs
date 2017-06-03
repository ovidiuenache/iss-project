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
            loadAuthors();
            if (this.proposal != null)
            {

                textBoxName.Text = proposal.Title;
                textBoxKeywords.Text = proposal.Description;
                
                foreach (User us in proposal.Authors)
                {
                    for (int i = 0; i < comboBoxAuthors.Items.Count; i++)
                    {
                        if (us.UserId == ((User)comboBoxAuthors.Items[i]).UserId)
                        {
                            comboBoxAuthors.SetItemChecked(i, true);
                        }
                    }
                }
                
                dateTimePickerAnPublicare.Value = new DateTime(proposal.Year);
            }
            else
            {
                textBoxName.Text = "";
                textBoxKeywords.Text = "";
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
                for (int i = 0; i < comboBoxAuthors.Items.Count; i++)
                {
                    if (comboBoxAuthors.GetItemChecked(i))
                    {
                        authors.Add((User)comboBoxAuthors.Items[i]);
                    }
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

        private void loadAuthors()
        {

            List<User> users = controller.getAllUsers();
            foreach (User user in users)
            {
                comboBoxAuthors.Items.Add(user);
            }

            // If more then 5 items, add a scroll bar to the dropdown.
            comboBoxAuthors.MaxDropDownItems = 5;
            // Make the "Name" property the one to display
            comboBoxAuthors.DisplayMember = "LastName";
            comboBoxAuthors.ValueSeparator = ", ";
        }



    }

    
}

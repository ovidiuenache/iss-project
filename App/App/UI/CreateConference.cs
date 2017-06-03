using App.Controller;
using App.Entity;
using App.Factory;
using App.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace App.UI
{
    /// <summary>
    /// 
    /// Class Conference
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public partial class CreateConference : Form
    {
        private PreliminaryPhase parent;
        private PreliminaryPhaseController preliminaryController;
        private ConferenceValidator validator;

        public CreateConference(PreliminaryPhase parent, int positionX, int positionY)
        {
            InitializeComponent();
            Location = new Point(positionX, positionY);
            this.parent = parent;
            preliminaryController = ApplicationFactory.getPreliminaryPhaseController();
            validator = new ConferenceValidator();
        }

        private void CreateConferenceUI_Load(object sender, EventArgs e)
        {
            loadUsers();
            loadTopics();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string conferenceName = textBoxName.Text;
            DateTime endDate = dateTimePicker.Value;
            List<User> commiteeMembers = new List<User>();
            for (int i = 0; i < comboBoxCheckedListCreate.Items.Count; i++)
            {
                if (comboBoxCheckedListCreate.GetItemChecked(i))
                {
                    commiteeMembers.Add((User)comboBoxCheckedListCreate.Items[i]);
                }
            }
       
            List<Topic> selectedTopics = new List<Topic>();
            foreach (int i in listBoxTopics.SelectedIndices)
            {
                string topicName = listBoxTopics.Items[i].ToString();
                selectedTopics.Add(preliminaryController.FindTopicByName(topicName));
            }
            string fee = textBoxFee.Text;

            try
            {
                Conference conference = new Conference();
                conference.Name = conferenceName;
                conference.EndDate = endDate;
                conference.Topics = selectedTopics;
                conference.ConferenceFee = float.Parse(fee);
                validator.validate(conference);

                Phase preliminaryPhase = new Phase();
                preliminaryPhase.Name = "PRELIMINARY";
                preliminaryPhase.Deadline = endDate;
                preliminaryController.CreatePhase(preliminaryPhase);

                conference.StartDate = DateTime.Now;
                conference.ActivePhase = preliminaryPhase;

                preliminaryController.CreateConference(conference, commiteeMembers);
                MessageBox.Show("Conference has been successfully created!\nYou can update it in the \"Update Conference\" section!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            parent.Location = new Point(Location.X, Location.Y);
            parent.updateStatus();
            parent.Show();
        }

        private void loadUsers()
        {
            List<User> users = preliminaryController.FindAllUsers();

            foreach (User user in users)
            {
                comboBoxCheckedListCreate.Items.Add(user);
            }

            // If more then 5 items, add a scroll bar to the dropdown.
            comboBoxCheckedListCreate.MaxDropDownItems = 5;
            // Make the "Name" property the one to display
            comboBoxCheckedListCreate.DisplayMember = "LastName";
            comboBoxCheckedListCreate.ValueSeparator = ", ";
        }

        private void loadTopics()
        {
            List<Topic> topics = preliminaryController.FindAllTopics();

            foreach (Topic topic in topics)
            {
                listBoxTopics.Items.Add(topic.Name);
            }
        }
    }
}

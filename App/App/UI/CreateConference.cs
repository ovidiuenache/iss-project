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
            preliminaryController = ApplicationFactory.GetPreliminaryPhaseController();
            validator = new ConferenceValidator();
        }

        private void CreateConferenceUI_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadTopics();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var conferenceName = textBoxName.Text;
            var endDate = dateTimePicker.Value;
            var commiteeMembers = new List<User>();
            for (int i = 0; i < comboBoxCheckedListCreate.Items.Count; i++)
            {
                if (comboBoxCheckedListCreate.GetItemChecked(i))
                {
                    commiteeMembers.Add((User)comboBoxCheckedListCreate.Items[i]);
                }
            }

            var selectedTopics = new List<Topic>();
            foreach (int i in listBoxTopics.SelectedIndices)
            {
                var topicName = listBoxTopics.Items[i].ToString();
                selectedTopics.Add(preliminaryController.FindTopicByName(topicName));
            }
            var fee = textBoxFee.Text;

            try
            {
                var conference = new Conference();
                conference.Name = conferenceName;
                conference.EndDate = endDate;
                conference.Topics = selectedTopics;
                conference.ConferenceFee = float.Parse(fee);
                validator.Validate(conference);

                var preliminaryPhase = new Phase();
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

        private void LoadUsers()
        {
            var users = preliminaryController.FindAllUsers();

            foreach (var user in users)
            {
                comboBoxCheckedListCreate.Items.Add(user);
            }

            // If more then 5 items, add a scroll bar to the dropdown.
            comboBoxCheckedListCreate.MaxDropDownItems = 5;
            // Make the "Name" property the one to display
            comboBoxCheckedListCreate.DisplayMember = "LastName";
            comboBoxCheckedListCreate.ValueSeparator = ", ";
        }

        private void LoadTopics()
        {
            var topics = preliminaryController.FindAllTopics();

            foreach (var topic in topics)
            {
                listBoxTopics.Items.Add(topic.Name);
            }
        }
    }
}

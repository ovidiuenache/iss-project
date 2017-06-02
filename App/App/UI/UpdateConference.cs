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
    public partial class UpdateConference : Form
    {
        private Form parent;
        private Conference activeConference;
        private PreliminaryPhaseController preliminaryController;
        private ConferenceValidator validator;

        public UpdateConference(Form parent, int positionX, int positionY)
        {
            InitializeComponent();
            Location = new Point(positionX, positionY);
            this.parent = parent;
            preliminaryController = ApplicationFactory.getPreliminaryPhaseController();
            activeConference = preliminaryController.ActiveConference();
            validator = new ConferenceValidator();
        }

        private void UpdateConferenceUI_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            loadUsers();
            loadTopics();

            textBoxName.Text = activeConference.Name;
            textBoxFee.Text = activeConference.ConferenceFee.ToString();
            dateTimePicker.Value = activeConference.EndDate;

            foreach (ConferenceUser conferenceUser in activeConference.Users)
            {
                for (int i = 0; i < comboBoxCheckedListUpdate.Items.Count; i++)
                {
                    if (conferenceUser.UserId == ((User)comboBoxCheckedListUpdate.Items[i]).UserId)
                    {
                        comboBoxCheckedListUpdate.SetItemChecked(i, true);
                    }
                }
            }

            foreach (Topic topic in activeConference.Topics)
            {
                for (int i = 0; i < listBoxTopics.Items.Count; i++)
                {
                    if (topic.Name == ((Topic)listBoxTopics.Items[i]).Name)
                    {
                        listBoxTopics.SetSelected(i, true);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = this.Location;
            Hide();
            parent.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string conferenceName = textBoxName.Text;
            DateTime endDate = dateTimePicker.Value;
            List<User> commiteeMembers = new List<User>();
            for (int i = 0; i < comboBoxCheckedListUpdate.Items.Count; i++)
            {
                if (comboBoxCheckedListUpdate.GetItemChecked(i))
                {
                    commiteeMembers.Add((User)comboBoxCheckedListUpdate.Items[i]);
                }
            }

            List<Topic> selectedTopics = new List<Topic>();
            foreach (int i in listBoxTopics.SelectedIndices)
            {
                string topicName = listBoxTopics.Items[listBoxTopics.SelectedIndex].ToString();
                selectedTopics.Add(preliminaryController.FindTopicByName(topicName));
            }
            string fee = textBoxFee.Text;

            try
            {
                activeConference.Name = conferenceName;
                activeConference.EndDate = endDate;
                activeConference.Topics = selectedTopics;
                activeConference.ConferenceFee = float.Parse(fee);
                validator.validate(activeConference);

                preliminaryController.UpdateConference(activeConference);
                MessageBox.Show("Conference has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadUsers()
        {
            List<User> users = preliminaryController.FindAllUsers();

            foreach (User user in users)
            {
                comboBoxCheckedListUpdate.Items.Add(user);
            }

            // If more then 5 items, add a scroll bar to the dropdown.
            comboBoxCheckedListUpdate.MaxDropDownItems = 5;
            // Make the "Name" property the one to display
            comboBoxCheckedListUpdate.DisplayMember = "LastName";
            comboBoxCheckedListUpdate.ValueSeparator = ", ";
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

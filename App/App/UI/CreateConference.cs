using App.Entity;
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
        Form parent;

        public CreateConference(Form parent, int positionX, int positionY)
        {
            InitializeComponent();
            Location = new Point(positionX, positionY);
            this.parent = parent;
        }

        private void CreateConferenceUI_Load(object sender, EventArgs e)
        {
            var listTopic = populateList();

            foreach (var topic in listTopic)
            {
                comboBoxCheckedListCreate.Items.Add(topic);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            comboBoxCheckedListCreate.MaxDropDownItems = 5;
            // Make the "Name" property the one to display
            comboBoxCheckedListCreate.DisplayMember = "Name";
            comboBoxCheckedListCreate.ValueSeparator = ", ";
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = Location;
            Hide();
            parent.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            string conferenceName = textBoxName.Text;
            DateTime endDate = dateTimePicker.Value;
            //List<IUser> commiteeMembers = ...
            //List<String> topics = ...
            string fee = textBoxFee.Text;

            Conference conference = new Conference();
            conference.Name = conferenceName;
            //conference.setEndDate(endDate);
            //conference.setCommiteeMembers();
            //conference.setTopics()
            //conference.setActivePhase();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private List<Topic> populateList()
        {
            var listTest = new List<Topic>();
            listTest.Add(new Topic( "name1", "desc1"));
            listTest.Add(new Topic( "name2", "desc2"));
            listTest.Add(new Topic( "name3", "desc3"));
            listTest.Add(new Topic( "name4", "desc4"));
            listTest.Add(new Topic( "name5", "desc5"));
            listTest.Add(new Topic( "name6", "desc6"));
            listTest.Add(new Topic( "name7", "desc7"));

            return listTest;
        }
    }
}

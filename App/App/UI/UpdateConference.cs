﻿using App.Entity;
using System;
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
        Form parent;

        public UpdateConference(Form parent, int positionX, int positionY)
        {
            InitializeComponent();
            Location = new Point(positionX, positionY);
            this.parent = parent;
        }

        private void UpdateConferenceUI_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = this.Location;
            Hide();
            parent.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            string conferenceName = textBoxName.Text;
            DateTime endDate = dateTimePicker.Value;
            //List<IUser> commiteeMembers = ...
            //List<String> topics = ...
            string fee = textBoxFee.Text;

            //conference.setName(conferenceName);
            //conference.setEndDate(endDate);
            //conference.setCommiteeMembers();
            //conference.setTopics()
            //conference.setActivePhase();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

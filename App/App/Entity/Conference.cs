using System;
using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Conference
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Conference
    {
        public int ConferenceId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Phase ActivePhase { get; set; }

        public IList<ConferenceUser> Users { get; set; }

        public IList<Topic> Topics { get; set; }

        public float ConferenceFee { get; set; }

        public Conference()
        {
            Name = "";
            StartDate = new DateTime();
            EndDate = new DateTime();
            ActivePhase = null;
            Users = new List<ConferenceUser>();
            Topics = new List<Topic>();
            ConferenceFee = 0;
        }

        public Conference(
            string name,
            DateTime startDate,
            DateTime endDate,
            Phase activePhase,
            IList<ConferenceUser> users,
            float conferenceFee
        )
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ActivePhase = activePhase;
            this.Users = users;
            this.ConferenceFee = conferenceFee;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Conference;

            return ConferenceId == item?.ConferenceId;
        }
    }
}

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
        public int ConferenceId;

        public string Name;

        public IList<Phase> Phases;

        public DateTime StartDate;

        public Phase ActivePhase;

        public IList<AbstractCommiteeMember> CommiteeMembers;

        public IList<Topic> Topics;

        public float ConferenceFee;

        public Conference()
        {
            ConferenceId = -1;
            Name = "";
            Phases = new List<Phase>();
            StartDate = new DateTime();
            ActivePhase = null;
            CommiteeMembers = new List<AbstractCommiteeMember>();
            Topics = new List<Topic>();
            ConferenceFee = 0;
        }

        public Conference(
            string name,
            IList<Phase> phases,
            DateTime startDate,
            Phase activePhase,
            IList<AbstractCommiteeMember> commiteeMembers,
            float conferenceFee
        )
        {
            this.Name = name;
            this.Phases = phases;
            this.StartDate = startDate;
            this.ActivePhase = activePhase;
            this.CommiteeMembers = commiteeMembers;
            this.ConferenceFee = conferenceFee;
        }

        public void AddPhase(Phase phase)
        {
            Phases.Add(phase);
        }

        public void RemovePhase(Phase phase)
        {
            Phases.Remove(phase);
        }

        public void SetCommiteeMembers(IList<AbstractCommiteeMember> commiteeMembers)
        {
            this.CommiteeMembers = commiteeMembers;
        }

        public void AddCommiteeMember(AbstractCommiteeMember commiteeMember)
        {
            CommiteeMembers.Add(commiteeMember);
        }

        public void RemoveCommiteeMember(AbstractCommiteeMember commiteeMember)
        {
            CommiteeMembers.Remove(commiteeMember);
        }

        public void AddTopic(Topic topic)
        {
            Topics.Add(topic);
        }

        public void RemoveTopic(Topic topic)
        {
            Topics.Remove(topic);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Conference;

            return ConferenceId == item?.ConferenceId;
        }
    }
}

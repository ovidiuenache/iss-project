using System;
using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Conference
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class Conference
    {
        private int id;

        private string name;

        private IList<Phase> phases;

        private DateTime startDate;

        private Phase activePhase;

        private IList<AbstractCommiteeMember> commiteeMembers;

        private IList<Topic> topics;

        private float conferenceFee;

        public Conference()
        {
            id = -1;
            name = "";
            phases = new List<Phase>();
            startDate = new DateTime();
            activePhase = null;
            commiteeMembers = new List<AbstractCommiteeMember>();
            topics = new List<Topic>();
            conferenceFee = 0;
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
            this.name = name;
            this.phases = phases;
            this.startDate = startDate;
            this.activePhase = activePhase;
            this.commiteeMembers = commiteeMembers;
            this.conferenceFee = conferenceFee;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public IList<Phase> getPhases()
        {
            return phases;
        }

        public DateTime getStartDate()
        {
            return startDate;
        }

        public Phase getActivePhase()
        {
            return activePhase;
        }

        public IList<AbstractCommiteeMember> getCommiteeMembers()
        {
            return commiteeMembers;
        }

        public void setActivePhase(Phase activePhase)
        {
            this.activePhase = activePhase;
        }

        public void setPhases(IList<Phase> phases)
        {
            this.phases = phases;
        }

        public void addPhase(Phase phase)
        {
            phases.Add(phase);
        }

        public void removePhase(Phase phase)
        {
            phases.Remove(phase);
        }

        public void setCommiteeMembers(IList<AbstractCommiteeMember> commiteeMembers)
        {
            this.commiteeMembers = commiteeMembers;
        }

        public void addCommiteeMember(AbstractCommiteeMember commiteeMember)
        {
            commiteeMembers.Add(commiteeMember);
        }

        public void removeCommiteeMember(AbstractCommiteeMember commiteeMember)
        {
            commiteeMembers.Remove(commiteeMember);
        }

        public IList<Topic> getTopics()
        {
            return topics;
        }

        public void setTopics(IList<Topic> topics)
        {
            this.topics = topics;
        }

        public void addTopic(Topic topic)
        {
            topics.Add(topic);
        }

        public void removeTopic(Topic topic)
        {
            topics.Remove(topic);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Conference;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}

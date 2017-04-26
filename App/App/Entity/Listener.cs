using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Listener
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class Listener : AbstractNonCommiteeMember
    {
        private IList<Topic> topicsOfInterest;

        public Listener()
        {
            topicsOfInterest = new List<Topic>();
        }

        public IList<Topic> getTopicsOfInterest()
        {
            return topicsOfInterest;
        }

        public void setTopicsOfInterest(IList<Topic> topicsOfInterest)
        {
            this.topicsOfInterest = topicsOfInterest;
        }

        public void addTopicOfInterest(Topic topic)
        {
            topicsOfInterest.Add(topic);
        }

        public void removeTopicOfInterest(Topic topic)
        {
            topicsOfInterest.Remove(topic);
        }
    }
}

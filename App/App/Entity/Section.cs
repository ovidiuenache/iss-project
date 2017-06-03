using System;
using System.Collections;
using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Section
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public User SectionLeader { get; set; }
        public IList<Topic> Topics { get; set; }
        public IList<User> Listeners { get; set; }
        public IList<User> Authors { get; set; }
        public string Room { get; set; }
        public Dictionary<String, Proposal> Schedule;

        public override string ToString()
        {
            return Name;
        }
    }
}

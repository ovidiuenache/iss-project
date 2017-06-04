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
        public List<Topic> Topics { get; set; }
        public List<User> Authors { get; set; }
        public List<Proposal> Proposals { get; set; }
        public string Room { get; set; }
        public List<UserSection>  UserSections { get; set; }

        public Section()
        {
            Name = "";
            SectionLeader = new User();
            Topics = new List<Topic>();
            Authors = new List<User>();
            Room = "";
        }

        public Section(
            string name,
            User sectionLeader,
            List<Topic> topics,
            List<User> authors,
            string room
        )
        {
            Name = name;
            SectionLeader = sectionLeader;
            Topics = topics;
            Authors = authors;
            Room = room;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

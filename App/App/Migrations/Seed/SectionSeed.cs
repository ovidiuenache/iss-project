using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;

namespace App.Migrations.Seed
{
    /// <summary>
    /// 
    /// Class SectionSeed
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class SectionSeed
    {
        /// <summary>
        /// This method is used at startup of App
        /// for populate db with dummy data.
        /// Usage: ProposalSeed.Seed()
        /// 
        /// </summary>
        public static void Seed()
        {
            using (var db = new AppContext())
            {
                if (!db.Sections.Any())
                {
                    List<Topic> topics = new List<Topic> { db.Topics.Find(1), db.Topics.Find(4), db.Topics.Find(5) };
                    List<User> listeners = new List<User>();
                    List<User> authors = new List<User> { db.Users.Find(2) };

                    db.Sections.Add(
                        new Section("Web", null, topics, authors, "Aula")
                    );

                    topics = new List<Topic> { db.Topics.Find(2), db.Topics.Find(3) };
                    authors = new List<User> { db.Users.Find(3) };
                    db.Sections.Add(
                        new Section("Desktop", null, topics, authors, "Mare")
                    );

                    db.SaveChanges();
                }
            }
        }
    }
}

﻿using System.Collections.Generic;
using System.Linq;
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
                    var sectionLeader = db.Users.Find(1);
                    var topics = new List<Topic>();
                    topics.Add(db.Topics.Find(1));
                    topics.Add(db.Topics.Find(4));
                    topics.Add(db.Topics.Find(5));
                    var listeners = new List<User>();
                    var authors = new List<User>();
                    authors.Add(db.Users.Find(2));
                    authors.Add(db.Users.Find(3));
                    db.Sections.Add(
                        new Section("Web", null, topics, authors, "Aula")
                    );

                    sectionLeader = db.Users.Find(5);
                    topics = new List<Topic>();
                    topics.Add(db.Topics.Find(2));
                    topics.Add(db.Topics.Find(3));
                    listeners = new List<User>();
                    authors = new List<User>();
                    authors.Add(db.Users.Find(4));
                    db.Sections.Add(
                        new Section("Desktop", null, topics, authors, "Mare")
                    );

                    db.SaveChanges();
                }
            }
        }
    }
}

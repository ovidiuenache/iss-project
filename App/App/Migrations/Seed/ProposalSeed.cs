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
    /// Class ProposalSeed
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class ProposalSeed
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
                if (!db.Proposals.Any())
                {
                    List<User> authors = new List<User>();

                    authors.Add(db.Users.Find(1));
                    authors.Add(db.Users.Find(2));
                    db.Proposals.Add(new Proposal("Kickstart PHP", authors, 2017, "bla-bla", "abstract1", "full1"));

                    authors = new List<User>();
                    authors.Add(db.Users.Find(3));
                    db.Proposals.Add(new Proposal("New approach of C#", authors, 2017, "lba-lba", "abstract2", "full2"));

                    authors = new List<User>();
                    authors.Add(db.Users.Find(4));
                    authors.Add(db.Users.Find(5));
                    db.Proposals.Add(new Proposal("JS for all", authors, 2017, "alb-alb", "abstract3", "full23"));

                    db.SaveChanges();
                }
            }
        }
    }
}

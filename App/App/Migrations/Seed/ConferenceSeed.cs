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
    /// Class ConferenceSeed
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class ConferenceSeed
    {
        /// <summary>
        /// This method is used at startup of App
        /// for populate db with dummy data.
        /// Usage: ConferenceSeed.Seed()
        /// 
        /// </summary>
        public static void Seed()
        {
            using (var db = new AppContext())
            {
                if (!db.Conferences.Any())
                {
                    db.Conferences.Add(
                        new Conference(
                            "Conf", 
                            DateTime.Now, 
                            new DateTime(2017, 06, 20), 
                            db.Phases.Find(1), 
                            new List<ConferenceUser>(),
                            100
                        )
                    );
                    db.SaveChanges();
                }
            }
        }
    }
}

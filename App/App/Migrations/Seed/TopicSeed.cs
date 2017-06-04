using System.Linq;
using App.Context;
using App.Entity;

namespace App.Migrations.Seed
{
    /// <summary>
    /// Class TopicSeed
    /// 
    /// Author: Claudiu Nicola
    /// </summary>
    public class TopicSeed
    {
        /// <summary>
        /// This method is used at startup of App
        /// for populate db with dummy data.
        /// Usage: TopicSeed.Seed()
        /// 
        /// </summary>
        public static void Seed()
        {
            using (var db = new AppContext())
            {
                if (!db.Topics.Any())
                {
                    db.Topics.Add(new Topic("PHP", "dummy"));
                    db.Topics.Add(new Topic("C#", "dummy"));
                    db.Topics.Add(new Topic("Java", "dummy"));
                    db.Topics.Add(new Topic("JS", "dummy"));
                    db.Topics.Add(new Topic("Ruby", "dummy"));

                    db.SaveChanges();
                }
            }
        }
    }
}

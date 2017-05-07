using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations.Seed
{
    /// <summary>
    /// Class UserContextSeed
    /// 
    /// Author: Claudiu Nicola
    /// </summary>
    public static class UserContextSeed
    {
        /// <summary>
        /// This method is used at startup of App
        /// for populate db with dummy data.
        /// Usage: UserContextSeed.Seed()
        /// 
        /// </summary>
        public static void Seed()
        {
            using (var db = new UserContext())
            {
                var chair = new Role("Chair", "chair");
                var author = new Role("Author", "author");
                var speaker = new Role("Speaker", "speaker");
                var listner = new Role("Listner", "listner");
                var reviewer = new Role("Reviewer", "reviewer");
                if (!db.Roles.Any())
                {
                    db.Roles.Add(chair);
                    db.Roles.Add(author);
                    db.Roles.Add(speaker);
                    db.Roles.Add(listner);
                    db.Roles.Add(reviewer);
                }

                var user1 = new User("Andu", "Popa", "popa@gmail.com", "parola", "ro", new List<Role> { chair });
                var user2 = new User("Zuluf", "Matea", "matea@gmail.com", "parola", "ro", new List<Role> { author });
                var user3 = new User("Razvi", "DejuDeju28", "deju@gmail.com", "parola", "ro", new List<Role> { speaker });
                var user4 = new User("Alex", "Bjz", "bjz@gmail.com", "parola", "ro", new List<Role> { listner });
                var user5 = new User("Bobo", "LaMisto", "misto@gmail.com", "parola", "ro", new List<Role> { reviewer });
                if (!db.Users.Any())
                {
                    db.Users.Add(user1);
                    db.Users.Add(user2);
                    db.Users.Add(user3);
                    db.Users.Add(user4);
                    db.Users.Add(user5);
                }

                db.SaveChanges();
            }
        }
    }
}

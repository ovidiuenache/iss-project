using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;
using Microsoft.EntityFrameworkCore.Migrations;
using App.Utils;

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
            using (var db = new AppContext())
            {
                var encrypter = new EncryptDecrypt();

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

                var user1 = new User("Andu", "Popa", "popa@gmail.com", encrypter.encryptPassword("parola"), "ro");
                var userRole = new UserRole() {Role = chair, RoleId = chair.RoleId, User = user1, UserId = user1.UserId};
                user1.UserRoles = new List<UserRole>() {userRole};

                var user2 = new User("Haba", "Baba", "haba@gmail.com", encrypter.encryptPassword("parola"), "ro");
                var userRole2 = new UserRole() { Role = reviewer, RoleId = reviewer.RoleId, User = user2, UserId = user2.UserId };
                user2.UserRoles = new List<UserRole>() { userRole2 };

                var user3 = new User("Yolo", "Swag", "swag@gmail.com", encrypter.encryptPassword("parola"), "ro");
                var userRole3 = new UserRole() { Role = reviewer, RoleId = reviewer.RoleId, User = user3, UserId = user3.UserId };
                user3.UserRoles = new List<UserRole>() { userRole3 };

                if (!db.Users.Any())
                {
                    db.Users.Add(user1);
                    db.Users.Add(user2);
                    db.Users.Add(user3);
                }

                db.SaveChanges();
            }
        }
    }
}
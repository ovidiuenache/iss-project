using System;
using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class User
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public List<Role> Roles { get; set; }

        public User(string firstName, string lastName, string email, string password, string country, List<Role> roles)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Country = country;
            Roles = roles;
        }

        protected User()
        {
            
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            var item = obj as User;

            return UserId == item?.UserId;
        }
    }
}

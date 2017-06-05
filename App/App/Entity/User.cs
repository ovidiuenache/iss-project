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
        public List<UserRole> UserRoles { get; set; }
        public List<ConferenceUser> ConferenceUsers { get; set; }
        public List<UserSection> UserSections { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, string email, string password, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Country = country;
        }

        public override bool Equals(object obj)
        {
            var item = obj as User;

            return UserId == item?.UserId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

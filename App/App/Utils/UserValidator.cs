using App.Entity;
using App.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Utils
{
    /// <summary>
    /// 
    /// User vaidator class
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class UserValidator : IValidator<User>
    {
        /// <summary>
        /// This method checks if all the fields of a user are valid
        /// If a single field is not valid, ValidationException will be thrown
        /// </summary>
        /// <param name="entity"></param>
        public void validate(User entity)
        {
            string errors = "";
            if (!validateName(entity.FirstName))
            {
                errors += "The firstname must have between 2 and 30 letters!\n";
            }
            if (!validateName(entity.LastName))
            {
                errors += "The lastname must have between 2 and 30 letters!\n";
            }
            if (!validateEmail(entity.Email))
            {
                errors += "You have introduced an invalid email !\n";
            }
            if (!validatePassword(entity.Password))
            {
                errors += "The password must have between 8 and 30 characters and at least one number, one uppercase and one " +
                    "lowercase characer!\n";
            }
            if (!validateCountry(entity.Country))
            {
                errors += "The country must have between 3 and 25 letters !\n";
            }

            if (errors.Length != 0)
            {
                throw new ValidationException(errors);
            }
        }

        /// <summary>
        /// Checks if a name is valid 
        /// A name is considered valid if it has only letter and at between 2 and 30 characters
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool validateName(string name)
        {
            if (name.Length < 2 || name.Length > 30)
            {
                return false;
            }
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check is the string got as parameter is a valid email adress
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool validateEmail(string email)
        {
            try
            {
                System.Net.Mail.MailAddress addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (FormatException exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a passwords is valid
        /// A passwords is considered valid if it has between 8 and 30 characters and at least one number, one lowercase letter and 
        /// at least one upper case letter
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool validatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 30)
            {
                return false;
            }
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the string got as parameter is a valid country name
        /// The string is valid if it contains between 3 and 25 characters, only letters
        /// A country can contain hyphens
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public bool validateCountry(string country)
        {
            if (country.Length < 3 || country.Length > 25)
            {
                return false;
            }
            if (!Regex.IsMatch(country, @"^[a-zA-Z- ]+$"))
            {
                return false;
            }
            return true;
        }
    }
}

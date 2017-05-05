using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Utils
{
    class UserValidator : IValidator<IUser>
    {
        public void validate(IUser entity)
        {
            if (!validateName(entity.getFirstName()))
            {

            }
            if (!validateName(entity.getLastName()))
            {

            }
            if (!validateBirthDate(entity.getBirthdate()))
            {

            }
        }

        /// <summary>
        /// Gets as parameter a DateTime value
        /// Check if the value is between 01.01.1930 and 01.01.2000
        /// </summary>
        /// <param name="birthDate"></param>
        /// <returns></returns>
        private bool validateBirthDate(DateTime birthDate)
        {
            if (birthDate == null)
            {
                return false;
            }
            if (birthDate > new DateTime(2000,01,01) || birthDate < new DateTime(1930, 01, 01))
            {
                return false;
            }
            return true;
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
            if (Regex.IsMatch(name, @"^[a-zA-Z]*$"))
            {
                return true;
            }
            return true;
        }

        /// <summary>
        /// Checks if the phone number got as paramter is valid
        /// A phone number is considered valid if it has exactly 10 characters, only digits
        /// </summary>
        /// <param name="telehpone"></param>
        /// <returns></returns>
        private bool validateTelephone(string telehpone)
        {
            if (telehpone.Length != 10)
            {
                return false;
            }
            if (Regex.IsMatch(telehpone, @"^[0-9]*$"))
            {
                return true;
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
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a passwords is valid
        /// A passwords is considered valid if it has between 8 and 30 characters and at least one number, one lowercase letter and 
        /// at leas one upper case letter
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool validatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 30)
            {
                return false;
            }
            if (!password.Any(c => char.IsDigit(c)))
            {
                return false;
            }
            if (!password.Any(c => char.IsUpper(c)))
            {
                return false;
            }
            if (!password.Any(c => char.IsLower(c)))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the string got as parameter is a valid country name
        /// The string is valid if it contains between 3 and 25 characters, only letters
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        private bool validateCountry(string country)
        {
            if (country.Length < 3 || country.Length > 25)
            {
                return false;
            }
            if (Regex.IsMatch(country, @"^[a-zA-Z]*$"))
            {
                return true;
            }
            return true;
        }

        /// <summary>
        /// Checks if the string got as parameter is a valid adress
        /// A valid adress cotains between 5 and 40 characters, only letters and digits
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>
        private bool validateAdress(string adress)
        {
            if (adress.Length < 5 || adress.Length > 40)
            {
                return false;
            }
            if (Regex.IsMatch(adress, @"^[A-Za-z0-9]*[A-Za-z0-9][A-Za-z0-9 ]*$"))
            {
                return true;
            }
            return true;
        }

        /// <summary>
        /// Checks if the string got as parameter is a valid city name
        /// A valid city name has between 2 and 25 characters, only letters
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        private bool validateCity(string city)
        { 
            if (city.Length < 3 || city.Length > 25)
            {
                return false;
            }
            if (Regex.IsMatch(city, @"^[a-zA-Z]*$"))
            {
                return true;
            } 
            return true;
        }
    }
}

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
    /// Author : Dezsi Razvan 
    /// 
    /// </summary>
    public class ConferenceValidator : IValidator<Conference>
    {
        public void validate(Conference entity)
        {
            string errors = "";
            if (!validateName(entity.Name))
            {
                errors += "The Conference Name must have between 2 and 30 letters!\n";
                errors += "The Conference Name must be start with an uppercase!";
            }

            if (errors.Length != 0)
            {
                throw new ValidationException(errors);
            }
        }
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
            if (name[0].ToString().ToUpper() != name[0].ToString())
                return false;
            return true;
        }
    }
}

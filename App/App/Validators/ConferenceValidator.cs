using App.Entity;
using App.Exception;
using System;
using System.Text.RegularExpressions;

namespace App.Validators
{
    /// <summary>
    /// 
    /// User vaidator class
    /// Author : Dezsi Razvan 
    /// Author : Ioan Ovidiu Enache
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
            if (!validateDate(entity.EndDate))
            {
                errors += "The End Date must be bigger than Start Date!";
            }
            if (!validateFee(entity.ConferenceFee.ToString()))
            {
                errors += "The Conference Fee must be a positive number!!";
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
            if (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
            {
                return false;
            }
            if (name[0].ToString().ToUpper() != name[0].ToString())
            {
                return false;
            }
                
            return true;
        }

        private bool validateFee(string fee)
        {
            int n;
            bool isNumeric = int.TryParse(fee, out n);

            if (isNumeric == false)
            {
                return false;
            }

            if (n < 0)
            {
                return false;
            }

            return true;
        }
        private bool validateDate(DateTime date)
        {
            DateTime curentDate = DateTime.Now;
            if (date < curentDate)
                return false;
            return true;
        }
    }
}

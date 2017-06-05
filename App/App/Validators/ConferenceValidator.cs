using App.Entity;
using App.Exception;
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
        public void Validate(Conference entity)
        {
            var errors = "";
            if (!ValidateName(entity.Name))
            {
                errors += "The Conference Name must have between 2 and 30 letters!\n";
                errors += "The Conference Name must be start with an uppercase!";
            }

            if (errors.Length != 0)
            {
                throw new ValidationException(errors);
            }
        }
        private bool ValidateName(string name)
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

        private bool ValidateFee(string fee)
        {
            int n;
            var isNumeric = int.TryParse(fee, out n);

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
    }
}

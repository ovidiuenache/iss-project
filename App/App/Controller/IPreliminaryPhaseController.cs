using App.Entity;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Preliminary Phase Controller interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface IPreliminaryPhaseController
    {
        /// <summary>
        /// Register a new user if all the user data is valid and notifies the user by email
        /// Throws ValidationException if the user contains invalid fields
        /// Throws InvalidEmailAdressException if the email adress is allready in use 
        /// </summary>
        /// <param name="user"></param>
        void Register(User user);
    }
}
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
        /// Register a new user and notifies the user by email
        /// The user fields are considered allready valid
        /// Throws InvalidEmailAdressException if the email adress is allready in use 
        /// </summary>
        /// <param name="user"></param>
        void Register(User user);

        /// <summary>
        /// Creates a new conference
        /// Throws ConfrenceInProgressException if a conference allready exists
        /// </summary>
        /// <param name="conference"></param>
        void CreateConference(Conference conference);
    }
}
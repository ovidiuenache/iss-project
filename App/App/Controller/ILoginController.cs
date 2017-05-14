using App.Entity;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Login Controller interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface ILoginController
    {
        /// <summary>
        /// Returns the user with the credentials got as parameters or null if there is no user with that credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUser(string username, string password);

        /// <summary>
        /// Returns true if there is an active conference or false otherwise
        /// </summary>
        /// <returns></returns>
        bool IsConferenceActive();

        /// <summary>
        /// Returns a string with the user's role
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string GetUserRole(User user);
    }
}
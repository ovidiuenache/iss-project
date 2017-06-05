using System.Collections.Generic;
using App.Entity;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Login Controller interface
    /// Author : Catalin Radoiu 
    /// Author: Dezsi Razvan
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
        /// Returns a a list with the user's roles
        /// If the user has no roles the list will be empty
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Role> GetUserRoles(User user);
        User GetUserByEmail(string email);
        void ChangePassword(string email, string password);
        Conference ActiveConference();
    }
}
using App.Entity;
using System.Collections.Generic;

namespace App.Repository
{
    /// <summary>
    /// 
    /// User Repository interface
    /// Author : Catalin Radoiu
    /// Author : Claudiu Nicola
    /// Author: Dezsi Razvan
    /// 
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Returns the user having the email equals with the one got as parameter 
        /// Returns null if there is no user with that email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User FindUserByEmail(string email);

        /// <summary>
        /// Returns a list with user's roles
        /// If the user has no roles the list will be empty
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Role> GetRoles(User user);
        void ChangePassword(string email, string password);
    }
}

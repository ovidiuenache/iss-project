using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    /// <summary>
    /// 
    /// User Repository interface
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Returns the user having the email equals with the one got as parameter 
        /// Returns null if there is no user with that email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User FindUserByEmail(string email);

        /// <summary>
        /// Return the user's role
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Role GetRole(User user);
    }
}

using App.Context;
using App.Entity;
using System;
using System.Linq;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// User Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public UserRepository(AppContext context) : base(context)
        {
        }

        public User FindUserByEmail(string email)
        {
            return Context.Users.SingleOrDefault(user => user.Email == email);
        }
    }
}

using App.Context;
using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

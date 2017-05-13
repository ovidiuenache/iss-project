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
    /// UserRole Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    class UserRoleRepository : AbstractRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AppContext context) : base(context)
        {

        }
    }
}

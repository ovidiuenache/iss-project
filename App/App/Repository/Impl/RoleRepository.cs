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
    /// Role Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    class RoleRepository : AbstractRepository<Role>, IRoleRepository
    {
        public RoleRepository(AppContext context) : base(context)
        {

        }
    }
}

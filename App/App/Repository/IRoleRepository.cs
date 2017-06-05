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
    /// Role Repository interface
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public interface IRoleRepository : IRepository<Role>
    {
        Role getBySlug(string slug);
    }
}

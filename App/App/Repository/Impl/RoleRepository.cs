using App.Context;
using App.Entity;
using System.Linq;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Role Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class RoleRepository : AbstractRepository<Role>, IRoleRepository
    {
        public RoleRepository(AppContext context) : base(context)
        {
        }

        public Role getBySlug(string slug)
        {
            return Context.Roles.Where(r => r.Slug == slug).ToList().Last();
        }
    }
}

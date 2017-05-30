using App.Context;
using App.Entity;

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
    }
}

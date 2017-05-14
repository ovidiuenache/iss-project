using App.Context;
using App.Entity;

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

using App.Entity;

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
        Role GetBySlug(string slug);
    }
}

using System.Collections.Generic;
using App.Entity;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Interface IUserSectionRepository
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public interface IUserSectionRepository : IRepository<UserSection>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Section> AllSectionsAssigned(User user);
    }
}

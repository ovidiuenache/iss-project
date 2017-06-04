using System.Collections.Generic;
using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Class UserSectionRepository
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class UserSectionRepository : AbstractRepository<UserSection>, IUserSectionRepository
    {
        public UserSectionRepository(AppContext context) : base(context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Section> AllSectionsAssigned(User loggedUser)
        {
            var all = base.All();
            List<Section> sections = new List<Section>();
            foreach (var userSection in all)
            {
                if (userSection.User.Equals(loggedUser))
                    sections.Add(userSection.Section);
            }
            return sections;
        }
    }
}

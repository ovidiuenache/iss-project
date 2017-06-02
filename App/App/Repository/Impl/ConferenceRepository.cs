using System.Linq;
using App.Context;
using App.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Conference Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class ConferenceRepository : AbstractRepository<Conference>, IConferenceRepository
    {
        public ConferenceRepository(AppContext context) : base(context)
        {
        }

        public Conference GetActiveConference()
        {
            return Context.Conferences
                .Include(p => p.ActivePhase)
                .Include(u => u.Users)
                .Include(t => t.Topics)
                .SingleOrDefault(conference => conference.ActivePhase != null); ;
        }
    }
}

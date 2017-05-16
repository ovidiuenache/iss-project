using System.Linq;
using App.Context;
using App.Entity;

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
            return Context.Conferences.SingleOrDefault(conference => conference.ActivePhase != null);
        }
    } 
}

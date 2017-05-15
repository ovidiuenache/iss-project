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
    } 
}

using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Class ConferenceUserRepository
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class ConferenceUserRepository : AbstractRepository<ConferenceUser>, IConferenceUserRepository
    {
        public ConferenceUserRepository(AppContext context) : base(context)
        {
        }
    }
}

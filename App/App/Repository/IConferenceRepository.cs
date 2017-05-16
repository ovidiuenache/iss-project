using App.Entity;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Conference Repository interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface IConferenceRepository : IRepository<Conference>
    {
        /// <summary>
        /// Returns the current conference if there is an active conference
        /// Returns null if there is no active conference 
        /// </summary>
        /// <returns></returns>
        Conference GetActiveConference();
    }
}

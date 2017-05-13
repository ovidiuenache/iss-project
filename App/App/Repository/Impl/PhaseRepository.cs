using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Phase Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public class PhaseRepository : AbstractRepository<Phase>, IPhaseRepository
    {
        public PhaseRepository(AppContext context) : base(context)
        {

        }
    }
}

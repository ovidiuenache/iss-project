using App.Context;
using App.Entity;


namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Proposal Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public class ProposalRepository : AbstractRepository<Proposal>, IProposalRepository
    {
        public ProposalRepository(AppContext context) : base(context)
        {

        }
    }
}

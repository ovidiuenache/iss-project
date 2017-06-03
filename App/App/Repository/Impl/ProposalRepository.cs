using App.Context;
using App.Entity;
using System.Collections.Generic;
using System.Linq;

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

        public List<Proposal> getProposalsBindingSource()
        {
            return Context.Proposals.ToList();
        }

        public void saveChanges()
        {
            Context.SaveChanges();
        }
    }
}

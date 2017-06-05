using App.Context;
using App.Entity;
using System.Collections.Generic;
using System.Linq;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Review Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public class ReviewRepository : AbstractRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppContext context) : base(context)
        {
        }

        public List<int> getRejectedProposalsIds()
        {
            return Context.Reviews.Where(r => r.Qualifier.ToLower().IndexOf("accept") == -1).Select(r => r.Proposal.ProposalId).ToList();
        } 
    }
}

using App.Entity;
using System.Collections.Generic;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Review Repository interface
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public interface IReviewRepository : IRepository<Review>
    {
        List<int> GetRejectedProposalsIds();
    }
}

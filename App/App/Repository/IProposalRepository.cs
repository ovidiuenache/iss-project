using App.Entity;
using System.Collections.Generic;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Proposal Repository interface
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public interface IProposalRepository : IRepository<Proposal>
    {
        List<Proposal> getProposalsBindingSource();

        void saveChanges();

        Proposal FindProposalByName(string name);
    }
}

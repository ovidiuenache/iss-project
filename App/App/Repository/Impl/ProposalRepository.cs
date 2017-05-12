using App.Context;
using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Proposal Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    class ProposalRepository : AbstractRepository<Proposal>, IProposalRepository
    {
        public ProposalRepository(AppContext context) : base(context)
        {

        }
    }
}

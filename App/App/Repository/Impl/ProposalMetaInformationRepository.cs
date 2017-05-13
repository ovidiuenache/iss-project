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
    /// ProposalMetaInformation Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    class ProposalMetaInformationRepository : AbstractRepository<ProposalMetaInformation>, 
        IProposalMetaInformationRepository
    {
        public ProposalMetaInformationRepository(AppContext context) : base(context)
        {

        }
    }
}

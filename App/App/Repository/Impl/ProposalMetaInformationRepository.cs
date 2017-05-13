using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// ProposalMetaInformation Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class ProposalMetaInformationRepository : AbstractRepository<ProposalMetaInformation>, 
        IProposalMetaInformationRepository
    {
        public ProposalMetaInformationRepository(AppContext context) : base(context)
        {

        }
    }
}

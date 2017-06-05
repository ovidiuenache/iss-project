using App.Entity;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase one controller interface
    /// Author : Catalin Radoiu
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public interface IPhaseOneController
    {
        void saveChanges();

        void updateUserRoles();

        void deleteProposalsWithoutFull();

        Proposal getProposalByUser(int userId);

        List<User> getAllUsers();

        List<Proposal> ProposalsAuthoredByUser(int userId);

        Proposal getProposal(int proposalId);

        List<Role> GetUserRoles(User user);

        void UpdateConference(Conference conference);

        Conference ActiveConference();

        void updateProposal(Proposal proposal);

        void addProposal(Proposal proposal);


    }
}
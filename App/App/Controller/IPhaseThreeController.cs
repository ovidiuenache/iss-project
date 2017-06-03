using System.Collections.Generic;
using App.Entity;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase three controller interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface IPhaseThreeController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Section> FindAllSections();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        Section FindSectionByName(string sectionName);

        /// <summary>
        /// Iterate all sections and add the user.
        /// </summary>
        /// <param name="sections"></param>
        /// <param name="loggedUser"></param>
        void AddListenerToSections(List<Section> sections, User loggedUser);

        /// <summary>
        /// Add the leader of section.
        /// </summary>
        /// <param name="sectionLeader"></param>
        void AddSectionLeader(User sectionLeader);

        /// <summary>
        /// All users that have the following roles: chair or reviewer.
        /// </summary>
        /// <returns></returns>
        List<User> FindAllComiteeMemberWithoutSection();

        /// <summary>
        ///
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        List<Proposal> FindAllProposalsBySection(Section section);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Proposal> FindAllProposals();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Proposal> FindAllProposalsWithoutSection();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proposalName"></param>
        /// <returns></returns>
        Proposal FindProposalByName(string proposalName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="proposal"></param>
        void AddProposalToSection(Section section, Proposal proposal);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Conference GetActiveConference();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proposal"></param>
        void UpdateProposal(Proposal proposal);
    }
}
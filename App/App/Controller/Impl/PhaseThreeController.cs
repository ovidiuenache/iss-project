using System.Collections.Generic;
using System.Linq;
using App.Entity;
using App.Repository;
using App.Repository.Impl;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase three controller implementation 
    /// Author : Catalin Radoiu 
    /// Author : Claudiu Nicola
    /// </summary>
    public class PhaseThreeController : IPhaseThreeController
    {
        private ISectionRepository SectionRepository;
        private IUserRepository UserRepository;
        private IProposalRepository ProposalRepository;
        private IConferenceRepository ConferenceRepository;

        public PhaseThreeController(
            ISectionRepository sectionRepository,
            IUserRepository userRepository,
            IProposalRepository proposalRepository,
            IConferenceRepository conferenceRepository
        )
        {
            SectionRepository = sectionRepository;
            UserRepository = userRepository;
            ProposalRepository = proposalRepository;
            ConferenceRepository = conferenceRepository;
        }

        /// <summary>
        /// Get a list with all topics.
        /// </summary>
        /// <returns></returns>
        public List<Section> FindAllSections()
        {
            return SectionRepository.All();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public Section FindSectionByName(string sectionName)
        {
            return SectionRepository.FindSectionByName(sectionName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sections"></param>
        /// <param name="loggedUser"></param>
        public void AddListenerToSections(List<Section> sections, User loggedUser)
        {
            foreach (var section in sections)
            {
                section.Listeners.Add(loggedUser);
                SectionRepository.Update(section);
            }
        }

        /// <summary>
        /// Add the leader of section.
        /// </summary>
        /// <param name="sectionLeader"></param>
        public void AddSectionLeader(User sectionLeader)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// All users that have the following roles: chair or reviewer.
        /// and don't have already set sectionId
        /// </summary>
        /// <returns></returns>
        public List<User> FindAllComiteeMemberWithoutSection()
        {
            //temp 
            return UserRepository.All();
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        public List<Proposal> FindAllProposalsBySection(Section section)
        {
            List<Proposal> proposals = new List<Proposal>();

            return proposals;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Proposal> FindAllProposalsWithoutSection()
        {
            var allProposals = ProposalRepository.All();
            var proposalsExistingInSections = SectionRepository.FindAllProposalsExistingInSections();

            List<Proposal> proposals = allProposals.Except(proposalsExistingInSections).ToList();

            return proposals;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Proposal> FindAllProposals()
        {
            return ProposalRepository.All();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proposalName"></param>
        /// <returns></returns>
        public Proposal FindProposalByName(string proposalName)
        {
            return ProposalRepository.FindProposalByName(proposalName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="proposal"></param>
        public void AddProposalToSection(Section section, Proposal proposal)
        {
            SectionRepository.AddProposalToSection(section, proposal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Conference GetActiveConference()
        {
            return ConferenceRepository.GetActiveConference();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proposal"></param>
        public void UpdateProposal(Proposal proposal)
        {
            ProposalRepository.Update(proposal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="roomName"></param>
        public void AddSectionRoom(Section section, string roomName)
        {
            section.Room = roomName;
            SectionRepository.Update(section);
        }
    }
}
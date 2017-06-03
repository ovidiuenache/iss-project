using System.Collections.Generic;
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
        private IProposalMetaInformationRepository ProposalMetaInformationRepository;

        public PhaseThreeController(
            ISectionRepository sectionRepository,
            IUserRepository userRepository,
            IProposalMetaInformationRepository proposalMetaInformationRepository
        )
        {
            SectionRepository = sectionRepository;
            UserRepository = userRepository;
            ProposalMetaInformationRepository = proposalMetaInformationRepository;
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
        public List<ProposalMetaInformation> FindAllProposalsBySection(Section section)
        {
            List<ProposalMetaInformation> proposalMetaInformations = new List<ProposalMetaInformation>();
            var authors = SectionRepository.FindAllAuthors(section);
            var p = ProposalMetaInformationRepository.All();
            foreach (var author in authors)
            {
              
            }

            return proposalMetaInformations;
        }
    }
}
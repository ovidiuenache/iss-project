using System.Collections.Generic;
using System.Linq;
using App.Entity;
using App.Repository;
using Castle.Core.Internal;

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
        private IUserSectionRepository UserSectionRepository;
        private IReviewRepository ReviewRepository;
        private IPhaseRepository PhaseRepository;
        private ITopicRepository TopicRepository;

        public PhaseThreeController(
            ISectionRepository sectionRepository,
            IUserRepository userRepository,
            IProposalRepository proposalRepository,
            IConferenceRepository conferenceRepository,
            IUserSectionRepository userSectionRepository,
            IReviewRepository reviewRepository,
            IPhaseRepository phaseRepository,
            ITopicRepository topicRepository
        )
        {
            SectionRepository = sectionRepository;
            UserRepository = userRepository;
            ProposalRepository = proposalRepository;
            ConferenceRepository = conferenceRepository;
            UserSectionRepository = userSectionRepository;
            ReviewRepository = reviewRepository;
            PhaseRepository = phaseRepository;
            TopicRepository = topicRepository;
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
        /// <param name="loggedUser"></param>
        /// <returns></returns>
        public List<Section> FindAllUnassignedSections(User loggedUser)
        {
            List<Section> assigned = UserSectionRepository.AllSectionsAssigned(loggedUser);
            List<Section> all = SectionRepository.All();
            if (!assigned.IsNullOrEmpty())
            {
                all = all.Except(assigned).ToList();
            }
            return all;
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
            UserSection userSection = new UserSection();
            userSection.User = loggedUser;
            foreach (var section in sections)
            {
                userSection.Section = SectionRepository.FindSectionByName(section.Name);
                UserSectionRepository.Add(userSection);
            }
        }

        /// <summary>
        /// Add the leader of section.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="sectionLeader"></param>
        public void AddSectionLeader(Section section, User sectionLeader)
        {
            section.SectionLeader = sectionLeader;
            SectionRepository.Update(section);
        }

        /// <summary>
        /// All users that have the following roles: chair or reviewer.
        /// and don't have already set sectionId
        /// </summary>
        /// <returns></returns>
        public List<User> FindAllComiteeMemberWithoutSection()
        {
            var users = UserRepository.All();
            List<User> comiteeMembersWithoutSection = new List<User>();
            foreach (var user in users)
            {
                if (IsComiteeMemberWithoutSection(user))
                {
                    comiteeMembersWithoutSection.Add(user);
                }
            }
            return comiteeMembersWithoutSection;
        }

        private bool IsComiteeMemberWithoutSection(User user)
        {
            var a = UserRepository.GetRoles(user).Select(role => role.Slug).Contains("chair");
            var b = UserRepository.GetRoles(user).Select(role => role.Slug).Contains("reviewer");
            var c = !SectionRepository.All().Select(s => s.SectionLeader).Contains(user);
            return (UserRepository.GetRoles(user).Select(role => role.Slug).Contains("chair")
                   || UserRepository.GetRoles(user).Select(role => role.Slug).Contains("reviewer"))
                   && !SectionRepository.All().Select(s => s.SectionLeader).Contains(user);
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Section> FindAllSectionsWithoutLeader()
        {
            return SectionRepository.FindAllSectionsWithoutLeader();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Section> FindAllSectionsWithoutRoom()
        {
            return SectionRepository.FindAllSectionsWithoutRoom();
        }

        public void deleteReviews()
        {
            foreach (Review review in ReviewRepository.All())
            {
                ReviewRepository.Delete(review);
            }
        }

        public void deleteProposals()
        {
            foreach(Proposal proposal in ProposalRepository.All())
            {
                ProposalRepository.Delete(proposal);
            }
        }

        public void deleteTopics()
        {
            foreach (Topic topic in TopicRepository.All())
            {
                TopicRepository.Delete(topic);
            }
        }

        public void deleteConferences()
        {
            foreach (Conference conference in ConferenceRepository.All())
            {
                ConferenceRepository.Delete(conference);
            }
        }

        public void deletePhases()
        {
            foreach (Phase phase in PhaseRepository.All())
            {
                PhaseRepository.Delete(phase);
            }
        }
    }
}
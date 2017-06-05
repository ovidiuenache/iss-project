using App.Entity;
using App.Repository.Impl;
using System.Collections.Generic;
using System.Linq;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase one controller implementation 
    /// Author : Catalin Radoiu 
    /// Author : Ioan Ovidiu Enache
    /// Author : Alexandru Emil Popa
    /// 
    /// </summary>
    public class PhaseOneController
    {
        private ProposalRepository proposalRepository;
        private UserRepository userRepository;
        private ConferenceRepository conferenceRepository;
        private RoleRepository roleRepository;

        public PhaseOneController(
            ProposalRepository proposalRepository,
            UserRepository userRepository,
            ConferenceRepository conferenceRepository,
            RoleRepository roleRepository
        )
        {
            this.proposalRepository = proposalRepository;
            this.userRepository = userRepository;
            this.conferenceRepository = conferenceRepository;
            this.roleRepository = roleRepository;
        }

        public void AddProposal(Proposal proposal)
        {
            proposalRepository.Add(proposal);
        }

        public void UpdateProposal(Proposal proposal)
        {
            proposalRepository.Update(proposal);
        }

        public Conference ActiveConference()
        {
            return conferenceRepository.GetActiveConference();
        }

        public void UpdateConference(Conference conference)
        {
            conferenceRepository.Update(conference);
        }

        public List<Role> GetUserRoles(User user)
        {
            return userRepository.GetRoles(user);
        }

        public Proposal GetProposal(int proposalId)
        {
            return proposalRepository.Find(proposalId);
        }

        public List<Proposal> ProposalsAuthoredByUser(int userId)
        {
            return proposalRepository.ProposalsAuthoredByUser(userId);
        }

        public void SaveChanges()
        {
            proposalRepository.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return userRepository.All();
        }

        public Proposal GetProposalByUser(int userId)
        {
            return proposalRepository.All().Where(proposal => proposal.Authors.Contains(userRepository.Find(userId))).ToList().FirstOrDefault();
        }

        public void deleteProposalsWithoutFull()
        {
            var proposalsWithoutFull = proposalRepository.GetProposalsWithoutFull();
            foreach (var prop in proposalsWithoutFull)
            {
                proposalRepository.Delete(prop);
            }
        }

        public void UpdateUserRoles()
        {
            var allProposals = proposalRepository.All();

            foreach (var user in userRepository.All())
            {
                var isAuthor = false;

                foreach (var proposal in allProposals)
                {
                    if (proposal.Authors.Select(author => author.UserId).Contains(user.UserId))
                    {
                        isAuthor = true;
                    }
                }

                if (isAuthor)
                {
                    var role = roleRepository.GetBySlug("author");
                    user.UserRoles = new List<UserRole>() { new UserRole() { Role = role, RoleId = role.RoleId, User = user, UserId = user.UserId } };
                    userRepository.Update(user);
                }
            }
        }
    }
}
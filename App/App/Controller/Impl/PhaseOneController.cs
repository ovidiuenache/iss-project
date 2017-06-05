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

        public PhaseOneController(ProposalRepository proposalRepository, UserRepository userRepository, ConferenceRepository conferenceRepository)
        {
            this.proposalRepository = proposalRepository;
            this.userRepository = userRepository;
            this.conferenceRepository = conferenceRepository;
        }

        public void addProposal(Proposal proposal)
        {
            proposalRepository.Add(proposal);
        }

        public void updateProposal(Proposal proposal)
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

        public Proposal getProposal(int proposalId)
        {
            return proposalRepository.Find(proposalId);
        }

        public List<Proposal> ProposalsAuthoredByUser(int userId)
        {
            return proposalRepository.ProposalsAuthoredByUser(userId);
        }

        public void saveChanges()
        {
            proposalRepository.saveChanges();
        }

        public List<User> getAllUsers()
        {
            return userRepository.All();
        }

        public Proposal getProposalByUser(int userId)
        {
            return proposalRepository.All().Where(proposal => proposal.Authors.Contains(userRepository.Find(userId))).ToList().FirstOrDefault();
        }

        public void deleteProposalsWithoutFull()
        {
            List<Proposal> proposalsWithoutFull = proposalRepository.getProposalsWithoutFull();
            foreach (Proposal prop in proposalsWithoutFull)
            {
                proposalRepository.Delete(prop);
            }
        }

        public void updateUserRoles()
        {
            List<Proposal> allProposals = proposalRepository.All();

            foreach (User user in userRepository.All())
            {
                bool isAuthor = false;

                foreach (Proposal proposal in allProposals)
                {
                    if (proposal.Authors.Select(author => author.UserId).Contains(user.UserId))
                    {
                        isAuthor = true;
                    }
                }

                if (isAuthor)
                {
                    //Make the motherfucker an author
                }
            }
        }
    }
}
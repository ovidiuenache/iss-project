using App.Entity;
using App.Repository.Impl;
using System.Collections.Generic;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase one controller implementation 
    /// Author : Catalin Radoiu 
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class PhaseOneController
    {
        private ProposalRepository proposalRepository;
        private UserRepository userRepository;

        public PhaseOneController(ProposalRepository proposalRepository, UserRepository userRepository)
        {
            this.proposalRepository = proposalRepository;
            this.userRepository = userRepository;
        }

        public void addProposal(Proposal proposal)
        {
            proposalRepository.Add(proposal);
        }

        public void updateProposal(Proposal proposal)
        {
            proposalRepository.Update(proposal);
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
    }
}
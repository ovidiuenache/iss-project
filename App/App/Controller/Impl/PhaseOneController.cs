using System;
using App.Entity;
using App.Repository;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase one controller implementation 
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class PhaseOneController
    {
        private IProposalRepository proposalRepository;
        private IUserRepository userRepository;

        public PhaseOneController(IProposalRepository proposalRepository, IUserRepository userRepository)
        {
            this.proposalRepository = proposalRepository;
            this.userRepository = userRepository;
        }

        public void updateProposal(Proposal proposal)
        {
            proposalRepository.Update(proposal);
        }

        public User getUserByEmail(string email)
        {
            return userRepository.FindUserByEmail(email);
        }

        public Proposal getProposal(int id)
        {
            return proposalRepository.Find(id);
        }
    }
}
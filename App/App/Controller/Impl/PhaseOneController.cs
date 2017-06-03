using App.Entity;
using App.Repository.Impl;
using System.Collections.Generic;
using Moq;

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

        public PhaseOneController(ProposalRepository proposalRepository)
        {
            this.proposalRepository = proposalRepository;
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
            var test = new List<User>();
            test.Add(new User("t1", "t2", "t3", "t4", "t5"));
          
            return test;
        }
    }
}
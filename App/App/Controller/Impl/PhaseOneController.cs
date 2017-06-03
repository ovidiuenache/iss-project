using System;
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

        public PhaseOneController(ProposalRepository proposalRepository)
        {
            this.proposalRepository = proposalRepository;
        }

        public void updateProposal(Proposal proposal)
        {
            throw new NotImplementedException();
        }

        public User getUserByName(string v)
        {
            throw new NotImplementedException();
        }
    
        public Proposal getProposal(int v)
        {
            throw new NotImplementedException();
        }

        public List<Proposal> getProposalsBindingSource()
        {
            return proposalRepository.getProposalsBindingSource();
        }

        public void saveChanges()
        {
            proposalRepository.saveChanges();
        }
    }
}
using System;
using App.Entity;
using App.Repository;
﻿using App.Entity;
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
    }
}
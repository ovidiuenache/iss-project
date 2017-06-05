using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test.Repository
{
    /// <summary>
    /// Test class for ProposalRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class ProposalRepositoryTest
    {
        private ProposalRepository proposalRepository;
        private UserRepository userRepository;
        private Proposal proposal;
        private User user;

        [TestInitialize()]
        public void Initialize()
        {
            proposalRepository = ApplicationFactory.getProposalRepository();
            userRepository = ApplicationFactory.getUserRepository();
            proposal = new Proposal();
            user = new User();
            proposal.Title = "Test";
            proposal.AbstractPaper = "Test";
            user.FirstName = "Test";
            user.Email = "test@gmail.com";
            proposal.Authors.Add(user);

        }

        [TestMethod]
        public void TestProposalsAuthoredByUser()
        {
            proposalRepository.Add(proposal);
            List<Proposal> proposals = proposalRepository.ProposalsAuthoredByUser(user.UserId);
            Assert.AreEqual(proposals.Count, 1);
            proposalRepository.Delete(proposal);
            userRepository.Delete(user);
        }

        [TestMethod]
        public void TestFindProposalByName()
        {
            proposalRepository.Add(proposal);
            Assert.AreEqual(proposal.AbstractPaper, proposalRepository.FindProposalByName("Test").AbstractPaper);
            proposalRepository.Delete(proposal);
            userRepository.Delete(user);
        }

        [TestMethod]
        public void TestgetProposalsWithoutFull()
        {
            proposalRepository.Add(proposal);
            Assert.AreEqual(1, proposalRepository.getProposalsWithoutFull().Count);
            proposalRepository.Delete(proposal);
            userRepository.Delete(user);
        }
    }
}

using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Repository
{
    /// <summary>
    /// Test class for ReviewRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class ReviewRepositoryTest
    {
        private ReviewRepository reviewRepository;
        private ProposalRepository proposalRepository;
        private Review review;
        private Proposal proposal;

        [TestInitialize()]
        public void Initialize()
        {
            reviewRepository = ApplicationFactory.getReviewRepository();
            proposalRepository = ApplicationFactory.getProposalRepository();
            review = new Review();
            proposal=new Proposal();
            review.DateCreated = DateTime.Now;
            review.Comment = "Test";
            review.Qualifier = "Reject";
            proposal.Title = "Ceva test";
            review.Proposal = proposal;
        }

        [TestMethod]
        public void TestgetRejectedProposalsIds()
        {
            reviewRepository.Add(review);
            Assert.AreEqual(1, reviewRepository.getRejectedProposalsIds().Count);
            reviewRepository.Delete(review);
            proposalRepository.Delete(proposal);
        }
    }
}

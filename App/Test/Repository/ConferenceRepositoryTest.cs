using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Repository
{
    /// <summary>
    /// Test class for ConferenceRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class ConferenceRepositoryTest
    {
        private ConferenceRepository conferenceRepository;
        private PhaseRepository phaseRepository;
        private Conference conference;
        private Conference newConference;
        private Phase phase;


        [TestInitialize()]
        public void Initialize()
        {
            conferenceRepository = ApplicationFactory.getConferenceRepository();
            phaseRepository = ApplicationFactory.getPhaseRepository();
            conference = new Conference();
            newConference = new Conference();
            phase = new Phase();
            conference.ConferenceFee = 150;
            conference.Name = "Test";
            conference.StartDate = DateTime.Now;
            phase.Name = "Test";
            conference.ActivePhase = phase;
            newConference.Name = "Before";
            newConference.ConferenceFee = 100;
        }

        [TestMethod]
        public void TestGetActiveConference()
        {
            Assert.AreEqual(conference.Name, "Test");
            Assert.AreEqual(conference.ConferenceFee, 150);
            conferenceRepository.Add(conference);
            Conference activeConference = conferenceRepository.GetActiveConference();
            Assert.AreEqual(newConference.Name, "Before");
            Assert.AreEqual(100, newConference.ConferenceFee);
            newConference.Name = activeConference.Name;
            newConference.ConferenceFee = activeConference.ConferenceFee;
            Assert.AreEqual(conference.Name, "Test");
            Assert.AreEqual(conference.ConferenceFee, 150);
            conferenceRepository.Delete(conference);
            phaseRepository.Delete(phase);
        }
    }
}

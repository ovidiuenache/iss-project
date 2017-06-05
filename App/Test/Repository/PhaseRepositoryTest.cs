using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Repository
{
    /// <summary>
    /// Test class for PhaseRepository
    /// Author : Ioan Ovidiu Enache
    /// </summary>
    [TestClass]
    public class PhaseRepositoryTest
    {
        private PhaseRepository phaseRepository;
        private Phase phase;

        [TestInitialize()]
        public void Initialize()
        {
            phaseRepository = ApplicationFactory.getPhaseRepository();
            phase = new Phase();
            phase.Name = "Test";
            phase.Deadline = DateTime.Now;
        }

        [TestMethod]
        public void TestAdd()
        {
            int initialValues = phaseRepository.All().Count;
            Assert.AreEqual(initialValues, 0);
            phaseRepository.Add(phase);
            Assert.AreEqual(phaseRepository.All().Count, (initialValues + 1));
            phaseRepository.Delete(phase);
        }

        [TestMethod]
        public void TestDelete()
        {
            phaseRepository.Add(phase);
            int initialValues = phaseRepository.All().Count;
            phaseRepository.Delete(phase);
            Assert.AreEqual(phaseRepository.All().Count, (initialValues - 1));
        }

        [TestMethod]
        public void TestAll()
        {
            int initialValues = phaseRepository.All().Count;
            phaseRepository.Add(phase);
            Assert.AreEqual(phaseRepository.All().Count, (initialValues + 1));
            phaseRepository.Delete(phase);
        }

        [TestMethod]
        public void TestFind()
        {
            phaseRepository.Add(phase);
            Assert.AreEqual(phaseRepository.Find(phase.PhaseId).Name, "Test");
            phaseRepository.Delete(phase);
        }

        [TestMethod]
        public void TestUpdate()
        {
            phaseRepository.Add(phase);
            Assert.AreEqual(phaseRepository.Find(phase.PhaseId).Name, "Test");
            phase.Name = "Updated";
            phaseRepository.Update(phase);
            Assert.AreEqual(phaseRepository.Find(phase.PhaseId).Name, "Updated");
            phaseRepository.Delete(phase);
        }
    }
}

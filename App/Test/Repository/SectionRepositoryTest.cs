using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using App.Controller.Impl;

namespace Test.Repository
{
    /// <summary>
    /// Test class for SectionRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class SectionRepositoryTest
    {
        private SectionRepository sectionRepository;
        private ProposalRepository proposalRepository;
        private UserRepository userRepository;
        private Section section;
        private Section newSection;
        private Proposal proposal;
        private User user;
        private User newUser;

        [TestInitialize()]
        public void Initialize()
        {
            
            sectionRepository = ApplicationFactory.GetSectionRepository();
            proposalRepository = ApplicationFactory.getProposalRepository();
            userRepository = ApplicationFactory.getUserRepository();
            user=new User();
            newUser=new User();
            section =new Section();
            newSection = new Section();
            section.SectionLeader = null;
            newSection.SectionLeader = null;
            proposal =new Proposal();
            section.Name = "Test";
            section.Room = "Test room";
            proposal.Title = "Test proposal";
            user.FirstName = "User test";
            newUser.FirstName = "Newuser test";
            newSection.Name = "New section";
            newSection.Room = null;

        }

        [TestMethod]
        public void TestFindSectionByName()
        {

            sectionRepository.Add(section);
            Assert.AreEqual(sectionRepository.FindSectionByName("Test").Room, "Test room");
            sectionRepository.Delete(section);

        }

        [TestMethod]
        public void TestFindAllProposalsExistingInSections()
        {
            
            proposalRepository.Add(proposal);
            sectionRepository.Add(section);
            int initialValue = sectionRepository.FindAllProposalsExistingInSections().Count;
            Assert.AreEqual(0, initialValue);
            sectionRepository.AddProposalToSection(section, proposal);
            Assert.AreEqual((initialValue + 1), sectionRepository.FindAllProposalsExistingInSections().Count);
            proposalRepository.Delete(proposal);
            sectionRepository.Delete(section);
            
        }

        [TestMethod]
        public void TestFindAllSectionsWithoutRoom()
        {
            
            sectionRepository.Add(section);
            int initValue = sectionRepository.FindAllSectionsWithoutRoom().Count;
            sectionRepository.Add(newSection);
            Assert.AreEqual((initValue + 1), sectionRepository.FindAllSectionsWithoutRoom().Count);
            sectionRepository.Delete(section);
            sectionRepository.Delete(newSection);
            
        }

        [TestMethod]
        public void TestFindAllSectionsWithoutLeader()
        {
            section.SectionLeader = new User();
            sectionRepository.Add(section);
            int initValue = sectionRepository.FindAllSectionsWithoutLeader().Count;
            userRepository.Add(user);
            newSection.SectionLeader = user;
            sectionRepository.Add(newSection);
            Assert.AreEqual(initValue, sectionRepository.FindAllSectionsWithoutLeader().Count);
            sectionRepository.Delete(section);
            sectionRepository.Delete(newSection);
            userRepository.Delete(user);
            
        }

        [TestMethod]
        public void TestFindAllAuthors()
        {
            
            sectionRepository.Add(section);
            userRepository.Add(user);
            int initialValue = sectionRepository.FindAllAuthors(section).Count;
            userRepository.Add(newUser);
            Assert.AreEqual((initialValue + 1), sectionRepository.FindAllAuthors(section).Count);
            userRepository.Delete(user);
            userRepository.Delete(newUser);
            sectionRepository.Delete(section);
            
        }
    }
}

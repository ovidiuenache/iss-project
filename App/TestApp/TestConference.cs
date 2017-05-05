using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entity;
using System.Collections.Generic;

namespace TestApp
{
    [TestClass]
    public class TestConference
    {
        [TestMethod]
        public void testConferenceConstructorWithouParam()
        {
            Conference conference = new Conference();
            Assert.AreEqual(-1, conference.getId());
            Assert.AreEqual("", conference.getName());
            Assert.AreEqual(null, conference.getActivePhase());
        }

        [TestMethod]
        public void testConference()
        {
            IList<Phase> list = new List<Phase>();
            DateTime dateTime = new DateTime(2017, 05, 05);
            DateTime dateTimeStart = new DateTime(2017, 04, 01);
            Phase phase1 = new Phase("No. 1", dateTime);
            Phase phase2 = new Phase("No. 2", dateTime);
            list.Add(phase1);
            IList<AbstractCommiteeMember> commiteeMembers = new List<AbstractCommiteeMember>();
            Chair chair1 = new Chair();
            chair1.setFirstName("Andrei");
            Chair chair2 = new Chair();
            chair2.setFirstName("Ionut");
            commiteeMembers.Add(chair1);
            Conference conference = new Conference("Conference", list, dateTimeStart, phase1, commiteeMembers, (float)250.5);
            conference.addPhase(phase2);
            Assert.AreEqual(2, conference.getPhases().Count);
            conference.removePhase(phase2);
            Assert.AreEqual(1, conference.getPhases().Count);
            Assert.AreEqual(1, conference.getCommiteeMembers().Count);
            conference.addCommiteeMember(chair2);
            Assert.AreEqual(2, conference.getCommiteeMembers().Count);
            conference.removeCommiteeMember(chair2);
            Assert.AreEqual(1, conference.getCommiteeMembers().Count);
            Conference conference2 = new Conference();
            Topic topic1 = new Topic("Apa", "Despre apa");
            Topic topic2 = new Topic("Pamant", "Despre pamant");
            conference2.addTopic(topic1);
            conference2.addTopic(topic2);
            Assert.AreEqual(2, conference2.getTopics().Count);
            conference2.removeTopic(topic2);
            Assert.AreEqual(1, conference2.getTopics().Count);
        }
    }
}

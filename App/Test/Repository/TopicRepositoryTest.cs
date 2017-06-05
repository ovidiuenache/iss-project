using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Repository
{
    /// <summary>
    /// Test class for TopicRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class TopicRepositoryTest
    {
        private TopicRepository topicRepository;
        private Topic topic;

        [TestInitialize()]
        public void Initialize()
        {
            topicRepository = ApplicationFactory.getTopicRepository();
            topic = new Topic();
            topic.Name = "Test";
            topic.Description = "Test";
        }

        [TestMethod]
        public void TestFindTopicByName()
        {
            topicRepository.Add(topic);
            Assert.AreEqual("Test", topicRepository.FindTopicByName("Test").Description);
            topicRepository.Delete(topic);
        }
    }
}

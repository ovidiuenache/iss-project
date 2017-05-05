using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entity;

namespace TestApp
{
    [TestClass]
    public class TestTopic
    {
        [TestMethod]
        public void testTopicConstructorWithoutParameters()
        {
            Topic topic = new Topic();
            Assert.AreEqual(-1, topic.getId());
            topic.setDescription("Desc");
            Assert.AreEqual("Desc", topic.getDescription());
            Assert.AreEqual("", topic.getName());
        }

        [TestMethod]
        public void testTopicConstructorWithParameters()
        {
            Topic topic = new Topic("Apa", "Despre apa");
            Assert.AreEqual("Apa", topic.getName());
            Assert.AreEqual("Despre apa", topic.getDescription());
        }
    }
}

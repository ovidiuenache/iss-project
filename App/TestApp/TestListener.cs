using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entity;
using System.Collections.Generic;

namespace TestApp
{
    [TestClass]
    public class TestListener
    {
        [TestMethod]
        public void testTopicOfInterest()
        {
            Listener listener = new Listener();
            IList<Topic> list = new List<Topic>();
            Topic topic = new Topic("Apa", "Despre apa");
            Topic topicNew = new Topic("Pamant", "Despre pamant");
            list.Add(topic);
            listener.setTopicsOfInterest(list);
            Assert.AreEqual(1, listener.getTopicsOfInterest().Count);
            listener.addTopicOfInterest(topicNew);
            Assert.AreEqual(listener.getTopicsOfInterest().Count, 2);
            listener.removeTopicOfInterest(topicNew);
            Assert.AreEqual(1, listener.getTopicsOfInterest().Count);
        }
    }
}

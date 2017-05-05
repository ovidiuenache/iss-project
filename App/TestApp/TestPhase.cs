using System;
using App.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestApp
{
    [TestClass]
    public class TestPhase
    {
        [TestMethod]
        public void testConstructorWithoutParameters()
        {
            Phase phase = new Phase();
            Assert.AreEqual(-1, phase.getId());
            Assert.AreEqual("", phase.getName());
            DateTime dateTime = new DateTime();
            Assert.AreEqual(dateTime, phase.getDeadline());
        }

        [TestMethod]
        public void testConstructorWithParameters()
        {
            DateTime dateTime = new DateTime(2017, 05, 05);
            Phase phase = new Phase("No. 1", dateTime);
            Assert.AreEqual(phase.getName(), "No. 1");
            DateTime dateTimeNew = new DateTime(2017, 05, 06);
            phase.setDeadline(dateTimeNew);
            Assert.AreEqual(dateTimeNew, phase.getDeadline());
        }
    }
}

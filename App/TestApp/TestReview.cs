using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Entity;

namespace TestApp
{
    [TestClass]
    public class TestReview
    {
        [TestMethod]
        public void testReviewConstructorWithoutParameters()
        {
            Review review = new Review();
            Assert.AreEqual(-1, review.getId());
            Assert.AreEqual("", review.getQualifier());
            Assert.AreEqual("", review.getComment());
            DateTime dateTime = new DateTime();
            Assert.AreEqual(dateTime, review.getDateCreated());
            Assert.AreEqual(null, review.getReviewer());
        }

        [TestMethod]
        public void testReviewConstructorWithParameters()
        {
            Reviewer reviewer = new Reviewer();
            reviewer.setCity("Cluj-Napoca");
            DateTime dateTime = new DateTime(2017, 05, 05);
            Review review = new Review("Accept", "None", reviewer, dateTime);
            Assert.AreEqual("Accept", review.getQualifier());
            review.setComment("Alter");
            Assert.AreEqual("Alter", review.getComment());
            Assert.AreEqual("Cluj-Napoca", review.getReviewer().getCity());
            Assert.AreEqual(dateTime, review.getDateCreated());
        }
    }
}

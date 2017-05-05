using App.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestApp
{
    [TestClass]
    public class TestAuthor
    {
        [TestMethod]
        public void testGetFirstName()
        {
            Author author = new Author();
            author.setFirstName("Andrei");
            Assert.AreEqual("Andrei", author.getFirstName());
        }

        [TestMethod]
        public void testGetLastName()
        {
            Author author = new Author();
            author.setLastName("Matea");
            Assert.AreEqual("Matea", author.getLastName());
        }

        [TestMethod]
        public void testGetBirthdate()
        {
            Author author = new Author();
            DateTime dateTime = new DateTime(2017, 05, 05);
            author.setBirthdate(dateTime);
            Assert.AreEqual(dateTime, author.getBirthdate());
        }

        [TestMethod]
        public void testGetTelephone()
        {
            Author author = new Author();
            author.setTelephone("0764147485");
            Assert.AreEqual("0764147485", author.getTelephone());
        }

        [TestMethod]
        public void testGetEmail()
        {
            Author author = new Author();
            author.setEmail("andrei.matea96@gmail.com");
            Assert.AreEqual("andrei.matea96@gmail.com", author.getEmail());
        }

        [TestMethod]
        public void testGetPassword()
        {
            Author author = new Author();
            author.setPassword("123a");
            Assert.AreEqual("123a", author.getPassword());
        }

        [TestMethod]
        public void testGetAdress()
        {
            Author author = new Author();
            author.setAddress("Cluj-Napoca");
            Assert.AreEqual("Cluj-Napoca", author.getAddress());
        }

        [TestMethod]
        public void testGetCity()
        {
            Author author = new Author();
            author.setCity("Cluj-Napoca");
            Assert.AreEqual("Cluj-Napoca", author.getCity());
        }

        [TestMethod]
        public void testGetCountry()
        {
            Author author = new Author();
            author.setCountry("Romania");
            Assert.AreEqual("Romania", author.getCountry());
        }
    }
}

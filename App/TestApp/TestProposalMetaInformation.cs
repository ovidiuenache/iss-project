using System;
using App.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestApp
{
    [TestClass]
    public class TestProposalMetaInformation
    {
        [TestMethod]
        public void testProposalMetaConstructorWithouParam()
        {
            ProposalMetaInformation proposalMeta = new ProposalMetaInformation();
            Assert.AreEqual(-1, proposalMeta.getId());
            Assert.AreEqual("", proposalMeta.getTitle());
            Assert.AreEqual(-1, proposalMeta.getYear());
            Assert.AreEqual("", proposalMeta.getDescription());
        }

        [TestMethod]
        public void testProposalMetaInformation()
        {
            IList<Author> authors = new List<Author>();
            Author author1 = new Author();
            author1.setCity("Cluj");
            Author author2 = new Author();
            author2.setCity("Targu Jiu");
            authors.Add(author1);
            ProposalMetaInformation proposalMeta = new ProposalMetaInformation("Terra", authors, 2015, "Ceva");
            Assert.AreEqual(proposalMeta.getDescription(), "Ceva");
            Assert.AreEqual(1, proposalMeta.getAuthors().Count);
            proposalMeta.addAuthor(author2);
            Assert.AreEqual(2, proposalMeta.getAuthors().Count);
            proposalMeta.removeAuthor(author1);
            Assert.AreEqual(1, proposalMeta.getAuthors().Count);
        }
    }
}

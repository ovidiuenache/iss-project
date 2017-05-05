using System;
using App.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestApp
{
    [TestClass]
    public class TestProposal
    {
        [TestMethod]
        public void testProposalWithoutParam()
        {
            Proposal proposal = new Proposal();
            Assert.AreEqual(-1, proposal.getId());
            Assert.AreEqual("", proposal.getFullPaper());
            Assert.AreEqual("", proposal.getAbstractPaper());
            Assert.AreEqual(null, proposal.getMetaInformation());
        }

        [TestMethod]
        public void testProposalWithParam()
        {
            Author author = new Author();
            IList<Author> authors = new List<Author>();
            author.setCity("Cluj");
            authors.Add(author);
            ProposalMetaInformation proposalMeta = new ProposalMetaInformation("Terra", authors, 2015, "Ceva");
            Proposal proposal = new Proposal(proposalMeta, "Full", "Abstract");
            Assert.AreEqual(1, proposal.getMetaInformation().getAuthors().Count);
            Assert.AreEqual("Full", proposal.getFullPaper());
            Assert.AreEqual("Abstract", proposal.getAbstractPaper());
        }
    }
}

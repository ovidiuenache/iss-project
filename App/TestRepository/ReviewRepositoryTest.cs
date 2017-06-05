using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Context;
using App.Repository.Impl;

namespace TestRepository
{
    [TestClass]
    public class ReviewRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            AppContext appContext = new AppContext();
            ReviewRepository reviewRepo = new ReviewRepository(appContext);
        }
    }
}

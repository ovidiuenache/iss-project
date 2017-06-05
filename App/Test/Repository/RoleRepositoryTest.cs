using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Repository
{
    /// <summary>
    /// Test class for RoleRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class RoleRepositoryTest
    {
        private RoleRepository roleRepository;
        private Role role;

        [TestInitialize()]
        public void Initialize()
        {
            roleRepository = ApplicationFactory.getRoleRepository();
            role = new Role();
            role.Slug = "chair";
        }

        [TestMethod]
        public void TestgetBySlug()
        {
            roleRepository.Add(role);
            Assert.AreEqual("chair", roleRepository.getBySlug(role.Slug).Slug);
            roleRepository.Delete(role);
        }
    }
}

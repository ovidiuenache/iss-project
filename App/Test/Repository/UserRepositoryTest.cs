using App.Entity;
using App.Factory;
using App.Repository.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using App.Utils;

namespace Test.Repository
{
    /// <summary>
    /// Test class for UserRepository
    /// Author : Matea Andrei
    /// </summary>
    [TestClass]
    public class UserRepositoryTest
    {
        private UserRepository userRepository;
        private UserRoleRepository userRoleRepository;
        private RoleRepository roleRepository;
        private User user;
        private Role role;
        private UserRole userRole;

        [TestInitialize()]
        public void Initialize()
        {
            userRepository = ApplicationFactory.getUserRepository();
            userRoleRepository = ApplicationFactory.getUserRoleRepository();
            roleRepository = ApplicationFactory.getRoleRepository();
            user = new User();
            user.Email = "test@gmail.com";
            user.FirstName = "Test";
            user.Password = "test0";
            role = new Role();
            role.Slug = "listener";

        }
        [TestMethod]
        public void TestFindUserByEmail()
        {
            userRepository.Add(user);
            Assert.AreEqual(userRepository.FindUserByEmail("test@gmail.com").FirstName, user.FirstName);
            userRepository.Delete(user);
        }

        [TestMethod]
        public void TestChangePassword()
        {
            userRepository.Add(user);
            Assert.AreEqual(userRepository.FindUserByEmail("test@gmail.com").Password, user.Password);
            userRepository.ChangePassword("test@gmail.com", "updated");
            var encrypt = new EncryptDecrypt();
            Assert.AreEqual(encrypt.decryptPassword(userRepository.FindUserByEmail(user.Email).Password), "updated");
            userRepository.Delete(user);
        }

        [TestMethod]
        public void TestGetRoles()
        {
            /*
            UserRepository.Add(user);
            Role role = roleRepository.getBySlug("listner");
            UserRoleRepository.Add(new UserRole { UserId = user.UserId, User = user, Role = role, RoleId = role.RoleId });
            */

            userRepository.Add(user);
            roleRepository.Add(role);
            userRole = new UserRole {UserId = user.UserId, User = user, Role = role, RoleId = role.RoleId};
            userRoleRepository.Add(userRole);
            Assert.AreEqual(1,userRepository.GetRoles(user).Count);
            userRoleRepository.Delete(userRole);
            roleRepository.Delete(role);
            userRepository.Delete(user);
        }
    }
}

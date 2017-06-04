using App.Entity;
using System;
using System.Collections.Generic;
using App.Repository;
using App.Utils;

namespace App.Controller
{
    /// <summary>
    /// 
    /// LoginController implementation
    /// Author: Vancea Vlad
    /// Author : Catalin Radoiu
    /// Author : Dezsi Razvan
    /// Author : Ioan Ovidiu Enache
    /// 
    /// 
    /// </summary>
    public class LoginController : ILoginController
    {
        private IUserRepository UserRepository;
        private IConferenceRepository ConferenceRepository;

        public LoginController(IUserRepository userRepository, IConferenceRepository conferenceRepository)
        {
            this.UserRepository = userRepository;
            this.ConferenceRepository = conferenceRepository;
        }

        public User GetUser(string email, string password)
        {
            var decrypt = new EncryptDecrypt();
            User user = UserRepository.FindUserByEmail(email);
            if (user == null)
            {
                return null;
            } 
            else if (decrypt.decryptPassword(user.Password) != password)
            {
                user.Password = password;
                return null;
            }
            else
            {
                return user;
            }
        }

        public bool IsConferenceActive()
        {
            return (ConferenceRepository.GetActiveConference() != null);
        }

        public List<Role> GetUserRoles(User user)
        {
            return UserRepository.GetRoles(user);
        }

        public User GetUserByEmail(String email)
        {
            return UserRepository.FindUserByEmail(email);
        }

        public void ChangePassword(string email,string password)
        {
            UserRepository.ChangePassword(email, password);
        }

        public Conference ActiveConference()
        {
            return ConferenceRepository.GetActiveConference();
        }
    }
}
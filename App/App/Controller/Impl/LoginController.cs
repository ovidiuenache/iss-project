using App.Entity;
using System;
using System.Collections.Generic;
using App.Repository;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Class LoginController
    /// 
    /// Author: Vancea Vlad
    /// Author : Catalin Radoiu
    /// </summary>
    /// 
    public class LoginController : ILoginController
    {
        private IUserRepository UserRepository;
        private IConferenceRepository ConferenceRepository;

        public LoginController()
        {
            
        }

        public LoginController(IUserRepository UserRepository, IConferenceRepository ConferenceRepository)
        {
            this.UserRepository = UserRepository;
            this.ConferenceRepository = ConferenceRepository;
        }

        public User GetUser(string email, string password)
        {
            User user = UserRepository.FindUserByEmail(email);
            if (user.Password == password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public bool IsConferenceActive()
        {
            return (ConferenceRepository.GetActiveConference() != null);
        }

        public string GetUserRole(User user)
        {
            throw new NotImplementedException();
        }

        public Phase CurrentPhase()
        {
            throw new NotImplementedException();
        }
    }
}
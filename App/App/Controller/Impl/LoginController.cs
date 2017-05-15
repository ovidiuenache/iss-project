using App.Entity;
using System;
using System.Collections.Generic;
using App.Repository;

namespace App.Controller
{
    /// <summary>
    /// 
    /// LoginController implementation
    /// Author: Vancea Vlad
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public class LoginController : ILoginController
    {
        private IUserRepository UserRepository;
        private IConferenceRepository ConferenceRepository;

        //Temporary constructor 
        public LoginController()
        {
            
        }

        public LoginController(IUserRepository userRepository, IConferenceRepository conferenceRepository)
        {
            this.UserRepository = userRepository;
            this.ConferenceRepository = conferenceRepository;
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

        public List<Role> GetUserRoles(User user)
        {
            return UserRepository.GetRoles(user);
        }
    }
}
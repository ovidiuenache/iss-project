using System.Collections.Generic;
using App.Entity;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Preliminary Phase Controller interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface IPreliminaryPhaseController
    {
        /// <summary>
        /// Register a new user and notifies the user by email
        /// The user fields are considered allready valid
        /// Throws InvalidEmailAdressException if the email adress is allready in use 
        /// </summary>
        /// <param name="user"></param>
        void Register(User user);

        /// <summary>
        /// Creates a new conference
        /// Throws ConfrenceInProgressException if a conference allready exists
        /// </summary>
        /// <param name="conference"></param>
        /// <param name="comiteeMembers"></param>
        void CreateConference(Conference conference, List<User> comiteeMembers);

        void CreatePhase(Phase phase);

        void UpdateConference(Conference conference);

        User FindUserById(int id);

        Conference ActiveConference();

        Topic FindTopicByName(string topicName);

        List<User> FindAllUsers();

        List<Topic> FindAllTopics();


    }
}
using App.Entity;
using App.Exception;
using App.Repository;
using App.Utils;
using System.Collections.Generic;
using System.Net.Mail;
using App.Factory;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Preliminary Phase Controller implementation
    /// Author : Catalin Radoiu 
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class PreliminaryPhaseController : IPreliminaryPhaseController
    {
        private IUserRepository UserRepository;
        private IConferenceRepository ConferenceRepository;
        private ITopicRepository TopicRepository;
        private IPhaseRepository PhaseRepository;
        private IConferenceUserRepository ConferenceUserRepository;
        private MailSender MailSender;

        public PreliminaryPhaseController(
            IUserRepository userRepository, 
            IConferenceRepository conferenceRepository, 
            ITopicRepository topicRepository, 
            IPhaseRepository phaseRepository,
            IConferenceUserRepository conferenceUserRepository
        )
        {
            UserRepository = userRepository;
            ConferenceRepository = conferenceRepository;
            TopicRepository = topicRepository;
            PhaseRepository = phaseRepository;
            ConferenceUserRepository = conferenceUserRepository;
            MailSender = new MailSender();
        }

        public void Register(User user)
        {
            if (UserRepository.FindUserByEmail(user.Email) != null)
            {
                throw new InvalidEmailAddressException("Email adress is allready in use! Please introduce another " +
                                                       "email adress");
            }
            else
            {
                var encrypt = new EncryptDecrypt();
                user.Password = encrypt.encryptPassword(user.Password);
                UserRepository.Add(user);
                MailAddress sender = new MailAddress("iss.cmsmailer@gmail.com");
                MailAddress receiver = new MailAddress(user.Email);
                string mailBody = "Thank you for your registration. Your account " +
                                  "has been created succesfully.\nYour credentials are : \n" +
                                  "Username : " + user.Email +
                                  "\nPassword : " + encrypt.decryptPassword(user.Password);
                string mailSubject = "Registration complete";
                MailSender.sendMail(receiver, mailBody, mailSubject);
            }
        }

        public void CreateConference(Conference conference, List<User> comiteeMembers)
        {
            if (ConferenceRepository.GetActiveConference() == null)
            {
                var conferenceUsers = new ConferenceUser();
                foreach (var member in comiteeMembers)
                {
                    conferenceUsers = new ConferenceUser();
                    conferenceUsers.User = member;
                    conferenceUsers.Conference = conference;
                    ConferenceUserRepository.Add(conferenceUsers);
                }
            }
            else
            {
                throw new ConferenceInProgressException("Could not create conference. There is allready " +
                                                        "a conference in progress.");
            }
        }

        public void CreatePhase(Phase phase)
        {
            PhaseRepository.Add(phase);
        }

        public void UpdateConference(Conference conference)
        {
            ConferenceRepository.Update(conference);
        }

        public User FindUserById(int id)
        {
            return UserRepository.Find(id);
        }

        public Conference ActiveConference()
        {
            return ConferenceRepository.GetActiveConference();
        }

        public Topic FindTopicByName(string topicName)
        {
            return TopicRepository.FindTopicByName(topicName);
        }

        public List<User> FindAllUsers()
        {
            return UserRepository.All();
        }

        public List<Topic> FindAllTopics()
        {
            return TopicRepository.All();
        }
    }
}
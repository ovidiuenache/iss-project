using App.Entity;
using App.Exception;
using App.Repository;
using App.Utils;
using System.Net.Mail;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Preliminary Phase Controller implementation
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class PreliminaryPhaseController : IPreliminaryPhaseController
    {

        private IUserRepository UserRepository;
        private IConferenceRepository ConferenceRepository;
        private MailSender MailSender;

        public PreliminaryPhaseController(IUserRepository userRepository, IConferenceRepository conferenceRepository)
        {
            this.UserRepository = userRepository;
            this.ConferenceRepository = conferenceRepository;
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
                UserRepository.Add(user);
                MailAddress sender = new MailAddress("iss.cmsmailer@gmail.com");
                MailAddress receiver = new MailAddress(user.Email);
                string mailBody = "Thank you for your registration. Your account " +
                                  "has been created succesfully.\nYour credentials are : \n" +
                                  "Username : " + user.Email + 
                                  "\nPassword : " + user.Password;
                string mailSubject = "Registration complete";
                MailSender.sendMail(sender, receiver, mailBody, mailSubject);
            }
        }

        public void CreateConference(Conference conference)
        {
            if (ConferenceRepository.GetActiveConference() == null)
            {
                ConferenceRepository.Add(conference);
            }
            else
            {
                throw new ConferenceInProgressException("Could not create conference. There is allready " +
                                                        "a conference in progress.");
            }
        }
    }
}
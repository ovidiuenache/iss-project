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
        private IValidator<User> UserValidator;
        private IUserRepository UserRepository;
        private MailSender MailSender;

        public PreliminaryPhaseController(IUserRepository UserRepository, IValidator<User> UserValidator)
        {
            this.UserRepository = UserRepository;
            this.UserValidator = UserValidator;
            MailSender = new MailSender();
        }

        public void Register(User user)
        {
            UserValidator.validate(user);
            if (UserRepository.FindUserByEmail(user.Email) != null)
            {
                throw new InvalidEmailAddressException("Email adress is allready in use! Please introduce another " +
                                                       "email adress");
            }
            else
            {
                UserRepository.Add(user);
                MailAddress Sender = new MailAddress("iss.cmsmailer@gmail.com");
                MailAddress Receiver = new MailAddress(user.Email);
                string MailBody = "Thank you for your registration. Your account " +
                                  "has been created succesfully.\nYour credentials are : \n" +
                                  "Username : " + user.Email + 
                                  "\nPassword : " + user.Password;
                string MailSubject = "Registration complete";
                MailSender.sendMail(Sender, Receiver, MailBody, MailSubject);
            }
        }
    }
}
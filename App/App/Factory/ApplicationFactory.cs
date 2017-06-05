using App.Context;
using App.Controller;
using App.Controller.Impl;
using App.Repository.Impl;

namespace App.Factory
{
    /// <summary>
    /// 
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class ApplicationFactory
    {
        private static AppContext _context = null;

        public static AppContext GetAppContext()
        {
            if (_context == null)
            {
                _context = new AppContext();
            }

            return _context;
        }

        public static UserRepository GetUserRepository()
        {
            return new UserRepository(GetAppContext());
        }

        public static TopicRepository GetTopicRepository()
        {
            return new TopicRepository(GetAppContext());
        }

        public static ConferenceRepository GetConferenceRepository()
        {
            return new ConferenceRepository(GetAppContext());
        }

        public static PhaseRepository GetPhaseRepository()
        {
            return new PhaseRepository(GetAppContext());
        }

        public static ProposalRepository GetProposalRepository()
        {
            return new ProposalRepository(GetAppContext());
        }

        public static ReviewRepository GetReviewRepository()
        {
            return new ReviewRepository(GetAppContext());
        }

        public static UserRoleRepository GetUserRoleRepository()
        {
            return new UserRoleRepository(GetAppContext());
        }

        public static PreliminaryPhaseController GetPreliminaryPhaseController()
        {
            return new PreliminaryPhaseController(
                GetUserRepository(),
                GetConferenceRepository(),
                GetTopicRepository(),
                GetPhaseRepository(),
                GetConferenceUserRepository(),
                GetUserRoleRepository(),
                GetRoleRepository()
            );
        }

        public static LoginController GetLoginController()
        {
            return new LoginController(GetUserRepository(), GetConferenceRepository());
        }

        public static PhaseOneController GetPhaseOneController()
        {
            return new PhaseOneController(GetProposalRepository(), GetUserRepository(), GetConferenceRepository(), GetRoleRepository());
        }

        public static PhaseTwoController GetPhaseTwoController()
        {
            return new PhaseTwoController(GetReviewRepository(), GetProposalRepository(), GetUserRepository(), GetConferenceRepository(), GetUserRoleRepository(), GetRoleRepository());
        }

        public static PhaseThreeController GetPhaseThreeController()
        {
            return new PhaseThreeController(
                GetSectionRepository(),
                GetUserRepository(),
                GetProposalRepository(),
                GetConferenceRepository(),
                GetUserSectionRepository(),
                GetReviewRepository(),
                GetPhaseRepository(),
                GetTopicRepository()
            );
        }

        public static SectionRepository GetSectionRepository()
        {
            return new SectionRepository(GetAppContext());
        }

        public static ConferenceUserRepository GetConferenceUserRepository()
        {
            return new ConferenceUserRepository(GetAppContext());
        }

        public static UserSectionRepository GetUserSectionRepository()
        {
            return new UserSectionRepository(GetAppContext());
        }

        public static RoleRepository GetRoleRepository()
        {
            return new RoleRepository(GetAppContext());
        }
    }
}

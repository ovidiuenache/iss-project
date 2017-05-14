using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{

    /// <summary>
    /// Author: Vancea Vlad
    /// The service who manage the details about a conference
    /// </summary>
    class ConferenceService
    {



        public IList<ConferenceUser> getListenersForConference(Conference conference)
        {
            var result = new List<ConferenceUser>();
            foreach(ConferenceUser user in conference.Users)
            {
                if(user.User.UserRoles.Equals("Listener"))
                {
                    result.Add(user);
                }
            }
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public IList<ConferenceUser> getAuthorsForConference(Conference conference)
        {
            var result = new List<ConferenceUser>();
            foreach (ConferenceUser user in conference.Users)
            {
                if (user.User.UserRoles.Equals("Authors"))
                {
                    result.Add(user);
                }
            }
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}

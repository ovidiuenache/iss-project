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
    /// The controller who manage the details about a conference
    /// </summary>
    class ConferenceController
    {



        public IList<ConferenceUser> getListenersForConference(Conference conference)
        {
            var listeners = new List<ConferenceUser>();
            var emptyArray = new ConferenceUser[0];
            foreach (ConferenceUser user in conference.Users)
            {
                if(user.User.UserRoles.Equals("Listener"))
                {
                    listeners.Add(user);
                }
            }
            if (listeners.Count!=0)
            {
                return listeners;
            }
            return emptyArray;
        }

        public IList<ConferenceUser> getAuthorsForConference(Conference conference)
        {
            var authors = new List<ConferenceUser>();
            var emptyArray = new ConferenceUser[0];
            foreach (ConferenceUser user in conference.Users)
            {
                if (user.User.UserRoles.Equals("Authors"))
                {
                    authors.Add(user);
                }
            }
            if (authors.Count != 0)
            {
                return authors;
            }
            return emptyArray;
        }
    }
}

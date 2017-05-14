using System;
using System.Collections.Generic;
using System.Windows.Forms;
using App.Context;
using App.Entity;
using App.Migrations.Seed;
using App.Repository;
using App.Repository.Impl;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Use this for dummy data
            UserContextSeed.Seed();

            AppContext context = new AppContext();
            IConferenceRepository conferenceRepository = new ConferenceRepository(context);
            conferenceRepository.Add(new Conference("First", new DateTime(2000,10,10), new DateTime(2010, 05,05), 
                null, new List<ConferenceUser>(), 105));
            conferenceRepository.Add(new Conference("Second", new DateTime(2000, 10, 10), new DateTime(2010, 05, 05),
                null, new List<ConferenceUser>(), 105));
            conferenceRepository.Add(new Conference("Third", new DateTime(2000, 10, 10), new DateTime(2010, 05, 05),
                null, new List<ConferenceUser>(), 105));

          /*  IUserRepository userRepo = new UserRepository(context);
            userRepo.Add(new User("first","last","email","pass","test"));*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConferenceDetails());
        }
    }
}

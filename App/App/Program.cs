using System;
using System.Windows.Forms;
using App.Migrations.Seed;
using App.Repository.Impl;
using App.Context;
using App.Controller;
using App.UI;

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
            UserRepository userRepository = new UserRepository(context);
            ConferenceRepository conferenceRepository = new ConferenceRepository(context);
            LoginController loginController = new LoginController(userRepository, conferenceRepository);
            PreliminaryPhaseController preliminaryController = new PreliminaryPhaseController(userRepository, conferenceRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConferenceDetails(loginController, preliminaryController));
           
        }
    }
}

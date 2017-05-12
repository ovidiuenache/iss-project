using System;
using System.Windows.Forms;
using App.Migrations.Seed;
using App.Context;
using App.Repository.Impl;
using App.Entity;
using System.Collections.Generic;
using App.Repository;

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
           // testRepoAdd();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConferenceDetails());
        }

       /* public static void testRepoAdd()
        {
            AppContext context = new AppContext();
            IUserRepository userRepo = new UserRepository(context);
            var user1 = userRepo.findOne(8);
            user1.LastName = "UPDATED !!!";
            //    userRepo.add(user1);
            userRepo.update(user1);
            Console.WriteLine(userRepo.findOne(5).FirstName);
            List<User> users = userRepo.findAll();

            foreach (User o in users)
            {
                Console.WriteLine(o.Email);
            }

            IProposalRepository proposalRepo = new ProposalRepository(context);
            proposalRepo.add(new Proposal(new ProposalMetaInformation("title", userRepo.findAll(), 2000, "desc"),
                "yes", "no"));
        }*/
    }
}

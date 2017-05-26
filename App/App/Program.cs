using System;
using System.Windows.Forms;
using App.Migrations.Seed;
using App.Repository.Impl;
using App.Context;
using App.Controller;
using App.Factory;

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConferenceDetails());
        }
    }
}

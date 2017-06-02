﻿using System;
using System.Windows.Forms;
using App.Migrations.Seed;

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
            TopicSeed.Seed();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConferenceDetails main = new ConferenceDetails();
            main.Show();

            Application.Run();
        }
    }
}

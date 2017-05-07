using App.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           /*  Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());*/

            MailSender sender = new MailSender();
            sender.sendMailFromGmail(new System.Net.Mail.MailAddress("iss.cmsmailer@yahoo.com"), 
                new System.Net.Mail.MailAddress("cata1511@yahoo.com"), "test", "test11");
        }
    }
}

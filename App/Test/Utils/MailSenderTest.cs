using App.Entity;
using App.Factory;
using App.Repository.Impl;
using App.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Utils
{
    /// <summary>
    /// Test class for PhaseRepository
    /// Author : Ioan Ovidiu Enache
    /// </summary>
    [TestClass]
    public class MailSenderTest
    {
        [TestMethod]
        public void TestSendMail()
        {
            MailSender sender = new MailSender();

            try
            {
                sender.sendMail(new System.Net.Mail.MailAddress("test@yahoo.com"), "Test Body", "Test Subject");
                Assert.IsTrue(true);
            }
            #pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
            #pragma warning restore CS0168 // Variable is declared but never used
            {
                Assert.IsTrue(false);
            }
        }
    }
}

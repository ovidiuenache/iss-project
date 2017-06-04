using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Utils;
using System.Text.RegularExpressions;

namespace Test
{
    /// <summary>
    /// Test class for PasswordGenerator
    /// Author : Ioan Ovidiu Enache
    /// </summary>
    [TestClass]
    public class PasswordGeneratorTest
    {
        [TestMethod]
        public void TestGetString()
        {
            PasswordGenerator generator = new PasswordGenerator();
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");

            string password = generator.GetString(8);

            Assert.IsTrue(regex.IsMatch(password));
            Assert.IsTrue(password.Length == 8);
        }
    }
}

using System;
using System.Linq;

namespace App.Utils
{
    /// <summary>
    /// Author : Razvan Dezsi
    /// </summary>
    public class PasswordGenerator
    {
        public string GetString(int length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

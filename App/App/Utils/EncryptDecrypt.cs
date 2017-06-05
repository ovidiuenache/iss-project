using App.Exception;
using System;


namespace App.Utils
{
    public class EncryptDecrypt
    {

        public string EncryptPassword(string data)
        {
            try
            {
                var encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                var encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (BaseException e)
            {
                throw e;
            }
        }

        public string DecryptPassword(string sData)
        {
            var encoder = new System.Text.UTF8Encoding();
            var utf8Decode = encoder.GetDecoder();
            var mod4 = sData.Length % 4;
            if (mod4 > 0)
            {
                sData += new string('=', 4 - mod4);
            }
            var todecode_byte = Convert.FromBase64String(sData);
            var charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            var decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            var result = new String(decoded_char);
            return result;
        }
    }
}


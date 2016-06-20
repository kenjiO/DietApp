using System;
using System.Security.Cryptography;
using System.Text;

namespace DietApp.Model
{
    public class Encryption
    {
        /// <summary>
        /// Gets the hash of the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>A string representation of the hash.</returns>
        public String GetSHA1Hash(String input)
        {
            var x = new SHA1CryptoServiceProvider();
            var bs = Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            var s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            var password = s.ToString();
            return "0x" + password;
        }
    }
}
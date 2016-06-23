using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;
using System.Security.Cryptography;
using System.Text;

namespace DietApp.ModelTest
{
    /// <summary>
    /// Test the Encryption Class in DietApp.Model
    /// </summary>
    [TestClass]
    public class EncryptionTest
    {
        /// <summary>
        /// Test the encryption of Passwords
        /// </summary>
        [TestMethod]
        public void TestGetSHA1Hash()
        {
            //Set Test Passwords
            String goodPassword = "password";
            String badPassword = "testing";

            //Create goodWord Hash (password)
            SHA1CryptoServiceProvider x = new SHA1CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(goodPassword);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String password = "0x" + s.ToString();

            //Encrypt Test Passwords
            Encryption encrypt = new Encryption();
            String goodResult = encrypt.GetSHA1Hash(goodPassword);
            String badResult = encrypt.GetSHA1Hash(badPassword);

            //Check Test Passwords
            Assert.AreEqual(password, goodResult, "Encryption Error, good result.");
            Assert.AreNotEqual(password, badResult, "Encryption Error, bad result.");
        }
    }
}
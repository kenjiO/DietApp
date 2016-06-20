using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;
using System.Security.Cryptography;
using System.Text;

namespace DietApp.ModelTest
{
    [TestClass]
    public class EncryptionTest
    {
        private String goodWord = "password";
        private String badWord = "testing";

        /// <summary>
        /// Test the encryption of Passwords
        /// </summary>
        [TestMethod]
        public void TestEncryption()
        {
            //Encrypt Testword
            SHA1CryptoServiceProvider x = new SHA1CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(this.goodWord);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String password = "0x" + s.ToString();

            //Send Testword through encryption
            Encryption encrypt = new Encryption();
            String goodResult = encrypt.GetSHA1Hash(this.goodWord);
            String badResult = encrypt.GetSHA1Hash(this.badWord);

            //Test Good and Bad
            Assert.AreEqual(password, goodResult, "Encryption Error, good result.");
            Assert.AreNotEqual(password, badResult, "Encryption Error, bad result.");
        }
    }
}
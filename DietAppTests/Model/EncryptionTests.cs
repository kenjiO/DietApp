//-----------------------------------------------------------------------
// <copyright file="EncryptionTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.Encryption class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.Model
{
    using System.Security.Cryptography;
    using System.Text;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the Encryption Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class EncryptionTests
    {
        /// <summary>
        /// Test the encryption of Passwords.
        /// </summary>
        [TestMethod]
        public void TestGetSHA1Hash()
        {
            // Set Test Passwords
            string goodPassword = "password";
            string badPassword = "testing";

            // Create goodWord Hash (password)
            SHA1CryptoServiceProvider x = new SHA1CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(goodPassword);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }

            string password = "0x" + s.ToString();

            // Encrypt Test Passwords
            Encryption encrypt = new Encryption();
            string goodResult = encrypt.GetSHA1Hash(goodPassword);
            string badResult = encrypt.GetSHA1Hash(badPassword);

            // Check Test Passwords
            Assert.AreEqual(password, goodResult, "Encryption Error, good result.");
            Assert.AreNotEqual(password, badResult, "Encryption Error, bad result.");
        }
    }
}
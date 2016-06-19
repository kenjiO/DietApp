using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;

namespace DietAppTests.Model
{
    [TestClass]
    public class ValidationTest
    {
        Encryption encryption = new Encryption();
        Validation validation = new Validation();

        /// <summary>
        /// Test for validation.
        /// </summary>
        [TestMethod]
        public void TestValidation()
        {
            //Set Test
            String goodPassword = "password";
            String badPassword = "testing";
            bool result = false;

            //Get Hash
            String hash = encryption.GetSAW1Hash(goodPassword);

            //Compare Good
            result = validation.VerifySHA1Hash(goodPassword, hash);
            Assert.IsTrue(result, "Good Password Fails.");

            //Compare Bad
            result = validation.VerifySHA1Hash(badPassword, hash);
            Assert.IsFalse(result, "Bad Password passes.");
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="Model_ValidatorTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.Model_Validator class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.Model
{
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the Model_Validator Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class Model_ValidatorTests
    {
        /// <summary>
        /// Test comparison of Passwords.
        /// </summary>
        [TestMethod]
        public void TestcomparePassword()
        {
            // Set User BB
            string userName = "bb";
            string goodPassword = "abc";
            string badPassword = "123";

            // Checks Passwords
            bool goodResult = Model_Validator.comparePassword(userName, goodPassword);
            bool badResult = Model_Validator.comparePassword(userName, badPassword);

            // Returns Results
            Assert.IsTrue(goodResult, "Correct Password fails.");
            Assert.IsFalse(badResult, "Incorrect Password passes.");
        }

        /// <summary>
        /// Test verifies userName.
        /// </summary>
        [TestMethod]
        public void TestverifyUserName()
        {
            // Set Users
            string userNameGood = "bb";
            string userNameBad = "LeroyBrown";

            // Checks Users
            bool goodResult = Model_Validator.verifyUserName(userNameGood);
            bool badResult = Model_Validator.verifyUserName(userNameBad);

            // Returns Results
            Assert.IsTrue(goodResult, "Valid username fails.");
            Assert.IsFalse(badResult, "Invalid username passes.");
        }
    }
}
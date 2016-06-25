using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DietApp.Model.Tests
{
    /// <summary>
    /// Test the Model_Validator Class in DietApp.Model
    /// </summary>
    [TestClass()]
    public class Model_ValidatorTests
    {
        /// <summary>
        /// Test comparison of Passwords
        /// </summary>
        [TestMethod()]
        public void TestcomparePassword()
        {
            //Set User BB
            String userName = "bb";
            String goodPassword = "abc";
            String badPassword = "123";

            //Checks Passwords
            bool goodResult = Model_Validator.comparePassword(userName, goodPassword);
            bool badResult = Model_Validator.comparePassword(userName, badPassword);

            //Returns Results
            Assert.IsTrue(goodResult, "Correct Password fails.");
            Assert.IsFalse(badResult, "Incorrect Password passes.");
        }
    }
}
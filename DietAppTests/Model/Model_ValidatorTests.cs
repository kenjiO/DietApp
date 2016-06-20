using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;

namespace DietApp.Model.Tests
{
    [TestClass()]
    public class Model_ValidatorTests
    {

        [TestMethod()]
        public void comparePasswordTest()
        {
            //Set User BB
            String username = "bb";
            String goodPassword = "abc";
            String badPassword = "123";

            //Checks Passwords
            bool goodResults = Model_Validator.comparePassword(username, goodPassword);
            bool badResults = Model_Validator.comparePassword(username, badPassword);

            //Returns Results
            Assert.IsTrue(goodResults, "Correct Password fails.");
            Assert.IsFalse(badResults, "Incorrect Password passes.");
        }
    }
}
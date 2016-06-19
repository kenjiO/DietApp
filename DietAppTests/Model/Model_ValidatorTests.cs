using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;

namespace DietApp.Model.Tests
{
    [TestClass()]
    public class Model_ValidatorTests
    {
        Model_Validator validator = new Model_Validator();

        [TestMethod()]
        public void comparePasswordTest()
        {
            //Set User BB
            String username = "bb";
            String goodPassword = "123";
            String badPassword = "abc";

            //Checks Passwords
            bool goodResults = validator.comparePassword(username, goodPassword);
            bool badResults = validator.comparePassword(username, badPassword);

            //Returns Results
            Assert.IsTrue(goodResults, "Correct Password fails.");
            Assert.IsFalse(badResults, "Incorrect Password passes.");
        }
    }
}
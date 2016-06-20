using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Controller;
using System.Collections.Generic;

namespace DietApp.Controller.Tests
{
    [TestClass()]
    public class DietAppControllerTests
    {
        [TestMethod()]
        public void comparePasswordTest()
        {
            //Set User BB
            String username = "bb";
            String goodPassword = "abc";
            String badPassword = "123";

            //Checks Passwords
            bool goodResults = DietAppController.comparePassword(username, goodPassword);
            bool badResults = DietAppController.comparePassword(username, badPassword);

            //Returns Results
            Assert.IsTrue(goodResults, "Correct Password fails.");
            Assert.IsFalse(badResults, "Incorrect Password passes.");
        }

        [TestMethod()]
        public void getUserDataTest()
        {
            //Set User AA
            int userId = 1;
            String username = "aa";
            String firstName = "Al";

            //Get User AA (by userId)
            Assert.AreEqual(firstName, DietAppController.getUserData(userId).firstName, "AA's firstName not " + firstName + ".");

            //Get User AA (by userName)
            Assert.AreEqual(firstName, DietAppController.getUserData(username).firstName, "AA's firstName not " + firstName + ".");
        }

        [TestMethod()]
        public void addUserData()
        {
            //Set New User
            String username = "ee";
            String password = "password";
            int ddId = 0;



            //Create New User
            ddId = DietAppController.addNewUser(username, password);
            Assert.AreNotEqual(0, ddId, "New User not added.");

            //Deletes Test New User
            //bool results = DietAppController.deleteUsers(username);
            //Assert.IsTrue(results, "New Test User not Deleted.");
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Controller;
using System.Collections.Generic;
using DietApp.DAL;
using DietApp.Model;

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

            //Deletes Test New User (Uses UsersDAL to Prevent Delete Testing Method from being accessed by controller.
            UsersDAL.deleteUsers(ddId);
            Users ee = UsersDAL.getUserData(ddId);
            Assert.AreEqual(0, ee.userId, "New Test User not Deleted.");
        }

        [TestMethod()]
        public void TestUpdateUser()
        {
            //Set User BB
            int userId = 2;
            String firstName = "Emitt";
            Users originalUser = UsersDAL.getUserData(userId);

            //Get User AA (by userName)
            Users oldUser = DietAppController.getUserData(userId);
            Users newUser = DietAppController.getUserData(userId);
            newUser.userId = userId;
            newUser.firstName = firstName;

            //Update BB
            DietAppController.updateUsers(oldUser, newUser);
            Users testUser = DietAppController.getUserData(userId);

            //Check Results, expected Update
            Assert.AreEqual(newUser.userId, testUser.userId, "testUser's userId not " + newUser.userId + ".");
            Assert.AreEqual(newUser.firstName, testUser.firstName, "testUser's firstName not " + newUser.firstName + ".");

            //Rest to Original
            UsersDAL.updateUsers(testUser, originalUser);
            testUser = DietAppController.getUserData(userId);

            //Check Results, expected Origianl
            Assert.AreEqual(originalUser.userId, testUser.userId, "testUser's userId not " + originalUser.userId + ".");
            Assert.AreEqual(originalUser.firstName, testUser.firstName, "testUser's firstName not " + originalUser.firstName + ".");
        }
    }
}
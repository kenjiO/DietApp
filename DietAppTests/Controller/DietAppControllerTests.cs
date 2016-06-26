﻿using DietApp.DAL;
using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DietApp.Controller.Tests
{
    /// <summary>
    /// Test the DietAppController Class in DietApp.Controller
    /// </summary>
    [TestClass()]
    public class DietAppControllerTests
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
            bool goodResults = DietAppController.comparePassword(userName, goodPassword);
            bool badResults = DietAppController.comparePassword(userName, badPassword);

            //Returns Results
            Assert.IsTrue(goodResults, "Correct Password fails.");
            Assert.IsFalse(badResults, "Incorrect Password passes.");
        }

        /// <summary>
        /// Test for return of user data
        /// </summary>
        [TestMethod()]
        public void TestgetUserData()
        {
            //Set User AA
            int userId = 1;
            String userName = "aa";
            String firstName = "Al";

            //Get User AA (by userId)
            Assert.AreEqual(firstName, DietAppController.getUserData(userId).firstName, "AA's firstName not " + firstName + ".");

            //Get User AA (by userName)
            Assert.AreEqual(firstName, DietAppController.getUserData(userName).firstName, "AA's firstName not " + firstName + ".");
        }

        /// <summary>
        /// Test for add newuser, return of user data
        /// intial profile setup
        /// will delete then completed
        /// </summary>
        [TestMethod()]
        public void TestaddUserData()
        {
            //Set New User
            String userName = "ee";
            String password = "password";

            //Create New User
            int ddId = DietAppController.addNewUser(userName, password);
            Assert.AreNotEqual(0, ddId, "New User not added.");

            //Deletes Test New User (Uses UsersDAL to Prevent Delete Testing Method from being accessed by controller.
            UsersDAL.deleteUsers(ddId);
            Users ee = UsersDAL.getUserData(ddId);
            Assert.AreEqual(0, ee.userId, "New Test User not Deleted.");
        }

        /// <summary>
        /// Test for update of user data
        /// will reverse when complete
        /// </summary>
        [TestMethod()]
        public void TestupdateUsers()
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
            Assert.AreEqual(newUser.userId, testUser.userId, "TestUser's userId not " + newUser.userId + ".");
            Assert.AreEqual(newUser.firstName, testUser.firstName, "TestUser's firstName not " + newUser.firstName + ".");

            //Rest to Original
            UsersDAL.updateUsers(testUser, originalUser);
            testUser = DietAppController.getUserData(userId);

            //Check Results, expected Origianl
            Assert.AreEqual(originalUser.userId, testUser.userId, "OriginalUser's userId not " + originalUser.userId + ".");
            Assert.AreEqual(originalUser.firstName, testUser.firstName, "OriginalUser's firstName not " + originalUser.firstName + ".");
        }

        [TestMethod()]
        public static void updateUsers()
        {
        }

        [TestMethod()]
        public static void dateWellnessData()
        {
            //Sets the values.
            int weight = 210;
            int heartRate = 65;
            int systolicBP = 100;
            int diastolicBP = 80;
            int userID = 1;
            var date = Convert.ToDateTime("06/23/2016");

            //Builds a Wellness object.
            var testWellness = DietAppController.dateWellnessData(userID, date.ToString());

            //Checks Results
            Assert.AreEqual(weight, testWellness.weight, "Wellness object's weight not " + weight + ".");
            Assert.AreEqual(heartRate, testWellness.heartRate, "Wellness object's weight not " + heartRate + ".");
            Assert.AreEqual(systolicBP, testWellness.systolicBP, "Wellness object's systolic BP not " + systolicBP + ".");
            Assert.AreEqual(diastolicBP, testWellness.diastolicBP, "Wellness object's diastolic BP not " + diastolicBP + ".");
            Assert.AreEqual(userID, testWellness.userID, "Wellness object's userId not " + userID + ".");
            Assert.AreEqual(date, testWellness.date, "Wellness object's date not " + date + ".");
        }

        [TestMethod()]
        public static void addDailyWellnessData()
        {
            int weight = 213;
            int heartRate = 95;
            int systolicBP = 110;
            int diastolicBP = 80;
            int userID = 1;
            var date = Convert.ToDateTime("06/22/2016");
            var compare = new Wellness
            {
                diastolicBP = diastolicBP,
                systolicBP = systolicBP,
                weight = weight,
                heartRate = heartRate,
                date = date,
                userID = userID
            };

            //Builds a Wellness object.
            DietAppController.addDailyWellnessData(compare);
            var testWellness = DietAppController.dateWellnessData(userID, date.ToString());

            //Checks Results
            Assert.AreEqual(weight, testWellness.weight, "Wellness object's weight not " + weight + ".");
            Assert.AreEqual(heartRate, testWellness.heartRate, "Wellness object's weight not " + heartRate + ".");
            Assert.AreEqual(systolicBP, testWellness.systolicBP, "Wellness object's systolic BP not " + systolicBP + ".");
            Assert.AreEqual(diastolicBP, testWellness.diastolicBP, "Wellness object's diastolic BP not " + diastolicBP + ".");
            Assert.AreEqual(userID, testWellness.userID, "Wellness object's userId not " + userID + ".");
            Assert.AreEqual(date, testWellness.date, "Wellness object's date not " + date + ".");
        }

        [TestMethod()]
        public static void updateDailyWellnessData()
        {
            //TO DO:  UNDER DEVELOPMENT FOR ITERATION 2.
        }
    }
}
//-----------------------------------------------------------------------
// <copyright file="DietAppControllerTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Controller.DietAppController class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Transactions;
    using DietApp.Controller;
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the DietAppController Class in DietApp.Controller.
    /// </summary>
    [TestClass]
    public class DietAppControllerTests
    {
        /// <summary>
        /// Test comparison of Passwords.
        /// </summary>
        [TestMethod]
        public void TestcomparePassword()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set User BB
                string userName = "bb";
                string goodPassword = "abc";
                string badPassword = "123";

                // Checks Passwords
                bool goodResults = DietAppController.comparePassword(userName, goodPassword);
                bool badResults = DietAppController.comparePassword(userName, badPassword);

                // Returns Results
                Assert.IsTrue(goodResults, "Correct Password fails.");
                Assert.IsFalse(badResults, "Incorrect Password passes.");
            }
        }

        /// <summary>
        /// Test for return of user data.
        /// </summary>
        [TestMethod]
        public void TestgetUserData()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set User AA
                int userId = 1;
                string userName = "aa";
                string firstName = "Al";

                // Get User AA (by userId)
                Assert.AreEqual(firstName, DietAppController.getUserData(userId).firstName, "AA's firstName not " + firstName + ".");

                // Get User AA (by userName)
                Assert.AreEqual(firstName, DietAppController.getUserData(userName).firstName, "AA's firstName not " + firstName + ".");
            }
        }

        /// <summary>
        /// Test for add new user, return of user data
        /// initial profile setup
        /// will delete then completed.
        /// </summary>
        [TestMethod]
        public void TestaddUserData()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set New User
                string userName = "ee";
                string password = "password";

                // Create New User
                int userId = DietAppController.addNewUser(userName, password);
                Assert.AreNotEqual(0, userId, "New User not added.");

                // Deletes Test New User (Uses UsersDAL to Prevent Delete Testing Method from being accessed by controller.
                UsersDAL.deleteUsers(userId);
                Users ee = UsersDAL.getUserData(userId);
                Assert.AreEqual(0, ee.userId, "New Test User not Deleted.");
            }
        }

        /// <summary>
        /// Test for update of user data
        /// will reverse when complete.
        /// </summary>
        [TestMethod]
        public void TestupdateUsers()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set User BB
                int userId = 2;
                string firstName = "Emitt";
                Users originalUser = UsersDAL.getUserData(userId);

                // Get User AA (by userName)
                Users oldUser = DietAppController.getUserData(userId);
                Users newUser = DietAppController.getUserData(userId);
                newUser.userId = userId;
                newUser.firstName = firstName;

                // Update BB
                DietAppController.updateUsers(oldUser, newUser);
                Users testUser = DietAppController.getUserData(userId);

                // Check Results, expected Update
                Assert.AreEqual(newUser.userId, testUser.userId, "TestUser's userId not " + newUser.userId + ".");
                Assert.AreEqual(newUser.firstName, testUser.firstName, "TestUser's firstName not " + newUser.firstName + ".");

                // Rest to Original
                UsersDAL.updateUsers(testUser, originalUser);
                testUser = DietAppController.getUserData(userId);

                // Check Results, expected Origianl
                Assert.AreEqual(originalUser.userId, testUser.userId, "OriginalUser's userId not " + originalUser.userId + ".");
                Assert.AreEqual(originalUser.firstName, testUser.firstName, "OriginalUser's firstName not " + originalUser.firstName + ".");
            }
        }

        /// <summary>
        /// Test for update of wellness data.
        /// </summary>
        [TestMethod]
        public void TestdateWellnessData()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Sets the values.
                int weight = 210;
                int heartRate = 65;
                int systolicBP = 100;
                int diastolicBP = 80;
                int userID = 1;
                var date = Convert.ToDateTime("06/23/2016");

                // Builds a Wellness object.
                var testWellness = DietAppController.dateWellnessData(userID, date.ToString());

                // Checks Results
                Assert.AreEqual(weight, testWellness.weight, "Wellness object's weight not " + weight + ".");
                Assert.AreEqual(heartRate, testWellness.heartRate, "Wellness object's weight not " + heartRate + ".");
                Assert.AreEqual(systolicBP, testWellness.systolicBP, "Wellness object's systolic BP not " + systolicBP + ".");
                Assert.AreEqual(diastolicBP, testWellness.diastolicBP, "Wellness object's diastolic BP not " + diastolicBP + ".");
                Assert.AreEqual(userID, testWellness.userID, "Wellness object's userId not " + userID + ".");
                Assert.AreEqual(date, testWellness.date, "Wellness object's date not " + date + ".");
            }
        }

        /// <summary>
        /// Test for add wellness data.
        /// </summary>
        [TestMethod]
        public void TestaddDailyWellnessData()
        {
            using (TransactionScope transaction = new TransactionScope())
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

                // Builds a Wellness object.
                DietAppController.addDailyWellnessData(compare);
                var testWellness = DietAppController.dateWellnessData(userID, date.ToString());

                // Checks Results
                Assert.AreEqual(weight, testWellness.weight, "Wellness object's weight not " + weight + ".");
                Assert.AreEqual(heartRate, testWellness.heartRate, "Wellness object's weight not " + heartRate + ".");
                Assert.AreEqual(systolicBP, testWellness.systolicBP, "Wellness object's systolic BP not " + systolicBP + ".");
                Assert.AreEqual(diastolicBP, testWellness.diastolicBP, "Wellness object's diastolic BP not " + diastolicBP + ".");
                Assert.AreEqual(userID, testWellness.userID, "Wellness object's userId not " + userID + ".");
                Assert.AreEqual(date, testWellness.date, "Wellness object's date not " + date + ".");
            }
        }

        /// <summary>
        /// Test for wellness data.
        /// </summary>
        [TestMethod]
        public void TestupdateDailyWellnessData()
        {
            // TO DO:  UNDER DEVELOPMENT FOR ITERATION 2.
        }

        /// <summary>
        /// Test return of empty list with no entries.
        /// </summary>
        [TestMethod]
        public void TestgetFoodEntriesForUserByDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = 1;
                List<FoodEntry> entries = DietAppController.getFoodEntriesForUserByDate(userId, new DateTime(2016, 03, 12));
                Assert.AreEqual(0, entries.Count);
            }
        }

        /// <summary>
        /// Test for add food entry.
        /// </summary>
        [TestMethod]
        public void TestAnEntryCanBeAddedToTheDB()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = 1;
                string name = "test food item";
                int? calories = 200;
                int? protein = 7;
                int? fat = 2;
                int? carbohydrates = 40;
                DateTime consumedAt = new DateTime(2016, 06, 11, 23, 22, 00);
                DietAppController.addFoodEntry(userId, name, calories, protein, fat, carbohydrates, consumedAt);
                FoodEntry retreivedEntry = FoodEntryDAL.getEntry(userId, consumedAt, name);
                Assert.IsNotNull(retreivedEntry);
                Assert.AreEqual(1, retreivedEntry.UserId);
                Assert.AreEqual(name, retreivedEntry.Name);
                Assert.AreEqual(calories, retreivedEntry.Calories);
                Assert.AreEqual(protein, retreivedEntry.Protein);
                Assert.AreEqual(fat, retreivedEntry.Fat);
                Assert.AreEqual(carbohydrates, retreivedEntry.Carbohydrates);
                Assert.AreEqual(consumedAt, retreivedEntry.ConsumedAt);
            }
        }
    }
}
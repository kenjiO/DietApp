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
    using DietApp.Controller;
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Transactions;

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

        /// <summary>
        ///  Test exporting and then importing into a user with no entries
        /// </summary>
        [TestMethod]
        public void TestExportingAndImportingToNewUserWillProduceSameEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int user1Id = UsersDAL.addNewUser("importExportTestUser1", "ABC123xyz!");

                var wellness1 = new Wellness
                {
                    diastolicBP = 80,
                    systolicBP = 120,
                    weight = 180,
                    heartRate = 66,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = user1Id
                };
                WellnessDAL.addDailyWellnessData(wellness1);
                var wellness2 = new Wellness
                {
                    diastolicBP = 81,
                    systolicBP = 121,
                    weight = 181,
                    heartRate = 67,
                    date = Convert.ToDateTime("06/24/2016"),
                    userID = user1Id
                };
                WellnessDAL.addDailyWellnessData(wellness2);

                FoodEntry food1 = new FoodEntry(user1Id, "apple", 120, 20, 21, 40, new DateTime(2016, 01, 05));
                FoodEntry food2 = new FoodEntry(user1Id, "banana", 121, 1, 2, 41, new DateTime(2016, 01, 06));
                FoodEntryDAL.addEntry(food1);
                FoodEntryDAL.addEntry(food2);

                FileStream outFile = new FileStream("TestExportFile.health",
                         FileMode.Create,
                         FileAccess.Write, FileShare.None);
                DietAppController.exportData(user1Id, outFile);
                outFile.Close();

                //Create new user and import data
                int user2Id = UsersDAL.addNewUser("importExportTestUser2", "ABC123xyz!");
                Stream inFile = new FileStream("TestExportFile.health",
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                DietAppController.importData(user2Id, inFile);

                List<Wellness> user2Wellnes = WellnessDAL.getUserWellnessEntries(user2Id);
                Assert.AreEqual(2, user2Wellnes.Count);
                Assert.AreEqual(80, user2Wellnes[0].diastolicBP);
                Assert.AreEqual(120, user2Wellnes[0].systolicBP);
                Assert.AreEqual(180, user2Wellnes[0].weight);
                Assert.AreEqual(66, user2Wellnes[0].heartRate);
                Assert.AreEqual(81, user2Wellnes[1].diastolicBP);
                Assert.AreEqual(121, user2Wellnes[1].systolicBP);
                Assert.AreEqual(181, user2Wellnes[1].weight);

                List<FoodEntry> user2Foods = FoodEntryDAL.getUserEntries(user2Id);
                Assert.AreEqual(2, user2Foods.Count);
                Assert.AreEqual("apple", user2Foods[0].Name);
                Assert.AreEqual(120, user2Foods[0].Calories);
                Assert.AreEqual(20, user2Foods[0].Fat);
                Assert.AreEqual(21, user2Foods[0].Protein);
                Assert.AreEqual(40, user2Foods[0].Carbohydrates);
                Assert.AreEqual("banana", user2Foods[1].Name);
                Assert.AreEqual(121, user2Foods[1].Calories);
                Assert.AreEqual(1, user2Foods[1].Fat);
                Assert.AreEqual(2, user2Foods[1].Protein);
                Assert.AreEqual(41, user2Foods[1].Carbohydrates);
            }
        }

        /// <summary>
        ///  Test importing will not overwrite existing entries
        /// </summary>
        [TestMethod]
        public void TestImportingDataWillNotOverwriteExistingEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int user1Id = UsersDAL.addNewUser("importExportTestUser1", "ABC123xyz!");

                var wellness1 = new Wellness
                {
                    diastolicBP = 79,
                    systolicBP = 119,
                    weight = 179,
                    heartRate = 69,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = user1Id
                };
                WellnessDAL.addDailyWellnessData(wellness1);
                var wellness2 = new Wellness
                {
                    diastolicBP = 81,
                    systolicBP = 121,
                    weight = 181,
                    heartRate = 67,
                    date = Convert.ToDateTime("06/24/2016"),
                    userID = user1Id
                };
                WellnessDAL.addDailyWellnessData(wellness2);

                FoodEntry food1 = new FoodEntry(user1Id, "apple", 129, 29, 29, 49, new DateTime(2016, 01, 05));
                FoodEntry food2 = new FoodEntry(user1Id, "banana", 121, 1, 2, 41, new DateTime(2016, 01, 06));
                FoodEntryDAL.addEntry(food1);
                FoodEntryDAL.addEntry(food2);

                FileStream outFile = new FileStream("TestExportFile2.health",
                         FileMode.Create,
                         FileAccess.Write, FileShare.None);
                DietAppController.exportData(user1Id, outFile);
                outFile.Close();

                int user2Id = UsersDAL.addNewUser("importExportTestUser2", "ABC123xyz!");
                var existingWellness = new Wellness
                {
                    diastolicBP = 80,
                    systolicBP = 120,
                    weight = 180,
                    heartRate = 66,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = user2Id
                };
                WellnessDAL.addDailyWellnessData(existingWellness);
                FoodEntry existingFood = new FoodEntry(user2Id, "apple", 120, 20, 21, 40, new DateTime(2016, 01, 05));
                FoodEntryDAL.addEntry(existingFood);

                Stream inFile = new FileStream("TestExportFile2.health",
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                DietAppController.importData(user2Id, inFile);

                List<Wellness> user2Wellnes = WellnessDAL.getUserWellnessEntries(user2Id);
                Assert.AreEqual(2, user2Wellnes.Count);
                Assert.AreEqual(80, user2Wellnes[0].diastolicBP);
                Assert.AreEqual(120, user2Wellnes[0].systolicBP);
                Assert.AreEqual(180, user2Wellnes[0].weight);
                Assert.AreEqual(66, user2Wellnes[0].heartRate);
                Assert.AreEqual(81, user2Wellnes[1].diastolicBP);
                Assert.AreEqual(121, user2Wellnes[1].systolicBP);
                Assert.AreEqual(181, user2Wellnes[1].weight);

                List<FoodEntry> user2Foods = FoodEntryDAL.getUserEntries(user2Id);
                Assert.AreEqual(2, user2Foods.Count);
                Assert.AreEqual("apple", user2Foods[0].Name);
                Assert.AreEqual(120, user2Foods[0].Calories);
                Assert.AreEqual(20, user2Foods[0].Fat);
                Assert.AreEqual(21, user2Foods[0].Protein);
                Assert.AreEqual(40, user2Foods[0].Carbohydrates);
                Assert.AreEqual("banana", user2Foods[1].Name);
                Assert.AreEqual(121, user2Foods[1].Calories);
                Assert.AreEqual(1, user2Foods[1].Fat);
                Assert.AreEqual(2, user2Foods[1].Protein);
                Assert.AreEqual(41, user2Foods[1].Carbohydrates);
            }
        }

        /// <summary>
        ///  Test exporting with no entries creates an import file with no entries
        /// </summary>
        [TestMethod]
        public void TestExportingWithNoEntriesCreatesAnImportFileWithNoEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int user1Id = UsersDAL.addNewUser("importExportTestUser1", "ABC123xyz!");
                FileStream outFile = new FileStream("TestExportFile3.health",
                         FileMode.Create,
                         FileAccess.Write, FileShare.None);
                DietAppController.exportData(user1Id, outFile);
                outFile.Close();

                //Create new user and import data
                int user2Id = UsersDAL.addNewUser("importExportTestUser2", "ABC123xyz!");
                Stream inFile = new FileStream("TestExportFile3.health",
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                DietAppController.importData(user2Id, inFile);

                List<Wellness> user2Wellnes = WellnessDAL.getUserWellnessEntries(user2Id);
                Assert.AreEqual(0, user2Wellnes.Count);
                List<FoodEntry> user2Foods = FoodEntryDAL.getUserEntries(user2Id);
                Assert.AreEqual(0, user2Foods.Count);
            }
        }
    }
}
//-----------------------------------------------------------------------
// <copyright file="WellnessDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.WellnessDAL class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.DAL.Tests
{
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Transactions;
    using System.Collections.Generic;

    /// <summary>
    /// Test the WellnessDAL Class in DietApp.DAL.
    /// </summary>
    [TestClass]
    public class WellnessDALTests
    {
        /// <summary>
        /// Test for wellness data.
        /// </summary>
        [TestMethod]
        public void TestdateWellnessDataTest()
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
                var testWellness = WellnessDAL.dateWellnessData(userID, date.ToString());

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
        public void TestaddDailyWellnessDataTest()
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
                WellnessDAL.addDailyWellnessData(compare);
                var testWellness = WellnessDAL.dateWellnessData(userID, date.ToString());

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
        /// Test for update wellness data.
        /// </summary>
        [TestMethod]
        public void TestupdateDailyWellnessDataTest()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int weight = 212;
                int heartRate = 90;
                int systolicBP = 115;
                int diastolicBP = 82;
                int userID = 1;
                DateTime date = Convert.ToDateTime("06/23/2016");
                var compare = new Wellness
                {
                    diastolicBP = diastolicBP,
                    systolicBP = systolicBP,
                    weight = weight,
                    heartRate = heartRate,
                    date = date,
                    userID = userID
                };

                var oldWellness = WellnessDAL.dateWellnessData(userID, date.ToString());

                // Builds a Wellness object.
                WellnessDAL.updateDailyWellnessData(compare, oldWellness);
                var testWellness = WellnessDAL.dateWellnessData(userID, date.ToString());

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
        /// Test for getting BMI data.
        /// </summary>
        [TestMethod]
        public void TestgetBMI()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int oldBMI = 32;
                int newBMI = 28;

                var theProgress = WellnessDAL.getBMIData(1);

                Assert.AreEqual(oldBMI, theProgress.oldBMI, "The Progress object's old BMI not " + oldBMI + ".");
                Assert.AreEqual(newBMI, theProgress.newBMI, "The Progress object's new BMI not " + newBMI + ".");
            }
        }

        /// <summary>
        /// Test getting wellness entries when no entries
        /// </summary>
        [TestMethod]
        public void TestGetUserWellnessEntriesGetsEmptyListWhenNoEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getUserWellnessEntriesTestUser", "ABC123xyz!");
                List<Wellness> result = WellnessDAL.getUserWellnessEntries(newUserId);
                Assert.AreEqual(0, result.Count);

            }
        }

        /// <summary>
        /// Test getting wellness entries when 1 entry
        /// </summary>
        [TestMethod]
        public void TestGetUserWellnessEntriesGets1Entry()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getUserWellnessEntriesTestUser", "ABC123xyz!");

                var entry = new Wellness
                {
                    diastolicBP = 80,
                    systolicBP = 120,
                    weight = 180,
                    heartRate = 66,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = newUserId
                };

                WellnessDAL.addDailyWellnessData(entry);

                List<Wellness> result = WellnessDAL.getUserWellnessEntries(newUserId);
                Assert.AreEqual(1, result.Count);
                Assert.AreEqual(80, result[0].diastolicBP);
                Assert.AreEqual(120, result[0].systolicBP);
                Assert.AreEqual(180, result[0].weight);
                Assert.AreEqual(66, result[0].heartRate);
            }
        }

        /// <summary>
        /// Test getUserWellnessEntries does not return other user's entries
        /// </summary>
        [TestMethod]
        public void TestGetUserWellnessEntriesDoesNotGetOtherUserEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getUserWellnessEntriesTestUser", "ABC123xyz!");
                int newUserId2 = UsersDAL.addNewUser("getUserWellnessEntriesTestUser2", "ABC123xyz!");

                var entry = new Wellness
                {
                    diastolicBP = 80,
                    systolicBP = 120,
                    weight = 180,
                    heartRate = 66,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = newUserId2
                };

                WellnessDAL.addDailyWellnessData(entry);

                List<Wellness> result = WellnessDAL.getUserWellnessEntries(newUserId);
                Assert.AreEqual(0, result.Count);
            }
        }

        /// <summary>
        /// Test getUserWellnessEntries returns the same 2 entries when there are 2 entries
        /// </summary>
        [TestMethod]
        public void TestGetUserWellnessEntriesGets2Entries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getUserWellnessEntriesTestUser", "ABC123xyz!");

                var entry = new Wellness
                {
                    diastolicBP = 80,
                    systolicBP = 120,
                    weight = 180,
                    heartRate = 66,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = newUserId
                };
                WellnessDAL.addDailyWellnessData(entry);
                var entry2 = new Wellness
                {
                    diastolicBP = 81,
                    systolicBP = 121,
                    weight = 181,
                    heartRate = 67,
                    date = Convert.ToDateTime("06/24/2016"),
                    userID = newUserId
                };
                WellnessDAL.addDailyWellnessData(entry2);

                List<Wellness> result = WellnessDAL.getUserWellnessEntries(newUserId);
                Assert.AreEqual(2, result.Count);
                Assert.AreEqual(80, result[0].diastolicBP);
                Assert.AreEqual(120, result[0].systolicBP);
                Assert.AreEqual(180, result[0].weight);
                Assert.AreEqual(66, result[0].heartRate);
                Assert.AreEqual(81, result[1].diastolicBP);
                Assert.AreEqual(121, result[1].systolicBP);
                Assert.AreEqual(181, result[1].weight);
                Assert.AreEqual(67, result[1].heartRate);
            }
        }

        /// <summary>
        /// Test getUserWellnessEntries returns the same 3 entries when there are 3 entries
        /// </summary>
        [TestMethod]
        public void TestGetUserWellnessEntriesGets3Entries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getUserWellnessEntriesTestUser", "ABC123xyz!");

                var entry = new Wellness
                {
                    diastolicBP = 80,
                    systolicBP = 120,
                    weight = 180,
                    heartRate = 66,
                    date = Convert.ToDateTime("06/23/2016"),
                    userID = newUserId
                };
                WellnessDAL.addDailyWellnessData(entry);
                var entry2 = new Wellness
                {
                    diastolicBP = 81,
                    systolicBP = 121,
                    weight = 181,
                    heartRate = 67,
                    date = Convert.ToDateTime("06/24/2016"),
                    userID = newUserId
                };
                WellnessDAL.addDailyWellnessData(entry2);
                var entry3 = new Wellness
                {
                    diastolicBP = 82,
                    systolicBP = 122,
                    weight = 182,
                    heartRate = 68,
                    date = Convert.ToDateTime("06/25/2016"),
                    userID = newUserId
                };

                WellnessDAL.addDailyWellnessData(entry3);
                List<Wellness> result = WellnessDAL.getUserWellnessEntries(newUserId);
                Assert.AreEqual(3, result.Count);
                Assert.AreEqual(80, result[0].diastolicBP);
                Assert.AreEqual(120, result[0].systolicBP);
                Assert.AreEqual(180, result[0].weight);
                Assert.AreEqual(66, result[0].heartRate);
                Assert.AreEqual(81, result[1].diastolicBP);
                Assert.AreEqual(121, result[1].systolicBP);
                Assert.AreEqual(181, result[1].weight);
                Assert.AreEqual(67, result[1].heartRate);
                Assert.AreEqual(82, result[2].diastolicBP);
                Assert.AreEqual(122, result[2].systolicBP);
                Assert.AreEqual(182, result[2].weight);
                Assert.AreEqual(68, result[2].heartRate);
            }
        }
    }
}
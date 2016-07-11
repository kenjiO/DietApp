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
    }
}
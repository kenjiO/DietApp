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
    using System;
    using DietApp.Controller;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        /// <summary>
        /// Test for add wellness data.
        /// </summary>
        [TestMethod]
        public void TestaddDailyWellnessDataTest()
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

        /// <summary>
        /// Test for update wellness data.
        /// </summary>
        [TestMethod]
        public void TestupdateDailyWellnessDataTest()
        {
            int weight = 212;
            int heartRate = 90;
            int systolicBP = 115;
            int diastolicBP = 82;
            int userID = 1;
            DateTime date = Convert.ToDateTime("06/22/2016");
            var compare = new Wellness
            {
                diastolicBP = diastolicBP,
                systolicBP = systolicBP,
                weight = weight,
                heartRate = heartRate,
                date = date,
                userID = userID
            };

            var oldWellness = DietAppController.dateWellnessData(userID, date.ToString());

            // Builds a Wellness object.
            DietAppController.updateDailyWellnessData(compare, oldWellness);
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
}
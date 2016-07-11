//-----------------------------------------------------------------------
// <copyright file="WellnessTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.Wellness class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTest.Model
{
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Test the Wellness Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class WellnessTests
    {
        /// <summary>
        /// Test for newly created Wellness, all gets show return 0.
        /// </summary>
        [TestMethod]
        public void TestNullWellness()
        {
            // Create Wellness (New)
            Wellness wellness = new Wellness();
            string wellnessString = "DietApp.Model.Wellness - " +
                "0 - " +
                "0 - " +
                "1/1/0001 12:00:00 AM - " +
                "0 lb. - " +
                "0 bpm. - " +
                "0/0";

            // Check Wellness Data
            Assert.AreEqual(0, wellness.dailyMeasurementID, 0, "Wellness's dailyMeasurementId not 0.");
            Assert.AreEqual(0, wellness.weight, 0, "Wellness's weight not 0.");
            Assert.AreEqual(0, wellness.heartRate, 0, "Wellness's heartRate not 0.");
            Assert.AreEqual(0, wellness.systolicBP, 0, "Wellness's systolicBP not 0.");
            Assert.AreEqual(0, wellness.diastolicBP, 0, "Wellness's diastolicBP not 0.");
            Assert.AreEqual(0, wellness.userID, 0, "Wellness's userID not 0.");
            Assert.AreEqual(new DateTime(), wellness.date, "Wellness's date not " + new DateTime() + ".");
            Assert.AreEqual(wellnessString, wellness.ToString(), "Wellness's info not " + wellnessString + ".");
        }

        /// <summary>
        /// Test for set and get of a wellness, Wellness class.
        /// </summary>
        [TestMethod]
        public void TestActiveWellness()
        {
            // Set Wellness
            int dailyMeasurementID = 1;
            int weight = 150;
            int heartRate = 92;
            int systolicBP = 124;
            int diastolicBP = 98;
            int userID = 1;
            DateTime date = Convert.ToDateTime("2016-06-24");
            string wellnessString = "DietApp.Model.Wellness - " +
                userID + " - " +
                dailyMeasurementID + " - " +
                date.ToString() + " - " +
                weight + " lb. - " +
                heartRate + " bpm. - " +
                systolicBP + "/" + diastolicBP;

            // Create Wellness (Active)
            Wellness wellness = new Wellness();
            wellness.dailyMeasurementID = dailyMeasurementID;
            wellness.weight = weight;
            wellness.heartRate = heartRate;
            wellness.systolicBP = systolicBP;
            wellness.diastolicBP = diastolicBP;
            wellness.userID = userID;
            wellness.date = date;

            // Check Wellness Data
            Assert.AreEqual(dailyMeasurementID, wellness.dailyMeasurementID, 0, "Wellness's dailyMeasurementID not " + dailyMeasurementID + ".");
            Assert.AreEqual(weight, wellness.weight, 0, "Wellness's weight not " + weight + ".");
            Assert.AreEqual(heartRate, wellness.heartRate, 0, "Wellness's heartRate not " + heartRate + ".");
            Assert.AreEqual(systolicBP, wellness.systolicBP, 0, "Wellness's systolicBP not " + systolicBP + ".");
            Assert.AreEqual(diastolicBP, wellness.diastolicBP, 0, "Wellness's diastolicBP not " + diastolicBP + ".");
            Assert.AreEqual(userID, wellness.userID, 0, "Wellness's userID not " + userID + ".");
            Assert.AreEqual(date, wellness.date, "Wellness's date not " + date + ".");
            Assert.AreEqual(wellnessString, wellness.ToString(), "Wellness's info not " + wellnessString + ".");
        }
    }
}
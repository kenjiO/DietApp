//-----------------------------------------------------------------------
// <copyright file="DailyMeasurementsTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.DailyMeasurements class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTest.Model
{
    using System;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the DailyMeasurements Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class DailyMeasurementsTests
    {
        /// <summary>
        /// Test for newly created DailyMeasurements, all gets show return 0.
        /// </summary>
        [TestMethod]
        public void TestNullDailyMeasurements()
        {
            // Create DailyeMeasurements (New)
            DailyMeasurements dailyMeasurements = new DailyMeasurements();

            // Check DailyMeasurements Data
            Assert.AreEqual(0, dailyMeasurements.DailyMeasurementId, 0, "DailyMeasurement's DailyMeasurementId not 0.");
            Assert.AreEqual(new DateTime(), dailyMeasurements.Date, "DailyMeasurement's Date not " + new DateTime() + ".");
            Assert.AreEqual(0, dailyMeasurements.UserId, "DailyMeasurement's UserId not 0.");
            Assert.AreEqual(0, dailyMeasurements.MeasurementTypeId, "DailyMeasurement's MeasurementTypeId not 0.");
            Assert.AreEqual(0, dailyMeasurements.Measurement, "DailyMeasurement's Measurement not 0.");
        }

        /// <summary>
        /// Test for set and get of a dailyMeasurements, DailyMeasurements class.
        /// </summary>
        [TestMethod]
        public void TestActiveDailyMeasurements()
        {
            // Set DailyMeasurements
            int dailyMeasurementId = 1;
            DateTime date = Convert.ToDateTime("2016-06-24");
            int userId = 1;
            int measurementTypeId = 1;
            int measurement = 169;

            // Create DailyMeasurements (Active)
            DailyMeasurements dailyMeasurements = new DailyMeasurements();
            dailyMeasurements.DailyMeasurementId = dailyMeasurementId;
            dailyMeasurements.Date = date;
            dailyMeasurements.UserId = userId;
            dailyMeasurements.MeasurementTypeId = measurementTypeId;
            dailyMeasurements.Measurement = measurement;

            // Check DailyMeasurements Data
            Assert.AreEqual(dailyMeasurementId, dailyMeasurements.DailyMeasurementId, 0, "DailyMeasurement's DailyMeasurementId not " + dailyMeasurementId + ".");
            Assert.AreEqual(date, dailyMeasurements.Date, "DailyMeasurement's Date not " + date + ".");
            Assert.AreEqual(userId, dailyMeasurements.UserId, "DailyMeasurement's firstName not " + userId + ".");
            Assert.AreEqual(measurementTypeId, dailyMeasurements.MeasurementTypeId, "DailyMeasurement's MeasurementTypeId not " + measurementTypeId + ".");
            Assert.AreEqual(measurement, dailyMeasurements.Measurement, "DailyMeasurement's Measurement not " + measurement + ".");
        }
    }
}
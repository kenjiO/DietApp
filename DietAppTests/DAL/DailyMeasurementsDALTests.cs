//-----------------------------------------------------------------------
// <copyright file="DailyMeasurementsDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.DailyMeasurementsDAL class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.DAL
{
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Transactions;

    /// <summary>
    /// Test the DailyMeasurementsDAL Class in DietApp.DAL.
    /// </summary>
    [TestClass]
    public class DailyMeasurementsDALTests
    {
        /// <summary>
        /// Test for return of user chart data.
        /// </summary>
        [TestMethod]
        public void TestGetUserChartData()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set DailyMeasurements [1]
                int listNumber = 1;
                int dailyMeasurementId = 5;
                DateTime date = Convert.ToDateTime("2016-06-24");
                int userId = 1;
                int measurementTypeId = 1;
                int measurement = 204;
                int length = 3;

                // Create DailyMeasurements [1]
                DailyMeasurements dailyMeasurements = new DailyMeasurements();

                // Get list and [1]
                List<DailyMeasurements> measurementsList = DailyMeasurementsDAL.GetUserChartData(userId, measurementTypeId);
                dailyMeasurements = measurementsList[listNumber];

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(dailyMeasurementId, dailyMeasurements.DailyMeasurementId, 0, "DailyMeasurement's DailyMeasurementId not " + dailyMeasurementId + ".");
                Assert.AreEqual(date, dailyMeasurements.Date, "DailyMeasurement's Date not " + date + ".");
                Assert.AreEqual(userId, dailyMeasurements.UserId, "DailyMeasurement's firstName not " + userId + ".");
                Assert.AreEqual(measurementTypeId, dailyMeasurements.MeasurementTypeId, "DailyMeasurement's MeasurementTypeId not " + measurementTypeId + ".");
                Assert.AreEqual(measurement, dailyMeasurements.Measurement, "DailyMeasurement's Measurement not " + measurement + ".");
                Assert.AreEqual(length, measurementsList.Count, "List does not have a length of " + length + ".");
            }
        }
    }
}
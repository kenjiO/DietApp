//-----------------------------------------------------------------------
// <copyright file="DailyMeasurementsDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.DailyMeasurementsDAL class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Transactions;
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void TestGetMeasurementByUserTypeDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set Data
                int userId = 1;
                int measurementTypeId = 1;
                DateTime dateA = Convert.ToDateTime("2016-06-23");
                double answerA = 210;
                DateTime dateB = Convert.ToDateTime("1982-12-22");
                double answerB = 0;

                // Get Measurement
                double resultA = DailyMeasurementsDAL.GetMeasurementByUserTypeDate(userId, measurementTypeId, dateA);
                double resultB = DailyMeasurementsDAL.GetMeasurementByUserTypeDate(userId, measurementTypeId, dateB);

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(answerA, resultA, 0, "Failed to return " + answerA + ".");
                Assert.AreEqual(answerB, resultB, 0, "Failed to return " + answerB + ".");
            }
        }

        /// <summary>
        /// Test for return of x days of user chart data.
        /// </summary>
        [TestMethod]
        public void GetUserChartDataXDays()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set Data
                int userId = 1;
                int measurementTypeId = 1;
                int toDisplay = 8;
                DateTime startDate = Convert.ToDateTime("2016-06-20");

                // Get Measurement
                List<DailyMeasurements> results = DailyMeasurementsDAL.GetUserChartDataXDays(userId, measurementTypeId, startDate, toDisplay);

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(startDate, results[0].Date, "Date at 0 incorrect.");
                Assert.AreEqual(0, results[0].Measurement, 0, "Measurement at 0 incorrect.");
                Assert.AreEqual(startDate.AddDays(4), results[4].Date, "Date at 4 incorrect.");
                Assert.AreEqual(204, results[4].Measurement, 0, "Measurement at 4 incorrect.");
                Assert.AreEqual(startDate.AddDays(7), results[7].Date, "Date at 7 incorrect.");
                Assert.AreEqual(0, results[7].Measurement, "Measurement at 7 incorrect.");
                Assert.AreEqual(toDisplay, results.Count, 0, "List an incrroect size.");
            }
        }

        /// <summary>
        /// Test for return of x days of user chart data, no data.
        /// </summary>
        [TestMethod]
        public void GetUserChartDataXDaysNoData()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set Data
                int userId = 1;
                int measurementTypeId = 1;
                int toDisplay = 10;
                DateTime startDate = Convert.ToDateTime("2016-07-22");

                // Get Measurement
                List<DailyMeasurements> results = DailyMeasurementsDAL.GetUserChartDataXDays(userId, measurementTypeId, startDate, toDisplay);

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(startDate, results[0].Date, "Date at 0 incorrect.");
                Assert.AreEqual(0, results[0].Measurement, 0, "Measurement at 0 incorrect.");
                Assert.AreEqual(startDate.AddDays(1), results[1].Date, "Date at 1 incorrect.");
                Assert.AreEqual(0, results[1].Measurement, 0, "Measurement at 1 incorrect.");
                Assert.AreEqual(startDate.AddDays(2), results[2].Date, "Date at 2 incorrect.");
                Assert.AreEqual(0, results[2].Measurement, 0, "Measurement at 2 incorrect.");
                Assert.AreEqual(startDate.AddDays(3), results[3].Date, "Date at 3 incorrect.");
                Assert.AreEqual(0, results[3].Measurement, 0, "Measurement at 3 incorrect.");
                Assert.AreEqual(startDate.AddDays(4), results[4].Date, "Date at 4 incorrect.");
                Assert.AreEqual(0, results[4].Measurement, 0, "Measurement at 4 incorrect.");
                Assert.AreEqual(startDate.AddDays(5), results[5].Date, "Date at 5 incorrect.");
                Assert.AreEqual(0, results[5].Measurement, 0, "Measurement at 5 incorrect.");
                Assert.AreEqual(startDate.AddDays(6), results[6].Date, "Date at 6 incorrect.");
                Assert.AreEqual(0, results[6].Measurement, 0, "Measurement at 6 incorrect.");
                Assert.AreEqual(startDate.AddDays(7), results[7].Date, "Date at 7 incorrect.");
                Assert.AreEqual(0, results[7].Measurement, 0, "Measurement at 7 incorrect.");
                Assert.AreEqual(startDate.AddDays(8), results[8].Date, "Date at 8 incorrect.");
                Assert.AreEqual(0, results[8].Measurement, 0, "Measurement at 8 incorrect.");
                Assert.AreEqual(startDate.AddDays(9), results[9].Date, "Date at 9 incorrect.");
                Assert.AreEqual(0, results[9].Measurement, "Measurement at 9 incorrect.");
                Assert.AreEqual(toDisplay, results.Count, 0, "List an incrroect size.");
            }
        }
    }
}
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
        public void TestGetMeasurementByUserTypeDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set Data
                int userId = 1;
                int measurementTypeId = 1;
                DateTime dateA = Convert.ToDateTime("2016-06-23");
                double answerA = 210;
                DateTime dateB = Convert.ToDateTime("1982-12-22"); ;
                double answerB = 0;

                // Get Measurement
                double resultA = DailyMeasurementsDAL.GetMeasurementByUserTypeDate(userId, measurementTypeId, dateA);
                double resultB = DailyMeasurementsDAL.GetMeasurementByUserTypeDate(userId, measurementTypeId, dateB);

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(answerA, resultA, 0, "Failed to return " + answerA + ".");
                Assert.AreEqual(answerB, resultB, 0, "Failed to return " + answerB + ".");
            }
        }

        [TestMethod]
        public void GetUserChartData10Days()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set Data
                int userId = 1;
                int measurementTypeId = 1;
                DateTime startDate = Convert.ToDateTime("2016-06-20");

                // Get Measurement
                List<DailyMeasurements> results = DailyMeasurementsDAL.GetUserChartData10Days(userId, measurementTypeId, startDate);

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(startDate, results[0].Date, "Date at 0 incorrect.");
                Assert.AreEqual(0, results[0].Measurement, 0, "Measurement at 0 incorrect.");
                Assert.AreEqual(startDate.AddDays(4), results[4].Date, "Date at 5 incorrect.");
                Assert.AreEqual(204, results[4].Measurement, 0, "Measurement at 5 incorrect.");
                Assert.AreEqual(startDate.AddDays(9), results[9].Date, "Date at 9 incorrect.");
                Assert.AreEqual(0, results[9].Measurement, "Measurement at 9 incorrect.");
                Assert.AreEqual(10, results.Count, 0, "List an incrroect size.");
            }
        }
    }
}
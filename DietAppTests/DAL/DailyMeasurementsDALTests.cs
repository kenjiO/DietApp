//-----------------------------------------------------------------------
// <copyright file="DailyMeasurementsDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.DailyMeasurementsDAL class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

using DietApp.DAL;
using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DietAppTests.DAL
{
    [TestClass]
    public class DailyMeasurementsDALTests
    {
        [TestMethod]
        public void TestGetUserChartData()
        {
            List<DailyMeasurements> measurementsList = DailyMeasurementsDAL.GetUserChartData(1, 1);

            Assert.AreEqual(3, measurementsList.Count, "List has length 3");
        }
    }
}
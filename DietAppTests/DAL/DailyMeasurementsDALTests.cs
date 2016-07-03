using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.DAL;
using DietApp.Model;
using System.Collections.Generic;

namespace DietAppTests.DAL
{
    [TestClass]
    public class DailyMeasurementsDALTests
    {
        [TestMethod]
        public void TestGetUserChartData()
        {
            List<Measurements> measurementsList = DailyMeasurementsDAL.getUserChartData(1, 1);

            Assert.AreEqual(4, measurementsList.Count, "List has length 4");
        }
    }
}

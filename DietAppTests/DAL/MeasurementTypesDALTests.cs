//-----------------------------------------------------------------------
// <copyright file="MeasurementTypesDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.MeasurementTypesDAL class.</summary>
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
    /// Test the MeasurementTypesDAL Class in DietApp.DAL.
    /// </summary>
    [TestClass]
    public class MeasurementTypesDALTests
    {
        /// <summary>
        /// Test for type data.
        /// </summary>
        [TestMethod]
        public void TestGetType()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                // Set MeasurementTypes [1]
                int measurementTypeId = 1;
                string measurementTypeName = "weight";
                string measurementDefaultUnit = "lb.";

                // Get MeasurementTypes [1]
                MeasurementTypes measurementTypes = new MeasurementTypes();

                measurementTypes = MeasurementTypesDAL.GetType(measurementTypeId);

                // Check DailyMeasurements Chart Data
                Assert.AreEqual(measurementTypeId, measurementTypes.MeasurementTypeId, 0, "MeasurementTypes's MeasurementTypeId not " + measurementTypeId + ".");
                Assert.AreEqual(measurementTypeName, measurementTypes.MeasurementTypeName, "MeasurementTypes's MmeasurementTypeName not " + measurementTypeName + ".");
                Assert.AreEqual(measurementDefaultUnit, measurementTypes.MeasurementDefaultUnit, "MeasurementTypes's MeasurementDefaultUnit not " + measurementDefaultUnit + ".");
            }
        }
    }
}
//-----------------------------------------------------------------------
// <copyright file="MeasurementTypesTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.MeasurementTypes class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTest.Model
{
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the MeasurementTypes Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class MeasurementTypesTests
    {
        /// <summary>
        /// Test for newly created MeasurementTypes, all gets show return 0.
        /// </summary>
        [TestMethod]
        public void TestNullMeasurementTypes()
        {
            // Create MeasurementTypes (New)
            MeasurementTypes measurementTypes = new MeasurementTypes();

            // Check DailyMeasurements Data
            Assert.AreEqual(0, measurementTypes.MeasurementTypeId, 0, "MeasurementType's MeasurementTypeId not 0.");
            Assert.IsNull(measurementTypes.MeasurementTypeName, "MeasurementType's MeasurementTypeName not null.");
            Assert.IsNull(measurementTypes.MeasurementDefaultUnit, "MeasurementType's MeasurementDefaultUnit not null.");
        }

        /// <summary>
        /// Test for set and get of a measurementTypes, MeasurementTypes class.
        /// </summary>
        [TestMethod]
        public void TestActiveMeasurementTypes()
        {
            // Set MeasurementTypes
            int measurementTypeId = 1;
            string measurementTypeName = "Weight";
            string measurementDefaultUnit = "lb.";

            // Create MeasurementTypes (Active)
            MeasurementTypes measurementTypes = new MeasurementTypes();
            measurementTypes.MeasurementTypeId = measurementTypeId;
            measurementTypes.MeasurementTypeName = measurementTypeName;
            measurementTypes.MeasurementDefaultUnit = measurementDefaultUnit;

            // Check MeasurementTypes Data
            Assert.AreEqual(measurementTypeId, measurementTypes.MeasurementTypeId, 0, "MeasurementType's MeasurementTypeId not " + measurementTypeId + ".");
            Assert.AreEqual(measurementTypeName, measurementTypes.MeasurementTypeName, "MeasurementType's MeasurementTypeName not " + measurementTypeName + ".");
            Assert.AreEqual(measurementDefaultUnit, measurementTypes.MeasurementDefaultUnit, "MeasurementType's MeasurementDefaultUnit not " + measurementDefaultUnit + ".");
        }
    }
}
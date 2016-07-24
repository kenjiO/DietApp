//-----------------------------------------------------------------------
// <copyright file="MeasurementTypesDAL.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the database access for the DietApp.measurements table.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DietApp.Model;

    /// <summary>
    /// Database access for Measurements table.
    /// </summary>
    public class MeasurementTypesDAL
    {
        /// <summary>
        /// Gets the measurement type data.
        /// </summary>
        /// <param name="typeId">ID of the type of measurement to be displayed.</param>
        /// <returns>The measurement type.</returns>
        public static MeasurementTypes GetType(int typeId)
        {
            MeasurementTypes results = new MeasurementTypes();
            using (var measurementsTypeDataSet = new DietAppDataSetTableAdapters.measurementTypesTableAdapter())
            {
                DataTable queryResultsTable = measurementsTypeDataSet.GetType(typeId);
                foreach (DataRow row in queryResultsTable.Rows)
                {
                    int measurementTypeId = Convert.ToInt32(row["measurementTypeId"].ToString());
                    string measurementTypeName = row["measurementTypeName"].ToString();
                    string measurementDefaultUnit = row["measurementDefaultUnit"].ToString();

                    results.MeasurementTypeId = measurementTypeId;
                    results.MeasurementTypeName = measurementTypeName;
                    results.MeasurementDefaultUnit = measurementDefaultUnit;
                }
            }

            return results;
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="DailyMeasurementsDAL.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the database access for the DietApp.dailyMeasurements table.</summary>
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
    /// Database access for dailyMeasurements table.
    /// </summary>
    public class DailyMeasurementsDAL
    {
        /// <summary>
        /// Gets the users data to populate the user data chart.
        /// </summary>
        /// <param name="userId">ID of the active user.</param>
        /// <param name="measurementTypeId">ID of the type of measurement to be displayed.</param>
        /// <returns>A list containing measurements of given user and measurement type.</returns>
        public static List<DailyMeasurements> GetUserChartData(int userId, int measurementTypeId)
        {
            List<DailyMeasurements> results = new List<DailyMeasurements>();
            using (var measurementsDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
            {
                DataTable queryResultsTable = measurementsDataSet.getUserDataChart(userId, measurementTypeId);
                foreach (DataRow row in queryResultsTable.Rows)
                {
                    int dailyMeasurementId = Convert.ToInt32(row["dailyMeasurementId"].ToString());
                    DateTime date = Convert.ToDateTime(row["date"]);
                    int measurement = Convert.ToInt32(row["measurement"].ToString());
                    
                    DailyMeasurements measurements = new DailyMeasurements();
                    measurements.DailyMeasurementId = dailyMeasurementId;
                    measurements.Date = date;
                    measurements.UserId = userId;
                    measurements.MeasurementTypeId = measurementTypeId;
                    measurements.Measurement = measurement;
                    results.Add(measurements);
                }
            }

            return results;
        }
    }
}
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
    using DietApp.Model;

    /// <summary>
    /// Database access for dailyMeasurements table.
    /// </summary>
    public class DailyMeasurementsDAL
    {
        /// <summary>
        /// Gets the users data to populate the yValues, for 1 day.
        /// </summary>
        /// <param name="userId">ID of the active user.</param>
        /// <param name="measurementTypeId">ID of the type of measurement to be displayed.</param>
        /// <param name="startDate">The date to start chart.</param>
        /// <returns>A measurements of given user, measurement type on date.</returns>
        public static double GetMeasurementByUserTypeDate(int userId, int measurementTypeId, DateTime date)
        {
            DailyMeasurements dailyMeasurements = new DailyMeasurements();
            string day = date.ToString("yyyy-MM-dd");
            using (var measurementsTableAdapter = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
            {
                DataTable queryResultsTable = measurementsTableAdapter.GetMeasurementByUserTypeDate(userId, measurementTypeId, day);

                foreach (DataRow row in queryResultsTable.Rows)
                {
                    int? measurement = 0;
                    if (row["measurement"] != DBNull.Value)
                    {
                        measurement = Convert.ToInt32(row["measurement"]);
                    }

                    dailyMeasurements.Measurement = (int) measurement;
                }
            }

            return dailyMeasurements.Measurement;
        }

        /// <summary>
        /// Gets the users data to populate the yValues, for 10 days.
        /// </summary>
        /// <param name="userId">user id.</param>
        /// <param name="measurementTypeId">measurement type id.</param>
        /// <param name="startDate">the start date of list.</param>
        /// <returns></returns>
        public static List<DailyMeasurements> GetUserChartDataXDays(int userId, int measurementTypeId, DateTime startDate, int toDisplay)
        {
            List<DailyMeasurements> dailyMeasurementsList = new List<DailyMeasurements>();

            for (int i = 0; i < toDisplay; i++)
            {
                DailyMeasurements dailyMeasurement = new DailyMeasurements();
                DateTime day = startDate.AddDays(i);
                double measurement = DailyMeasurementsDAL.GetMeasurementByUserTypeDate(userId, measurementTypeId, day);
                dailyMeasurement.Date = day;
                dailyMeasurement.Measurement = (int) measurement;
                dailyMeasurementsList.Add(dailyMeasurement);
            }

            return dailyMeasurementsList;
        }
    }
}
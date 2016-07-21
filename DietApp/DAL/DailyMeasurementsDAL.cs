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
        /// Gets the users data to populate the yValues, for 10 days.
        /// </summary>
        /// <param name="userId">ID of the active user.</param>
        /// <param name="measurementTypeId">ID of the type of measurement to be displayed.</param>
        /// <param name="startDate">The date to start chart.</param>
        /// <returns>A measurements of given user, measurement type on date.</returns>
        public static double GetMeasurementByUserTypeDate(int userId, int measurementTypeId, DateTime date)
        {
            double measurement = new double();

            using (var measurementsDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
            {
                try
                {
                    string day = date.ToString("yyyy-MM-dd");
                    var result = measurementsDataSet.GerMeasurementByUserTypeDate(userId, measurementTypeId, day);
                    measurement = Convert.ToDouble(result.ToString());
                }
                catch
                {
                    measurement = 0;
                }
            }
        
            return measurement;
        }

        public static List<DailyMeasurements> GetUserChartData10Days(int userId, int measurementTypeId, DateTime startDate)
        {
            List<DailyMeasurements> dailyMeasurementsList = new List<DailyMeasurements>();

            for (int i = 0; i < 10; i++)
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
//-----------------------------------------------------------------------
// <copyright file="DailyMeasurements.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the model class form holding dailyMeasurement lines from DB.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.Model
{
    using System;

    /// <summary>
    /// Model class associated with dailyMeasurements table in DB.
    /// </summary>
    public class DailyMeasurements
    {
        /// <summary>
        /// Gets or sets the dailyMeasurementId.
        /// </summary>
        public int DailyMeasurementId { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the measurementTypeId.
        /// </summary>
        public int MeasurementTypeId { get; set; }

        /// <summary>
        /// Gets or sets the measurement.
        /// </summary>
        public int Measurement { get; set; }
    }
}
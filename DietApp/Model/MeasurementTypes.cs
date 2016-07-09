//-----------------------------------------------------------------------
// <copyright file="MeasurementTypes.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the model class form holding measurementTypes lines from DB.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.Model
{
    /// <summary>
    /// Model class associated with measurementTypes table in DB.
    /// </summary>
    public class MeasurementTypes
    {
        /// <summary>
        /// Gets or sets the measurementTypeId.
        /// </summary>
        public int MeasurementTypeId { get; set; }

        /// <summary>
        /// Gets or sets the measurementTypeName.
        /// </summary>
        public string MeasurementTypeName { get; set; }

        /// <summary>
        /// Gets or sets the measurementDefaultUnit.
        /// </summary>
        public string MeasurementDefaultUnit { get; set; }
    }
}
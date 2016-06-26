using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace DietApp.DAL
{
    public class WellnessDAL
    {
        /// <summary>
        /// Retrieves the wellness data for the given day.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Wellness dateWellnessData(int userId, string date)
        {
            int number;
            var idNumber = "";
            var valueName = "";
            var wellnessInfo = new Wellness
            {
                userID = userId,
                date = Convert.ToDateTime(date)
            };
            //Get data table.
            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for name and number.
                using (var wellnessIDDataSet = new DietAppDataSetTableAdapters.measurementTypesTableAdapter())
                {
                    //For each row in the name/number dataset, give me the name and id for each value type.
                    foreach (DataRow row in wellnessIDDataSet.GetData().Rows)
                    {
                        idNumber = row["measurementTypeId"].ToString();
                        valueName = row["measurementTypeName"].ToString();
                        //Verifies the id is a number.
                        var result = Int32.TryParse(idNumber, out number);
                        if (result)
                        {
                            result = setWellnessValues(number, date, userId, result, valueName, wellnessInfo);
                        }
                    }
                    return wellnessInfo;
                }
            }
        }

        /// <summary>
        /// Updates the user's wellness data for a given day.
        /// UPDATE FUNCTIONALITY UNDER DEVELOPMENT FOR ITERATION 2.
        /// </summary>
        /// <param name="newWellness"></param>
        /// <param name="oldWellness"></param>
        public static void updateDailyWellnessData(Wellness newWellness, Wellness oldWellness)
        {
            int number, newValue, oldValue;
            var idNumber = "";
            var valueName = "";
            var measuremetType = new Dictionary<int, string>();

            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for name and number.
                using (var wellnessIDDataSet = new DietAppDataSetTableAdapters.measurementTypesTableAdapter())
                {
                    //For each row in the name/number dataset, give me the name and id for each value type.
                    foreach (DataRow row in wellnessIDDataSet.GetData().Rows)
                    {
                        idNumber = row["measurementTypeId"].ToString();
                        valueName = row["measurementTypeName"].ToString();
                        //Verifies the id is a number.
                        var result = Int32.TryParse(idNumber, out number);
                        if (result)
                        {
                            measuremetType.Add(number, valueName);
                        }
                    }
                    using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
                    {
                        //For each data element inside the values dataset, give me the measurement value.
                        foreach (KeyValuePair<int, string> kvp in measuremetType)
                        {
                            var property = typeof(Wellness).GetProperty(kvp.Value);
                            var newInt = Int32.TryParse(property.GetValue(newWellness, null).ToString(), out newValue);
                            var oldInt = Int32.TryParse(property.GetValue(oldWellness, null).ToString(), out oldValue);

                            if (newInt && oldInt)
                            {
                                wellnessDataSet.Update(newWellness.date, newWellness.userID, kvp.Key, newValue,
                                oldWellness.date, oldWellness.userID, kvp.Key, oldValue, oldWellness.dailyMeasurementID);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adds wellness data to the table in the DB.
        /// </summary>
        /// <param name="theWellness"></param>
        public static void addDailyWellnessData(Wellness theWellness)
        {
            int number;
            var idNumber = "";
            var valueName = "";
            var measuremetType = new Dictionary<int, string>();

            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for name and number.
                using (var wellnessIDDataSet = new DietAppDataSetTableAdapters.measurementTypesTableAdapter())
                {
                    //For each row in the name/number dataset, give me the name and id for each value type.
                    foreach (DataRow row in wellnessIDDataSet.GetData().Rows)
                    {
                        idNumber = row["measurementTypeId"].ToString();
                        valueName = row["measurementTypeName"].ToString();
                        //Verifies the id is a number.
                        var result = Int32.TryParse(idNumber, out number);
                        if (result)
                        {
                            measuremetType.Add(number, valueName);
                        }
                    }
                    
                    insertWellnessData(measuremetType, theWellness);
                }
            }
        }

        //Helper Methods//

        /// <summary>
        /// Gets the measurement value for each data element inside the values dataset.
        /// Referenced YouTube and http://stackoverflow.com/questions/7718792/can-i-set-a-property-value-with-reflection
        /// </summary>
        /// <param name="number"></param>
        /// <param name="date"></param>
        /// <param name="userId"></param>
        /// <param name="result"></param>
        /// <param name="valueName"></param>
        /// <param name="wellnessInfo"></param>
        /// <returns></returns>
        private static Boolean setWellnessValues(int number, string date, int userId, Boolean result, string valueName, Wellness wellnessInfo)
        {
            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for values.
                using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsSingleTableAdapter())
                {
                    foreach (DataRow row0 in wellnessDataSet.GetData(number, date, userId).Rows)
                    {
                        //Verifies the measurement is a number.
                        result = Int32.TryParse(row0["measurement"].ToString(), out number);

                        if (result)
                        {
                            //Sets the type name of a specific wellness object equal to the measurement value.
                            var property = typeof(Wellness).GetProperty(valueName);
                            property.SetValue(wellnessInfo, number, null);
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Inserts the wellness data into the DB.
        /// </summary>
        /// <param name="measuremetType"></param>
        /// <param name="theWellness"></param>
        private static void insertWellnessData(Dictionary<int, string> measuremetType, Wellness theWellness)
        {
            int newValue;
            using (var wellnessDataTable = new DietAppDataSet())
            {
                using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
                {
                    foreach (KeyValuePair<int, string> kvp in measuremetType)
                    {
                        var property = typeof(Wellness).GetProperty(kvp.Value);
                        var newInt = Int32.TryParse(property.GetValue(theWellness, null).ToString(), out newValue);

                        if (newInt)
                        {
                            wellnessDataSet.Insert(theWellness.date, theWellness.userID, kvp.Key, newValue);
                        }
                    }
                }
            }
        }
    }
}
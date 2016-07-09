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
        /// </summary>
        /// <param name="newWellness"></param>
        /// <param name="oldWellness"></param>
        public static void updateDailyWellnessData(Wellness newWellness, Wellness oldWellness)
        {
            int number, dailyMeasurementID;
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
                        foreach (DataRow row in wellnessDataSet.GetData().Rows)
                        {
                            var dailyMeasurementIDString = row["dailyMeasurementID"].ToString();
                            var dailyMeasurementIDNumber = Int32.TryParse(dailyMeasurementIDString, out dailyMeasurementID);

                            getValuePair(measuremetType, newWellness, oldWellness, dailyMeasurementIDNumber, dailyMeasurementID);
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

        /// <summary>
        /// Retrieves the progress for the given user.
        /// </summary>
        /// <param name="userID"></param>
        public static Progress getBMIData(int userID)
        {
            var idNumber = "";
            var bmiProgress = new Progress();
            int newBMI, oldBMI, newWeight, oldWeight;

            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for values.
                using (var wellnessDataSet = new DietAppDataSetTableAdapters.ProgressTableAdapter())
                {
                    foreach (DataRow row in wellnessDataSet.GetData(userID).Rows)
                    {
                        idNumber = row["orginalBMI"].ToString();
                        var result = Int32.TryParse(idNumber, out oldBMI);
                        if (result)
                        {
                            bmiProgress.oldBMI = oldBMI;
                        }
                        idNumber = row["currentBMI"].ToString();
                        var result0 = Int32.TryParse(idNumber, out newBMI);
                        if (result0)
                        {
                            bmiProgress.newBMI = newBMI;
                        }
                        idNumber = row["initialWeight"].ToString();
                        var result1 = Int32.TryParse(idNumber, out oldWeight);
                        if (result1)
                        {
                            bmiProgress.oldWeight = oldWeight;
                        }
                        idNumber = row["currentWeight"].ToString();
                        var result2 = Int32.TryParse(idNumber, out newWeight);
                        if (result2)
                        {
                            bmiProgress.newWeight = newWeight;
                        }
                    }
                    bmiProgress.userID = userID;
                }
            }
            return bmiProgress;
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

        /// <summary>
        /// Gets the measurement values associated with each measurement type in the DB for a wellness object.
        /// </summary>
        /// <param name="measuremetType"></param>
        /// <param name="newWellness"></param>
        /// <param name="oldWellness"></param>
        /// <param name="dailyMeasurementIDNumber"></param>
        /// <param name="dailyMeasurementID"></param>
        private static void getValuePair(Dictionary<int, string> measuremetType, Wellness newWellness, Wellness oldWellness, Boolean dailyMeasurementIDNumber, int dailyMeasurementID)
        {
            int newValue, oldValue;
            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for values.
                using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
                {
                    //For each data element inside the values dataset, give me the measurement value.
                    foreach (KeyValuePair<int, string> kvp in measuremetType)
                    {
                        var property = typeof(Wellness).GetProperty(kvp.Value);
                        var newInt = Int32.TryParse(property.GetValue(newWellness, null).ToString(), out newValue);
                        var oldInt = Int32.TryParse(property.GetValue(oldWellness, null).ToString(), out oldValue);

                        if (newInt && oldInt && dailyMeasurementIDNumber)
                        {
                            wellnessDataSet.Update(newWellness.date, newWellness.userID, kvp.Key, newValue,
                            oldWellness.date, oldWellness.userID, kvp.Key, oldValue, dailyMeasurementID);
                        }
                    }
                }
            }
        }
    }
}
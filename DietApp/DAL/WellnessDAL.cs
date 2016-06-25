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
        /// Referenced YouTube and http://stackoverflow.com/questions/7718792/can-i-set-a-property-value-with-reflection
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Wellness dateWellnessData(int userId, string date)
        {
            int number;
            var idNumber = "";
            var valueName = "";
            Wellness wellnessInfo = new Wellness();
            wellnessInfo.userID = userId;
            wellnessInfo.date = Convert.ToDateTime(date);
            //Get data table
            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for name and number.
                using (var wellnessIDDataSet = new DietAppDataSetTableAdapters.measurementTypesTableAdapter())
                {
                    //Get dataset for values.
                    using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsSingleTableAdapter())
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
                                //For each data element inside the values dataset, give me the measurement value.
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
                        return wellnessInfo;
                    }
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
                    using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
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
            int number, newValue, oldValue;
            var idNumber = "";
            var valueName = "";
            var measuremetType = new Dictionary<int, string>();

            using (var wellnessDataTable = new DietAppDataSet())
            {
                //Get dataset for name and number.
                using (var wellnessIDDataSet = new DietAppDataSetTableAdapters.measurementTypesTableAdapter())
                {
                    using (var wellnessDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
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
                        //For each data element inside the values dataset, give me the measurement value.
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
}
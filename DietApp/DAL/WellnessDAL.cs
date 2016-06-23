using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var valueName ="";
            Wellness wellnessInfo = new Wellness();
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
                                foreach (DataRow row in wellnessDataSet.GetData(number, date, userId).Rows)
                                {
                                    //Verifies the measurement is a number.
                                    result = Int32.TryParse(row["measurement"].ToString(), out number);

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

    }
}

using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL
{
    public class DailyMeasurementsDAL
    {

        public static List<Measurements> getUserChartData(int userId, int measurementTypeId)
        {
            List<Measurements> results = new List<Measurements>();
            using (var measurementsDataSet = new DietAppDataSetTableAdapters.dailyMeasurementsFullTableAdapter())
            {
                DataTable queryResultsTable = measurementsDataSet.getUserDataChart(userId, measurementTypeId);
                foreach (DataRow row in queryResultsTable.Rows)
                {

                    int measurement = Convert.ToInt32(row["measurement"].ToString());
                    DateTime date = Convert.ToDateTime(row["date"]);

                    Measurements measurements = new Measurements();
                    measurements.date = date;
                    measurements.measurement = measurement;
                    results.Add(measurements);
                }
            }
            return results;
        }
    }
}

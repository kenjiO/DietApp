using System;
using System.Collections.Generic;
using System.Data;
using DietApp.Model;

namespace DietApp.DAL
{
    public class FoodReportDAL
    {
        /// <summary>
        /// Get a 10 day nutrition report
        /// </summary>
        /// <param name="startDate">The date to start the report</param>
        /// <returns>A list of daily total calories and nutrients for ten days</returns>
        public static List<DailyNutrition> get10DayNutritionReport(int userId, DateTime startDate)
        {
            List<DailyNutrition> results = new List<DailyNutrition>();
            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = startDate.AddDays(9).ToString("yyyy-MM-dd");
            using (var dailyNutrientsTableAdapter = new DietAppDataSetTableAdapters.dailyNutrientsTableAdapter())
            {
                DataTable queryResultsTable = dailyNutrientsTableAdapter.GetDailyReport(userId, startDateString, endDateString);

                foreach (DataRow row in queryResultsTable.Rows)
                {
                    DateTime day = Convert.ToDateTime(row["day"]);

                    int? calories = 0;
                    if (row["calories"] != DBNull.Value)
                        calories = Convert.ToInt32(row["calories"]);

                    int? protein = 0;
                    if (row["protein"] != DBNull.Value)
                        protein = Convert.ToInt32(row["protein"]);

                    int? fat = 0;
                    if (row["fat"] != DBNull.Value)
                        fat = Convert.ToInt32(row["fat"]);

                    int? carbohydrates = 0;
                    if (row["carbohydrates"] != DBNull.Value)
                        carbohydrates = Convert.ToInt32(row["carbohydrates"]);

                    DailyNutrition entry = new DailyNutrition(day, calories, fat, protein, carbohydrates);
                    results.Add(entry);
                }
            }
            return results;
        }

        /// <summary>
        /// Get a x day nutrition report
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="startDate">The date to start the report</param>
        /// <param name="days">The days to display.</param>
        /// <returns>A list of daily total calories and nutrients for ten days</returns>
        public static List<DailyNutrition> GetXDayNutritionReport(int userId, DateTime startDate, int days)
        {
            List<DailyNutrition> results = new List<DailyNutrition>();
            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = startDate.AddDays(days - 1).ToString("yyyy-MM-dd");
            using (var dailyNutrientsTableAdapter = new DietAppDataSetTableAdapters.dailyNutrientsTableAdapter())
            {
                DataTable queryResultsTable = dailyNutrientsTableAdapter.GetDailyReport(userId, startDateString, endDateString);

                foreach (DataRow row in queryResultsTable.Rows)
                {
                    DateTime day = Convert.ToDateTime(row["day"]);

                    int? calories = 0;
                    if (row["calories"] != DBNull.Value)
                    {
                        calories = Convert.ToInt32(row["calories"]);
                    }

                    int? protein = 0;
                    if (row["protein"] != DBNull.Value)
                    {
                        protein = Convert.ToInt32(row["protein"]);
                    }

                    int? fat = 0;
                    if (row["fat"] != DBNull.Value)
                    {
                        fat = Convert.ToInt32(row["fat"]);
                    }

                    int? carbohydrates = 0;
                    if (row["carbohydrates"] != DBNull.Value)
                    {
                        carbohydrates = Convert.ToInt32(row["carbohydrates"]);
                    }

                    DailyNutrition entry = new DailyNutrition(day, calories, fat, protein, carbohydrates);
                    results.Add(entry);
                }
            }

            return results;
        }
    }
}
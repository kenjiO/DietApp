﻿using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DietApp.DAL
{
    public class FoodEntryDAL
    {
        /// <summary>
        /// Add a new item consumed to the database
        /// </summary>
        /// <param name="entry">The food entry to add </param>
        public static void addEntry(FoodEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("entry must not be null");
            }
            using (var itemConsumedTableAdapter = new DietAppDataSetTableAdapters.itemConsumedTableAdapter())
            {
                try
                {
                    itemConsumedTableAdapter.Insert(entry.ConsumedAt, entry.UserId, entry.Name, entry.Calories, entry.Protein, entry.Fat, entry.Carbohydrates);
                }
                catch (SqlException e)
                {
                    // Check if it is a primary key exception from a duplicate entry
                    if (e.Number == 2627)
                    {
                        throw new DuplcateFoodEntryException("An entry for that food and dateTime already exists");
                    }
                    else
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// Delete a food entry from the DB
        /// </summary>
        /// <param name="entry">The entry to delete.</param>
        public static void deleteEntry(FoodEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("entry must not be null");
            }
            using (var itemConsumedTableAdapter = new DietAppDataSetTableAdapters.itemConsumedTableAdapter())
            {
                itemConsumedTableAdapter.DeleteByDateTimeIdName(entry.ConsumedAt, entry.UserId, entry.Name);
            }
        }

        /// <summary>
        /// Get a food entry by userId, dateTime consumed and name
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <param name="consumedAt">DateTime consumed</param>
        /// <param name="foodName">The food name</param>
        /// <returns>The food entry with specified parameters or null if it does not exist</returns>
        public static FoodEntry getEntry(int userId, DateTime consumedAt, string foodName)
        {
            if (consumedAt == null)
                throw new ArgumentNullException("consumedAt cannot be null");
            if (foodName == null)
                throw new ArgumentNullException("foodName cannot be null");
            using (var itemConsumedTableAdapter = new DietAppDataSetTableAdapters.itemConsumedTableAdapter())
            {
                DietAppDataSet.itemConsumedDataTable dataTable = itemConsumedTableAdapter.GetDataByIdDateName(userId, consumedAt, foodName);
                System.Data.DataRowCollection rows = dataTable.Rows;
                if (rows.Count == 0)
                {
                    return null;
                }
                System.Data.DataRow row = rows[0];

                int id = Convert.ToInt32(row["userId"].ToString());
                string name = row["name"].ToString();
                int? calories = null;
                if (row["calories"] != DBNull.Value)
                    calories = Convert.ToInt32(row["calories"]);

                int? protein = null;
                if (row["protein"] != DBNull.Value)
                    protein = Convert.ToInt32(row["protein"]);

                int? fat = null;
                if (row["fat"] != DBNull.Value)
                    fat = Convert.ToInt32(row["fat"]);

                int? carbohydrates = null;
                if (row["carbohydrate"] != DBNull.Value)
                    carbohydrates = Convert.ToInt32(row["carbohydrate"]);

                DateTime dateTimeConsumedAt = Convert.ToDateTime(row["dateTimeConsumed"]);

                FoodEntry result = new FoodEntry(id, name, calories, fat, protein, carbohydrates, dateTimeConsumedAt);
                return result;
            }
        }

        /// <summary>
        /// Search for nutrition info on a food
        /// </summary>
        /// <param name="searchTerm">Search term for the food name</param>
        /// <returns>A list of nutrition info for foods in the database that match the search term</returns>
        public static List<FoodNutritionInfo> searchFoodInfo(string searchTerm)
        {
            if (searchTerm == null)
            {
                throw new ArgumentNullException("serch term must not be null");
            }
            List<FoodNutritionInfo> results = new List<FoodNutritionInfo>();

            using (var tableAdapter = new DietAppDataSetTableAdapters.defaultNutritionalValuesTableAdapter())
            {
                DietAppDataSet.defaultNutritionalValuesDataTable dataTable = tableAdapter.GetData("%" + searchTerm + "%");
                System.Data.DataRowCollection rows = dataTable.Rows;
                foreach (DataRow row in rows)
                {
                    FoodNutritionInfo food = new FoodNutritionInfo();
                    food.name = row["food"].ToString();
                    food.calories = Convert.ToInt32(row["calories"]);
                    food.fat = Convert.ToInt32(row["fat"]);
                    food.protein = Convert.ToInt32(row["protein"]);
                    food.carbohydrates = Convert.ToInt32(row["carbohydrates"]);
                    results.Add(food);
                }
            }
            return results;
        }
    }

    /// <summary>
    /// Exception used for when entering a duplicate food entry
    /// </summary>
    [Serializable]
    public class DuplcateFoodEntryException : Exception
    {
        public DuplcateFoodEntryException()
        {
        }

        public DuplcateFoodEntryException(string message)
            : base(message)
        {
        }
    }
}
using DietApp.DAL;
using DietApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DietApp.Controller
{
    public class DietAppController
    {
        /// <summary>
        /// Gets the users data to populate the yValues, for 10 days.
        /// </summary>
        /// <param name="userId">ID of the active user.</param>
        /// <param name="measurementTypeId">ID of the type of measurement to be displayed.</param>
        /// <param name="date">The date chart.</param>
        /// <returns>A measurements of given user and measurement type on date.</returns>
        public static double GetMeasurementByUserTypeDate(int userId, int measurementTypeId, DateTime date)
        {
            return DailyMeasurementsDAL.GetMeasurementByUserTypeDate(userId, measurementTypeId, date);
        }

        public static List<DailyMeasurements> GetUserChartData10Days(int userId, int measurementTypeId, DateTime startDate)
        {
            return DailyMeasurementsDAL.GetUserChartData10Days(userId, measurementTypeId, startDate);
        }
        
        /// <summary>
        /// Compares the password against the stored value of the password for the specified userName in the database.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>A boolean value indicating if the data matches.</returns>
        public static Boolean comparePassword(String userName, String password)
        {
            return Model_Validator.comparePassword(userName, password);
        }

        /// <summary>
        /// Adds a new user to the database
        /// </summary>
        /// <param name="userName">User's userName</param>
        /// <param name="password">User's password</param>
        /// <returns>New user's userId</returns>
        public static int addNewUser(String userName, String password)
        {
            return UsersDAL.addNewUser(userName, password);
        }

        /// <summary>
        /// Retrieves the user data from the system for the specified user.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <returns>The user object containing the specified data.</returns>
        public static Users getUserData(String userName)
        {
            return UsersDAL.getUserData(userName);
        }

        /// <summary>
        /// Retrieves the user data from the system for the specified user.
        /// </summary>
        /// <param name="userId">The user name.</param>
        /// <returns>The user object containing the specified data.</returns>
        public static Users getUserData(int userId)
        {
            return UsersDAL.getUserData(userId);
        }

        /// <summary>
        /// Updates the user's information.
        /// </summary>
        /// <param name="oldUsers">Old user's information</param>
        /// <param name="newUsers">New user's information</param>
        public static void updateUsers(Users oldUsers, Users newUsers)
        {
            UsersDAL.updateUsers(oldUsers, newUsers);
        }

        /// <summary>
        /// Get the food entries for a user on a given date
        /// </summary>
        /// <param name="userId">The user to get the food entries for</param>
        /// <param name="date">The date to get the entries for</param>
        /// <returns>A list of food entries for the user</returns>
        public static List<FoodEntry> getFoodEntriesForUserByDate(int userId, DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date must not be null");
            }

            return FoodEntryDAL.getUserEntriesByDate(userId, date);
        }

        /// <summary>
        /// Add a food entry to the DB
        /// </summary>
        /// <param name="userId">userId that consumed the food</param>
        /// <param name="name">The name of the food</param>
        /// <param name="calories">Amount of calories</param>
        /// <param name="protein">Amount of protein</param>
        /// <param name="fat">Amount of fat</param>
        /// <param name="carbohydrates">Amount of carbohydrates</param>
        /// <param name="consumedAt">Date and Time consumed</param>
        public static void addFoodEntry(int userId, string name, int? calories, int? protein, int? fat, int? carbohydrates, DateTime consumedAt)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name cannot be null");
            }

            if (consumedAt == null)
            {
                throw new ArgumentNullException("consumedAt cannot be null");
            }

            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, consumedAt);
            FoodEntryDAL.addEntry(entry);
        }

        /// <summary>
        /// Update a food entry
        /// </summary>
        /// <param name="originalEntry">The original entry</param>
        /// <param name="updatedEntry">The updated entry</param>
        public static void updateFoodEntry(FoodEntry originalEntry, FoodEntry updatedEntry)
        {
            if (originalEntry == null || updatedEntry == null)
            {
                throw new ArgumentNullException("entries cannot be null");
            }

            FoodEntryDAL.updateEntry(originalEntry, updatedEntry);
        }

        /// <summary>
        /// Delete a Food Entry from the DB
        /// </summary>
        /// <param name="entry">The entry to delete</param>
        public static void deleteFoodEntry(FoodEntry entry)
        {
            if (entry == null)
            {
                return;
            }

            FoodEntryDAL.deleteEntry(entry);
        }

        /// <summary>
        /// Search for nutrition info on a food.
        /// </summary>
        /// <param name="searchTerm">Search term for the food name</param>
        /// <returns>A list of nutrition info for foods in the database that match the search term</returns>
        public static List<FoodNutritionInfo> searchFoodInfo(string searchTerm)
        {
            if (searchTerm == null)
            {
                throw new ArgumentNullException("serch term must not be null");
            }

            return FoodEntryDAL.searchFoodInfo(searchTerm);
        }

        /// <summary>
        /// Gets the wellness data from the DB for a user on a given day.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Wellness dateWellnessData(int userId, string date)
        {
            return WellnessDAL.dateWellnessData(userId, date);
        }

        /// <summary>
        /// Adds the wellness data to the DB.
        /// </summary>
        /// <param name="theWellness"></param>
        public static void addDailyWellnessData(Wellness theWellness)
        {
            WellnessDAL.addDailyWellnessData(theWellness);
        }

        /// <summary>
        /// Updates the wellness data in the DB.
        /// </summary>
        /// <param name="newWellness"></param>
        /// <param name="oldWellness"></param>
        public static void updateDailyWellnessData(Wellness newWellness, Wellness oldWellness)
        {
            WellnessDAL.updateDailyWellnessData(newWellness, oldWellness);
        }

        /// <summary>
        /// Gets the type data.
        /// </summary>
        /// <param name="TypeId">The measurement type ID.</param>
        /// <returns>Type data.</returns>
        public static MeasurementTypes GetType(int typeId)
        {
            return MeasurementTypesDAL.GetType(typeId);
        }

        /// <summary>
        /// Gets the BMI data for the specified user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static Progress getBMIData(int userID)
        {
            return WellnessDAL.getBMIData(userID);
        }

        /// <summary>
        /// Get a list of daily nutrient totals for a ten day period
        /// </summary>
        /// <param name="userId">The userId to get the list for</param>
        /// <param name="startDate">The first day of the 10 day period</param>
        /// <returns>A list of nutrient totals for each day data is available</returns>
        public static List<DailyNutrition> get10DayNutrientTotals(int userId, DateTime startDate)
        {
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate cannot be null");
            }

            return FoodReportDAL.get10DayNutritionReport(userId, startDate);
        }

        /// <summary>
        /// Export wellness and food entries to a file
        /// </summary>
        /// <param name="userId">The userId of the entries to export</param>
        /// <param name="outFile">The file to write the entries to</param>
        public static void exportData(int userId, Stream outFile)
        {
            if (outFile == null)
            {
                throw new ArgumentNullException("outfile cannot be null");
            }
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(outFile, WellnessDAL.getUserWellnessEntries(userId));
            formatter.Serialize(outFile, FoodEntryDAL.getUserEntries(userId));
        }

        /// <summary>
        /// Import wellness and food entries from a file created by exportData
        /// </summary>
        /// <param name="userId">The userId who the imported entries are for</param>
        /// <param name="inFile">The file containing the exported entries</param>
        public static void importData(int userId, Stream inFile)
        {
            if (inFile == null)
            {
                throw new ArgumentNullException("infile cannot be null");
            }
            List<FoodEntry> foodEntries;
            List<Wellness> wellnessEntries;
            IFormatter formatter = new BinaryFormatter();

            try
            {
                // Retrieve the lists of wellness and foods from the file
                wellnessEntries = (List<Wellness>)formatter.Deserialize(inFile);
                foodEntries = (List<FoodEntry>)formatter.Deserialize(inFile);
            }
            catch (InvalidCastException e)
            {
                throw new DietAppImportExportException("This is not a valid Health Trends export file");
            }
            catch (SerializationException e)
            {
                throw new DietAppImportExportException("This is not a valid Health Trends export file");
            }

            if (foodEntries == null || wellnessEntries == null)
            {
                throw new DietAppImportExportException("Could not read entries from the file");
            }

            foreach (FoodEntry entry in foodEntries)
            {
                try
                {
                    // Need to create a new entry in order to set the proper userId
                    FoodEntry entryToAdd = new FoodEntry(userId, entry.Name, entry.Calories, entry.Fat, entry.Protein, entry.Carbohydrates, entry.ConsumedAt);
                    FoodEntryDAL.addEntry(entryToAdd);
                }
                catch (DuplcateFoodEntryException e)
                {
                    //Ignore since this does not overwrite existing entries
                }
            }

            foreach (Wellness entry in wellnessEntries)
            {
                entry.userID = userId;
                try
                {
                    WellnessDAL.addDailyWellnessData(entry);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    // error 2627 means that primary key already exists in the DB.
                    // It is not a problem since this does not overwrite existing entries anyway
                    // For other SqlExceptions they should be thrown
                    if (e.Number != 2627)
                    {
                        throw e;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Exception used for export/import errors
    /// </summary>
    [Serializable]
    public class DietAppImportExportException : Exception
    {
        public DietAppImportExportException()
        {
        }

        public DietAppImportExportException(string message)
            : base(message)
        {
        }
    }
}
using DietApp.Model;
using System;

namespace DietApp.DAL
{
    internal class FoodEntryDAL
    {
        /// <summary>
        /// Add a new item consumed to the database
        /// </summary>
        /// <param name="entry">The food entry to add </param>
        /// <param name="userId">The userId who consumed the entry</param>
        public static void addItem(FoodEntry entry, int userId)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("entry must not be null");
            }
            using (var itemConsumedTableAdapter = new DietAppDataSetTableAdapters.itemConsumedTableAdapter())
            {
                itemConsumedTableAdapter.Insert(entry.ConsumedAt, userId, entry.Name, entry.Calories, entry.Protein, entry.Fat, entry.Carbohydrates);
            }
        }
    }
}
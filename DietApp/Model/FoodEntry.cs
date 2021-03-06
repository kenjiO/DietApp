﻿using System;

namespace DietApp.Model
{
    [Serializable]
    public class FoodEntry
    {
        private string name;
        private int userId;
        private int? calories;
        private int? fat;
        private int? protein;
        private int? carbohydrates;
        private DateTime consumedAt;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int UserId
        {
            get
            {
                return userId;
            }
        }

        public int? Calories
        {
            get
            {
                return calories;
            }
        }

        public int? Fat
        {
            get
            {
                return fat;
            }
        }

        public int? Protein
        {
            get
            {
                return protein;
            }
        }

        public int? Carbohydrates
        {
            get
            {
                return carbohydrates;
            }
        }

        public DateTime ConsumedAt
        {
            get
            {
                return consumedAt;
            }
        }

        /// <summary>
        /// Creates a new entry for a food consumed with the time consumed set to the current time.
        /// </summary>
        /// <param name="userId">UserId that consumed the item</param>
        /// <param name="name">The name of the food</param>
        /// <param name="calories">Amount of calories</param>
        /// <param name="fat">Amount of fat</param>
        /// <param name="protein">Amount of protein</param>
        /// <param name="carbohyrdates">Amount of carbohydrates</param>
        public FoodEntry(int userId, string name, int? calories, int? fat, int? protein, int? carbohyrdates)
            : this(userId, name, calories, fat, protein, carbohyrdates, DateTime.Now)
        {
        }

        /// <summary>
        /// Creates a new entry for a food consumed.
        /// </summary>
        /// <param name="userId">UserId that consumed the item</param>
        /// <param name="name">The name of the food</param>
        /// <param name="calories">Amount of calories</param>
        /// <param name="fat">Amount of fat</param>
        /// <param name="protein">Amount of protein</param>
        /// <param name="carbohyrdates">Amount of carbohydrates</param>
        /// <param name="consumedAt">DateTime the food was consumed</param>
        public FoodEntry(int userId, string name, int? calories, int? fat, int? protein, int? carbohyrdates, DateTime consumedAt)
        {
            if (consumedAt == null)
            {
                throw new ArgumentNullException("consumedAt must not be null");
            }
            String validationErrors = validate(name, calories, fat, protein, carbohyrdates);
            if (validationErrors != null)
            {
                throw new ArgumentException(validationErrors);
            }
            this.userId = userId;
            this.name = name;
            this.calories = calories;
            this.fat = fat;
            this.protein = protein;
            this.carbohydrates = carbohyrdates;
            this.consumedAt = consumedAt;
        }

        // Returns null if validation passes. Otherwise, returns a string listing the errors.
        private string validate(string name, int? calories, int? fat, int? protein, int? carbohyrdates)
        {
            string errors = "";
            if (name == null || name.Trim().Equals(""))
            {
                errors += "Food name must be specified\n";
            }
            if (calories.HasValue && calories < 0)
            {
                errors += "Calories must not be less than 0\n";
            }
            if (fat.HasValue && fat < 0)
            {
                errors += "Fat must not be less than 0\n";
            }
            if (protein.HasValue && protein < 0)
            {
                errors += "Protein must not be less than 0\n";
            }
            if (carbohyrdates.HasValue && carbohyrdates < 0)
            {
                errors += "Carbohydrates must not be less than 0\n";
            }
            if (errors.Equals(""))
            {
                return null;
            }
            else
            {
                return errors;
            }
        }
    }
}
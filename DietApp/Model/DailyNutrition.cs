using System;

namespace DietApp.Model
{
    public class DailyNutrition
    {
        private DateTime date;
        private int? calories;
        private int? fat;
        private int? protein;
        private int? carbohydrates;

        public DateTime Date
        {
            get
            {
                return date;
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

        public DailyNutrition(DateTime date, int? calories, int? fat, int? protein, int? carbohyrdates)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date must not be null");
            }
            this.date = date;
            this.calories = calories;
            this.fat = fat;
            this.protein = protein;
            this.carbohydrates = carbohyrdates;
        }
    }
}
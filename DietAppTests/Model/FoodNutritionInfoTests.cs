//-----------------------------------------------------------------------
// <copyright file="FoodNutritionInfoTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.FoodNutritionInfo class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTest.Model
{
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the FoodNutritionInfo Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class FoodNutritionInfoTests
    {
        /// <summary>
        /// Test for newly created FoodNutritionInfo, all gets show return 0.
        /// </summary>
        [TestMethod]
        public void TestNullFoodNutritionInfo()
        {
            // Create FoodNutritionInfo (New)
            FoodNutritionInfo foodNutritionInfo = new FoodNutritionInfo();

            // Check FoodNutritionInfo Data
            Assert.IsNull(foodNutritionInfo.name, "FoodNutritionInfo's name not null.");
            Assert.AreEqual(0, foodNutritionInfo.calories, 0, "FoodNutritionInfo's calories not 0.");
            Assert.AreEqual(0, foodNutritionInfo.fat, 0, "FoodNutritionInfo's fat not 0.");
            Assert.AreEqual(0, foodNutritionInfo.protein, 0, "FoodNutritionInfo's protein not 0.");
            Assert.AreEqual(0, foodNutritionInfo.carbohydrates, 0, "FoodNutritionInfo's carbohydrates not 0.");
        }

        /// <summary>
        /// Test for set and get of a foodNutritionInfo, FoodNutritionInfo class.
        /// </summary>
        [TestMethod]
        public void TestActiveFoodNutritionInfo()
        {
            // Set FoodNutritionInfo
            string name = "Bread, Slice";
            int calories = 79;
            int fat = 1;
            int protein = 3;
            int carbohydrates = 15;

            // Create FoodNutritionInfo (Active)
            FoodNutritionInfo foodNutritionInfo = new FoodNutritionInfo();
            foodNutritionInfo.name = name;
            foodNutritionInfo.calories = calories;
            foodNutritionInfo.fat = fat;
            foodNutritionInfo.protein = protein;
            foodNutritionInfo.carbohydrates = carbohydrates;

            // Check FoodNutritionInfo Data
            Assert.AreEqual(name, foodNutritionInfo.name, "FoodNutritionInfo's name not " + name + ".");
            Assert.AreEqual(calories, foodNutritionInfo.calories, 0, "FoodNutritionInfo's calories not " + calories + ".");
            Assert.AreEqual(fat, foodNutritionInfo.fat, 0, "FoodNutritionInfo's fat not " + fat + ".");
            Assert.AreEqual(protein, foodNutritionInfo.protein, 0, "FoodNutritionInfo's protein not " + protein + ".");
            Assert.AreEqual(carbohydrates, foodNutritionInfo.carbohydrates, 0, "FoodNutritionInfo's carbohydrates not " + carbohydrates + ".");
        }
    }
}
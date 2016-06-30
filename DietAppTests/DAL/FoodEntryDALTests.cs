//-----------------------------------------------------------------------
// <copyright file="FoodEntryDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the DAL.FoodEntryDAL class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Kenji Okamoto</author>
//-----------------------------------------------------------------------

namespace DietAppTests.DAL
{
    using System;
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the FoodEntryDAL Class in DietApp.DAL.
    /// </summary>
    [TestClass]
    public class FoodEntryDALTests
    {
        /// <summary>
        /// Test for add food entry.
        /// </summary>
        [TestMethod]
        public void TestAnEntryCanBeAddedToTheDB()
        {
            int userId = 1;
            string name = "test food item";
            int? calories = 200;
            int? protein = 7;
            int? fat = 2;
            int? carbohydrates = 40;
            DateTime consumedAt = new DateTime(2016, 06, 11, 23, 22, 00);
            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, consumedAt);

            FoodEntryDAL.deleteEntry(entry);
            FoodEntryDAL.addEntry(entry);
            FoodEntry retreivedEntry = FoodEntryDAL.getEntry(userId, consumedAt, name);
            Assert.IsNotNull(retreivedEntry);
            Assert.AreEqual(1, retreivedEntry.UserId);
            Assert.AreEqual(name, retreivedEntry.Name);
            Assert.AreEqual(calories, retreivedEntry.Calories);
            Assert.AreEqual(protein, retreivedEntry.Protein);
            Assert.AreEqual(fat, retreivedEntry.Fat);
            Assert.AreEqual(carbohydrates, retreivedEntry.Carbohydrates);
            Assert.AreEqual(consumedAt, retreivedEntry.ConsumedAt);
            FoodEntryDAL.deleteEntry(entry);
        }

        /// <summary>
        /// Test for add with null calories.
        /// </summary>
        [TestMethod]
        public void TestAnEntryCanBeAddedToTheDBWithNullCalories()
        {
            int userId = 1;
            string name = "test food item";
            int? calories = null;
            int? protein = 7;
            int? fat = 2;
            int? carbohydrates = 40;
            DateTime consumedAt = new DateTime(2016, 06, 11, 23, 22, 00);
            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, consumedAt);

            FoodEntryDAL.deleteEntry(entry);
            FoodEntryDAL.addEntry(entry);
            FoodEntry retreivedEntry = FoodEntryDAL.getEntry(userId, consumedAt, name);
            Assert.IsNotNull(retreivedEntry);
            Assert.AreEqual(1, retreivedEntry.UserId);
            Assert.AreEqual(name, retreivedEntry.Name);
            Assert.IsNull(retreivedEntry.Calories);
            Assert.AreEqual(protein, retreivedEntry.Protein);
            Assert.AreEqual(fat, retreivedEntry.Fat);
            Assert.AreEqual(carbohydrates, retreivedEntry.Carbohydrates);
            Assert.AreEqual(consumedAt, retreivedEntry.ConsumedAt);
            FoodEntryDAL.deleteEntry(entry);
        }

        /// <summary>
        /// Test for add with null protein.
        /// </summary>
        [TestMethod]
        public void TestAnEntryCanBeAddedToTheDBWithNullprotein()
        {
            int userId = 1;
            string name = "test food item";
            int? calories = 200;
            int? protein = null;
            int? fat = 2;
            int? carbohydrates = 40;
            DateTime consumedAt = new DateTime(2016, 06, 11, 23, 22, 00);
            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, consumedAt);

            FoodEntryDAL.deleteEntry(entry);
            FoodEntryDAL.addEntry(entry);
            FoodEntry retreivedEntry = FoodEntryDAL.getEntry(userId, consumedAt, name);
            Assert.IsNotNull(retreivedEntry);
            Assert.AreEqual(1, retreivedEntry.UserId);
            Assert.AreEqual(name, retreivedEntry.Name);
            Assert.AreEqual(calories, retreivedEntry.Calories);
            Assert.IsNull(retreivedEntry.Protein);
            Assert.AreEqual(fat, retreivedEntry.Fat);
            Assert.AreEqual(carbohydrates, retreivedEntry.Carbohydrates);
            Assert.AreEqual(consumedAt, retreivedEntry.ConsumedAt);
            FoodEntryDAL.deleteEntry(entry);
        }

        /// <summary>
        /// Test for add with null fat.
        /// </summary>
        [TestMethod]
        public void TestAnEntryCanBeAddedToTheDBWithNullFat()
        {
            int userId = 1;
            string name = "test food item";
            int? calories = 200;
            int? protein = 7;
            int? fat = null;
            int? carbohydrates = 40;
            DateTime consumedAt = new DateTime(2016, 06, 11, 23, 22, 00);
            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, consumedAt);

            FoodEntryDAL.deleteEntry(entry);
            FoodEntryDAL.addEntry(entry);
            FoodEntry retreivedEntry = FoodEntryDAL.getEntry(userId, consumedAt, name);
            Assert.IsNotNull(retreivedEntry);
            Assert.AreEqual(1, retreivedEntry.UserId);
            Assert.AreEqual(name, retreivedEntry.Name);
            Assert.AreEqual(calories, retreivedEntry.Calories);
            Assert.AreEqual(protein, retreivedEntry.Protein);
            Assert.IsNull(retreivedEntry.Fat);
            Assert.AreEqual(carbohydrates, retreivedEntry.Carbohydrates);
            Assert.AreEqual(consumedAt, retreivedEntry.ConsumedAt);
            FoodEntryDAL.deleteEntry(entry);
        }

        /// <summary>
        /// Test for add with null carbohydrates.
        /// </summary>
        [TestMethod]
        public void TestAnEntryCanBeAddedToTheDBWithNullCarbohydrates()
        {
            int userId = 1;
            string name = "test food item";
            int? calories = 200;
            int? protein = 7;
            int? fat = 2;
            int? carbohydrates = null;
            DateTime consumedAt = new DateTime(2016, 06, 11, 23, 22, 00);
            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, consumedAt);

            FoodEntryDAL.deleteEntry(entry);
            FoodEntryDAL.addEntry(entry);
            FoodEntry retreivedEntry = FoodEntryDAL.getEntry(userId, consumedAt, name);
            Assert.IsNotNull(retreivedEntry);
            Assert.AreEqual(1, retreivedEntry.UserId);
            Assert.AreEqual(name, retreivedEntry.Name);
            Assert.AreEqual(calories, retreivedEntry.Calories);
            Assert.AreEqual(protein, retreivedEntry.Protein);
            Assert.AreEqual(fat, retreivedEntry.Fat);
            Assert.IsNull(retreivedEntry.Carbohydrates);
            Assert.AreEqual(consumedAt, retreivedEntry.ConsumedAt);
            FoodEntryDAL.deleteEntry(entry);
        }
    }
}
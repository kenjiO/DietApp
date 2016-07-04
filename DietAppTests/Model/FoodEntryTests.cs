//-----------------------------------------------------------------------
// <copyright file="FoodEntryTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.FoodEntry class.</summary>
// <author>Kenji Okamoto</author>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.Model
{
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Test the FoodEntry Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class FoodEntryTests
    {
        /// <summary>
        /// Test the FoodEntry.
        /// </summary>
        [TestMethod]
        public void TestFoodEntry()
        {
            // Sets Food
            int userId = 1;
            string name = "apple";
            int calories = 100;
            int fat = 1;
            int protein = 3;
            int carbohydrates = 11;

            // Enters Food
            FoodEntry entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates);

            // Checks Test Results
            Assert.AreEqual(userId, entry.UserId, "Food userId is not " + userId + ".");
            Assert.AreEqual(name, entry.Name, "Food name is not " + name + ".");
            Assert.AreEqual(calories, entry.Calories, "Food calories is not " + calories + ".");
            Assert.AreEqual(fat, entry.Fat, "Food fat is not " + fat + ".");
            Assert.AreEqual(protein, entry.Protein, "Food protein is not " + protein + ".");
            Assert.AreEqual(carbohydrates, entry.Carbohydrates, "Food carbohydrates is not " + carbohydrates + ".");

            // Allow a 10 second delta between the two DateTimes
            Assert.IsTrue((DateTime.Now - entry.ConsumedAt) < TimeSpan.FromSeconds(10));

            // Check Time
            DateTime specifiedDateTime = new DateTime(2012, 3, 18, 16, 55, 22, 0);
            entry = new FoodEntry(userId, name, calories, fat, protein, carbohydrates, specifiedDateTime);
            Assert.AreEqual(specifiedDateTime, entry.ConsumedAt);
        }

        /// <summary>
        /// Test for created FoodEntry, null name.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryNameNull()
        {
            try
            {
                new FoodEntry(1, null, 0, 0, 0, 0);
                Assert.Fail("Exception not thrown for null food name");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Food name must be specified\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, blank name.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryNameBlank()
        {
            try
            {
                new FoodEntry(1, string.Empty, 0, 0, 0, 0);
                Assert.Fail("Exception not thrown for blank food name");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Food name must be specified\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, whitespace name.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryNameWhitespace()
        {
            try
            {
                new FoodEntry(1, "  ", 0, 0, 0, 0);
                Assert.Fail("Exception not thrown for whitespace food name");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Food name must be specified\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, negative calories.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryCaloriesNegative()
        {
            try
            {
                new FoodEntry(1, "apple", -1, 0, 0, 0);
                Assert.Fail("Exception not thrown for negative calories");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Calories must not be less than 0\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, negative fat.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryFatNegative()
        {
            try
            {
                new FoodEntry(1, "apple", 0, -1, 0, 0);
                Assert.Fail("Exception not thrown for negative fat");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Fat must not be less than 0\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, negative protein.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryProteinNegative()
        {
            try
            {
                new FoodEntry(1, "apple", 0, 0, -1, 0);
                Assert.Fail("Exception not thrown for negative protein");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Protein must not be less than 0\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, negative carbohydrates.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryCarbohydratesNegative()
        {
            try
            {
                new FoodEntry(1, "apple", 0, 0, 0, -1);
                Assert.Fail("Exception not thrown for negative carbohydrates");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Carbohydrates must not be less than 0\n", ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, negative data.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryAllNegative()
        {
            try
            {
                new FoodEntry(1, string.Empty, -1, -1, -1, -1);
                Assert.Fail("Exception not thrown for multiple validation errors");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(
                    "Food name must be specified\n" +
                    "Calories must not be less than 0\n" +
                    "Fat must not be less than 0\n" +
                    "Protein must not be less than 0\n" +
                    "Carbohydrates must not be less than 0\n",
                    ex.Message);
            }
        }

        /// <summary>
        /// Test for created FoodEntry, null calories.
        /// </summary>
        [TestMethod]
        public void TestFoodEntryNullEntry()
        {
            // Sets Food
            int userId = 1;
            string name = "apple";

            // Enters Food
            FoodEntry entry = new FoodEntry(userId, name, null, null, null, null);

            // Checks Test Results
            Assert.IsNull(entry.Calories, "Calories should be null");
            Assert.IsNull(entry.Fat, "Fat should be null");
            Assert.IsNull(entry.Protein, "Protein should be null");
            Assert.IsNull(entry.Carbohydrates, "Carbohydrates should be null");
        }
    }
}
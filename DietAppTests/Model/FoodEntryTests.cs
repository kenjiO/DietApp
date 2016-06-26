using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DietAppTests.Model
{
    [TestClass]
    public class FoodEntryTests
    {
        [TestMethod]
        public void TestUserIdGetsSet()
        {
            FoodEntry entry = new FoodEntry(17, "apple", 100, 1, 3, 11);
            Assert.AreEqual(17, entry.UserId, "UserId did not get set right");
        }

        [TestMethod]
        public void TestFoodNameGetsSet()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11);
            Assert.AreEqual("apple", entry.Name, "Food name did not get set right");
        }

        [TestMethod]
        public void TestCaloriesGetsSet()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11);
            Assert.AreEqual(100, entry.Calories, "Calories did not get set right");
        }

        [TestMethod]
        public void TestFatGetsSet()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11);
            Assert.AreEqual(1, entry.Fat, "Fat did not get set right");
        }

        [TestMethod]
        public void TestProteinGetsSet()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11);
            Assert.AreEqual(3, entry.Protein, "Protein did not get set right");
        }

        [TestMethod]
        public void TestCarbohydratesGetsSet()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11);
            Assert.AreEqual(11, entry.Carbohydrates, "Carbohydrates did not get set right");
        }

        [TestMethod]
        public void TestFoodNameCannotBeNull()
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

        [TestMethod]
        public void TestFoodNameCannotBeBlank()
        {
            try
            {
                new FoodEntry(1, "", 0, 0, 0, 0);
                Assert.Fail("Exception not thrown for blank food name");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Food name must be specified\n", ex.Message);
            }
        }

        [TestMethod]
        public void TestFoodNameCannotBeWhitspace()
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

        [TestMethod]
        public void TestCaloriesCannotBeNegative()
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

        [TestMethod]
        public void TestFatCannotBeNegative()
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

        [TestMethod]
        public void TestProteinCannotBeNegative()
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

        [TestMethod]
        public void TestCarbohydratesCannotBeNegative()
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

        [TestMethod]
        public void TestExceptionMessageShowsAllErrors()
        {
            try
            {
                new FoodEntry(1, "", -1, -1, -1, -1);
                Assert.Fail("Exception not thrown for multiple validation errors");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Food name must be specified\n" +
                    "Calories must not be less than 0\n" +
                    "Fat must not be less than 0\n" +
                    "Protein must not be less than 0\n" +
                    "Carbohydrates must not be less than 0\n", ex.Message);
            }
        }

        [TestMethod]
        public void TestCaloriesCanBeNull()
        {
            FoodEntry entry = new FoodEntry(1, "apple", null, 1, 3, 11);
            Assert.IsNull(entry.Calories, "Calories should be null");
        }

        [TestMethod]
        public void TestFatCanBeNull()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, null, 3, 11);
            Assert.IsNull(entry.Fat, "Fat should be null");
        }

        [TestMethod]
        public void TestProteinCanBeNull()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, null, 11);
            Assert.IsNull(entry.Protein, "Protein should be null");
        }

        [TestMethod]
        public void TestCarbohydratesCanBeNull()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, null);
            Assert.IsNull(entry.Carbohydrates, "Carbohydrates should be null");
        }

        [TestMethod]
        public void TestWhenConsumedAtIsNotSpecifiedItIsNow()
        {
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11);
            //Allow a 10 second delta between the two DateTimes
            Assert.IsTrue((DateTime.Now - entry.ConsumedAt) < TimeSpan.FromSeconds(10));
        }

        [TestMethod]
        public void TestWhenConsumedAtCanBeSpecified()
        {
            DateTime specifiedDateTime = new DateTime(2012, 3, 18, 16, 55, 22, 0);
            FoodEntry entry = new FoodEntry(1, "apple", 100, 1, 3, 11, specifiedDateTime);
            Assert.AreEqual(specifiedDateTime, entry.ConsumedAt);
        }
    }
}
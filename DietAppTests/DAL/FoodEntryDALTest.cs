using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;
using DietApp.DAL;
namespace DietAppTests.DAL
{
    [TestClass]
    public class FoodEntryDALTest
    {
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

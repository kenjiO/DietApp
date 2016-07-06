using DietApp.DAL;
using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace DietAppTests.DAL
{
    [TestClass]
    public class FoodReportDALTests
    {
        [TestMethod]
        public void TestReportsAreGeneratedFor10Days()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = UsersDAL.addNewUser("FoodReportDALTestUser", "ABC123xyz!");

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apples", 75, 9, 18, 27, new DateTime(2015, 01, 01))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 25, 2, 3, 4, new DateTime(2015, 01, 01))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 150, 7, 15, 22, new DateTime(2015, 01, 02))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 50, 5, 7, 10, new DateTime(2015, 01, 02))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 255, 7, 20, 17, new DateTime(2015, 01, 03))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 45, 6, 3, 16, new DateTime(2015, 01, 03))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 300, 11, 2, 30, new DateTime(2015, 01, 04))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 100, 3, 22, 4, new DateTime(2015, 01, 04))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 200, 14, 23, 32, new DateTime(2015, 01, 05))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 300, 1, 2, 3, new DateTime(2015, 01, 05))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 200, 1, 2, 3, new DateTime(2015, 01, 06))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 400, 15, 24, 33, new DateTime(2015, 01, 06))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 200, 16, 25, 34, new DateTime(2015, 01, 07))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 500, 1, 2, 3, new DateTime(2015, 01, 07))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 700, 17, 26, 35, new DateTime(2015, 01, 08))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 100, 1, 2, 3, new DateTime(2015, 01, 08))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 800, 18, 27, 36, new DateTime(2015, 01, 09))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 100, 1, 2, 3, new DateTime(2015, 01, 09))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 900, 19, 28, 37, new DateTime(2015, 01, 10))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 100, 1, 2, 3, new DateTime(2015, 01, 10))
                );

                List<DailyNutrition> results = FoodReportDAL.get10DayNutritionReport(userId, new DateTime(2015, 01, 01));
                Assert.AreEqual(10, results.Count);
                Assert.AreEqual(100, results[0].Calories);
                Assert.AreEqual(11, results[0].Fat);
                Assert.AreEqual(21, results[0].Protein);
                Assert.AreEqual(31, results[0].Carbohydrates);
                Assert.AreEqual(200, results[1].Calories);
                Assert.AreEqual(12, results[1].Fat);
                Assert.AreEqual(22, results[1].Protein);
                Assert.AreEqual(32, results[1].Carbohydrates);
                Assert.AreEqual(300, results[2].Calories);
                Assert.AreEqual(13, results[2].Fat);
                Assert.AreEqual(23, results[2].Protein);
                Assert.AreEqual(33, results[2].Carbohydrates);
                Assert.AreEqual(400, results[3].Calories);
                Assert.AreEqual(14, results[3].Fat);
                Assert.AreEqual(24, results[3].Protein);
                Assert.AreEqual(34, results[3].Carbohydrates);
                Assert.AreEqual(500, results[4].Calories);
                Assert.AreEqual(15, results[4].Fat);
                Assert.AreEqual(25, results[4].Protein);
                Assert.AreEqual(35, results[4].Carbohydrates);
                Assert.AreEqual(600, results[5].Calories);
                Assert.AreEqual(16, results[5].Fat);
                Assert.AreEqual(26, results[5].Protein);
                Assert.AreEqual(36, results[5].Carbohydrates);
                Assert.AreEqual(700, results[6].Calories);
                Assert.AreEqual(17, results[6].Fat);
                Assert.AreEqual(27, results[6].Protein);
                Assert.AreEqual(37, results[6].Carbohydrates);
                Assert.AreEqual(800, results[7].Calories);
                Assert.AreEqual(18, results[7].Fat);
                Assert.AreEqual(28, results[7].Protein);
                Assert.AreEqual(38, results[7].Carbohydrates);
                Assert.AreEqual(900, results[8].Calories);
                Assert.AreEqual(19, results[8].Fat);
                Assert.AreEqual(29, results[8].Protein);
                Assert.AreEqual(39, results[8].Carbohydrates);
                Assert.AreEqual(1000, results[9].Calories);
                Assert.AreEqual(20, results[9].Fat);
                Assert.AreEqual(30, results[9].Protein);
                Assert.AreEqual(40, results[9].Carbohydrates);
            }
        }

        [TestMethod]
        public void TestReportsCanBeGeneratedWithMissingDays()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = UsersDAL.addNewUser("FoodReportDALTestUser", "ABC123xyz!");

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apples", 75, 9, 18, 27, new DateTime(2015, 01, 01))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 25, 2, 3, 4, new DateTime(2015, 01, 01))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 255, 7, 20, 17, new DateTime(2015, 01, 03))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 45, 6, 3, 16, new DateTime(2015, 01, 03))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 200, 14, 23, 32, new DateTime(2015, 01, 05))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 300, 1, 2, 3, new DateTime(2015, 01, 05))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 200, 16, 25, 34, new DateTime(2015, 01, 07))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 500, 1, 2, 3, new DateTime(2015, 01, 07))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 800, 18, 27, 36, new DateTime(2015, 01, 09))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 100, 1, 2, 3, new DateTime(2015, 01, 09))
                );

                List<DailyNutrition> results = FoodReportDAL.get10DayNutritionReport(userId, new DateTime(2015, 01, 01));
                Assert.AreEqual(5, results.Count);
                Assert.AreEqual(100, results[0].Calories);
                Assert.AreEqual(11, results[0].Fat);
                Assert.AreEqual(21, results[0].Protein);
                Assert.AreEqual(31, results[0].Carbohydrates);
                Assert.AreEqual(300, results[1].Calories);
                Assert.AreEqual(13, results[1].Fat);
                Assert.AreEqual(23, results[1].Protein);
                Assert.AreEqual(33, results[1].Carbohydrates);
                Assert.AreEqual(500, results[2].Calories);
                Assert.AreEqual(15, results[2].Fat);
                Assert.AreEqual(25, results[2].Protein);
                Assert.AreEqual(35, results[2].Carbohydrates);
                Assert.AreEqual(700, results[3].Calories);
                Assert.AreEqual(17, results[3].Fat);
                Assert.AreEqual(27, results[3].Protein);
                Assert.AreEqual(37, results[3].Carbohydrates);
                Assert.AreEqual(900, results[4].Calories);
                Assert.AreEqual(19, results[4].Fat);
                Assert.AreEqual(29, results[4].Protein);
                Assert.AreEqual(39, results[4].Carbohydrates);
            }
        }

        [TestMethod]
        public void TestResultsDoNotIncludeDaysOutsideOf10DayWindow()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = UsersDAL.addNewUser("FoodReportDALTestUser", "ABC123xyz!");

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apples", 75, 9, 18, 27, new DateTime(2015, 01, 01))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 25, 2, 3, 4, new DateTime(2015, 01, 01))
                );

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 150, 7, 15, 22, new DateTime(2015, 01, 12))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 50, 5, 7, 10, new DateTime(2015, 01, 12))
                );

                List<DailyNutrition> results = FoodReportDAL.get10DayNutritionReport(userId, new DateTime(2015, 01, 02));
                Assert.AreEqual(0, results.Count);
            }
        }

        [TestMethod]
        public void TestResultsAreOrderedByDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = UsersDAL.addNewUser("FoodReportDALTestUser", "ABC123xyz!");

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apples", 300, 0, 0, 0, new DateTime(2015, 01, 03))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 100, 0, 0, 0, new DateTime(2015, 01, 01))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", 200, 0, 0, 0, new DateTime(2015, 01, 02))
                );

                List<DailyNutrition> results = FoodReportDAL.get10DayNutritionReport(userId, new DateTime(2015, 01, 01));
                Assert.AreEqual(3, results.Count);
                Assert.AreEqual(100, results[0].Calories);
                Assert.AreEqual(200, results[1].Calories);
                Assert.AreEqual(300, results[2].Calories);
            }
        }

        [TestMethod]
        public void TestNullValuesAreTreatedAs0()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = UsersDAL.addNewUser("FoodReportDALTestUser", "ABC123xyz!");

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", null, null, null, null, new DateTime(2015, 01, 01))
                );

                List<DailyNutrition> results = FoodReportDAL.get10DayNutritionReport(userId, new DateTime(2015, 01, 01));
                Assert.AreEqual(1, results.Count);
                Assert.AreEqual(0, results[0].Calories);
                Assert.AreEqual(0, results[0].Fat);
                Assert.AreEqual(0, results[0].Protein);
                Assert.AreEqual(0, results[0].Carbohydrates);
            }
        }

        [TestMethod]
        public void TestNullValuesWorkWillNotCauseProblemsWithNonNulls()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = UsersDAL.addNewUser("FoodReportDALTestUser", "ABC123xyz!");

                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "apple", null, null, null, null, new DateTime(2015, 01, 01))
                );
                FoodEntryDAL.addEntry(
                    new FoodEntry(userId, "banana", 100, 1, 2, 3, new DateTime(2015, 01, 01))
                );

                List<DailyNutrition> results = FoodReportDAL.get10DayNutritionReport(userId, new DateTime(2015, 01, 01));
                Assert.AreEqual(1, results.Count);
                Assert.AreEqual(100, results[0].Calories);
                Assert.AreEqual(1, results[0].Fat);
                Assert.AreEqual(2, results[0].Protein);
                Assert.AreEqual(3, results[0].Carbohydrates);
            }
        }
    }
}
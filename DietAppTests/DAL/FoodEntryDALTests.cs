//-----------------------------------------------------------------------
// <copyright file="FoodEntryDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the DAL.FoodEntryDAL class.</summary>
// <author>Robert Carswell</author>
// <author>Kenji Okamoto</author>
//-----------------------------------------------------------------------

namespace DietAppTests.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Transactions;
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

        /// <summary>
        /// Test return of empty list with no entries.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsEmptyListWhenUserHasNoEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.AreEqual(0, entries.Count);
            }
        }

        /// <summary>
        /// Test the return of an empty list with no date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsEmptyListWhenUserHasNoEntriesOnGivenDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 01));
                FoodEntryDAL.addEntry(entry);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 01, 02));
                Assert.AreEqual(0, entries.Count);
            }
        }

        /// <summary>
        /// Test the return of the list for a given date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsOnlyEntriesOnGivenDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 01));
                FoodEntry entry2 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 02));
                FoodEntry entry3 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 03));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                FoodEntryDAL.addEntry(entry3);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 01, 02));
                Assert.AreEqual(1, entries.Count);
            }
        }

        /// <summary>
        /// Test the return of the list not returned for other entries.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesDoesNotReturnOtherUserEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                int otherUserId = UsersDAL.addNewUser("getEntriesOtherTestUser", "ABC123xyz!");

                FoodEntry entry = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 01));
                FoodEntry otherUserEntry = new FoodEntry(otherUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 01));
                FoodEntryDAL.addEntry(entry);
                FoodEntryDAL.addEntry(otherUserEntry);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 01, 01));
                Assert.AreEqual(1, entries.Count);
                Assert.AreEqual(newUserId, entries[0].UserId);
            }
        }

        /// <summary>
        /// Test the return of the list for a given date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsTheSameEntryWhenOneEntryOnGivenDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 03, 12));
                FoodEntryDAL.addEntry(entry);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.AreEqual(1, entries.Count);
                FoodEntry listItem1 = entries[0];
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry, listItem1));
            }
        }

        /// <summary>
        /// Test to return Two Entries When Two Entries On Same Date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsTwoEntriesWhenTwoEntriesOnSameDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 03, 12));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.AreEqual(2, entries.Count);
            }
        }

        /// <summary>
        /// Test to return The Same Entries When Two Entries On Same Date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsTheSameEntriesWhenTwoEntriesOnSameDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 03, 12));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry2, entries[1]));
            }
        }

        /// <summary>
        /// Test to return 3 Entries When 3 Entries On Same Date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturns3EntriesWhen3EntriesOnSameDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 03, 12));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12));
                FoodEntry entry3 = new FoodEntry(newUserId, "cherry", 12, 0, 0, 4, new DateTime(2016, 03, 12));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                FoodEntryDAL.addEntry(entry3);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.AreEqual(3, entries.Count);
            }
        }

        /// <summary>
        /// Test to return The Same Entries When Three Entries On Same Date.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsTheSameEntriesWhenThreeEntriesOnSameDate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 03, 12));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12));
                FoodEntry entry3 = new FoodEntry(newUserId, "cherry", 12, 0, 0, 4, new DateTime(2016, 03, 12));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                FoodEntryDAL.addEntry(entry3);

                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry2, entries[1]));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry3, entries[2]));
            }
        }

        /// <summary>
        /// Test to return List Sorted By Time.
        /// </summary>
        [TestMethod]
        public void TestGetEntriesReturnsListSortedByTime()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry3 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 03, 12, 01, 01, 03, 00));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12, 01, 01, 02, 00));
                FoodEntry entry4 = new FoodEntry(newUserId, "cherry", 12, 0, 0, 4, new DateTime(2016, 03, 12, 01, 01, 04, 00));
                FoodEntry entry1 = new FoodEntry(newUserId, "donut", 12, 0, 0, 4, new DateTime(2016, 03, 12, 01, 01, 01, 00));
                FoodEntryDAL.addEntry(entry3);
                FoodEntryDAL.addEntry(entry2);
                FoodEntryDAL.addEntry(entry4);
                FoodEntryDAL.addEntry(entry1);

                List<FoodEntry> entries = FoodEntryDAL.getUserEntriesByDate(newUserId, new DateTime(2016, 03, 12));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry2, entries[1]));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry3, entries[2]));
                Assert.IsTrue(this.TestareFoodEntriesEqual(entry4, entries[3]));
            }
        }

        /// <summary>
        /// Test an empty list is returned when no entries
        /// </summary>
        [TestMethod]
        public void TestGetUserEntriesReturnsEmptyListWhenNoEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                List<FoodEntry> entries = FoodEntryDAL.getUserEntries(newUserId);
                Assert.AreEqual(0, entries.Count);
            }
        }

        /// <summary>
        /// Test getUserEntries returns 1 entries when there is 1 entry        
        /// </summary>
        [TestMethod]
        public void TestGetUserEntriesReturns1EntriesWhen1Entry()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 05));
                FoodEntryDAL.addEntry(entry1);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntries(newUserId);
                Assert.AreEqual(1, entries.Count);
                Assert.IsTrue(TestareFoodEntriesEqual(entry1, entries[0]));
            }
        }


        /// <summary>
        /// Test getUserEntries returns 2 entries when there are 2 entries        
        /// </summary>
        [TestMethod]
        public void TestGetUserEntriesReturns2EntriesWhen2Entries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 05));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntries(newUserId);
                Assert.AreEqual(2, entries.Count);
                Assert.IsTrue(TestareFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(TestareFoodEntriesEqual(entry2, entries[1]));
            }
        }

        /// <summary>
        /// Test getUserEntries returns 2 entries when there are 2 entries on the same day        
        /// </summary>
        [TestMethod]
        public void TestGetUserEntriesReturns2EntriesWhen2EntriesOnSameDay()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 05));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 01, 05));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntries(newUserId);
                Assert.AreEqual(2, entries.Count);
                Assert.IsTrue(TestareFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(TestareFoodEntriesEqual(entry2, entries[1]));
            }
        }

        /// <summary>
        /// Test getUserEntries returns 3 entries when there are 3 entries        
        /// </summary>
        [TestMethod]
        public void TestGetUserEntriesReturns3EntriesWhen3Entries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                FoodEntry entry1 = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 05));
                FoodEntry entry2 = new FoodEntry(newUserId, "banana", 121, 1, 2, 41, new DateTime(2016, 03, 12));
                FoodEntry entry3 = new FoodEntry(newUserId, "cherry", 12, 0, 0, 4, new DateTime(2016, 06, 23));
                FoodEntryDAL.addEntry(entry1);
                FoodEntryDAL.addEntry(entry2);
                FoodEntryDAL.addEntry(entry3);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntries(newUserId);
                Assert.AreEqual(3, entries.Count);
                Assert.IsTrue(TestareFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(TestareFoodEntriesEqual(entry2, entries[1]));
                Assert.IsTrue(TestareFoodEntriesEqual(entry3, entries[2]));
            }
        }

        /// <summary>
        /// Test the return of the list not returned for other entries.
        /// </summary>
        [TestMethod]
        public void TestGetUserEntriesDoesNotReturnOtherUserEntries()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("getEntriesTestUser", "ABC123xyz!");
                int otherUserId = UsersDAL.addNewUser("getEntriesOtherTestUser", "ABC123xyz!");

                FoodEntry entry = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 01));
                FoodEntry otherUserEntry = new FoodEntry(otherUserId, "apple", 120, 0, 1, 40, new DateTime(2016, 01, 01));
                FoodEntryDAL.addEntry(entry);
                FoodEntryDAL.addEntry(otherUserEntry);
                List<FoodEntry> entries = FoodEntryDAL.getUserEntries(newUserId);
                Assert.AreEqual(1, entries.Count);
                Assert.AreEqual(newUserId, entries[0].UserId);
            }
        }


        /// <summary>
        /// Private: test the compared entries.
        /// </summary>
        /// <param name="fe1">First Entry.</param>
        /// <param name="fe2">Second Entry.</param>
        /// <returns>True if same, else false.</returns>
        private bool TestareFoodEntriesEqual(FoodEntry fe1, FoodEntry fe2)
        {
            return fe1.UserId == fe2.UserId &&
                fe1.Calories == fe2.Calories &&
                fe1.Carbohydrates == fe2.Carbohydrates &&
                fe1.ConsumedAt.ToString("yyyyMMddhhmmss") == fe2.ConsumedAt.ToString("yyyyMMddhhmmss") &&
                fe1.Fat == fe2.Fat &&
                fe1.Name == fe2.Name &&
                fe1.Protein == fe2.Protein;
        }
    }
}
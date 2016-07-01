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
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Transactions;

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
                Assert.IsTrue(areFoodEntriesEqual(entry, listItem1));
            }
        }

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
                Assert.IsTrue(areFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(areFoodEntriesEqual(entry2, entries[1]));
            }
        }

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
                Assert.IsTrue(areFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(areFoodEntriesEqual(entry2, entries[1]));
                Assert.IsTrue(areFoodEntriesEqual(entry3, entries[2]));
            }
        }

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
                Assert.IsTrue(areFoodEntriesEqual(entry1, entries[0]));
                Assert.IsTrue(areFoodEntriesEqual(entry2, entries[1]));
                Assert.IsTrue(areFoodEntriesEqual(entry3, entries[2]));
                Assert.IsTrue(areFoodEntriesEqual(entry4, entries[3]));
            }
        }

        [TestMethod]
        public void TestUpdateEntryUpdatesTheName()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.addEntry(original);
                FoodEntry updated = new FoodEntry(newUserId, "banana", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);
                // "apple" should no longer exist for that userId and dateTime
                FoodEntry dBAppleEntry = FoodEntryDAL.getEntry(newUserId, consumedAt, "apple");
                Assert.IsNull(dBAppleEntry);
                // "banana" should exist for that userId and dateTime
                FoodEntry dBBananaEntry = FoodEntryDAL.getEntry(newUserId, consumedAt, "banana");
                Assert.IsTrue(areFoodEntriesEqual(updated, dBBananaEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryUpdatesTheDateTime()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime originalDateTime = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, originalDateTime);
                FoodEntryDAL.addEntry(original);

                DateTime updatedDateTime = new DateTime(2016, 04, 30, 16, 07, 00);
                FoodEntry updated = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, updatedDateTime);

                FoodEntryDAL.updateEntry(original, updated);

                // apple for user should no longer exist at the original dateTime
                FoodEntry dBOriginal = FoodEntryDAL.getEntry(newUserId, originalDateTime, "apple");
                Assert.IsNull(dBOriginal);
                // apple for user should exist at the new dateTime
                FoodEntry dBUpdated = FoodEntryDAL.getEntry(newUserId, updatedDateTime, "apple");
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdated));
            }
        }

        [TestMethod]
        public void TestUpdateEntryUpdatesTheCalories()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.addEntry(original);

                FoodEntry updated = new FoodEntry(newUserId, "apple", 500, 0, 1, 40, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryUpdatesTheFat()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.addEntry(original);

                FoodEntry updated = new FoodEntry(newUserId, "apple", 120, 3, 1, 40, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryUpdatesTheProtein()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.addEntry(original);

                FoodEntry updated = new FoodEntry(newUserId, "apple", 120, 0, 6, 40, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryUpdatesTheCarbohydrates()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.addEntry(original);

                FoodEntry updated = new FoodEntry(newUserId, "apple", 120, 0, 1, 20, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryWorksWithChangingSetValuesToNulls()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 120, 0, 1, 40, consumedAt);
                FoodEntryDAL.addEntry(original);

                FoodEntry updated = new FoodEntry(newUserId, "apple", null, null, null, null, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryWorksWithChangingNullValuesToSetValues()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", null, null, null, null, consumedAt);
                FoodEntryDAL.addEntry(original);

                FoodEntry updated = new FoodEntry(newUserId, "apple", 120, 0, 1, 20, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryCanChangeAllValuesExceptUserId()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId, "apple", 1, 2, 3, 4, consumedAt);
                FoodEntryDAL.addEntry(original);

                DateTime newConsumedAt = new DateTime(2016, 06, 05, 15, 14, 00);
                FoodEntry updated = new FoodEntry(newUserId, "banana", 11, 12, 13, 14, newConsumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                FoodEntry dBUpdatedEntry = FoodEntryDAL.getEntry(newUserId, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(updated, dBUpdatedEntry));
            }
        }

        [TestMethod]
        public void TestUpdateEntryCannotChangeTheUserId()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int newUserId1 = UsersDAL.addNewUser("UpdateEntryTestUser", "ABC123xyz!");
                DateTime consumedAt = new DateTime(2016, 03, 12, 05, 26, 00);
                FoodEntry original = new FoodEntry(newUserId1, "apple", 1, 2, 3, 4, consumedAt);
                FoodEntryDAL.addEntry(original);

                int newUserId2 = UsersDAL.addNewUser("UpdateEntryTestUser2", "ABC123xyz!");
                FoodEntry updated = new FoodEntry(newUserId2, "apple", 1, 2, 3, 4, consumedAt);
                FoodEntryDAL.updateEntry(original, updated);

                // Should still be in DB under original user Id
                FoodEntry dBUpdatedEntryNewUser1 = FoodEntryDAL.getEntry(newUserId1, updated.ConsumedAt, updated.Name);
                Assert.IsTrue(areFoodEntriesEqual(original, dBUpdatedEntryNewUser1));

                FoodEntry dBUpdatedEntryNewUser2 = FoodEntryDAL.getEntry(newUserId2, updated.ConsumedAt, updated.Name);
                Assert.IsNull(dBUpdatedEntryNewUser2);
            }
        }

        private bool areFoodEntriesEqual(FoodEntry fe1, FoodEntry fe2)
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
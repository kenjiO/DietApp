//-----------------------------------------------------------------------
// <copyright file="UserDALTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.UserDAL class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTests.DAL
{
    using System;
    using DietApp.DAL;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the UserDAL Class in DietApp.DAL.
    /// </summary>
    [TestClass]
    public class UserDALTests
    {
        /// <summary>
        /// Test for return of user data.
        /// </summary>
        [TestMethod]
        public void TestgetUserData()
        {
            // Set Users AA
            int userId = 1;
            string userName = "aa";
            string firstName = "Al";
            string lastName = "Adams";
            string email = "aladams@example.com";
            int initialWeight = 220;
            int heightInches = 70;
            int dailyCalorieGoal = 2500;
            int goalWeight = 180;
            string fullName = firstName + " " + lastName;

            // Get User AA (by userName)
            Users userAAName = UsersDAL.getUserData(userName);

            // Check Results, expect AA
            Assert.AreEqual(userId, userAAName.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(userName, userAAName.userName, "AA's userName not " + userName + ".");
            Assert.AreEqual(firstName, userAAName.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, userAAName.lastName, "AA's lastName not " + lastName + ".");
            Assert.AreEqual(email, userAAName.email, "AA's email not " + email + ".");
            Assert.AreEqual(initialWeight, userAAName.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, userAAName.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, userAAName.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, userAAName.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, userAAName.getFullName(), "AA's fullName not " + fullName + ".");

            // Get User AA (by userId)
            Users userAAId = UsersDAL.getUserData(userId);

            // Check Results, expect AA
            Assert.AreEqual(userId, userAAId.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(userName, userAAId.userName, "AA's userName not " + userName + ".");
            Assert.AreEqual(firstName, userAAId.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, userAAId.lastName, "AA's lastName not " + lastName + ".");
            Assert.AreEqual(email, userAAId.email, "AA's email not " + email + ".");
            Assert.AreEqual(initialWeight, userAAId.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, userAAId.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, userAAId.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, userAAId.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, userAAId.getFullName(), "AA's fullName not " + fullName + ".");
        }

        /// <summary>
        /// Test for add new user, return of user data
        /// initial profile setup
        /// will delete then completed.
        /// </summary>
        [TestMethod]
        public void TestaddNewUser()
        {
            // Set New Users
            string userName = "dd";
            string firstName = string.Empty;
            string lastName = string.Empty;
            string email = string.Empty;
            string password = "password";
            int initialWeight = 0;
            int heightInches = 0;
            int dailyCalorieGoal = 0;
            int goalWeight = 0;
            string fullName = firstName + " " + lastName;

            // Create New User
            int userDDId = UsersDAL.addNewUser(userName, password);
            Users dd = UsersDAL.getUserData(userDDId);

            // Check Results, expect New UserS
            Assert.AreEqual(userName, dd.userName, "DD's username not " + userName + ".");
            Assert.AreEqual(firstName, dd.firstName, "DD's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, dd.lastName, "DD's lastName not " + lastName + ".");
            Assert.AreEqual(email, dd.email, "DD's email not " + email + ".");
            Assert.AreEqual(initialWeight, dd.initialWeight, "DD's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, dd.heightInches, 0, "DD's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, dd.dailyCalorieGoal, 0, "DD's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, dd.goalWeight, 0, "DD's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, dd.getFullName(), "DD's fullName not " + fullName + ".");

            // Deletes Test New User
            UsersDAL.deleteUsers(userDDId);
            dd = UsersDAL.getUserData(userDDId);
            Assert.AreEqual(0, dd.userId, "New Test Users not Deleted.");
        }

        /// <summary>
        /// Test for update of user data
        /// will reverse when complete.
        /// </summary>
        [TestMethod]
        public void TestupdateUsers()
        {
            // Set Users BB
            int userId = 2;
            string firstName = "Emitt";
            string lastName = "Ethan";
            string email = "eethan@example.com";
            int initialWeight = 175;
            int heightInches = 72;
            int dailyCalorieGoal = 2200;
            int goalWeight = 145;
            string fullName = firstName + " " + lastName;
            Users originalUsers = UsersDAL.getUserData(userId);

            // Get Users BB (by userName)
            Users oldUsers = UsersDAL.getUserData(userId);
            Users newUsers = UsersDAL.getUserData(userId);
            newUsers.userId = userId;
            newUsers.firstName = firstName;
            newUsers.lastName = lastName;
            newUsers.email = email;
            newUsers.initialWeight = initialWeight;
            newUsers.heightInches = heightInches;
            newUsers.dailyCalorieGoal = dailyCalorieGoal;
            newUsers.goalWeight = goalWeight;

            // Update BB
            UsersDAL.updateUsers(oldUsers, newUsers);
            Users testUsers = UsersDAL.getUserData(userId);

            // Check Results, expected Update
            Assert.AreEqual(newUsers.userId, testUsers.userId, "TestUser's userId not " + newUsers.userId + ".");
            Assert.AreEqual(newUsers.firstName, testUsers.firstName, "TestUser's firstName not " + newUsers.firstName + ".");
            Assert.AreEqual(newUsers.lastName, testUsers.lastName, "TestUser's lastName not " + newUsers.lastName + ".");
            Assert.AreEqual(newUsers.email, testUsers.email, "TestUser's email not " + newUsers.email + ".");
            Assert.AreEqual(newUsers.initialWeight, testUsers.initialWeight, "TestUser's initialWeight not " + newUsers.initialWeight + ".");
            Assert.AreEqual(newUsers.heightInches, testUsers.heightInches, 0, "TestUser's heightInches not " + newUsers.heightInches + ".");
            Assert.AreEqual(newUsers.dailyCalorieGoal, testUsers.dailyCalorieGoal, 0, "TestUser's dailyCalorieGoal not " + newUsers.dailyCalorieGoal + ".");
            Assert.AreEqual(newUsers.goalWeight, testUsers.goalWeight, 0, "TestUser's goalWeight not " + newUsers.goalWeight + ".");
            Assert.AreEqual(newUsers.getFullName(), testUsers.getFullName(), "TestUser's fullName not " + newUsers.getFullName() + ".");

            // Rest to Original
            UsersDAL.updateUsers(testUsers, originalUsers);
            testUsers = UsersDAL.getUserData(userId);

            // Check Results, expected Origianl
            Assert.AreEqual(originalUsers.userId, testUsers.userId, "OriginalUser's userId not " + originalUsers.userId + ".");
            Assert.AreEqual(originalUsers.firstName, testUsers.firstName, "OriginalUser's firstName not " + originalUsers.firstName + ".");
            Assert.AreEqual(originalUsers.lastName, testUsers.lastName, "OriginalUser's lastName not " + originalUsers.lastName + ".");
            Assert.AreEqual(originalUsers.email, testUsers.email, "OriginalUser's email not " + originalUsers.email + ".");
            Assert.AreEqual(originalUsers.initialWeight, testUsers.initialWeight, "OriginalUser's initialWeight not " + originalUsers.initialWeight + ".");
            Assert.AreEqual(originalUsers.heightInches, testUsers.heightInches, 0, "OriginalUser's heightInches not " + originalUsers.heightInches + ".");
            Assert.AreEqual(originalUsers.dailyCalorieGoal, testUsers.dailyCalorieGoal, 0, "OriginalUser's dailyCalorieGoal not " + originalUsers.dailyCalorieGoal + ".");
            Assert.AreEqual(originalUsers.goalWeight, testUsers.goalWeight, 0, "OriginalUser's goalWeight not " + originalUsers.goalWeight + ".");
            Assert.AreEqual(originalUsers.getFullName(), testUsers.getFullName(), "OriginalUser's fullName not " + originalUsers.getFullName() + ".");
        }
    }
}
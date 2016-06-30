//-----------------------------------------------------------------------
// <copyright file="UsersTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.User class.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTest.Model
{
    using System;
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the UserS Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class UsersTests
    {
        /// <summary>
        /// Test for newly created Users, all gets show return null.
        /// </summary>
        [TestMethod]
        public void TestNullUsers()
        {
            // Set Users (New)
            string fullName;

            // Create User (New)
            Users users = new Users();
            fullName = " ";

            // Check User Data
            Assert.AreEqual(0, users.userId, 0, "User's userID not 0.");
            Assert.IsNull(users.userName, "User's userName not null.");
            Assert.IsNull(users.firstName, "User's firstName not null.");
            Assert.IsNull(users.lastName, "User's lastName not null.");
            Assert.IsNull(users.email, "User's email not null.");
            Assert.IsNull(users.password, "User's password not null.");
            Assert.AreEqual(0, users.initialWeight, 0, "User's initialWeight not 0.");
            Assert.AreEqual(0, users.heightInches, 0, "User's heightInches not 0.");
            Assert.AreEqual(0, users.dailyCalorieGoal, 0, "User's dailyCalorieGoal not 0.");
            Assert.AreEqual(0, users.goalWeight, 0, "User's goalWeight not 0.");
            Assert.AreEqual(fullName, users.getFullName(), "User's userInfo not correct.");
        }

        /// <summary>
        /// Test for set and get of a user, Users class.
        /// </summary>
        [TestMethod]
        public void TestActiveUsers()
        {
            // Set Users
            int userId = 1;
            string userName = "jdoe01";
            string firstName = "John";
            string lastName = "Doe";
            string email = "testing@test.edu";
            string password = "password";
            int initialWeight = 155;
            int heightInches = 69;
            int dailyCalorieGoal = 2222;
            int goalWeight = 145;
            string fullName;

            // Create User (Active)
            Users users = new Users();
            users.userId = userId;
            users.userName = userName;
            users.firstName = firstName;
            users.lastName = lastName;
            users.email = email;
            users.password = password;
            users.initialWeight = initialWeight;
            users.heightInches = heightInches;
            users.dailyCalorieGoal = dailyCalorieGoal;
            users.goalWeight = goalWeight;
            fullName = firstName + " " + lastName;

            // Check User Data
            Assert.AreEqual(userId, users.userId, 0, "User's userId not " + userId + ".");
            Assert.AreEqual(userName, users.userName, "User's userName not " + userName + ".");
            Assert.AreEqual(firstName, users.firstName, "User's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, users.lastName, "User's lastName not " + lastName + ".");
            Assert.AreEqual(email, users.email, "User's email not " + email + ".");
            Assert.AreEqual(password, users.password, "User's password not " + password + ".");
            Assert.AreEqual(initialWeight, users.initialWeight, "User's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, users.heightInches, 0, "User's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, users.dailyCalorieGoal, 0, "User's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, users.goalWeight, 0, "User's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, users.getFullName(), "User's fullName not " + fullName + ".");
        }
    }
}
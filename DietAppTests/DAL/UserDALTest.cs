using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;
using DietApp.DAL;
using System.Collections.Generic;

namespace DietAppTests.DAL
{
    [TestClass]
    public class UserDALTest
    {
        Validation validation = new Validation();
        Encryption encryption = new Encryption();

        /// <summary>
        /// Test for return of user data
        /// </summary>
        [TestMethod]
        public void TestGetUserAA()
        {
            //Set User AA
            int userId = 1;
            String username = "aa";
            String firstName = "Al";
            String lastName = "Adams";
            //String email = "aladams@example.com";
            //String password = encryption.GetSAW1Hash("123");
            int initialWeight = 220;
            int heightInches = 70;
            int dailyCalorieGoal = 2500;
            int goalWeight = 180;
            String fullName = firstName + " " + lastName;


            //Get User AA
            Users aa = UsersDAL.getUserData("aa");

            //Check Results, expect AA
            Assert.AreEqual(userId, aa.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(username, aa.username, "AA's username not " + username + ".");
            Assert.AreEqual(firstName, aa.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, aa.lastName, "AA's lastName not " + lastName + ".");
            //Assert.AreEqual(email, aa.email, "AA's email not " + email + ".");
            //Assert.AreEqual(password, aa.password, "AA's password not " + password + ".");
            Assert.AreEqual(initialWeight, aa.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, aa.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, aa.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, aa.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, aa.getFullName(), "AA's fullName not " + fullName + ".");
        }

        /// <summary>
        /// Test for add newuser, return of user data
        /// intial profile setup
        /// will delete then complete
        /// </summary>
        [TestMethod]
        public void TestAddNewDeleteUser()
        {
            //Set New User
            String username = "dd";
            String firstName = "New";
            String lastName = "User";
            //String email = "sample@email.com";
            String password = encryption.GetSAW1Hash("password");
            int initialWeight = 150;
            int heightInches = 69;
            int dailyCalorieGoal = 1800;
            int goalWeight = 140;
            String fullName = firstName + " " + lastName;

            //Create New User
            Users dd = UsersDAL.addNewUser(username, password);

            //Check Results, expect New User
            Assert.AreEqual(username, dd.username, "AA's username not " + username + ".");
            Assert.AreEqual(firstName, dd.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, dd.lastName, "AA's lastName not " + lastName + ".");
            //Assert.AreEqual(email, dd.email, "AA's email not " + email + ".");
            //Assert.AreEqual(password, dd.password, "AA's password not " + password + ".");
            Assert.AreEqual(initialWeight, dd.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, dd.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, dd.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, dd.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, dd.getFullName(), "AA's fullName not " + fullName + ".");

            //Deletes Test New User
            bool results = UsersDAL.deleteUsers(username);
            Assert.IsTrue(results, "New Test User not Deleted.");
        }
    
        [TestMethod]
        public void TestComparePassword()
        {
            //Set User BB
            String username = "bb";
            String goodPassword = "123";
            String badPassword = "abc";

            //Checks Passwords
            bool goodResults = UsersDAL.ComparePassword(username, goodPassword);
            bool badResults = UsersDAL.ComparePassword(username, badPassword);

            //Returns Results
            Assert.IsTrue(goodResults, "Correct Password fails.");
            Assert.IsFalse(badResults, "Incorrect Password passes.");
        }
    }
}

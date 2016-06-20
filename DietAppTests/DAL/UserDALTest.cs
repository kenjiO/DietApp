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
            String email = "aladams@example.com";
            String password = encryption.GetSHA1Hash("123");
            int initialWeight = 220;
            int heightInches = 70;
            int dailyCalorieGoal = 2500;
            int goalWeight = 180;
            String fullName = firstName + " " + lastName;


            //Get User AA (by userName)
            Users aa = UsersDAL.getUserData(username);

            //Check Results, expect AA
            Assert.AreEqual(userId, aa.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(username, aa.userName, "AA's username not " + username + ".");
            Assert.AreEqual(firstName, aa.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, aa.lastName, "AA's lastName not " + lastName + ".");
            Assert.AreEqual(email, aa.email, "AA's email not " + email + ".");
            //Assert.AreEqual(password, aa.password, "AA's password not " + password + ".");
            Assert.AreEqual(initialWeight, aa.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, aa.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, aa.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, aa.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, aa.getFullName(), "AA's fullName not " + fullName + ".");

            //Get User AA (by userId)
            aa = UsersDAL.getUserData(userId);

            //Check Results, expect AA
            Assert.AreEqual(userId, aa.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(username, aa.userName, "AA's username not " + username + ".");
            Assert.AreEqual(firstName, aa.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, aa.lastName, "AA's lastName not " + lastName + ".");
            Assert.AreEqual(email, aa.email, "AA's email not " + email + ".");
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
            String firstName = "";
            String lastName = "";
            String email = "";
            String password = encryption.GetSHA1Hash("password");
            int initialWeight = 0;
            int heightInches = 0;
            int dailyCalorieGoal = 0;
            int goalWeight = 0;
            String fullName = firstName + " " + lastName;

            //Create New User
            int ddID = UsersDAL.addNewUser(username, password);
            Users dd = UsersDAL.getUserData(ddID);

            //Check Results, expect New User
            Assert.AreEqual(username, dd.userName, "DD's username not " + username + ".");
            Assert.AreEqual(firstName, dd.firstName, "DD's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, dd.lastName, "DD's lastName not " + lastName + ".");
            Assert.AreEqual(email, dd.email, "DD's email not " + email + ".");
            //Assert.AreEqual(password, dd.password, "DD's password not " + password + ".");
            Assert.AreEqual(initialWeight, dd.initialWeight, "DD's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, dd.heightInches, 0, "DD's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, dd.dailyCalorieGoal, 0, "DD's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, dd.goalWeight, 0, "DD's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, dd.getFullName(), "DD's fullName not " + fullName + ".");

            //Deletes Test New User
            //bool results = UsersDAL.deleteUsers(username);
            //Assert.IsTrue(results, "New Test User not Deleted.");
        }
    }
}
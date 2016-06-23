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
            String password = "password";
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
            Assert.AreEqual(initialWeight, dd.initialWeight, "DD's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, dd.heightInches, 0, "DD's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, dd.dailyCalorieGoal, 0, "DD's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, dd.goalWeight, 0, "DD's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, dd.getFullName(), "DD's fullName not " + fullName + ".");

            //Deletes Test New User
            UsersDAL.deleteUsers(ddID);
            dd = UsersDAL.getUserData(ddID);
            Assert.AreEqual(0, dd.userId, "New Test User not Deleted.");
        }

        /// <summary>
        /// Test for update of user data
        /// </summary>
        [TestMethod]
        public void TestUpdateUserBB()
        {
            //Set User BB
            int userId = 2;
            String firstName = "Emitt";
            String lastName = "Ethan";
            String email = "eethan@example.com";
            int initialWeight = 175;
            int heightInches = 72;
            int dailyCalorieGoal = 2200;
            int goalWeight = 145;
            String fullName = firstName + " " + lastName;
            Users originalUser = UsersDAL.getUserData(userId);

            //Get User AA (by userName)
            Users oldUser = UsersDAL.getUserData(userId);
            Users newUser = UsersDAL.getUserData(userId);
            newUser.userId = userId;
            newUser.firstName = firstName;
            newUser.lastName = lastName;
            newUser.email = email;
            newUser.initialWeight = initialWeight;
            newUser.heightInches = heightInches;
            newUser.dailyCalorieGoal = dailyCalorieGoal;
            newUser.goalWeight = goalWeight;

            //Update BB
            UsersDAL.updateUsers(oldUser, newUser);
            Users testUser = UsersDAL.getUserData(userId);

            //Check Results, expected Update
            Assert.AreEqual(newUser.userId, testUser.userId, "testUser's userId not " + newUser.userId + ".");
            Assert.AreEqual(newUser.firstName, testUser.firstName, "testUser's firstName not " + newUser.firstName + ".");
            Assert.AreEqual(newUser.lastName, testUser.lastName, "testUser's lastName not " + newUser.lastName + ".");
            Assert.AreEqual(newUser.email, testUser.email, "testUser's email not " + newUser.email + ".");
            Assert.AreEqual(newUser.initialWeight, testUser.initialWeight, "testUser's initialWeight not " + newUser.initialWeight + ".");
            Assert.AreEqual(newUser.heightInches, testUser.heightInches, 0, "testUser's heightInches not " + newUser.heightInches + ".");
            Assert.AreEqual(newUser.dailyCalorieGoal, testUser.dailyCalorieGoal, 0, "testUser's dailyCalorieGoal not " + newUser.dailyCalorieGoal + ".");
            Assert.AreEqual(newUser.goalWeight, testUser.goalWeight, 0, "testUser's goalWeight not " + newUser.goalWeight + ".");
            Assert.AreEqual(newUser.getFullName(), testUser.getFullName(), "testUser's fullName not " + newUser.getFullName() + ".");

            //Rest to Original
            UsersDAL.updateUsers(testUser, originalUser);
            testUser = UsersDAL.getUserData(userId);

            //Check Results, expected Origianl
            Assert.AreEqual(originalUser.userId, testUser.userId, "testUser's userId not " + originalUser.userId + ".");
            Assert.AreEqual(originalUser.firstName, testUser.firstName, "testUser's firstName not " + originalUser.firstName + ".");
            Assert.AreEqual(originalUser.lastName, testUser.lastName, "testUser's lastName not " + originalUser.lastName + ".");
            Assert.AreEqual(originalUser.email, testUser.email, "testUser's email not " + originalUser.email + ".");
            Assert.AreEqual(originalUser.initialWeight, testUser.initialWeight, "testUser's initialWeight not " + originalUser.initialWeight + ".");
            Assert.AreEqual(originalUser.heightInches, testUser.heightInches, 0, "testUser's heightInches not " + originalUser.heightInches + ".");
            Assert.AreEqual(originalUser.dailyCalorieGoal, testUser.dailyCalorieGoal, 0, "testUser's dailyCalorieGoal not " + originalUser.dailyCalorieGoal + ".");
            Assert.AreEqual(originalUser.goalWeight, testUser.goalWeight, 0, "testUser's goalWeight not " + originalUser.goalWeight + ".");
            Assert.AreEqual(originalUser.getFullName(), testUser.getFullName(), "testUser's fullName not " + originalUser.getFullName() + ".");
        }
    }
}
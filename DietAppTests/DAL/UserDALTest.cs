using DietApp.DAL;
using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DietAppTests.DAL
{
    /// <summary>
    /// Test the UserDAL Class in DietApp.DAL
    /// </summary>
    [TestClass]
    public class UserDALTest
    {
        private Encryption encryption = new Encryption();

        /// <summary>
        /// Test for return of user data
        /// </summary>
        [TestMethod]
        public void TestgetUserData()
        {
            //Set Users AA
            int userId = 1;
            String userName = "aa";
            String firstName = "Al";
            String lastName = "Adams";
            String email = "aladams@example.com";
            int initialWeight = 220;
            int heightInches = 70;
            int dailyCalorieGoal = 2500;
            int goalWeight = 180;
            String fullName = firstName + " " + lastName;

            //Get User AA (by userName)
            Users aaName = UsersDAL.getUserData(userName);

            //Check Results, expect AA
            Assert.AreEqual(userId, aaName.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(userName, aaName.userName, "AA's userName not " + userName + ".");
            Assert.AreEqual(firstName, aaName.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, aaName.lastName, "AA's lastName not " + lastName + ".");
            Assert.AreEqual(email, aaName.email, "AA's email not " + email + ".");
            Assert.AreEqual(initialWeight, aaName.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, aaName.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, aaName.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, aaName.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, aaName.getFullName(), "AA's fullName not " + fullName + ".");

            //Get User AA (by userId)
            Users aaId = UsersDAL.getUserData(userId);

            //Check Results, expect AA
            Assert.AreEqual(userId, aaId.userId, "AA's userId not " + userId + ".");
            Assert.AreEqual(userName, aaId.userName, "AA's userName not " + userName + ".");
            Assert.AreEqual(firstName, aaId.firstName, "AA's firstName not " + firstName + ".");
            Assert.AreEqual(lastName, aaId.lastName, "AA's lastName not " + lastName + ".");
            Assert.AreEqual(email, aaId.email, "AA's email not " + email + ".");
            Assert.AreEqual(initialWeight, aaId.initialWeight, "AA's initialWeight not " + initialWeight + ".");
            Assert.AreEqual(heightInches, aaId.heightInches, 0, "AA's heightInches not " + heightInches + ".");
            Assert.AreEqual(dailyCalorieGoal, aaId.dailyCalorieGoal, 0, "AA's dailyCalorieGoal not " + dailyCalorieGoal + ".");
            Assert.AreEqual(goalWeight, aaId.goalWeight, 0, "AA's goalWeight not " + goalWeight + ".");
            Assert.AreEqual(fullName, aaId.getFullName(), "AA's fullName not " + fullName + ".");
        }

        /// <summary>
        /// Test for add newuser, return of user data
        /// intial profile setup
        /// will delete then completed
        /// </summary>
        [TestMethod]
        public void TestaddNewUser()
        {
            //Set New Users
            String userName = "dd";
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
            int ddID = UsersDAL.addNewUser(userName, password);
            Users dd = UsersDAL.getUserData(ddID);

            //Check Results, expect New UserS
            Assert.AreEqual(userName, dd.userName, "DD's username not " + userName + ".");
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
            Assert.AreEqual(0, dd.userId, "New Test Users not Deleted.");
        }

        /// <summary>
        /// Test for update of user data
        /// will reverse when complete
        /// </summary>
        [TestMethod]
        public void TestupdateUsers()
        {
            //Set Users BB
            int userId = 2;
            String firstName = "Emitt";
            String lastName = "Ethan";
            String email = "eethan@example.com";
            int initialWeight = 175;
            int heightInches = 72;
            int dailyCalorieGoal = 2200;
            int goalWeight = 145;
            String fullName = firstName + " " + lastName;
            Users originalUsers = UsersDAL.getUserData(userId);

            //Get Users BB (by userName)
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

            //Update BB
            UsersDAL.updateUsers(oldUsers, newUsers);
            Users testUsers = UsersDAL.getUserData(userId);

            //Check Results, expected Update
            Assert.AreEqual(newUsers.userId, testUsers.userId, "TestUser's userId not " + newUsers.userId + ".");
            Assert.AreEqual(newUsers.firstName, testUsers.firstName, "TestUser's firstName not " + newUsers.firstName + ".");
            Assert.AreEqual(newUsers.lastName, testUsers.lastName, "TestUser's lastName not " + newUsers.lastName + ".");
            Assert.AreEqual(newUsers.email, testUsers.email, "TestUser's email not " + newUsers.email + ".");
            Assert.AreEqual(newUsers.initialWeight, testUsers.initialWeight, "TestUser's initialWeight not " + newUsers.initialWeight + ".");
            Assert.AreEqual(newUsers.heightInches, testUsers.heightInches, 0, "TestUser's heightInches not " + newUsers.heightInches + ".");
            Assert.AreEqual(newUsers.dailyCalorieGoal, testUsers.dailyCalorieGoal, 0, "TestUser's dailyCalorieGoal not " + newUsers.dailyCalorieGoal + ".");
            Assert.AreEqual(newUsers.goalWeight, testUsers.goalWeight, 0, "TestUser's goalWeight not " + newUsers.goalWeight + ".");
            Assert.AreEqual(newUsers.getFullName(), testUsers.getFullName(), "TestUser's fullName not " + newUsers.getFullName() + ".");

            //Rest to Original
            UsersDAL.updateUsers(testUsers, originalUsers);
            testUsers = UsersDAL.getUserData(userId);

            //Check Results, expected Origianl
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
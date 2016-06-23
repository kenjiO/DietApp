using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;

namespace DietAppTest.ModelTest
{
    [TestClass]
    public class UserTest
    {
        private Users users = new Users();
        private int userId = 1;
        private string username = "jdoe01";
        private string firstName = "John";
        private string lastName = "Doe";
        private string email = "testing@test.edu";
        private string password = "password";
        private int initialWeight = 155;
        private int heightInches = 69;
        private int dailyCalorieGoal = 2222;
        private int goalWeight = 145;
        private String fullName;

        /// <summary>
        /// Test for newly created User, all gets show return null
        /// </summary>
        [TestMethod]
        public void TestNullUser()
        {
            //Create User (New)
            this.fullName = " ";

            //Return User Data
            Assert.AreEqual(0, this.users.userId, 0, "User's UserID not 0.");
            Assert.IsNull(this.users.userName, "User's username not null.");
            Assert.IsNull(this.users.firstName, "User's firstName not null.");
            Assert.IsNull(this.users.lastName, "User's lastName not null.");
            Assert.IsNull(this.users.email, "User's email not null.");
            Assert.IsNull(this.users.password, "User's password not null.");
            Assert.AreEqual(0, this.users.initialWeight, 0, "User's initialWeight not 0.");
            Assert.AreEqual(0, this.users.heightInches, 0, "User's heightInches not 0.");
            Assert.AreEqual(0, this.users.dailyCalorieGoal, 0, "User's dailyCalorieGoal not 0.");
            Assert.AreEqual(0, this.users.goalWeight, 0, "User's goalWeight not 0.");
            Assert.AreEqual(this.fullName, this.users.getFullName(), "User's userInfo not correct.");
        }

        /// <summary>
        /// Test for set and get of a user, User class
        /// </summary>
        [TestMethod]
        public void TestActiveUser()
        {
            //Create User (Active)
            this.users.userId = this.userId;
            this.users.userName = this.username;
            this.users.firstName = this.firstName;
            this.users.lastName = this.lastName;
            this.users.email = this.email;
            this.users.password = this.password;
            this.users.initialWeight = this.initialWeight;
            this.users.heightInches = this.heightInches;
            this.users.dailyCalorieGoal = this.dailyCalorieGoal;
            this.users.goalWeight = this.goalWeight;
            this.fullName = this.firstName + " " + this.lastName;

            //Return User Data
            Assert.AreEqual(this.userId, this.users.userId, 0, "User's UserId not " + this.userId + ".");
            Assert.AreEqual(this.username, this.users.userName, "User's username not " + this.username + ".");
            Assert.AreEqual(this.firstName, this.users.firstName, "User's firstName not " + this.firstName + ".");
            Assert.AreEqual(this.lastName, this.users.lastName, "User's lastName not " + this.lastName + ".");
            Assert.AreEqual(this.email, this.users.email, "User's email not " + this.email + ".");
            Assert.AreEqual(this.password, this.users.password, "User's password not " + this.password + ".");
            Assert.AreEqual(this.initialWeight, this.users.initialWeight, "User's initialWeight not " + this.initialWeight + ".");
            Assert.AreEqual(this.heightInches, this.users.heightInches, 0, "User's heightInches not " + this.heightInches + ".");
            Assert.AreEqual(this.dailyCalorieGoal, this.users.dailyCalorieGoal, 0, "User's dailyCalorieGoal not " + this.dailyCalorieGoal + ".");
            Assert.AreEqual(this.goalWeight, this.users.goalWeight, 0, "User's goalWeight not " + this.goalWeight + ".");
            Assert.AreEqual(this.fullName, this.users.getFullName(), "User's fullName not " + this.fullName + ".");
        }
    }
}
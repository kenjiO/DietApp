using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.Model;

namespace DietAppTest.ModelTest
{
    [TestClass]
    public class UserTest
    {
        private User user = new User();
        private int userID = 1;
        private string username = "jdoe01";
        private string firstName = "John";
        private string lastName = "Doe";
        private string password = "password";
        private double initialWeight = 155.5;
        private int heightFeet = 5;
        private int heightInches = 9;
        private double dailyCalorieGoal = 2222.2;
        private double goalWeight = 145.2;
        private string email = "testing@test.edu";
        private String userInfo;

        /// <summary>
        /// Test for newly created User, all gets show return null
        /// </summary>
        [TestMethod]
        public void TestNullUser()
        {
            //Create User (New)
            this.userInfo = " ";

            //Return User Data
            Assert.AreEqual(0, this.user.userID, 0, "User's UserID not 0.");
            Assert.IsNull(this.user.username, "User's username not null.");
            Assert.IsNull(this.user.firstName, "User's firstName not null.");
            Assert.IsNull(this.user.lastName, "User's lastName not null.");
            Assert.IsNull(this.user.password, "User's password not null.");
            Assert.AreEqual(0, this.user.initialWeight, 0, "User's initialWeight not 0.");
            Assert.AreEqual(0, this.user.heightFeet, 0, "User's heightFeet not 0.");
            Assert.AreEqual(0, this.user.heightInches, 0, "User's heightInches not 0.");
            Assert.AreEqual(0, this.user.dailyCalorieGoal, 0, "User's dailyCalorieGoal not 0.");
            Assert.AreEqual(0, this.user.goalWeight, 0, "User's goalWeight not 0.");
            Assert.IsNull(this.user.email, "User's email not null.");
            Assert.AreEqual(this.userInfo, this.user.UserInfo, "User's userInfo not correct.");
        }

        /// <summary>
        /// Test for set and get of a user, User class
        /// </summary>
        [TestMethod]
        public void TestActiveUser()
        {
            //Create User (Active)
            this.user.userID = this.userID;
            this.user.username = this.username;
            this.user.firstName = this.firstName;
            this.user.lastName = this.lastName;
            this.user.password = this.password;
            this.user.initialWeight = this.initialWeight;
            this.user.heightFeet = this.heightFeet;
            this.user.heightInches = this.heightInches;
            this.user.dailyCalorieGoal = this.dailyCalorieGoal;
            this.user.goalWeight = this.goalWeight;
            this.user.email = this.email;
            this.userInfo = this.firstName + " " + this.lastName;

            //Return User Data
            Assert.AreEqual(this.userID, this.user.userID, 0, "User's UserID not " + this.email + ".");
            Assert.AreEqual(this.username, this.user.username, "User's username not " + this.username + ".");
            Assert.AreEqual(this.firstName, this.user.firstName, "User's firstName not " + this.firstName + ".");
            Assert.AreEqual(this.lastName, this.user.lastName, "User's lastName not " + this.lastName + ".");
            Assert.AreEqual(this.password, this.user.password, "User's password not " + this.password + ".");
            Assert.AreEqual(this.initialWeight, this.user.initialWeight, "User's initialWeight not " + this.initialWeight + ".");
            Assert.AreEqual(this.heightFeet, this.user.heightFeet, 0, "User's heightFeet not " + this.heightFeet + ".");
            Assert.AreEqual(this.heightInches, this.user.heightInches, 0, "User's heightInches not " + this.heightInches + ".");
            Assert.AreEqual(this.dailyCalorieGoal, this.user.dailyCalorieGoal, 0, "User's dailyCalorieGoal not " + this.dailyCalorieGoal + ".");
            Assert.AreEqual(this.goalWeight, this.user.goalWeight, 0, "User's goalWeight not " + this.goalWeight + ".");
            Assert.AreEqual(this.email, this.user.email, "User's email not " + this.email + ".");
            Assert.AreEqual(this.userInfo, this.user.UserInfo, "User's userInfo not correct.");
        }
    }
}

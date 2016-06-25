using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DietApp.Controller.Tests
{
    [TestClass()]
    public class DietAppControllerTests
    {
        [TestMethod()]
        public void comparePasswordTest()
        {
            //Set User BB
            String username = "bb";
            String goodPassword = "abc";
            String badPassword = "123";

            //Checks Passwords
            bool goodResults = DietAppController.comparePassword(username, goodPassword);
            bool badResults = DietAppController.comparePassword(username, badPassword);

            //Returns Results
            Assert.IsTrue(goodResults, "Correct Password fails.");
            Assert.IsFalse(badResults, "Incorrect Password passes.");
        }

        [TestMethod()]
        public void getUserDataTest()
        {
            //Set User AA
            int userId = 1;
            String username = "aa";
            String firstName = "Al";

            //Get User AA (by userId)
            Assert.AreEqual(firstName, DietAppController.getUserData(userId).firstName, "AA's firstName not " + firstName + ".");

            //Get User AA (by userName)
            Assert.AreEqual(firstName, DietAppController.getUserData(username).firstName, "AA's firstName not " + firstName + ".");
        }

        [TestMethod()]
        public void addUserData()
        {
            //Set New User
            String username = "ee";
            String password = "password";
            int ddId = 0;

            //Create New User
            ddId = DietAppController.addNewUser(username, password);
            Assert.AreNotEqual(0, ddId, "New User not added.");

            //Deletes Test New User
            //bool results = DietAppController.deleteUsers(username);
            //Assert.IsTrue(results, "New Test User not Deleted.");
        }

        [TestMethod()]
        public static void updateUsers()
        {

        }

        [TestMethod()]
        public static void dateWellnessData()
        {
            //Sets the values.
            int weight = 210;
            int heartRate = 65;
            int systolicBP = 100;
            int diastolicBP = 80;
            int userID = 1;
            var date = Convert.ToDateTime("06/23/2016");

            //Builds a Wellness object.
            var testWellness = DietAppController.dateWellnessData(userID, date.ToString());

            //Checks Results
            Assert.AreEqual(weight, testWellness.weight, "Wellness object's weight not " + weight + ".");
            Assert.AreEqual(heartRate, testWellness.heartRate, "Wellness object's weight not " + heartRate + ".");
            Assert.AreEqual(systolicBP, testWellness.systolicBP, "Wellness object's systolic BP not " + systolicBP + ".");
            Assert.AreEqual(diastolicBP, testWellness.diastolicBP, "Wellness object's diastolic BP not " + diastolicBP + ".");
            Assert.AreEqual(userID, testWellness.userID, "Wellness object's userId not " + userID + ".");
            Assert.AreEqual(date, testWellness.date, "Wellness object's date not " + date + ".");
        }

        [TestMethod()]
        public static void addDailyWellnessData()
        {
            int weight = 213;
            int heartRate = 95;
            int systolicBP = 110;
            int diastolicBP = 80;
            int userID = 1;
            var date = Convert.ToDateTime("06/22/2016");
            var compare = new Wellness
            {
                diastolicBP = diastolicBP,
                systolicBP = systolicBP,
                weight = weight,
                heartRate = heartRate,
                date = date,
                userID = userID
            };

            //Builds a Wellness object.
            DietAppController.addDailyWellnessData(compare);
            var testWellness = DietAppController.dateWellnessData(userID, date.ToString());

            //Checks Results
            Assert.AreEqual(weight, testWellness.weight, "Wellness object's weight not " + weight + ".");
            Assert.AreEqual(heartRate, testWellness.heartRate, "Wellness object's weight not " + heartRate + ".");
            Assert.AreEqual(systolicBP, testWellness.systolicBP, "Wellness object's systolic BP not " + systolicBP + ".");
            Assert.AreEqual(diastolicBP, testWellness.diastolicBP, "Wellness object's diastolic BP not " + diastolicBP + ".");
            Assert.AreEqual(userID, testWellness.userID, "Wellness object's userId not " + userID + ".");
            Assert.AreEqual(date, testWellness.date, "Wellness object's date not " + date + ".");
        }


        [TestMethod()]
        public static void updateDailyWellnessData()
        {
            //TO DO:  UNDER DEVELOPMENT FOR ITERATION 2.
        }

    }
}
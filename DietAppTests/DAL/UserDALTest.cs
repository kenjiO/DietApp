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
        /// <summary>
        /// Test for return of user data
        /// </summary>
        [TestMethod]
        public void TestGetUserAA()
        {
            //Set User AA
            String username = "aa";

            //Get User AA
            Users aa = UsersDAL.getUserData("aa");

            //Check Results, expect AA
            Assert.AreEqual(username, aa.username, "User's username not " + username + ".");

        }
    }
}

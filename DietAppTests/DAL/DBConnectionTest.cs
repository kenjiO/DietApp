using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DietApp.DAL;
using System.Data.SqlClient;
using System.Data;

namespace DietAppTests.DAL
{
    [TestClass]
    public class DBConnectionTest
    {
        /// <summary>
        /// Test for open DBConnection
        /// </summary>
        [TestMethod]
        public void TestActiveDBConnetion()
        {
            //Get Connection
            SqlConnection connection = DBConnection.GetConnection();

            //Test for Closed DB
            Assert.AreEqual(ConnectionState.Closed, connection.State, "Database connection is not closed.");

            //Open DB
            connection.Open();

            //Test for Open DB
            Assert.AreEqual(ConnectionState.Open, connection.State, "Database connection is not opened.");

            //Close DB
            connection.Close();

            //Test for Closed DB
            Assert.AreEqual(ConnectionState.Closed, connection.State, "Database connection is not closed.");
        }
    }
}

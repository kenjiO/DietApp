﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DietApp.DAL
{
    /// <summary>
    /// Connect to DietApp Database
    /// </summary>
    public static class DBConnection
    {
        /// <summary>
        /// Tries connecting to the Database
        /// </summary>
        public static SqlConnection GetConnection()
        {
            try
            {
                String connectionString =
                    "Data Source=localhost;Initial Catalog=DietApp;" +
                    "Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DietApp.Model;

namespace DietApp.Database
{
    class UserDb
    {

        public static User GetUser(string username)
        {
           string selectStatement =
                "SELECT firstName, lastName, email " +
                "FROM users " +
                "WHERE username = @username";

           using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User();

                            if (!DBNull.Value.Equals(reader["firstName"]))
                                user.FirstName = reader["firstName"].ToString();
                            if (!DBNull.Value.Equals(reader["lastName"]))
                                user.LastName = reader["lastName"].ToString();
                            if (!DBNull.Value.Equals(reader["email"]))
                                user.LastName = reader["email"].ToString();
                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}

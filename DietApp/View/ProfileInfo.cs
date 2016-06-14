using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DietApp
{
    public partial class ProfileInfo : Form
    {
        public ProfileInfo()
        {
            InitializeComponent();
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("user1");
            } catch (SqlException ex)
            {
                MessageBox.Show("Database error loading profile.\n" + ex.Message);
            }
        }

        private SqlConnection GetDBConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=DietApp;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        private void LoadData(string username)
        {
            string selectStatement =
                "SELECT firstName, lastName, email " +
                "FROM users " +
                "WHERE username = @username";

            using (SqlConnection connection = GetDBConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = "[NOT SET]";
                            if (!DBNull.Value.Equals(reader["firstName"]))
                                firstName = reader["firstName"].ToString();
                            string lastName = "[NOT SET]";
                            if (!DBNull.Value.Equals(reader["lastName"]))
                                lastName = reader["lastName"].ToString();
                            string email = "[NOT SET]";
                            if (!DBNull.Value.Equals(reader["email"]))
                               email = reader["email"].ToString();


                            firstNameBox.Text = firstName;
                            lastNameBox.Text = lastName;
                            emailBox.Text = email;

                        }
                        else
                        {
                            MessageBox.Show("username not found");
                        }
                    }
                }
            }
        }

    }
}


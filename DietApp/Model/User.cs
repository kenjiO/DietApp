using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model
{
    /// <summary>
    /// User class, relates to Users table in HealthTrends
    /// </summary>
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;

        public User()
        {
        }
        
        //*********** Getters and Setters **********//
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public double initialWeight { get; set; }
        public double heightFeet { get; set; }
        public double heightInches { get; set; }
        public double dailyCalorieGoal { get; set; }
        public double goalWeight { get; set; }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
    }
}

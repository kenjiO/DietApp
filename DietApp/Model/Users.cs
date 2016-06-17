namespace DietApp.Model
{
    public class Users
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int initialWeight { get; set; }
        public int heightInches { get; set; }
        public int dailyCalorieGoal { get; set; }
        public int goalWeight { get; set; }

        /// <summary>
        /// Concatenates the user's first and last name.
        /// </summary>
        /// <returns>A string representation of the user's full name.</returns>
        public string getFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
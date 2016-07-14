namespace DietApp.Model
{
    public class Progress
    {
        public int oldBMI { get; set; }
        public int newBMI { get; set; }
        public int oldWeight { get; set; }
        public int newWeight { get; set; }
        public int userID { get; set; }

        /// <summary>
        /// Overrides the toString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Old BMI: " + this.oldBMI + " New BMI: " + this.newBMI + "\n" +
            "Old Weight: " + this.oldWeight + " New Weight: " + this.newWeight + "\n" +
            "UserId: " + this.userID;
        }
    }
}
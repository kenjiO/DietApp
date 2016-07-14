using System;

namespace DietApp.Model
{
    [Serializable]
    public class Wellness
    {
        public int dailyMeasurementID { get; set; }
        public int weight { get; set; }
        public int heartRate { get; set; }
        public int systolicBP { get; set; }
        public int diastolicBP { get; set; }
        public int userID { get; set; }
        public DateTime date { get; set; }

        /// <summary>
        /// Overrides ToString function.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " - " +
                this.userID + " - " +
                this.dailyMeasurementID + " - " +
                this.date.ToString() + " - " +
                this.weight + " lb. - " +
                this.heartRate + " bpm. - " +
                this.systolicBP + "/" + this.diastolicBP;
        }
    }
}
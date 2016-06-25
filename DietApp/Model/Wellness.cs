using System;

namespace DietApp.Model
{
    public class Wellness
    {
        public int dailyMeasurementID { get; set; }
        public int weight { get; set; }
        public int heartRate { get; set; }
        public int systolicBP { get; set; }
        public int diastolicBP { get; set; }
        public int userID { get; set; }
        public DateTime date { get; set; }
    }
}
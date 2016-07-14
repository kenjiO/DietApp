//-----------------------------------------------------------------------
// <copyright file="ProgressTests.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the testing for the Model.Progress class.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietAppTest.Model
{
    using DietApp.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the Progress Class in DietApp.Model.
    /// </summary>
    [TestClass]
    public class ProgressTests
    {
        /// <summary>
        /// Test for newly created progress, all gets show return 0.
        /// </summary>
        [TestMethod]
        public void TestNullProgress()
        {
            // Create Progress (New)
            Progress progress = new Progress();
            string progressString = "Old BMI: 0 New BMI: 0\n" +
            "Old Weight: 0 New Weight: 0\n" +
            "UserId: 0";

            // Check Progress Data
            Assert.AreEqual(0, progress.oldBMI, 0, "Progress's oldBMI not 0.");
            Assert.AreEqual(0, progress.newBMI, 0, "Progress's newBMI not 0.");
            Assert.AreEqual(0, progress.userID, 0, "Progress's userID not 0.");
            Assert.AreEqual(progressString, progress.ToString(), "Progress's progressString not " + progressString + ".");
        }

        /// <summary>
        /// Test for set and get of a progress, Progress class.
        /// </summary>
        [TestMethod]
        public void TestActiveProgress()
        {
            // Set Progress
            int oldBMI = 28;
            int newBMI = 25;
            int oldWeight = 165;
            int newWeight = 147;
            int userID = 3;
            string progressString = "Old BMI: " + oldBMI + " New BMI: " + newBMI + "\n" +
            "Old Weight: " + oldWeight + " New Weight: " + newWeight + "\n" +
            "UserId: " + userID;

            // Create Progress (Active)
            Progress progress = new Progress();
            progress.oldBMI = oldBMI;
            progress.newBMI = newBMI;
            progress.oldWeight = oldWeight;
            progress.newWeight = newWeight;
            progress.userID = userID;

            // Check Progress Data
            Assert.AreEqual(oldBMI, progress.oldBMI, 0, "Progress's oldBMI not " + oldBMI + ".");
            Assert.AreEqual(newBMI, progress.newBMI, 0, "Progress's newBMI not " + newBMI + ".");
            Assert.AreEqual(userID, progress.userID, 0, "Progress's userID not " + userID + ".");
            Assert.AreEqual(progressString, progress.ToString(), "Progress's progressString not " + progressString + ".");
        }
    }
}
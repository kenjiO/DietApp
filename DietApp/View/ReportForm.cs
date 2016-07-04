//-----------------------------------------------------------------------
// <copyright file="ReportForm.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the form view for user reports.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// Form for display of User Reports.
    /// </summary>
    public partial class ReportForm : Form
    {
        private Users theUser;

        /// <summary>
        /// Form for display of User Reports.
        /// </summary>
        public ReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the reports information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportForm_Load(object sender, EventArgs e)
        {
            rbWeight.Checked = true;
        }
        
        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUser">The active user class.</param>
        public void loadUser(Users newUser)
        {
            //Updates Any Changes
            this.theUser = DietAppController.getUserData(newUser.userId);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            foreach (var series in chartUserData.Series)
            {
                series.Points.Clear();
            }

            int type = 1;
            int userId = this.theUser.userId;

            if (rbWeight.Checked == true)
            {
                chartUserData.Titles["Title1"].Text = this.theUser.firstName + "'s Weight";
                type = 1;
            }
            else if (rbHeartRate.Checked == true)
            {
                chartUserData.Titles["Title1"].Text = this.theUser.firstName + "'s Heart Rate";
                type = 2;
            }
            else if (rbSystolicBP.Checked == true)
            {
                chartUserData.Titles["Title1"].Text = this.theUser.firstName + "'s Systolic BP";
                type = 3;
            }
            else if (rbDiastolicBP.Checked == true)
            {
                chartUserData.Titles["Title1"].Text = this.theUser.firstName + "'s Diastolic BP";
                type = 4;
            }
            else
            {
                chartUserData.Titles["Title1"].Text = this.theUser.firstName + "'s Weight";
                type = 1;
            }

            List<DailyMeasurements> chartList = DietAppController.getUserChartData(userId, type);
            foreach(DailyMeasurements measurements in chartList)
            {
                chartUserData.Series["UserData"].Points.AddXY(measurements.Date.ToShortDateString(), measurements.Measurement);
            }
        }
    }
}
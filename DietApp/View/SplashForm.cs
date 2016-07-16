

using System;
using System.Timers;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class SplashForm : Form
    {

        private int timeLeft;
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the splash form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timeLeft = 100;
            timer1.Start();
            progressBar1.Step = 1;
        }

        /// <summary>
        /// Moves the progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft > 0)
            {
                this.timeLeft--;
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}

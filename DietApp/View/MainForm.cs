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

namespace DietApp
{
    public partial class MainForm : Form
    {
        private AppController _controller;

        public MainForm()
        {
            InitializeComponent();
            //TODO get a real controller
            this._controller = new AppController();
        }

        private void myHealthTrendsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfileInfo profileForm = new ProfileInfo(this._controller);
            profileForm.ShowDialog();
        }
    }
}

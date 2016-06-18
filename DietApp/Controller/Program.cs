﻿using System;
using System.Windows.Forms;
using DietApp.Controller;

namespace DietApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());

            //AppController controller = new AppController();
            //Application.Run(new ProfileInfo(controller));
        }
    }
}
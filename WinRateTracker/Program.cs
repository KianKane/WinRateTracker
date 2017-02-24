﻿using System;
using System.Windows.Forms;
using WinRateTracker.Model;
using WinRateTracker.View;

namespace WinRateTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IModel model = new Model.Model();
            Application.Run(new Home(model));
        }
    }
}

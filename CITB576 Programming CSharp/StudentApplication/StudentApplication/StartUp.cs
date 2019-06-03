﻿namespace StudentApplication
{
    using StudentApplication.Data;

    using System;
    using System.Windows.Forms;

    public static class StartUp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (SchoolDbContext context = new SchoolDbContext())
            {
                DbInitializer.Initialize(context);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

﻿using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketSystem.Windows;
namespace MarketSystem
{
    static class Program
    {
        public static Employee EmpLogedin;
        public static Form1 frm; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLgn());
        }
    }
}

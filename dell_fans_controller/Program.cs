﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dell_fans_controller
{
    static class Program
    {
        static Timer timer = new Timer();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool onlyInstance;

            Mutex mtx = new Mutex(true, "WindowsFormsApp6", out onlyInstance);

            // Если другие процессы не владеют мьютексом, то
            // приложение запущено в единственном экземпляре
            if (onlyInstance)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show(
                   "Приложение уже запущено",
                   "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           // Application.Run(new Form1());
        }
    }
}

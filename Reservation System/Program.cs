using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System
{
    static class Program
    {
        public static bool session;
        public static string username;
        [STAThread]
        static void Main(String[]args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            session = true;
           
             while (true)
             {
                 session = true;
                 MainForm loginForm = new MainForm();
                 Application.Run(loginForm);
                 if (session)
                {
                    Clock clock = new Clock();
                    Application.Run(clock);
               } 
                    
             } 
        }
    }
}

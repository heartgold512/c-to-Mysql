using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restarunttest2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Loginform loginform = new Loginform();
            Form1 form = new Form1();
            Application.Run(form);
            Application.Run(loginform);
           
          ;
        }
    }
}

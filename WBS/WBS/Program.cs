using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            // automatisch opstarten .cs, files -> remove/update - Laurens
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hoofdmenu());
            Application.Run(new CarForm());
            Application.Run( new PersonForm()); 
        }
    }
}

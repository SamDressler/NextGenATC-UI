//Sam Dressler
//CSCI 363 Final Project
//This is a GUI designed to be the NextGen air traffic controller
//The program was implemented with the features that would be expected in
//a layout that the users would see as friendly
//In addition, there are test cases integrated into the application
//that would not be part of the final project but are integrated to make
//demonstrating the system easier.
//NOTE:When running each of the test cases, for some reason when you stop moving your mouse in the application
//window, the controls that are moving as the aircraft stop updating and the user can't see them. 
//To avoid this from happening, be sure to move the mouse while the simulations are running so it will wrk properly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGenATC_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
         public static ApplicationWindow mainWindow;
        //Stupid windows requires this....
        [STAThread]
        //
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new ApplicationWindow();
            Application.Run(mainWindow);
        }
    }
}

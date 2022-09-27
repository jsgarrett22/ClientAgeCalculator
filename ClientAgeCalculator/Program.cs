using System;
using System.Windows.Forms;

/** Client Age Calculator
 * Calculates a client's age given an appropriate date of birth.
 * Written by Joshua S. Garrett
 * 09/27/2022
 */
namespace ClientAgeCalculator
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
            Application.Run(new Form1());
        }
    }
}

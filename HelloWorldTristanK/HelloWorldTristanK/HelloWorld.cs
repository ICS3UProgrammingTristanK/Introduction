/* Created by: Tristan kalabric
 * Created on: September 7, 2018
 * Created for: ICS3U Programming
 * Daily Assignment #3 - Hello,World!
 * This program displays Hello, World!, my name and the day it was created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldTristanK
{
    static class HelloWorld
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHelloWorld());
        }
    }
}

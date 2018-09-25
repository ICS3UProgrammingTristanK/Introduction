/*
 * Created by: Tristan Kalabric
 * Created on: September 11, 2018
 * Created for: ICS3U Programming
 * Daily Assignment - Day #4 - Hello World with Menu
 * This program displays Hello World but with a menu to exit
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMenuTristanK
{
    public partial class frmHelloMenu : Form
    {
        public frmHelloMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // When exit is clicked, exit the program
            this.Close();
        }
    }
}

/*
 * Created by: Tristan Kalabric
 * Created on: September 12, 2018
 * Created for: ICS3U Programming
 * Daily Assignment: - Day #5 - Hello World International
 * This program displays Hello, World! in different languages when you click on the language buttons
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

namespace HelloWorldIntTristanK
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            // When clicked, label displays Bonjour, Monde!
            this.lblHelloWorld.Text = "Bonjour, Monde!";
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // When clicked, label displays Hello, World!
            this.lblHelloWorld.Text = "Hello, World!";
        }

        private void radItalian_CheckedChanged(object sender, EventArgs e)
        {
            // When clicked, label displays Ciao mondo!
            this.lblHelloWorld.Text = "Ciao mondo!";
        }

        private void radCroatian_CheckedChanged(object sender, EventArgs e)
        {
            // When clicked, label displays Pozdrav svijete!
            this.lblHelloWorld.Text = "Pozdrav svijete!";
        }

        private void frmHelloWorldInt_Load(object sender, EventArgs e)
        {

        }
    }
}

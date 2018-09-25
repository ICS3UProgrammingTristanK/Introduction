/* Created by: Tristan Kalabric
 * Created on September 15, 2018
 * Daily Assignment: - Day # 6 - Calculations
 * This program displays the area, circumference of a circle and the volume of a sphere
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

namespace AreaCircVolTristanK
{
    public partial class frmAreaCircVol : Form
    {
        public frmAreaCircVol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Displays the area when button is clicked
            lblAreaAnswer.Text = Convert.ToString(Math.PI * Math.Pow(6.5, 2)) + "cm";
        }

        private void btnCircumference_Click(object sender, EventArgs e)
        {
            //Displays the circumfrence when button is clicked
            lblCircAnswer.Text = Convert.ToString(Math.PI * 10) + "cm";
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            //Displays the volume when the button is clicked
            lblVolAnswer.Text = Convert.ToString(4 / 3 * Math.PI * Math.Pow(5, 3)) + "cm";
        }
    }
}

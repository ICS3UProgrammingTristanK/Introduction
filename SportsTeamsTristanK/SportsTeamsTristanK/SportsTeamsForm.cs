/* Created by: Tristan Kalabric
 * Created on: September 16, 2018
 * Created for: ICS3U Programming
 * Daily Assignment: - Day #7 - Sports Teams
 * This program displays the names of 4 different NHL teams. To display one of the teams names you must click on the corresponding menu item
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

namespace SportsTeamsTristanK
{
    public partial class frmSportsTeams : Form
    {
        public frmSportsTeams()
        {
            InitializeComponent();
        }

        private void sportsTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniOttawa_Click(object sender, EventArgs e)
        {
            //When clicked, labels display Ottawa Senators
            this.lblCityName.Text = "Ottawa";
            this.lblTeamName.Text = "Senators";
        }

        private void mniMontreal_Click(object sender, EventArgs e)
        {
            //When clicked, labels display Montreal Canadians
            this.lblCityName.Text = "Montreal";
            this.lblTeamName.Text = "Canadians";
        }

        private void mniToronto_Click(object sender, EventArgs e)
        {
            //When clicked, labels display Toronto Maple Leafs
            this.lblCityName.Text = "Toronto";
            this.lblTeamName.Text = "Maple Leafs";
        }

        private void mniCalgary_Click(object sender, EventArgs e)
        {
            //When clicked, labels display Calgary Flames
            this.lblCityName.Text = "Calgary";
            this.lblTeamName.Text = "Flames";
            
        }
    }
}

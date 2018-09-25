namespace SportsTeamsTristanK
{
    partial class frmSportsTeams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuSportsTeams = new System.Windows.Forms.MenuStrip();
            this.mniSportsTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOttawa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMontreal = new System.Windows.Forms.ToolStripMenuItem();
            this.mniToronto = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCalgary = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.grbTeams = new System.Windows.Forms.GroupBox();
            this.mnuSportsTeams.SuspendLayout();
            this.grbTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSportsTeams
            // 
            this.mnuSportsTeams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSportsTeams});
            this.mnuSportsTeams.Location = new System.Drawing.Point(0, 0);
            this.mnuSportsTeams.Name = "mnuSportsTeams";
            this.mnuSportsTeams.Size = new System.Drawing.Size(284, 24);
            this.mnuSportsTeams.TabIndex = 0;
            // 
            // mniSportsTeams
            // 
            this.mniSportsTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOttawa,
            this.mniMontreal,
            this.mniToronto,
            this.mniCalgary});
            this.mniSportsTeams.Name = "mniSportsTeams";
            this.mniSportsTeams.Size = new System.Drawing.Size(89, 20);
            this.mniSportsTeams.Text = "Sports Teams";
            // 
            // mniOttawa
            // 
            this.mniOttawa.Name = "mniOttawa";
            this.mniOttawa.Size = new System.Drawing.Size(152, 22);
            this.mniOttawa.Text = "Ottawa";
            this.mniOttawa.Click += new System.EventHandler(this.mniOttawa_Click);
            // 
            // mniMontreal
            // 
            this.mniMontreal.Name = "mniMontreal";
            this.mniMontreal.Size = new System.Drawing.Size(152, 22);
            this.mniMontreal.Text = "Montreal";
            this.mniMontreal.Click += new System.EventHandler(this.mniMontreal_Click);
            // 
            // mniToronto
            // 
            this.mniToronto.Name = "mniToronto";
            this.mniToronto.Size = new System.Drawing.Size(152, 22);
            this.mniToronto.Text = "Toronto";
            this.mniToronto.Click += new System.EventHandler(this.mniToronto_Click);
            // 
            // mniCalgary
            // 
            this.mniCalgary.Name = "mniCalgary";
            this.mniCalgary.Size = new System.Drawing.Size(152, 22);
            this.mniCalgary.Text = "Calgary";
            this.mniCalgary.Click += new System.EventHandler(this.mniCalgary_Click);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.Location = new System.Drawing.Point(47, 16);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(54, 25);
            this.lblCityName.TabIndex = 1;
            this.lblCityName.Text = "NHL";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(47, 57);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(77, 25);
            this.lblTeamName.TabIndex = 2;
            this.lblTeamName.Text = "Teams";
            // 
            // grbTeams
            // 
            this.grbTeams.Controls.Add(this.lblCityName);
            this.grbTeams.Controls.Add(this.lblTeamName);
            this.grbTeams.Location = new System.Drawing.Point(39, 86);
            this.grbTeams.Name = "grbTeams";
            this.grbTeams.Size = new System.Drawing.Size(200, 100);
            this.grbTeams.TabIndex = 3;
            this.grbTeams.TabStop = false;
            this.grbTeams.Text = "NHL Team";
            // 
            // frmSportsTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbTeams);
            this.Controls.Add(this.mnuSportsTeams);
            this.MainMenuStrip = this.mnuSportsTeams;
            this.Name = "frmSportsTeams";
            this.Text = "Sports Teams";
            this.mnuSportsTeams.ResumeLayout(false);
            this.mnuSportsTeams.PerformLayout();
            this.grbTeams.ResumeLayout(false);
            this.grbTeams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSportsTeams;
        private System.Windows.Forms.ToolStripMenuItem mniSportsTeams;
        private System.Windows.Forms.ToolStripMenuItem mniOttawa;
        private System.Windows.Forms.ToolStripMenuItem mniMontreal;
        private System.Windows.Forms.ToolStripMenuItem mniToronto;
        private System.Windows.Forms.ToolStripMenuItem mniCalgary;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.GroupBox grbTeams;
    }
}


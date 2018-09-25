namespace HelloWorldIntTristanK
{
    partial class frmHelloWorldInt
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrançais = new System.Windows.Forms.RadioButton();
            this.radItaliano = new System.Windows.Forms.RadioButton();
            this.radHrvatski = new System.Windows.Forms.RadioButton();
            this.grbLanguage = new System.Windows.Forms.GroupBox();
            this.grbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(122, 9);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(229, 41);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Checked = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(6, 19);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(91, 28);
            this.radEnglish.TabIndex = 1;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radFrançais
            // 
            this.radFrançais.AutoSize = true;
            this.radFrançais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrançais.Location = new System.Drawing.Point(6, 53);
            this.radFrançais.Name = "radFrançais";
            this.radFrançais.Size = new System.Drawing.Size(100, 28);
            this.radFrançais.TabIndex = 2;
            this.radFrançais.Text = "Français";
            this.radFrançais.UseVisualStyleBackColor = true;
            this.radFrançais.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radItaliano
            // 
            this.radItaliano.AutoSize = true;
            this.radItaliano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radItaliano.Location = new System.Drawing.Point(6, 124);
            this.radItaliano.Name = "radItaliano";
            this.radItaliano.Size = new System.Drawing.Size(86, 28);
            this.radItaliano.TabIndex = 3;
            this.radItaliano.Text = "Italiano";
            this.radItaliano.UseVisualStyleBackColor = true;
            this.radItaliano.CheckedChanged += new System.EventHandler(this.radItalian_CheckedChanged);
            // 
            // radHrvatski
            // 
            this.radHrvatski.AutoSize = true;
            this.radHrvatski.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHrvatski.Location = new System.Drawing.Point(6, 87);
            this.radHrvatski.Name = "radHrvatski";
            this.radHrvatski.Size = new System.Drawing.Size(93, 28);
            this.radHrvatski.TabIndex = 4;
            this.radHrvatski.Text = "Hrvatski";
            this.radHrvatski.UseVisualStyleBackColor = true;
            this.radHrvatski.CheckedChanged += new System.EventHandler(this.radCroatian_CheckedChanged);
            // 
            // grbLanguage
            // 
            this.grbLanguage.Controls.Add(this.radEnglish);
            this.grbLanguage.Controls.Add(this.radHrvatski);
            this.grbLanguage.Controls.Add(this.radFrançais);
            this.grbLanguage.Controls.Add(this.radItaliano);
            this.grbLanguage.Location = new System.Drawing.Point(12, 91);
            this.grbLanguage.Name = "grbLanguage";
            this.grbLanguage.Size = new System.Drawing.Size(200, 158);
            this.grbLanguage.TabIndex = 5;
            this.grbLanguage.TabStop = false;
            this.grbLanguage.Text = "Language";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.grbLanguage);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International!";
            this.Load += new System.EventHandler(this.frmHelloWorldInt_Load);
            this.grbLanguage.ResumeLayout(false);
            this.grbLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFrançais;
        private System.Windows.Forms.RadioButton radItaliano;
        private System.Windows.Forms.RadioButton radHrvatski;
        private System.Windows.Forms.GroupBox grbLanguage;
    }
}


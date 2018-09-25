namespace AreaCircVolTristanK
{
    partial class frmAreaCircVol
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
            this.btnCircumference = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lblCircAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.lblVolAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCircumference
            // 
            this.btnCircumference.Location = new System.Drawing.Point(12, 25);
            this.btnCircumference.Name = "btnCircumference";
            this.btnCircumference.Size = new System.Drawing.Size(191, 110);
            this.btnCircumference.TabIndex = 0;
            this.btnCircumference.Text = "Calculate the circumference of a circle with a radius of 5cm";
            this.btnCircumference.UseVisualStyleBackColor = true;
            this.btnCircumference.Click += new System.EventHandler(this.btnCircumference_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(12, 154);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(191, 108);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calculate the area of a circle that has a radius of 6.5cm";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(12, 288);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(191, 108);
            this.btnVolume.TabIndex = 2;
            this.btnVolume.Text = "Calculate the volume of a sphere that has a radius of 5cm";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblCircAnswer
            // 
            this.lblCircAnswer.AutoSize = true;
            this.lblCircAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircAnswer.Location = new System.Drawing.Point(372, 65);
            this.lblCircAnswer.Name = "lblCircAnswer";
            this.lblCircAnswer.Size = new System.Drawing.Size(72, 25);
            this.lblCircAnswer.TabIndex = 3;
            this.lblCircAnswer.Text = "?????";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(372, 203);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(72, 25);
            this.lblAreaAnswer.TabIndex = 4;
            this.lblAreaAnswer.Text = "?????";
            // 
            // lblVolAnswer
            // 
            this.lblVolAnswer.AutoSize = true;
            this.lblVolAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolAnswer.Location = new System.Drawing.Point(374, 336);
            this.lblVolAnswer.Name = "lblVolAnswer";
            this.lblVolAnswer.Size = new System.Drawing.Size(72, 25);
            this.lblVolAnswer.TabIndex = 5;
            this.lblVolAnswer.Text = "?????";
            // 
            // frmAreaCircVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(686, 408);
            this.Controls.Add(this.lblVolAnswer);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblCircAnswer);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnCircumference);
            this.Name = "frmAreaCircVol";
            this.Text = "Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCircumference;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblCircAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.Label lblVolAnswer;
    }
}


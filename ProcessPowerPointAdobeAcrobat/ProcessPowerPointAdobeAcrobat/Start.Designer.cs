namespace ProcessPowerPointAdobeAcrobat
{
    partial class Start
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
            this.powerpoint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powerpoint
            // 
            this.powerpoint.Location = new System.Drawing.Point(35, 38);
            this.powerpoint.Name = "powerpoint";
            this.powerpoint.Size = new System.Drawing.Size(159, 42);
            this.powerpoint.TabIndex = 0;
            this.powerpoint.Text = "PowerPoint";
            this.powerpoint.UseVisualStyleBackColor = true;
            this.powerpoint.Click += new System.EventHandler(this.POWERPOINT_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "AdobeReader";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ADOBEREADER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 141);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.powerpoint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powerpoint;
        private System.Windows.Forms.Button button2;
    }
}


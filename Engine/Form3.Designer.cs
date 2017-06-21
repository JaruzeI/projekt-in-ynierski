using System.Drawing;
using System.Windows.Forms;

namespace rysowanie
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(screenWidth, screenHeight);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(screenWidth, screenHeight);
            this.panel2.TabIndex = 1;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(screenWidth - 185, screenHeight - 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(15, 194, 247);
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.BackColor = System.Drawing.Color.FromArgb(255, 249, 249);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(screenWidth - 100, screenHeight - 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.FlatAppearance.BorderColor = Color.FromArgb(15, 194, 247);
            this.button2.FlatAppearance.BorderSize = 1;
            this.button2.BackColor = System.Drawing.Color.FromArgb(255, 249, 249);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(screenWidth - 100, screenHeight - 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.FlatAppearance.BorderColor = Color.FromArgb(15, 194, 247);
            this.button3.FlatAppearance.BorderSize = 1;
            this.button3.BackColor = System.Drawing.Color.FromArgb(255, 249, 249);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(screenWidth - 185, screenHeight - 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.FlatAppearance.BorderColor = Color.FromArgb(15, 194, 247);
            this.button4.FlatAppearance.BorderSize = 1;
            this.button4.BackColor = System.Drawing.Color.FromArgb(255, 249, 249);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(screenWidth - 185, screenHeight - 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Show saved";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.FlatAppearance.BorderColor = Color.FromArgb(15, 194, 247);
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.BackColor = System.Drawing.Color.FromArgb(255, 249, 249);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 533);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.test);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.KeyPreview = true;

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


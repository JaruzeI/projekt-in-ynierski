using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessPowerPointAdobeAcrobat
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void POWERPOINT_Click(object sender, EventArgs e)
        {
            PowerPoint form2 = new PowerPoint();

            this.Hide();

            form2.Show();
 
        }

        private void ADOBEREADER_Click(object sender, EventArgs e)
        {
            AdobeReader form3 = new AdobeReader();

            this.Hide();

            form3.Show();

        }
    }
}

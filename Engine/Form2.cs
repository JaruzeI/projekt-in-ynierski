using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingOnTop
{
    public partial class Form2 : Form
    {
        Pen p2;
        public Form2(Pen pen)
        {
            InitializeComponent();
            p2 = pen;
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p2.Color = Color.Red;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p2.Color = Color.Green;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p2.Color = Color.Blue;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p2.Color = Color.Black;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p2.Color = Color.White;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p2.Color = Color.Yellow;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            colorDialog1.ShowDialog();
            p2.Color = colorDialog1.Color;
        }
    }
}

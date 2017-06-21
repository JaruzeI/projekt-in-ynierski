using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace rysowanie
{
    public partial class Form3 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Graphics g;
        public int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        public int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public string savePath = "J:/Desktop/";
        public int imageNumber = 0;

        public Form3()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();

            // SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            panel1.BackColor = Color.Transparent;
            panel1.Bounds = Screen.PrimaryScreen.Bounds;

            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = Color.AliceBlue;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            Shown += new EventHandler(Form_Shown);

            Application.EnableVisualStyles();
        }

        public void Form_Shown(object sender, System.EventArgs e)
        {
            DrawRectangleRectangle();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            DrawRectangleRectangle();
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Application.OpenForms[0].TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawingOnTop.Form2 frm = new DrawingOnTop.Form2(p);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            TestNewEngineWPF.PPAD main = new TestNewEngineWPF.PPAD();
            main.Show();
            main.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //panel2.Invalidate();
            /*
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            */
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            //DateTime currentDateTime = new DateTime();
            //String newDirectory = savePath + "/" + currentDateTime;

            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }

                //DirectoryInfo di = Directory.CreateDirectory(newDirectory);
                bitmap.Save(savePath + "/obraz" + imageNumber + ".jpg", ImageFormat.Jpeg);
            }
            imageNumber++;
            /*
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            */
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Process.Start(@savePath);
        }

        private void test(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                p.Width = p.Width + 1;
            }

            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                p.Width = p.Width - 1;
            }

            if (e.KeyCode == Keys.F10)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    savePath = fbd.SelectedPath;
                }

            }
        }
        public void DrawRectangleRectangle()
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 1);

            // Create rectangle.
            Rectangle rect = new Rectangle(screenWidth - 200, screenHeight -215 , 185, 120);

            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(29, 57, 106));

            // Create rectangle.
            Rectangle rectFill = new Rectangle(screenWidth - 200, screenHeight - 215, 185, 120);

            // Fill rectangle to screen.
            g.FillRectangle(blueBrush, rect);

            // Draw rectangle to screen.
            g.DrawRectangle(blackPen, rect);


        }
    }
}

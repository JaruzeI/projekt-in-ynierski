using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace TestNewEngineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PPAD : Window
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public System.Drawing.Point current = new System.Drawing.Point();
        public System.Drawing.Point old = new System.Drawing.Point();
        public System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Black, 5);
        public Graphics g;
        public double screenWidth = System.Windows.SystemParameters.PrimaryScreenHeight;
        public double screenHeight = System.Windows.SystemParameters.PrimaryScreenWidth;
        public string savePath = "J:/Desktop/";
        rysowanie.Form3 canvas = new rysowanie.Form3();


        public PPAD()
        {
            SizeChanged += (o, e) =>
            {
                var r = SystemParameters.WorkArea;
                Left = r.Right - ActualWidth;
                Top = r.Bottom - ActualHeight;
            };

            InitializeComponent();
        }

        private void zIn_Click(object sender, RoutedEventArgs e)
        {
            sendKey("^{ADD}", "^{ADD}");
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            sendKey("{F5}", "^{h}");

        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            sendKey("{ESC}", "{ESC}");
        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {
            sendKey("{Up}", "{Left}");
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            sendKey("{DOWN}", "{Right}");
        }

        private void zOut_Click(object sender, RoutedEventArgs e)
        {
            sendKey("^{SUBTRACT}", "^{SUBTRACT}");
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            sendKey("{HOME}", "{HOME}");
        }

        private void last_Click(object sender, RoutedEventArgs e)
        {
            sendKey("{END}", "{END}");
        }

        public void draw_Click(object sender, EventArgs e)
        {
            this.Hide();
            rysowanie.Form3 can = new rysowanie.Form3();
            canvas = can;
            canvas.Show();
            //this.TopMost = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            canvas.Close();*/
        }

        private void sendKey(string Pp, string Ad)
        {

            this.Hide();

            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);

            if (p.MainWindowTitle.Contains("PowerPoint"))
                System.Windows.Forms.SendKeys.SendWait(Pp);
            if (p.MainWindowTitle.Contains("Adobe Acrobat Reader"))
                System.Windows.Forms.SendKeys.SendWait(Ad);

            change_window();
        }

        private void change_window()
        {
            PPAD main = new PPAD();
            main.Show();
            main.Activate();
        }

    }
}

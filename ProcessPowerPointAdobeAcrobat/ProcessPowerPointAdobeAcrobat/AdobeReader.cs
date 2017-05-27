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
    public partial class AdobeReader : Form
    {

        Process acrProcess;
        Process[] collectionOfProcessA;

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public AdobeReader()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            collectionOfProcessA = Process.GetProcessesByName("AcroRd32");
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess = collectionOfProcessA[0];

            }

        }

        private void start_Click(object sender, EventArgs e)
        {     
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{l}");
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{ESC}");
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{Left}");
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{Right}");
            }
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{SUBTRACT}");
            }
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{ADD}");
            }

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Start form1 = new Start();

            this.Hide();

            form1.Show();
        }

        private void first_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{HOME}");
            }

        }

        private void last_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessA.Length >= 1)
            {
                acrProcess.WaitForInputIdle();
                IntPtr handle = acrProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{END}");
               
            }

        }
    }
}

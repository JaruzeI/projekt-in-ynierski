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
    public partial class PowerPoint : Form
    {
        Process powProcess;
        Process[] collectionOfProcessP;

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public PowerPoint()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            collectionOfProcessP = Process.GetProcessesByName("POWERPNT");
           
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess = collectionOfProcessP[0];


            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{Left}");
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{Right}");
            }
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{ADD}");
            }
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{SUBTRACT}");
            }
        }

        private void pen_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{p}");
            }

        }

        private void rubber_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{e}");
            }

        }

        private void pointer_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^{a}");
            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{F5}");
            }

        }

        private void end_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{ESC}");
            }

        }

        private void stopstart_Click(object sender, EventArgs e)
        {
            if (collectionOfProcessP.Length >= 1)
            {
                powProcess.WaitForInputIdle();
                IntPtr handle = powProcess.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("{s}");
            }

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Start form1 = new Start();

            this.Hide();

            form1.Show();
        }
    }
}

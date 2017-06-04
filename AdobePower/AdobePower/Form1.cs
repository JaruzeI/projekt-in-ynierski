using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobePower
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        Process startProcess;
        

        public Form1()
        {
            InitializeComponent();
            startProcess = Process.GetCurrentProcess();
        }

        private void start_Click(object sender, EventArgs e)
        {
            sendKey("{F5}", "^{l}");
        }

        private void end_Click(object sender, EventArgs e)
        {
            sendKey("{ESC}", "{ESC}");
           
        }

        private void previous_Click(object sender, EventArgs e)
        {
            sendKey("{Up}", "{Left}");
            
        }

        private void next_Click(object sender, EventArgs e)
        {
            sendKey("{DOWN}", "{Right}");
            
        }

        private void zIN_Click(object sender, EventArgs e)
        {
            sendKey("^{ADD}", "^{ADD}");
           
        }

        private void zOUT_Click(object sender, EventArgs e)
        {
            sendKey("^{SUBTRACT}", "^{SUBTRACT}");
            

        }

        private void first_Click(object sender, EventArgs e)
        {
            sendKey("{HOME}", "{HOME}");
          

        }

        private void last_Click(object sender, EventArgs e)
        {
            sendKey("{END}", "{END}");
          

        }

        private void sendKey(string Pp,string Ad)
        {
            this.WindowState = FormWindowState.Minimized;
            
                IntPtr hwnd = GetForegroundWindow();
                uint pid;
                GetWindowThreadProcessId(hwnd, out pid);
                Process p = Process.GetProcessById((int)pid);
                if (p.MainWindowTitle.Contains("PowerPoint"))
                    SendKeys.SendWait(Pp);
                if (p.MainWindowTitle.Contains("Adobe Acrobat Reader"))
                    SendKeys.SendWait(Ad);

          


        }
    }
}

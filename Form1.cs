using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace maketopmost
{
    public partial class Form1 : Form
    {
        public const int GWL_EXSTYLE = -20;
        public const UInt32 WS_EX_TOPMOST = 0x0008;
        public const int SWP_NOMOVE = 2;
        public const int SWP_NOSIZE = 1;
        public const int HWND_TOPMOST = -1;
        public const int HWND_NOTOPMOST = -2;

        IntPtr targetwindow;
        bool activated;
        public Form1()
        {
            activated = false;
            InitializeComponent();
        }
        [DllImport("User32.dll", SetLastError=false)]
        static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndinsertafter, int x, int y, int cx, int cy, UInt32 flags);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        
        [DllImport("User32.dll", SetLastError=false)]
        static extern bool GetCursorPos(out Point lppoint);
        
        [DllImport("User32.dll", SetLastError=false)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpString, int nMax);

        [DllImport("User32.dll", SetLastError = false)]
        static extern IntPtr WindowFromPoint(Point point);

        [DllImport("User32.dll", SetLastError = false)]
        static extern IntPtr GetParent(IntPtr child);

        [DllImport("User32.dll", SetLastError = false)]
        static extern int IsWindow(IntPtr hwnd);

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Target Window";
            targetwindow = IntPtr.Zero;
        }
        public static bool IsWindowTopMost(IntPtr Handle)
        {
            return (GetWindowLong(Handle, GWL_EXSTYLE) & WS_EX_TOPMOST) != 0;
        }
        private void maketopMost()
        {
            SetWindowPos(targetwindow, (IntPtr)HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }
        private void undoTopMost()
        {
            SetWindowPos(targetwindow, (IntPtr)HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (activated)
            {
                activated = false;
                targetwindow = GetForegroundWindow();
                StringBuilder name = new StringBuilder(255);
                GetWindowText(targetwindow, name, 255);
                label1.Text = name.ToString();
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            activated = true;
        }

        private void btntoggle_Click(object sender, EventArgs e)
        {
            if ( IsWindow(targetwindow) == 0 ){
                MessageBox.Show("invalid window");
                return;
            }
            if (IsWindowTopMost(targetwindow))
            {
                undoTopMost();
            }
            else
            {
                maketopMost();
            }
        }
    }
}

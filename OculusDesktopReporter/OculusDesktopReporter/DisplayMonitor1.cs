using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EvergreenDesktopReporter
{
    class DisplayMonitor1
    {
        [DllImport("user32.dll")]
        //static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        static extern IntPtr SendMessage(int hWnd, uint Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        static extern IntPtr PostMessage(int hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 dwData, UIntPtr dwExtraInfo);

        const int MONITOR_ON = -1;
        const int MONITOR_OFF = 2;
        const int MONITOR_STANBY = 1;       

        private const int MOUSEEVENTF_MOVE = 0x0001;

        private void Wake()
        {
            mouse_event(MOUSEEVENTF_MOVE, 0, 1, 0, UIntPtr.Zero);
           
            mouse_event(MOUSEEVENTF_MOVE, 0, -1, 0, UIntPtr.Zero);
        }

        public void turnMonitorOn()
        {
            if (!EvergreenDesktopReporter.Properties.Settings.Default.monitorControl)
                return;

            int HWND_BROADCAST = 0xffff;
            //the message is sent to all 
            //top-level windows in the system

            int HWND_TOPMOST = -1;
            //the message is sent to one 
            //top-level window in the system

            int HWND_TOP = 0;        //
            int HWND_BOTTOM = 1;        //limited use
            int HWND_NOTOPMOST = -2;       //

            const int SC_MONITORPOWER = 0xF170;
            const int WM_SYSCOMMAND = 0x0112;

            PostMessage(0xFFFF, 0x112, 0xF170, -1);
            Wake();
            //SendMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_ON);       
        }

        public void turnMonitorOff()
        {
            if (!EvergreenDesktopReporter.Properties.Settings.Default.monitorControl)
                return;

            int HWND_BROADCAST = 0xffff;
            //the message is sent to all 
            //top-level windows in the system

            int HWND_TOPMOST = -1;
            //the message is sent to one 
            //top-level window in the system

            int HWND_TOP = 0;        //
            int HWND_BOTTOM = 1;        //limited use
            int HWND_NOTOPMOST = -2;       //

            const int SC_MONITORPOWER = 0xF170;
            const int WM_SYSCOMMAND = 0x0112;

            PostMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }
    }
}

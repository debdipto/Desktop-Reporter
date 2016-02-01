using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvergreenDesktopReporter
{
    class Volume
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        private IntPtr Handle;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public Volume(IntPtr _Handle)
        {
            Handle = _Handle;
        }

        public enum Volumes : int
        {
            OFF = 0,
            LOW = 858993459,
            NORMAL = 1717986918,
            MEDIUM = -1717986919,
            HIGH = -858993460,
            VERY_HIGH = -1
        }
        //WIP
        public void setVolume(uint level)
        {
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            MessageBox.Show((CalcVol / (ushort.MaxValue / 10)).ToString());

            int NewVolume = ((ushort.MaxValue / 10) * 0);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        public void mute()
        {
            if (EvergreenDesktopReporter.Properties.Settings.Default.volumeControl)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
            }
        }        

        public void decreaseVolume()
        {
            if (EvergreenDesktopReporter.Properties.Settings.Default.volumeControl)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
            }
        }

        public void increaseVolume()
        {
            if (EvergreenDesktopReporter.Properties.Settings.Default.volumeControl)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            }
        }
    }
}

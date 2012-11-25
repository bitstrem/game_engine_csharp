using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Runtime.InteropServices; 

namespace GameEngine
{
    class FastLoop
    {
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage(
            out Message msg,
            IntPtr hWnd,
            uint messageFilterMin,
            uint messageFilterMax,
            uint flags);

        PreciseTimer _timer = new PreciseTimer(); 
        public delegate void LoopCallback(double elapsedTime);
        LoopCallback _callback; 

        public FastLoop(LoopCallback callback)
        {
            _callback = callback; 
            Application.Idle += new EventHandler(OnApplicationEnterIdle); 
        }

        void OnApplicationEnterIdle(object sender, EventArgs e)
        {
            while(IsAppStillIdle())
            {
                _callback(_timer.GetElapsedTime()); 
            }
        }

        private bool IsAppStillIdle()
        {
            Message msg; 
            return !PeekMessage(out msg, IntPtr.Zero, 0, 0, 0); 
        }
    }
}

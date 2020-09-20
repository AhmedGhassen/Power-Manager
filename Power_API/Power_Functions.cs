using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Power_API
{
    internal struct LASTINPUTINFO
    {
        public uint cbSize;
        public uint dwTime;
    }
    public class Power_Functions
    {
        [DllImport("User32.dll")]
        private static extern bool LockWorkStation();

        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("wtsapi32.dll", SetLastError = true)]
        private static extern bool WTSDisconnectSession(IntPtr hServer, int sessionId, bool bWait);

        public static void ShutdownComputer()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void MakeComputerSleep()
        {
            SetSuspendState(false, true, true);
        }

        public static void MakeComputerHibernate()
        {
            SetSuspendState(true, true, true);
        }

        public static void RebootComputer()
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void LockComputer()
        {
            LockWorkStation();
        }

        private static uint GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            GetLastInputInfo(ref lastInPut);
            return ((uint)Environment.TickCount - lastInPut.dwTime);
        }

        public static uint GetComputeIdleTimeInMilliseconds()
        {
            return GetIdleTime();
        }

        public static uint GetComputeIdleTimeInSeconds()
        {
            return GetIdleTime() / 1000;
        }

        public static void LogOutFromCurrentUser()
        {
            WTSDisconnectSession(IntPtr.Zero, -1, false);
        }

        public static bool VerifyFile()
        {
            return true;
        }
    }
}
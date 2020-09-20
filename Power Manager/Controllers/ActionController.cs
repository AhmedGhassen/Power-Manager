using PowerManager.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Power_API;
namespace PowerManager.Controllers
{
    class ActionController
    {
        
        public static void ShutdownComputer()
        {
            if( Properties.Settings.Default.ModeDev && Properties.Settings.Default.ModeTestForClosePC)
            {
                MessageBox.Show("'Closing Computer' feature has been disactivated for testing perposes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                Power_Functions.ShutdownComputer();
            }
        }


        public static uint GetComputeIdleTimeInSeconds()
        {
            return Power_Functions.GetComputeIdleTimeInSeconds();
        }

        public static void LockComputer()
        {
            if (Properties.Settings.Default.ModeDev && Properties.Settings.Default.ModeTestForLockPc)
            {
                MessageBox.Show("'Lock Computer' has been disactivated for testing perposes","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Power_Functions.LockComputer();
            }
        }
    }
}

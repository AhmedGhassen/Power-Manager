using System;
using System.Windows.Forms;
using Power_API;
namespace PowerManager.Controllers
{
    class Controller
    {
        
        public static bool ShutdownComputer(Form form)
        {
            if( Properties.Settings.Default.ModeDev && Properties.Settings.Default.ModeTestForClosePC)
            {
                MessageBox.Show(form,"'Close Computer' feature has been disactivated for testing perposes", "Power Manager | Developer Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            } else
            {
                if (Properties.Settings.Default.DisableWhenPcUpdating)
                {
                    if (!isWindowsUpdating())
                    {
                        Power_Functions.ShutdownComputer();
                        return true;
                    } 
                    else
                    {
                        MessageBox.Show(form, "Windows is currently downloading or installing updates\nOperation canceled", "Power Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                
            }
            return false;
        }


        public static uint GetComputeIdleTimeInSeconds()
        {
            return Power_Functions.GetComputeIdleTimeInSeconds();
        }

        public static bool LockComputer(Form form)
        {
            if (Properties.Settings.Default.ModeDev && Properties.Settings.Default.ModeTestForLockPc)
            {
                MessageBox.Show(form,"'Lock Computer' has been disactivated for testing perposes","Power Manager | Developer Mode",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (Properties.Settings.Default.DisableWhenPcUpdating)
                {
                    if (!isWindowsUpdating())
                    {
                        Power_Functions.LockComputer();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(form, "Windows is currently downloading or installing updates\nOperation canceled", "Power Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return false;
        }


        private static bool isWindowsUpdating()
        {
            return false;
        }
        
        static public string getTimestamp()
        {
            var date = DateTime.UtcNow;
            return (string)(date.Year+"_"+date.Month+"_"+date.Day+"_"+date.Hour+"_"+date.Minute+"_"+date.Second);
        }
    }
}

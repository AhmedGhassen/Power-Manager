using System.Windows.Forms;
using Power_API;
namespace PowerManager.Controllers
{
    class ActionController
    {
        
        public static void ShutdownComputer(Form form)
        {
            if( Properties.Settings.Default.ModeDev && Properties.Settings.Default.ModeTestForClosePC)
            {
                MessageBox.Show(form,"'Close Computer' feature has been disactivated for testing perposes", "Power Manager | Developer Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                Power_Functions.ShutdownComputer();
            }
        }


        public static uint GetComputeIdleTimeInSeconds()
        {
            return Power_Functions.GetComputeIdleTimeInSeconds();
        }

        public static void LockComputer(Form form)
        {
            if (Properties.Settings.Default.ModeDev && Properties.Settings.Default.ModeTestForLockPc)
            {
                MessageBox.Show(form,"'Lock Computer' has been disactivated for testing perposes","Power Manager | Developer Mode",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Power_Functions.LockComputer();
            }
        }
    }
}

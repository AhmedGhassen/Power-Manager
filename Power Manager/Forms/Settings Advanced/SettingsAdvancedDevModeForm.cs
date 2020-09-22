using System;
using System.Drawing;
using System.Windows.Forms;

namespace PowerManager.Forms.Settings_Advanced
{
    public partial class SettingsAdvancedDevModeForm : Form
    {
        public SettingsAdvancedDevModeForm()
        {
            InitializeComponent();
        }

        private void SettingsAdvancedDevModeForm_Load(object sender, EventArgs e)
        {
            checkBox_reminder_timer.Checked = Properties.Settings.Default.ReminderTimerInStatusBar;
            checkBox_idle_timer.Checked = Properties.Settings.Default.IdleTimerStatusInStatusBar;
            checkBox_mode_test_close.Checked = Properties.Settings.Default.ModeTestForClosePC;
            checkBox_mode_test_lock.Checked = Properties.Settings.Default.ModeTestForLockPc;
            checkTheme();
        }

        private void checkBox_mode_test_Click(object sender, EventArgs e)
        {
            if (!checkBox_mode_test_close.Checked)
            {
                var response = MessageBox.Show(this, "If \"Test Mode for 'Shutdown'\"  is disabled the computer will shutdown \nContinue ?", "Power Manager |  Developer Mode Advanced Settings  | Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response != DialogResult.Yes)
                {
                    checkBox_mode_test_close.Checked = !checkBox_mode_test_close.Checked;
                }
            }
            Properties.Settings.Default.ModeTestForClosePC = checkBox_mode_test_close.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_mode_test_lock_Click(object sender, EventArgs e)
        {
            if (!checkBox_mode_test_lock.Checked)
            {
                var response = MessageBox.Show(this, "If \"Test Mode for 'Lock'\" is disabled the computer will lock \nContinue ?", "Power Manager | Developer Mode Advanced Settings  | Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response != DialogResult.Yes)
                {
                    checkBox_mode_test_lock.Checked = !checkBox_mode_test_lock.Checked;
                }
            }
            Properties.Settings.Default.ModeTestForLockPc = checkBox_mode_test_lock.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_reminder_timer_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReminderTimerInStatusBar = checkBox_reminder_timer.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_idle_timer_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IdleTimerStatusInStatusBar = checkBox_idle_timer.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkTheme()
        {
            Color textColor;
            Color backColor;
            if (Properties.Settings.Default.Theme == 0)
            {
                textColor = SystemColors.ControlText;
                backColor = Color.White;
            }else
            {
                textColor = SystemColors.ControlLightLight;
                backColor = SystemColors.WindowFrame;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
        }
    }
}

using Microsoft.Win32;
using PowerManager.Forms.Settings_Advanced;
using PowerManager.Forms.Utilities_Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PowerManager.Forms
{
    public partial class SettingsForm : Form
    {

        SettingsAdvancedPcIdleForm settingsAdvancedPcIdle = null;
        SettingsAdvancedDevModeForm SettingsAdvancedDev = null;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            checkBox_Startup.Checked = Properties.Settings.Default.runOnStartup;
            checkBox_min_to_tray_when_runing.Checked = Properties.Settings.Default.MinToTrayWhenOpening;
            checkBox_min_to_tray_when_closing.Checked = Properties.Settings.Default.MinToTrayWhenClosing;
            checkBox_dev_mode.Checked = Properties.Settings.Default.ModeDev;
            checkBox_pc_idle.Checked = Properties.Settings.Default.PcIdleReminderEnabled;
            checkBox_show_1mn_warning.Checked = Properties.Settings.Default.Show1MnWarning;
            linkLabel_advanced.Enabled = checkBox_pc_idle.Checked;
            linkLabel_advanced_dev_mode.Enabled = checkBox_dev_mode.Checked;
            checkTheme();
        }

        private void checkBox_pc_idle_CheckedChanged(object sender, EventArgs e)
        {
            linkLabel_advanced.Enabled = checkBox_pc_idle.Checked;
            if (Properties.Settings.Default.PcIdleReminderAction == 0 || Properties.Settings.Default.PcIdleReminderTimeInSeconds == 0)
            {
                showAdvancedPcIdle();
            }
            Properties.Settings.Default.PcIdleReminderEnabled = checkBox_pc_idle.Checked;
            Properties.Settings.Default.Save();
        }

        private void showAdvancedPcIdle()
        {
            if (settingsAdvancedPcIdle == null)
            {
                settingsAdvancedPcIdle = new SettingsAdvancedPcIdleForm();
                var result = settingsAdvancedPcIdle.ShowDialog();
                if (result != DialogResult.OK && (Properties.Settings.Default.PcIdleReminderAction == 0 || Properties.Settings.Default.PcIdleReminderTimeInSeconds == 0))
                {
                    checkBox_pc_idle.Checked = false;
                }
                settingsAdvancedPcIdle = null;
            }
            else
            {
                settingsAdvancedPcIdle.Focus();
            }

        }

        private void checkBox_dev_mode_Click(object sender, EventArgs e)
        {
            if (checkBox_dev_mode.Checked)
            {
                InputBoxForm inputBoxForm = new InputBoxForm("Developper Mode", "Please enter the Devepoler Mode password", "", true);
                inputBoxForm.ShowDialog();
                var password = inputBoxForm.returnedValue;
                if (inputBoxForm.DialogResult == DialogResult.OK)
                {
                    if (!password.Equals("0000"))
                    {
                        var response = MessageBox.Show(this, "Password for 'Developer Mode' is wrong !", "Power Manager | Mode Developer | Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (response == DialogResult.Retry)
                        {
                            checkBox_dev_mode_Click(checkBox_dev_mode, null);
                        }
                        checkBox_dev_mode.Checked = !checkBox_dev_mode.Checked;
                    }
                }
                else
                {
                    checkBox_dev_mode.Checked = !checkBox_dev_mode.Checked;
                }
            }
            linkLabel_advanced_dev_mode.Enabled = checkBox_dev_mode.Checked;
            Properties.Settings.Default.ModeDev = checkBox_dev_mode.Checked;
            Properties.Settings.Default.Save();
        }



        private void linkLabel_advanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAdvancedPcIdle();
        }

        private void linkLabel_advanced_dev_mode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAdvancedDevMode();
        }

        private void showAdvancedDevMode()
        {
            if (SettingsAdvancedDev == null)
            {
                SettingsAdvancedDev = new SettingsAdvancedDevModeForm();
                SettingsAdvancedDev.ShowDialog();
                SettingsAdvancedDev = null;
            }
            else
            {
                SettingsAdvancedDev.Focus();
            }
        }

        private void checkBox_Startup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (checkBox_Startup.Checked)
            {
                try
                {
                    registryKey.SetValue("Power Manager", Application.ExecutablePath.ToString());

                }
                catch (System.UnauthorizedAccessException error)
                {
                    Debug.WriteLine(error.Message);
                    checkBox_Startup.Checked = !checkBox_Startup.Checked;
                    MessageBox.Show(this,"Action blocked", "Power Manager | Settings | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var value = registryKey.GetValue("Power Manager");
                if (value != null)
                {
                    registryKey.DeleteValue("Power Manager");
                }

            }
            Properties.Settings.Default.runOnStartup = checkBox_Startup.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_min_to_tray_when_closing_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinToTrayWhenClosing = checkBox_min_to_tray_when_closing.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_min_to_tray_when_runing_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinToTrayWhenOpening = checkBox_min_to_tray_when_runing.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_show_1mn_warning_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Show1MnWarning = checkBox_show_1mn_warning.Checked;
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
            }
            else
            {
                textColor = SystemColors.ControlLightLight;
               backColor = Properties.Settings.Default.DarkThemeColor;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
        }
    }
}

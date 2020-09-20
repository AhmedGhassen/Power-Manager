using Microsoft.VisualBasic;
using Microsoft.Win32;
using PowerManager.Forms.Settings_Advanced;
using PowerManager.Forms.Utilities_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }



        private void save_btn_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (checkBox_Startup.Checked)
            {
                registryKey.SetValue("Power Manager", Application.ExecutablePath.ToString());
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
            Properties.Settings.Default.MinToTrayWhenClosing = checkBox_min_to_tray_when_closing.Checked;
            Properties.Settings.Default.MinToTrayWhenOpening = checkBox_min_to_tray_when_runing.Checked;

            Properties.Settings.Default.PcIdleReminderEnabled = checkBox_pc_idle.Checked;

            Properties.Settings.Default.Show1MnWarning = checkBox_show_1mn_warning.Checked;
            Properties.Settings.Default.ModeDev = checkBox_dev_mode.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }


        private void checkBox_pc_idle_CheckedChanged(object sender, EventArgs e)
        {
            linkLabel_advanced.Enabled = checkBox_pc_idle.Checked;
            if (Properties.Settings.Default.PcIdleReminderAction == 0 || Properties.Settings.Default.PcIdleReminderTimeInSeconds == 0)
            {
                showAdvancedPcIdle();
            }
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
    }
}

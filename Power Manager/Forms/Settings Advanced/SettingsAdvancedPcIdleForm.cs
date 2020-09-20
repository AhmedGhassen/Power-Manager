using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerManager.Forms.Settings_Advanced
{
    public partial class SettingsAdvancedPcIdleForm : Form
    {
        public SettingsAdvancedPcIdleForm()
        {
            InitializeComponent();
        }

        private void SettingsAdvancedPcIdleForm_Load(object sender, EventArgs e)
        {
            radioButton_close_computer.Checked = Properties.Settings.Default.PcIdleReminderAction == 1;
            radioButton_lock_workspace.Checked = Properties.Settings.Default.PcIdleReminderAction == 2;

            checkBox_disbale_idle_when_timer_on.Checked = Properties.Settings.Default.DisableIdleWhenTimerRunning;
            var allSeconds = TimeSpan.FromSeconds(double.Parse(Properties.Settings.Default.PcIdleReminderTimeInSeconds.ToString()));
            hours_field.Value = allSeconds.Hours;
            minutes_field.Value = allSeconds.Minutes;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if ((!radioButton_close_computer.Checked && !radioButton_lock_workspace.Checked) || (hours_field.Value == 0 && minutes_field.Value == 0))
            {
                MessageBox.Show(this,"Some fields are empry", "Power Manager | Advanced Settings PC idle Advanced Settings | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            } else
            {
                if (radioButton_close_computer.Checked)
                    Properties.Settings.Default.PcIdleReminderAction = 1;
                else if (radioButton_lock_workspace.Checked)
                    Properties.Settings.Default.PcIdleReminderAction = 2;
                Properties.Settings.Default.PcIdleReminderTimeInSeconds = hours_field.Value * 3600 + minutes_field.Value * 60;
                Properties.Settings.Default.DisableIdleWhenTimerRunning = checkBox_disbale_idle_when_timer_on.Checked;
                Properties.Settings.Default.Save();
                this.Close();
            }
            
        }
    }
}

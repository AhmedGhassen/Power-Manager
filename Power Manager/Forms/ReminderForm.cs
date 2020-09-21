using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerManager.Forms
{
    public partial class ReminderForm : Form
    {
        public ReminderForm()
        {
            InitializeComponent();
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {
            checkBox_disable_reminder_after_on.Checked = Properties.Settings.Default.MainTimerReminderDisabledAfterGoinOn;
            checkBox_main_timer.Checked = Properties.Settings.Default.MainTimerReminderEnabled;
            var mainTimerSeconds = TimeSpan.FromSeconds(double.Parse(Properties.Settings.Default.MainTimerReminderTimeInSeconds.ToString()));
            hours_field_main_timer.Value = mainTimerSeconds.Hours;
            minutes_field_main_timer.Value = mainTimerSeconds.Minutes;
        }

        private void checkBox_main_timer_CheckedChanged(object sender, EventArgs e)
        {
            hours_field_main_timer.Enabled = checkBox_main_timer.Checked;
            minutes_field_main_timer.Enabled = checkBox_main_timer.Checked;
            checkBox_disable_reminder_after_on.Enabled = checkBox_main_timer.Checked;
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            if (checkBox_main_timer.Checked && hours_field_main_timer.Value == 0 && minutes_field_main_timer.Value == 0)
            {
                MessageBox.Show("Some fields are empry", "Power Manager | Reminder | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                Properties.Settings.Default.MainTimerReminderEnabled = checkBox_main_timer.Checked;
                Properties.Settings.Default.MainTimerReminderTimeInSeconds = hours_field_main_timer.Value * 3600 + minutes_field_main_timer.Value * 60;

                Properties.Settings.Default.MainTimerReminderDisabledAfterGoinOn = checkBox_disable_reminder_after_on.Checked;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}

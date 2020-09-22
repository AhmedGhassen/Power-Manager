using System;
using System.Drawing;
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
            checkTheme();
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

        private void checkTheme()
        {
            Color textColor;
            Color backColor;
            if (Properties.Settings.Default.Theme == 0)
            {
                textColor = SystemColors.ControlText;
                backColor = Color.White;
                label_ps.ForeColor = Color.Red;
            }
            else
            {
                textColor = SystemColors.ControlLightLight;
                backColor = SystemColors.WindowFrame;
                label_ps.ForeColor = Color.Tomato;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
            groupBox_hours.ForeColor = textColor;
            groupBox_minutes.ForeColor = textColor;

            minutes_field_main_timer.ForeColor = textColor;
            minutes_field_main_timer.BackColor = backColor;

            hours_field_main_timer.ForeColor = textColor;
            hours_field_main_timer.BackColor = backColor;

            btn_save.ForeColor = SystemColors.ControlText;
        }
    }
}

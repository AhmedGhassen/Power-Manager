using PowerManager.Controllers;
using PowerManager.Forms;
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
    public partial class MainForm : Form
    {
        //Main Timer
        private Timer timer = new Timer();
        private decimal minutes;
        private decimal hours;
        private decimal allSeconds;
        private bool timerStoped = true;

        //Idle Timer
        private Timer timerWhenPcIdle = new Timer();
        private decimal reminderAllSeconds;
        private decimal reminderRemainingTime;

        //Forms
        private SettingsForm settingsForm = null;
        private ReminderForm reminderForm = null;
        private AboutForm aboutForm = null;

        private string time;

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timerWhenPcIdle.Interval = 1000;
            timerWhenPcIdle.Tick += TimerWhenPcIdle_Tick;


        }

        private void TimerWhenPcIdle_Tick(object sender, EventArgs e)
        {
            var idleTime = ActionController.GetComputeIdleTimeInSeconds();
            var allSecondsIdle = Properties.Settings.Default.PcIdleReminderTimeInSeconds;
            var remainingTimeIdle = TimeSpan.FromSeconds(double.Parse((allSecondsIdle - idleTime).ToString()));
            toolStripStatusLabel_idle_timer.Text = "Idle Timer  " + String.Format("{0:00}", remainingTimeIdle.Hours) + " : " + String.Format("{0:00}", remainingTimeIdle.Minutes) + " : " + String.Format("{0:00}", remainingTimeIdle.Seconds);
            if (idleTime == allSecondsIdle)
            {
                stopIdleTimer();
                this.Hide();
                ClosingAlertForm closingAlertForm = new ClosingAlertForm(true);
                closingAlertForm.ShowDialog();
                timerWhenPcIdle.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            allSeconds--;
            if (allSeconds < 0)
            {
                stopTimer();
                this.Hide();
                Properties.Settings.Default.PcIdleReminderAction = 1;
                ClosingAlertForm closingAlertForm = new ClosingAlertForm(false);
                closingAlertForm.ShowDialog();
            }
            else
            {
                var timeRemaining = TimeSpan.FromSeconds(double.Parse(allSeconds.ToString()));
                this.time = String.Format("{0:00}", timeRemaining.Hours) + " : " + String.Format("{0:00}", timeRemaining.Minutes) + " : " + String.Format("{0:00}", timeRemaining.Seconds);
                timeLeftLabel.Text = this.time;
                notifyIcon1.Text = notifyIcon1.Text = "Running | " + this.time;
                timerToolStripMenuItem.Text = "Timer : " + this.time;
                checkReminder();
            }
        }

        private void checkReminder()
        {
            if (Properties.Settings.Default.MainTimerReminderEnabled)
            {
                reminderRemainingTime--;
                if (reminderRemainingTime >= 0)
                {
                    refreshReminderDisplay();
                }

                if (reminderRemainingTime == 0)
                {
                    ReminderMessageForm reminderMessage = new ReminderMessageForm(allSeconds);
                    reminderMessage.Show();
                    if (Properties.Settings.Default.MainTimerReminderDisabledAfterGoinOn)
                    {
                        Properties.Settings.Default.MainTimerReminderEnabled = false;
                        Properties.Settings.Default.Save();
                    }

                }
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (hours_field.Value != 0 || minutes_field.Value != 0)
            {
                this.minutes = minutes_field.Value;
                this.hours = hours_field.Value;
                this.allSeconds = minutes * 60 + hours * 3600;
                minutes_field.Value = 0;
                hours_field.Value = 0;
                timeLeftLabel.Text = String.Format("{0:00}", hours) + " : " + String.Format("{0:00}", minutes) + " : 00";
                display_groupe_box.Visible = true;
                timer_groupe_box.Visible = false;
                pause_btn.Image = Properties.Resources.pause;
                timerStoped = false;
                reminderAllSeconds = Properties.Settings.Default.MainTimerReminderTimeInSeconds;
                refreshReminderDisplay();
                reminderRemainingTime = allSeconds - reminderAllSeconds;
                timer.Start();
                if (Properties.Settings.Default.DisableIdleWhenTimerRunning)
                {
                    stopIdleTimer();
                }
            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            pauseTimer();
            if (Properties.Settings.Default.DisableIdleWhenTimerRunning)
            {
                stopIdleTimer();
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stopTimer();
            reminderRemainingTime = Properties.Settings.Default.MainTimerReminderTimeInSeconds;
            refreshReminderDisplay();

            if (Properties.Settings.Default.PcIdleReminderEnabled && Properties.Settings.Default.DisableIdleWhenTimerRunning)
            {
                timerWhenPcIdle.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopTimer();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Properties.Settings.Default.MinToTrayWhenClosing)
            {
                this.Hide();
                e.Cancel = true;
                
            }
            else if (timer.Enabled || !timerStoped)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (timerStoped)
            {
                timerToolStripMenuItem.Visible = false;
                toolStripSeparator5.Visible = false;
            }
            else
            {
                timerToolStripMenuItem.Visible = true;
                toolStripSeparator5.Visible = true;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pauseTimer();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopTimer();
        }


        private void pauseTimer()
        {
            if (timer.Enabled)
            {
                timer.Stop();
                pause_btn.Image = Properties.Resources.play;
                notifyIcon1.Text = "Paused | " + this.time;
                pauseToolStripMenuItem.Text = "Resume";
            }
            else
            {
                timer.Start();
                pause_btn.Image = Properties.Resources.pause;
                pauseToolStripMenuItem.Text = "Pause";

            }
        }

        private void stopTimer()
        {
            timer.Stop();
            display_groupe_box.Visible = false;
            timer_groupe_box.Visible = true;
            timerStoped = true;
            notifyIcon1.Text = "Stopped";
        }

        private void stopIdleTimer()
        {
            toolStripStatusLabel_idle_timer.Text = "Idle Timer  00 : 00 : 00";
            timerWhenPcIdle.Stop();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm();
                settingsForm.ShowDialog();
                //if (settingsForm.DialogResult == DialogResult.OK)
                //{
                    if (Properties.Settings.Default.PcIdleReminderEnabled)
                    {
                        if (!timerWhenPcIdle.Enabled)
                        {
                            timerWhenPcIdle.Start();
                        }

                        if (Properties.Settings.Default.DisableIdleWhenTimerRunning && !timerStoped)
                        {
                            stopIdleTimer();
                        }
                    }
                    else if (!Properties.Settings.Default.PcIdleReminderEnabled)
                    {
                        stopIdleTimer();
                    }

                //}
                checkDevelopperMode();
                settingsForm = null;
            }
            else
            {
                settingsForm.Focus();
            }
        }

        private void refreshReminderDisplay()
        {
            var remainingTimeReminder = TimeSpan.FromSeconds(double.Parse((reminderRemainingTime).ToString()));
            toolStripStatusLabel_reminder_timer.Text = "Reminder Timer  " + String.Format("{0:00}", remainingTimeReminder.Hours) + " : " + String.Format("{0:00}", remainingTimeReminder.Minutes) + " : " + String.Format("{0:00}", remainingTimeReminder.Seconds);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkDevelopperMode();
            reminderRemainingTime = Properties.Settings.Default.MainTimerReminderTimeInSeconds;
            refreshReminderDisplay();
            if (Properties.Settings.Default.PcIdleReminderEnabled)
            {
                timerWhenPcIdle.Start();
            }
        }

        private void lockWorkstationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionController.LockComputer();
        }

        private void reminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reminderForm == null)
            {
                reminderForm = new ReminderForm();
                reminderForm.ShowDialog();
                if (reminderForm.DialogResult == DialogResult.OK)
                {
                    reminderAllSeconds = Properties.Settings.Default.MainTimerReminderTimeInSeconds;
                    refreshReminderDisplay();

                }
                reminderForm = null;

            }
            else
            {
                reminderForm.Focus();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinToTrayWhenOpening)
            {
                this.Hide();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new AboutForm();
                aboutForm.ShowDialog();
                aboutForm = null;
            }
            else
            {
                aboutForm.Focus();
            }
        }
        private void checkDevelopperMode()
        {
            statusStrip1.Visible = Properties.Settings.Default.ModeDev;
            if (Properties.Settings.Default.ModeDev)
            {
                toolStripStatusLabel_idle_timer.Visible = Properties.Settings.Default.IdleTimerStatusInStatusBar;
                toolStripStatusLabel_reminder_timer.Visible = Properties.Settings.Default.ReminderTimerInStatusBar;
                toolStripStatusLabel_test_close_mode.Visible = Properties.Settings.Default.ModeTestForClosePC;
                toolStripStatusLabel_test_lock_mode.Visible = Properties.Settings.Default.ModeTestForLockPc;
            }
        }

    }
}

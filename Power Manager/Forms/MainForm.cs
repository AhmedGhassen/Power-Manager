using PowerManager.Controllers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace PowerManager.Forms
{
    public partial class MainForm : Form
    {
        //Main Timer
        private Timer timer = new Timer();
        private decimal minutes;
        private decimal hours;

        private decimal reminingTimeInMainTimer;
        private bool timerStoped = true;
        private decimal reminderAllSeconds;

        //Idle Timer
        private Timer timerWhenPcIdle = new Timer();


        //Forms
        private SettingsForm settingsForm = null;
        private ReminderForm reminderForm = null;
        private AboutForm aboutForm = null;
        private ClosingAlertForm closingAlertForm = null;
        private ReminderMessageForm reminderMessage = null;

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
                closingAlertForm = new ClosingAlertForm(true);
                closingAlertForm.ShowDialog();
                closingAlertForm = null;
                if (!Properties.Settings.Default.HideMainWhenClosingAlertCloses)
                {
                    this.Show();
                }
                if (Properties.Settings.Default.PcIdleReminderEnabled)
                {
                    timerWhenPcIdle.Start();
                }

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            reminingTimeInMainTimer--;
            if (reminingTimeInMainTimer < 0)
            {
                stopTimer();
                this.Hide();
                Properties.Settings.Default.PcIdleReminderAction = 1;
                closingAlertForm = new ClosingAlertForm(false);
                closingAlertForm.ShowDialog();
                closingAlertForm = null;
                if (!Properties.Settings.Default.HideMainWhenClosingAlertCloses)
                {
                    this.Show();
                }
            }
            else
            {
                var timeRemaining = TimeSpan.FromSeconds(double.Parse(reminingTimeInMainTimer.ToString()));
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
                if (reminingTimeInMainTimer - reminderAllSeconds >= 0)
                {
                    refreshReminderDisplay();
                }

                if (reminingTimeInMainTimer - reminderAllSeconds == 0)
                {
                    reminderMessage = new ReminderMessageForm(reminingTimeInMainTimer);
                    reminderMessage.ShowDialog();
                    reminderMessage = null;
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
                this.reminingTimeInMainTimer = minutes * 60 + hours * 3600;
                minutes_field.Value = 0;
                hours_field.Value = 0;
                timeLeftLabel.Text = String.Format("{0:00}", hours) + " : " + String.Format("{0:00}", minutes) + " : 00";
                display_groupe_box.Visible = true;
                timer_groupe_box.Visible = false;
                timerStoped = false;
                reminderAllSeconds = Properties.Settings.Default.MainTimerReminderTimeInSeconds;
                refreshReminderDisplay();
                timer.Start();
                if (Properties.Settings.Default.DisableIdleWhenTimerRunning)
                {
                    stopIdleTimer();
                }
                if (Properties.Settings.Default.Theme == 0)
                {
                    pause_btn.Image = Properties.Resources.light_pause;
                }
                else
                {
                    pause_btn.Image = Properties.Resources.dark_pause;
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
            reminderAllSeconds = 0;
            reminingTimeInMainTimer = 0;
            refreshReminderDisplay();

            if (Properties.Settings.Default.PcIdleReminderEnabled && Properties.Settings.Default.DisableIdleWhenTimerRunning)
            {
                timerWhenPcIdle.Start();
            }

            if (Properties.Settings.Default.DisableReminderWhenMainTimerStops)
            {
                Properties.Settings.Default.MainTimerReminderEnabled = false;
                Properties.Settings.Default.Save();
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
                if (Properties.Settings.Default.Theme == 0)
                {
                    pause_btn.Image = Properties.Resources.light_play;
                }
                else
                {
                    pause_btn.Image = Properties.Resources.dark_play;
                }

                notifyIcon1.Text = "Paused | " + this.time;
                pauseToolStripMenuItem.Text = "Resume";
            }
            else
            {
                timer.Start();
                if (Properties.Settings.Default.Theme == 0)
                {
                    pause_btn.Image = Properties.Resources.light_pause;
                }
                else
                {
                    pause_btn.Image = Properties.Resources.dark_pause;
                }
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
            if (!Properties.Settings.Default.isClosing)
            {
                if (settingsForm == null)
                {
                    settingsForm = new SettingsForm();
                    settingsForm.ShowDialog();
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
                    checkDevelopperMode();
                    settingsForm = null;
                }
                else
                {
                    settingsForm.Focus();
                }
            }

        }

        private void refreshReminderDisplay()
        {
            if (reminingTimeInMainTimer - reminderAllSeconds >= 0)
            {
                var remainingTimeReminder = TimeSpan.FromSeconds(double.Parse((reminingTimeInMainTimer - reminderAllSeconds).ToString()));
                toolStripStatusLabel_reminder_timer.Text = "Reminder Timer  " + String.Format("{0:00}", remainingTimeReminder.Hours) + " : " + String.Format("{0:00}", remainingTimeReminder.Minutes) + " : " + String.Format("{0:00}", remainingTimeReminder.Seconds);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkDevelopperMode();
            reminderAllSeconds = Properties.Settings.Default.MainTimerReminderTimeInSeconds;

            if (Properties.Settings.Default.PcIdleReminderEnabled)
            {
                timerWhenPcIdle.Start();
            }
            if (Properties.Settings.Default.Theme == 0)
            {
                darkToolStripMenuItem.Checked = false;
                lightDefaultToolStripMenuItem.Checked = true;
                lightDefaultToolStripMenuItem1.Checked = true;
                darkToolStripMenuItem1.Checked = false;

            }
            else
            {
                darkToolStripMenuItem1.Checked = true;

                darkToolStripMenuItem.Checked = true;
                lightDefaultToolStripMenuItem.Checked = false;
                lightDefaultToolStripMenuItem1.Checked = false;
            }
            checkTheme();

        }




        private void lockWorkstationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.isClosing)
            {
                this.Hide();
                var oldAction = Properties.Settings.Default.PcIdleReminderAction;
                var oldWarning = Properties.Settings.Default.Show1MnWarning;
                Properties.Settings.Default.PcIdleReminderAction = 2;
                Properties.Settings.Default.Show1MnWarning = false;
                closingAlertForm = new ClosingAlertForm(false);
                closingAlertForm.ShowDialog();
                closingAlertForm = null;
                if (!Properties.Settings.Default.HideMainWhenClosingAlertCloses)
                {
                    this.Show();
                }
                Properties.Settings.Default.Show1MnWarning = oldWarning;
                Properties.Settings.Default.PcIdleReminderAction = oldAction;
            }
        }

        private void reminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.isClosing)
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
            if (!Properties.Settings.Default.isClosing)
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

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = 1;
            darkToolStripMenuItem.Checked = true;
            lightDefaultToolStripMenuItem.Checked = false;
            darkToolStripMenuItem1.Checked = true;
            lightDefaultToolStripMenuItem1.Checked = false;
            checkTheme();
            Properties.Settings.Default.Save();
        }
        private void lightDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = 0;
            darkToolStripMenuItem.Checked = false;
            lightDefaultToolStripMenuItem.Checked = true;
            darkToolStripMenuItem1.Checked = false;
            lightDefaultToolStripMenuItem1.Checked = true;
            checkTheme();
            Properties.Settings.Default.Save();
        }

        private void checkTheme()
        {

            if (reminderMessage != null)
            {
                reminderMessage.checkTheme();
            }
            if (closingAlertForm != null)
            {
                closingAlertForm.checkTheme();
            }
            if (settingsForm != null)
            {
                settingsForm.checkTheme();
            }
            if (reminderForm != null)
            {
                reminderForm.checkTheme();
            }
            if (aboutForm != null)
            {
                aboutForm.checkTheme();
            }

            Color textColor;
            Color backColor;
            if (Properties.Settings.Default.Theme == 0)
            {
                textColor = SystemColors.ControlText;
                backColor = Color.White;
                play_btn.Image = Properties.Resources.light_play;
                if (timer.Enabled)
                {
                    pause_btn.Image = Properties.Resources.light_pause;
                }
                else
                {
                    pause_btn.Image = Properties.Resources.light_play;
                }
                stop_btn.Image = Properties.Resources.light_stop;
            }
            else
            {
                backColor = Properties.Settings.Default.DarkThemeColor;
                textColor = SystemColors.ControlLightLight;
                play_btn.Image = Properties.Resources.dark_play;
                pause_btn.Image = Properties.Resources.dark_pause;
                if (timer.Enabled)
                {
                    pause_btn.Image = Properties.Resources.dark_pause;
                }
                else
                {
                    pause_btn.Image = Properties.Resources.dark_play;
                }
                stop_btn.Image = Properties.Resources.dark_stop;
            }
            menuStrip1.ForeColor = textColor;
            menuStrip1.BackColor = backColor;
            timeLeftLabel.ForeColor = textColor;
            hours_groupe_box.ForeColor = textColor;
            minutes_groupe_box.ForeColor = textColor;
            hours_field.ForeColor = textColor;
            hours_field.BackColor = backColor;
            minutes_field.ForeColor = textColor;
            minutes_field.BackColor = backColor;
            this.BackColor = backColor;
            statusStrip1.ForeColor = textColor;
            statusStrip1.BackColor = backColor;
            for (var i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].ForeColor = textColor;
                menuStrip1.Items[i].BackColor = backColor;
            }

        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            for (var i = 0; i < menuStrip1.Items.Count; i++)
            {
                if (Properties.Settings.Default.Theme == 1)
                {
                    menuStrip1.Items[i].ForeColor = SystemColors.ControlText;
                    menuStrip1.Items[i].BackColor = Color.White;
                }
            }
        }

        private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
        {
            for (var i = 0; i < menuStrip1.Items.Count; i++)
            {
                if (Properties.Settings.Default.Theme == 1)
                {
                    menuStrip1.Items[i].ForeColor = SystemColors.ControlLightLight;
                    menuStrip1.Items[i].BackColor = Properties.Settings.Default.DarkThemeColor;
                }
            }
        }
    }
}

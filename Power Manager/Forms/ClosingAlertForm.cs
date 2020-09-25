using PowerManager.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PowerManager.Forms
{
    public partial class ClosingAlertForm : Form
    {
        Timer timer = new Timer();
        int remainingTime = 59;
        bool isIdle;

        public ClosingAlertForm(bool isIdle)
        {
            if (!Properties.Settings.Default.Show1MnWarning)
            {
                remainingTime = 5;
            }
            InitializeComponent();
            this.isIdle = isIdle;
            if (isIdle)
            {
                label_press.Text = "Press any key to cancel";
            } else
            {
                label_press.Text = "Click here to cancel";
            }
        }

        private void ClosingAlertForm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.isClosing = true;
            label_time_remaing.Text = remainingTime.ToString() + " s";
            var action = Properties.Settings.Default.PcIdleReminderAction;
            if (action == 1)
            {
                label_action.Text = "Computer will close in ";
            }
            else if (action == 2)
            {
                label_action.Text = "Computer will lock in ";
            }
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            checkTheme();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label_time_remaing.Text = remainingTime.ToString() + " s";
            if (isIdle)
            {
                var idleTime = Controller.GetComputeIdleTimeInSeconds();
                if (idleTime == 0)
                {
                    Properties.Settings.Default.PcIdleReminderEnabled = false;
                    Properties.Settings.Default.Save();
                    timer.Stop();
                    this.Close();
                }
            }

            if (remainingTime < 0)
            {
                timer.Stop();
                label_time_remaing.Visible = false;
                label_press.Text = "Close";
                if (Properties.Settings.Default.PcIdleReminderAction == 1)
                {
                    
                    bool result = Controller.ShutdownComputer(this);
                    string res = result ? " " : " not ";
                    label_action.Text = "Computer"+res+"Closed";

                }
                else if (Properties.Settings.Default.PcIdleReminderAction == 2)
                {
                    
                    bool result = Controller.LockComputer(this);
                    string res = result ? " " : " not ";
                    label_action.Text = "Computer"+res+"Locked";
                }
                
            }
        }

        private void label_press_Click(object sender, EventArgs e)
        {
            if (!isIdle)
            {
                timer.Stop();
                this.Close();
            }
        }

        private void ClosingAlertForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Properties.Settings.Default.isClosing = false;
        }

        public void checkTheme()
        {
            Color textColor;
            Color backColor;
            if (Properties.Settings.Default.Theme == 0)
            {
                textColor = SystemColors.ControlText;
                backColor = Color.White;
                label_press.ForeColor = Color.Red;
            }
            else
            {
                textColor = SystemColors.ControlLightLight;
                backColor = Properties.Settings.Default.DarkThemeColor;
                label_press.ForeColor = Color.Tomato;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
        }
    }
}

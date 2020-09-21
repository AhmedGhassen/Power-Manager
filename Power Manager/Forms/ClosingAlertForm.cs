using PowerManager.Controllers;
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
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            remainingTime--;
            label_time_remaing.Text = remainingTime.ToString() + " s";
            if (isIdle)
            {
                var idleTime = ActionController.GetComputeIdleTimeInSeconds();
                if (idleTime == 0)
                {
                    timer.Stop();
                    this.Close();
                }
            }

            if (remainingTime < 0)
            {
                timer.Stop();

                label_time_remaing.Visible = false;
                label_press.Visible = false;
                if (Properties.Settings.Default.PcIdleReminderAction == 1)
                {
                    label_action.Text = "Computer Closed";
                    ActionController.ShutdownComputer();
                    
                }
                else if (Properties.Settings.Default.PcIdleReminderAction == 2)
                {
                    label_action.Text = "Computer Locked";
                    ActionController.LockComputer();
                    
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
    }
}

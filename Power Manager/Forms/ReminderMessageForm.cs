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
    public partial class ReminderMessageForm : Form
    {
        private decimal remainingTime;
        public ReminderMessageForm(decimal remainingTime)
        {
            InitializeComponent();
            this.remainingTime = remainingTime;
        }

        private void ReminderMessage_Load(object sender, EventArgs e)
        {
            var timeRemaining = TimeSpan.FromSeconds(double.Parse(remainingTime.ToString()));
            var time = String.Format("{0:00}", timeRemaining.Hours) + " : " + String.Format("{0:00}", timeRemaining.Minutes) + " : " + String.Format("{0:00}", timeRemaining.Seconds);
            label_diplay_message.Text = time;
        }

    }
}

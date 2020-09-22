using System;
using System.Drawing;
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
            checkTheme();
        }

        private void checkTheme()
        {
            Color textColor;
            Color backColor;
            if (Properties.Settings.Default.Theme == 0)
            {
                textColor = SystemColors.ControlText;
                backColor = Color.White;
                label_diplay_message.ForeColor = Color.Red;
            }
            else
            {
                textColor = SystemColors.ControlLightLight;
                backColor = SystemColors.WindowFrame;
                label_diplay_message.ForeColor = Color.Tomato;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
            labe1.ForeColor = textColor;

        }

    }
}

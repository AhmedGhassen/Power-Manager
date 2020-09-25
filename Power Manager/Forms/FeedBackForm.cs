using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerManager.API;
using PowerManager.Controllers;
using PowerManager.Models;
using PowerManager.Services;

namespace PowerManager.Forms
{
    public partial class FeedBackForm : Form
    {
        StarRating starRating = new StarRating();
        public FeedBackForm()
        {
            InitializeComponent();
            starRating.Location = new Point(137, 60);
            starRating.TopMargin = -1;
            starRating.BottomMargin = -1;
            starRating.LeftMargin = -1;
            starRating.RightMargin = -1;
            Controls.Add(starRating);
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            FeedBack feedBack = new FeedBack();
            feedBack.id = Controller.getTimestamp();
            feedBack.stars = starRating.SelectedStar;
            feedBack.username = textBox_username.Text;
            feedBack.description = textBox_description.Text;
            await Service.sendFeedback(feedBack);
            MessageBox.Show(this, "Feedback send", "Power Manager | Send Feedback", MessageBoxButtons.OK);
            this.Close();

        }

        private void FeedBackForm_Load(object sender, EventArgs e)
        {
            checkTheme();
        }

        public void checkTheme()
        {
            Color textColor;
            Color backColor;
            if (Properties.Settings.Default.Theme == 0)
            {
                textColor = SystemColors.ControlText;
                backColor = Color.White;
            }
            else
            {
                textColor = SystemColors.ControlLightLight;
                backColor = Properties.Settings.Default.DarkThemeColor;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
            btn_send.BackColor = backColor;
            btn_send.ForeColor = textColor;
            textBox_username.ForeColor = textColor;
            textBox_username.BackColor = backColor;
            textBox_description.ForeColor = textColor;
            textBox_description.BackColor = backColor;

        }
    }
}

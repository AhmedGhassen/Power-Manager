using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerManager.Models;
using PowerManager.Services;
namespace PowerManager.Forms
{
    public partial class CheckUpdatesForm : Form
    {
        Product productVersion;
        public CheckUpdatesForm()
        {
            InitializeComponent();

        }

        private void CheckUpdatesForm_Load(object sender, EventArgs e)
        {
            label_current_version.Text = Application.ProductVersion + " " + AboutForm.release;
            btn_update.Text = "Checking";
            this.getLastVersion();
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
            btn_update.BackColor = backColor;
            btn_update.ForeColor = textColor;
        }

        private async void getLastVersion()
        {
            productVersion = await Service.getLastVersionService();
            progressBar.Visible = false;
            if (productVersion == null)
            {
                btn_update.Text = "Error";
            }
            else
            {
                int currentVersion = int.Parse(Application.ProductVersion.Replace(".", string.Empty));
                int lastVersion = int.Parse(productVersion.version.Replace(".", string.Empty));
                label_last_version.Text = productVersion.version + " " + productVersion.release;
                if (currentVersion >=lastVersion)
                {
                    btn_update.Text = "Updated";
                }
                else
                {
                    btn_update.Enabled = true;
                    btn_update.Text = "Download";
                }
            }


        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://powermanager.web.app/");
            Process.Start(sInfo);
            
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PowerManager.Forms
{
    public partial class AboutForm : Form
    {
        public static string release = "Bêta";
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label_product.Text = Application.ProductName;
            label_version.Text = "Version "+Application.ProductVersion + " " + release;
            label_copyright.Text = "Copyright © 2020 By '" + Application.CompanyName+"'";
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
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerManager.Forms.Utilities_Forms
{
    public partial class InputBoxForm : Form
    {
        public string returnedValue { get; set; }
        public InputBoxForm(string title, string prompText, string value, bool isPassword = false)
        {
            InitializeComponent();
            this.Text = title;
            this.prompText.Text = prompText;
            this.inputText.Text = value;
            if (isPassword)
            {
                this.inputText.PasswordChar = '*';
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            returnedValue = inputText.Text;
        }

        private void InputBoxForm_Load(object sender, EventArgs e)
        {
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
            }
            else
            {
                textColor = SystemColors.ControlLightLight;
                backColor = Properties.Settings.Default.DarkThemeColor;
            }
            this.ForeColor = textColor;
            this.BackColor = backColor;
            inputText.ForeColor = textColor;
            inputText.BackColor = backColor;
            btn_ok.ForeColor = SystemColors.ControlText;
            btnCancel.ForeColor = SystemColors.ControlText;
        }
    }
}

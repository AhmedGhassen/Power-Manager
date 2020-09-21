namespace PowerManager.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBox_Startup = new System.Windows.Forms.CheckBox();
            this.checkBox_min_to_tray_when_closing = new System.Windows.Forms.CheckBox();
            this.checkBox_min_to_tray_when_runing = new System.Windows.Forms.CheckBox();
            this.checkBox_pc_idle = new System.Windows.Forms.CheckBox();
            this.checkBox_show_1mn_warning = new System.Windows.Forms.CheckBox();
            this.checkBox_dev_mode = new System.Windows.Forms.CheckBox();
            this.linkLabel_advanced = new System.Windows.Forms.LinkLabel();
            this.linkLabel_advanced_dev_mode = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // checkBox_Startup
            // 
            this.checkBox_Startup.Location = new System.Drawing.Point(13, 12);
            this.checkBox_Startup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_Startup.Name = "checkBox_Startup";
            this.checkBox_Startup.Size = new System.Drawing.Size(270, 30);
            this.checkBox_Startup.TabIndex = 3;
            this.checkBox_Startup.Text = "Run on Windows startup";
            this.checkBox_Startup.UseVisualStyleBackColor = true;
            this.checkBox_Startup.CheckedChanged += new System.EventHandler(this.checkBox_Startup_CheckedChanged);
            // 
            // checkBox_min_to_tray_when_closing
            // 
            this.checkBox_min_to_tray_when_closing.Location = new System.Drawing.Point(13, 48);
            this.checkBox_min_to_tray_when_closing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_min_to_tray_when_closing.Name = "checkBox_min_to_tray_when_closing";
            this.checkBox_min_to_tray_when_closing.Size = new System.Drawing.Size(329, 30);
            this.checkBox_min_to_tray_when_closing.TabIndex = 21;
            this.checkBox_min_to_tray_when_closing.Text = "Minimise to tray when closing";
            this.checkBox_min_to_tray_when_closing.UseVisualStyleBackColor = true;
            this.checkBox_min_to_tray_when_closing.CheckedChanged += new System.EventHandler(this.checkBox_min_to_tray_when_closing_CheckedChanged);
            // 
            // checkBox_min_to_tray_when_runing
            // 
            this.checkBox_min_to_tray_when_runing.Location = new System.Drawing.Point(13, 84);
            this.checkBox_min_to_tray_when_runing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_min_to_tray_when_runing.Name = "checkBox_min_to_tray_when_runing";
            this.checkBox_min_to_tray_when_runing.Size = new System.Drawing.Size(444, 30);
            this.checkBox_min_to_tray_when_runing.TabIndex = 22;
            this.checkBox_min_to_tray_when_runing.Text = "Minimize to tray when opening (Bêta)";
            this.checkBox_min_to_tray_when_runing.UseVisualStyleBackColor = true;
            this.checkBox_min_to_tray_when_runing.CheckedChanged += new System.EventHandler(this.checkBox_min_to_tray_when_runing_CheckedChanged);
            // 
            // checkBox_pc_idle
            // 
            this.checkBox_pc_idle.AutoSize = true;
            this.checkBox_pc_idle.Location = new System.Drawing.Point(13, 155);
            this.checkBox_pc_idle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_pc_idle.Name = "checkBox_pc_idle";
            this.checkBox_pc_idle.Size = new System.Drawing.Size(381, 29);
            this.checkBox_pc_idle.TabIndex = 23;
            this.checkBox_pc_idle.Text = "Close / Lock computer when it is idle";
            this.checkBox_pc_idle.UseVisualStyleBackColor = true;
            this.checkBox_pc_idle.CheckedChanged += new System.EventHandler(this.checkBox_pc_idle_CheckedChanged);
            // 
            // checkBox_show_1mn_warning
            // 
            this.checkBox_show_1mn_warning.AutoSize = true;
            this.checkBox_show_1mn_warning.Location = new System.Drawing.Point(13, 120);
            this.checkBox_show_1mn_warning.Name = "checkBox_show_1mn_warning";
            this.checkBox_show_1mn_warning.Size = new System.Drawing.Size(253, 29);
            this.checkBox_show_1mn_warning.TabIndex = 30;
            this.checkBox_show_1mn_warning.Text = "Show 1 minute warning";
            this.checkBox_show_1mn_warning.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_show_1mn_warning.UseVisualStyleBackColor = true;
            this.checkBox_show_1mn_warning.CheckedChanged += new System.EventHandler(this.checkBox_show_1mn_warning_CheckedChanged);
            // 
            // checkBox_dev_mode
            // 
            this.checkBox_dev_mode.AutoSize = true;
            this.checkBox_dev_mode.Location = new System.Drawing.Point(13, 190);
            this.checkBox_dev_mode.Name = "checkBox_dev_mode";
            this.checkBox_dev_mode.Size = new System.Drawing.Size(189, 29);
            this.checkBox_dev_mode.TabIndex = 31;
            this.checkBox_dev_mode.Text = "Developer Mode";
            this.checkBox_dev_mode.UseVisualStyleBackColor = true;
            this.checkBox_dev_mode.Click += new System.EventHandler(this.checkBox_dev_mode_Click);
            // 
            // linkLabel_advanced
            // 
            this.linkLabel_advanced.AutoSize = true;
            this.linkLabel_advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.linkLabel_advanced.Location = new System.Drawing.Point(465, 161);
            this.linkLabel_advanced.Name = "linkLabel_advanced";
            this.linkLabel_advanced.Size = new System.Drawing.Size(72, 18);
            this.linkLabel_advanced.TabIndex = 34;
            this.linkLabel_advanced.TabStop = true;
            this.linkLabel_advanced.Text = "Advanced";
            this.linkLabel_advanced.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_advanced_LinkClicked);
            // 
            // linkLabel_advanced_dev_mode
            // 
            this.linkLabel_advanced_dev_mode.AutoSize = true;
            this.linkLabel_advanced_dev_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.linkLabel_advanced_dev_mode.Location = new System.Drawing.Point(465, 196);
            this.linkLabel_advanced_dev_mode.Name = "linkLabel_advanced_dev_mode";
            this.linkLabel_advanced_dev_mode.Size = new System.Drawing.Size(72, 18);
            this.linkLabel_advanced_dev_mode.TabIndex = 35;
            this.linkLabel_advanced_dev_mode.TabStop = true;
            this.linkLabel_advanced_dev_mode.Text = "Advanced";
            this.linkLabel_advanced_dev_mode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_advanced_dev_mode_LinkClicked);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 238);
            this.Controls.Add(this.linkLabel_advanced_dev_mode);
            this.Controls.Add(this.linkLabel_advanced);
            this.Controls.Add(this.checkBox_dev_mode);
            this.Controls.Add(this.checkBox_show_1mn_warning);
            this.Controls.Add(this.checkBox_pc_idle);
            this.Controls.Add(this.checkBox_min_to_tray_when_runing);
            this.Controls.Add(this.checkBox_min_to_tray_when_closing);
            this.Controls.Add(this.checkBox_Startup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Manager | Settings";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_Startup;
        private System.Windows.Forms.CheckBox checkBox_min_to_tray_when_closing;
        private System.Windows.Forms.CheckBox checkBox_min_to_tray_when_runing;
        private System.Windows.Forms.CheckBox checkBox_pc_idle;
        private System.Windows.Forms.CheckBox checkBox_show_1mn_warning;
        private System.Windows.Forms.CheckBox checkBox_dev_mode;
        private System.Windows.Forms.LinkLabel linkLabel_advanced;
        private System.Windows.Forms.LinkLabel linkLabel_advanced_dev_mode;
    }
}
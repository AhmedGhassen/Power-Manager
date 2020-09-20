namespace PowerManager.Forms.Settings_Advanced
{
    partial class SettingsAdvancedDevModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsAdvancedDevModeForm));
            this.checkBox_reminder_timer = new System.Windows.Forms.CheckBox();
            this.checkBox_idle_timer = new System.Windows.Forms.CheckBox();
            this.checkBox_mode_test_close = new System.Windows.Forms.CheckBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.checkBox_mode_test_lock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_reminder_timer
            // 
            this.checkBox_reminder_timer.AutoSize = true;
            this.checkBox_reminder_timer.Location = new System.Drawing.Point(12, 12);
            this.checkBox_reminder_timer.Name = "checkBox_reminder_timer";
            this.checkBox_reminder_timer.Size = new System.Drawing.Size(366, 29);
            this.checkBox_reminder_timer.TabIndex = 0;
            this.checkBox_reminder_timer.Text = "Show Reminder Timer in status bar";
            this.checkBox_reminder_timer.UseVisualStyleBackColor = true;
            // 
            // checkBox_idle_timer
            // 
            this.checkBox_idle_timer.AutoSize = true;
            this.checkBox_idle_timer.Location = new System.Drawing.Point(12, 47);
            this.checkBox_idle_timer.Name = "checkBox_idle_timer";
            this.checkBox_idle_timer.Size = new System.Drawing.Size(339, 29);
            this.checkBox_idle_timer.TabIndex = 1;
            this.checkBox_idle_timer.Text = "Show Pc idle Timer in status bar";
            this.checkBox_idle_timer.UseVisualStyleBackColor = true;
            // 
            // checkBox_mode_test_close
            // 
            this.checkBox_mode_test_close.AutoSize = true;
            this.checkBox_mode_test_close.Location = new System.Drawing.Point(12, 82);
            this.checkBox_mode_test_close.Name = "checkBox_mode_test_close";
            this.checkBox_mode_test_close.Size = new System.Drawing.Size(332, 29);
            this.checkBox_mode_test_close.TabIndex = 2;
            this.checkBox_mode_test_close.Text = "Test Mode for \'Close Computer\'";
            this.checkBox_mode_test_close.UseVisualStyleBackColor = true;
            this.checkBox_mode_test_close.Click += new System.EventHandler(this.checkBox_mode_test_Click);
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(256, 186);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(130, 37);
            this.save_btn.TabIndex = 27;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // checkBox_mode_test_lock
            // 
            this.checkBox_mode_test_lock.AutoSize = true;
            this.checkBox_mode_test_lock.Location = new System.Drawing.Point(12, 117);
            this.checkBox_mode_test_lock.Name = "checkBox_mode_test_lock";
            this.checkBox_mode_test_lock.Size = new System.Drawing.Size(323, 29);
            this.checkBox_mode_test_lock.TabIndex = 28;
            this.checkBox_mode_test_lock.Text = "Test Mode for \'Lock Computer\'";
            this.checkBox_mode_test_lock.UseVisualStyleBackColor = true;
            this.checkBox_mode_test_lock.Click += new System.EventHandler(this.checkBox_mode_test_lock_Click);
            // 
            // SettingsAdvancedDevModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 235);
            this.Controls.Add(this.checkBox_mode_test_lock);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.checkBox_mode_test_close);
            this.Controls.Add(this.checkBox_idle_timer);
            this.Controls.Add(this.checkBox_reminder_timer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsAdvancedDevModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Manager |  Developer Mode Advanced Settings ";
            this.Load += new System.EventHandler(this.SettingsAdvancedDevModeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_reminder_timer;
        private System.Windows.Forms.CheckBox checkBox_idle_timer;
        private System.Windows.Forms.CheckBox checkBox_mode_test_close;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.CheckBox checkBox_mode_test_lock;
    }
}
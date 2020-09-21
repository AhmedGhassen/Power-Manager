namespace PowerManager.Forms.Settings_Advanced
{
    partial class SettingsAdvancedPcIdleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsAdvancedPcIdleForm));
            this.save_btn = new System.Windows.Forms.Button();
            this.checkBox_disbale_idle_when_timer_on = new System.Windows.Forms.CheckBox();
            this.radioButton_lock_workspace = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minutes_field = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hours_field = new System.Windows.Forms.NumericUpDown();
            this.radioButton_close_computer = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_field)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_field)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(378, 201);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(130, 37);
            this.save_btn.TabIndex = 26;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // checkBox_disbale_idle_when_timer_on
            // 
            this.checkBox_disbale_idle_when_timer_on.AutoSize = true;
            this.checkBox_disbale_idle_when_timer_on.Location = new System.Drawing.Point(13, 12);
            this.checkBox_disbale_idle_when_timer_on.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_disbale_idle_when_timer_on.Name = "checkBox_disbale_idle_when_timer_on";
            this.checkBox_disbale_idle_when_timer_on.Size = new System.Drawing.Size(415, 29);
            this.checkBox_disbale_idle_when_timer_on.TabIndex = 36;
            this.checkBox_disbale_idle_when_timer_on.Text = "Disable when timer is running or paused";
            this.checkBox_disbale_idle_when_timer_on.UseVisualStyleBackColor = true;
            // 
            // radioButton_lock_workspace
            // 
            this.radioButton_lock_workspace.AutoSize = true;
            this.radioButton_lock_workspace.Location = new System.Drawing.Point(13, 47);
            this.radioButton_lock_workspace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_lock_workspace.Name = "radioButton_lock_workspace";
            this.radioButton_lock_workspace.Size = new System.Drawing.Size(175, 29);
            this.radioButton_lock_workspace.TabIndex = 35;
            this.radioButton_lock_workspace.TabStop = true;
            this.radioButton_lock_workspace.Text = "Lock Computer";
            this.radioButton_lock_workspace.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minutes_field);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox4.Location = new System.Drawing.Point(275, 119);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(233, 76);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minutes";
            // 
            // minutes_field
            // 
            this.minutes_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.minutes_field.Location = new System.Drawing.Point(45, 31);
            this.minutes_field.Margin = new System.Windows.Forms.Padding(5);
            this.minutes_field.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_field.Name = "minutes_field";
            this.minutes_field.Size = new System.Drawing.Size(151, 27);
            this.minutes_field.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hours_field);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(233, 76);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hours";
            // 
            // hours_field
            // 
            this.hours_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.hours_field.Location = new System.Drawing.Point(45, 31);
            this.hours_field.Margin = new System.Windows.Forms.Padding(5);
            this.hours_field.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_field.Name = "hours_field";
            this.hours_field.Size = new System.Drawing.Size(151, 27);
            this.hours_field.TabIndex = 12;
            // 
            // radioButton_close_computer
            // 
            this.radioButton_close_computer.AutoSize = true;
            this.radioButton_close_computer.Location = new System.Drawing.Point(13, 83);
            this.radioButton_close_computer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_close_computer.Name = "radioButton_close_computer";
            this.radioButton_close_computer.Size = new System.Drawing.Size(184, 29);
            this.radioButton_close_computer.TabIndex = 32;
            this.radioButton_close_computer.TabStop = true;
            this.radioButton_close_computer.Text = "Close Computer";
            this.radioButton_close_computer.UseVisualStyleBackColor = true;
            // 
            // SettingsAdvancedPcIdleForm
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 249);
            this.Controls.Add(this.checkBox_disbale_idle_when_timer_on);
            this.Controls.Add(this.radioButton_lock_workspace);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radioButton_close_computer);
            this.Controls.Add(this.save_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsAdvancedPcIdleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Manager | Advanced Settings PC idle Advanced Settings";
            this.Load += new System.EventHandler(this.SettingsAdvancedPcIdleForm_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minutes_field)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hours_field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.CheckBox checkBox_disbale_idle_when_timer_on;
        private System.Windows.Forms.RadioButton radioButton_lock_workspace;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown minutes_field;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown hours_field;
        private System.Windows.Forms.RadioButton radioButton_close_computer;
    }
}
namespace PowerManager.Forms
{
    partial class ReminderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderForm));
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_main_timer = new System.Windows.Forms.CheckBox();
            this.checkBox_disable_reminder_after_on = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minutes_field_main_timer = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hours_field_main_timer = new System.Windows.Forms.NumericUpDown();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_field_main_timer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_field_main_timer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(284, 225);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 37);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 47);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ps : Reminder will go on when the duration given equals the duration left in the " +
    "timer";
            // 
            // checkBox_main_timer
            // 
            this.checkBox_main_timer.AutoSize = true;
            this.checkBox_main_timer.Location = new System.Drawing.Point(14, 14);
            this.checkBox_main_timer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_main_timer.Name = "checkBox_main_timer";
            this.checkBox_main_timer.Size = new System.Drawing.Size(98, 29);
            this.checkBox_main_timer.TabIndex = 25;
            this.checkBox_main_timer.Text = "Enable";
            this.checkBox_main_timer.UseVisualStyleBackColor = true;
            this.checkBox_main_timer.CheckedChanged += new System.EventHandler(this.checkBox_main_timer_CheckedChanged);
            // 
            // checkBox_disable_reminder_after_on
            // 
            this.checkBox_disable_reminder_after_on.AutoSize = true;
            this.checkBox_disable_reminder_after_on.Enabled = false;
            this.checkBox_disable_reminder_after_on.Location = new System.Drawing.Point(13, 49);
            this.checkBox_disable_reminder_after_on.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_disable_reminder_after_on.Name = "checkBox_disable_reminder_after_on";
            this.checkBox_disable_reminder_after_on.Size = new System.Drawing.Size(355, 29);
            this.checkBox_disable_reminder_after_on.TabIndex = 34;
            this.checkBox_disable_reminder_after_on.Text = "Diasble the reminder after goin on";
            this.checkBox_disable_reminder_after_on.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minutes_field_main_timer);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox4.Location = new System.Drawing.Point(219, 84);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(198, 76);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minutes";
            // 
            // minutes_field_main_timer
            // 
            this.minutes_field_main_timer.Enabled = false;
            this.minutes_field_main_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.minutes_field_main_timer.Location = new System.Drawing.Point(25, 31);
            this.minutes_field_main_timer.Margin = new System.Windows.Forms.Padding(5);
            this.minutes_field_main_timer.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_field_main_timer.Name = "minutes_field_main_timer";
            this.minutes_field_main_timer.Size = new System.Drawing.Size(151, 27);
            this.minutes_field_main_timer.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hours_field_main_timer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.Location = new System.Drawing.Point(13, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(198, 76);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hours";
            // 
            // hours_field_main_timer
            // 
            this.hours_field_main_timer.Enabled = false;
            this.hours_field_main_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.hours_field_main_timer.Location = new System.Drawing.Point(22, 31);
            this.hours_field_main_timer.Margin = new System.Windows.Forms.Padding(5);
            this.hours_field_main_timer.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_field_main_timer.Name = "hours_field_main_timer";
            this.hours_field_main_timer.Size = new System.Drawing.Size(151, 27);
            this.hours_field_main_timer.TabIndex = 12;
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 277);
            this.Controls.Add(this.checkBox_disable_reminder_after_on);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox_main_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReminderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Manager | Reminder";
            this.Load += new System.EventHandler(this.ReminderForm_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minutes_field_main_timer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hours_field_main_timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_main_timer;
        private System.Windows.Forms.CheckBox checkBox_disable_reminder_after_on;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown minutes_field_main_timer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown hours_field_main_timer;
    }
}
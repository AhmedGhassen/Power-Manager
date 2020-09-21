namespace PowerManager.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer_groupe_box = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minutes_field = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hours_field = new System.Windows.Forms.NumericUpDown();
            this.play_btn = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockWorkstationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.display_groupe_box = new System.Windows.Forms.GroupBox();
            this.stop_btn = new System.Windows.Forms.PictureBox();
            this.pause_btn = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reminderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lockWorkstationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_test_close_mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_test_lock_mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_reminder_timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_idle_timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_groupe_box.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_field)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.display_groupe_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_groupe_box
            // 
            this.timer_groupe_box.Controls.Add(this.groupBox4);
            this.timer_groupe_box.Controls.Add(this.groupBox3);
            this.timer_groupe_box.Controls.Add(this.play_btn);
            this.timer_groupe_box.Location = new System.Drawing.Point(13, 42);
            this.timer_groupe_box.Margin = new System.Windows.Forms.Padding(4);
            this.timer_groupe_box.Name = "timer_groupe_box";
            this.timer_groupe_box.Padding = new System.Windows.Forms.Padding(4);
            this.timer_groupe_box.Size = new System.Drawing.Size(647, 152);
            this.timer_groupe_box.TabIndex = 3;
            this.timer_groupe_box.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minutes_field);
            this.groupBox4.Location = new System.Drawing.Point(230, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 101);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minutes";
            // 
            // minutes_field
            // 
            this.minutes_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.minutes_field.Location = new System.Drawing.Point(20, 41);
            this.minutes_field.Margin = new System.Windows.Forms.Padding(4);
            this.minutes_field.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_field.Name = "minutes_field";
            this.minutes_field.Size = new System.Drawing.Size(126, 31);
            this.minutes_field.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hours_field);
            this.groupBox3.Location = new System.Drawing.Point(16, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 101);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hours";
            // 
            // hours_field
            // 
            this.hours_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.hours_field.Location = new System.Drawing.Point(20, 41);
            this.hours_field.Margin = new System.Windows.Forms.Padding(4);
            this.hours_field.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_field.Name = "hours_field";
            this.hours_field.Size = new System.Drawing.Size(126, 31);
            this.hours_field.TabIndex = 12;
            // 
            // play_btn
            // 
            this.play_btn.Image = global::PowerManager.Properties.Resources.play;
            this.play_btn.Location = new System.Drawing.Point(481, 40);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(85, 85);
            this.play_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play_btn.TabIndex = 10;
            this.play_btn.TabStop = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockWorkstationToolStripMenuItem,
            this.toolStripSeparator1,
            this.reminderToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.toolsToolStripMenuItem.Text = "File";
            // 
            // lockWorkstationToolStripMenuItem
            // 
            this.lockWorkstationToolStripMenuItem.Image = global::PowerManager.Properties.Resources._lock;
            this.lockWorkstationToolStripMenuItem.Name = "lockWorkstationToolStripMenuItem";
            this.lockWorkstationToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.lockWorkstationToolStripMenuItem.Text = "Lock Computer";
            this.lockWorkstationToolStripMenuItem.Click += new System.EventHandler(this.lockWorkstationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // reminderToolStripMenuItem
            // 
            this.reminderToolStripMenuItem.Image = global::PowerManager.Properties.Resources.reminder;
            this.reminderToolStripMenuItem.Name = "reminderToolStripMenuItem";
            this.reminderToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.reminderToolStripMenuItem.Text = "Reminder";
            this.reminderToolStripMenuItem.Click += new System.EventHandler(this.reminderToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::PowerManager.Properties.Resources.settings;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.optionsToolStripMenuItem.Text = "Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::PowerManager.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::PowerManager.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 56.25F);
            this.timeLeftLabel.Location = new System.Drawing.Point(7, 31);
            this.timeLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(415, 97);
            this.timeLeftLabel.TabIndex = 6;
            this.timeLeftLabel.Text = "00 : 00 : 00";
            this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display_groupe_box
            // 
            this.display_groupe_box.Controls.Add(this.stop_btn);
            this.display_groupe_box.Controls.Add(this.pause_btn);
            this.display_groupe_box.Controls.Add(this.timeLeftLabel);
            this.display_groupe_box.Location = new System.Drawing.Point(13, 42);
            this.display_groupe_box.Name = "display_groupe_box";
            this.display_groupe_box.Size = new System.Drawing.Size(647, 152);
            this.display_groupe_box.TabIndex = 12;
            this.display_groupe_box.TabStop = false;
            this.display_groupe_box.Visible = false;
            // 
            // stop_btn
            // 
            this.stop_btn.Image = global::PowerManager.Properties.Resources.stop;
            this.stop_btn.Location = new System.Drawing.Point(544, 40);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(85, 85);
            this.stop_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stop_btn.TabIndex = 11;
            this.stop_btn.TabStop = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Image = global::PowerManager.Properties.Resources.pause;
            this.pause_btn.Location = new System.Drawing.Point(429, 40);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(85, 85);
            this.pause_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause_btn.TabIndex = 10;
            this.pause_btn.TabStop = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Tag = "";
            this.notifyIcon1.Text = "Stopped";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerToolStripMenuItem,
            this.toolStripSeparator5,
            this.optionsToolStripMenuItem1,
            this.reminderToolStripMenuItem1,
            this.toolStripSeparator6,
            this.lockWorkstationToolStripMenuItem1,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 166);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.timerToolStripMenuItem.Image = global::PowerManager.Properties.Resources.timer;
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Image = global::PowerManager.Properties.Resources.settings;
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.optionsToolStripMenuItem1.Text = "Settings";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // reminderToolStripMenuItem1
            // 
            this.reminderToolStripMenuItem1.Image = global::PowerManager.Properties.Resources.reminder;
            this.reminderToolStripMenuItem1.Name = "reminderToolStripMenuItem1";
            this.reminderToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.reminderToolStripMenuItem1.Text = "Reminder";
            this.reminderToolStripMenuItem1.Click += new System.EventHandler(this.reminderToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(169, 6);
            // 
            // lockWorkstationToolStripMenuItem1
            // 
            this.lockWorkstationToolStripMenuItem1.Image = global::PowerManager.Properties.Resources._lock;
            this.lockWorkstationToolStripMenuItem1.Name = "lockWorkstationToolStripMenuItem1";
            this.lockWorkstationToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.lockWorkstationToolStripMenuItem1.Text = "Lock Computer";
            this.lockWorkstationToolStripMenuItem1.Click += new System.EventHandler(this.lockWorkstationToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::PowerManager.Properties.Resources.about;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::PowerManager.Properties.Resources.exit;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_test_close_mode,
            this.toolStripStatusLabel_test_lock_mode,
            this.toolStripStatusLabel_reminder_timer,
            this.toolStripStatusLabel_idle_timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(672, 24);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 19);
            this.toolStripStatusLabel1.Text = "Dev : ON";
            // 
            // toolStripStatusLabel_test_close_mode
            // 
            this.toolStripStatusLabel_test_close_mode.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_test_close_mode.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_test_close_mode.Name = "toolStripStatusLabel_test_close_mode";
            this.toolStripStatusLabel_test_close_mode.Size = new System.Drawing.Size(130, 19);
            this.toolStripStatusLabel_test_close_mode.Text = "Test Mode \'Close\' : ON";
            // 
            // toolStripStatusLabel_test_lock_mode
            // 
            this.toolStripStatusLabel_test_lock_mode.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_test_lock_mode.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_test_lock_mode.Name = "toolStripStatusLabel_test_lock_mode";
            this.toolStripStatusLabel_test_lock_mode.Size = new System.Drawing.Size(126, 19);
            this.toolStripStatusLabel_test_lock_mode.Text = "Test Mode \'Lock\' : ON";
            // 
            // toolStripStatusLabel_reminder_timer
            // 
            this.toolStripStatusLabel_reminder_timer.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_reminder_timer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_reminder_timer.Name = "toolStripStatusLabel_reminder_timer";
            this.toolStripStatusLabel_reminder_timer.Size = new System.Drawing.Size(155, 19);
            this.toolStripStatusLabel_reminder_timer.Text = "Reminder Timer  00 : 00 : 00";
            // 
            // toolStripStatusLabel_idle_timer
            // 
            this.toolStripStatusLabel_idle_timer.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_idle_timer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_idle_timer.Name = "toolStripStatusLabel_idle_timer";
            this.toolStripStatusLabel_idle_timer.Size = new System.Drawing.Size(123, 19);
            this.toolStripStatusLabel_idle_timer.Text = "Idle Timer  00 : 00 : 00";
            this.toolStripStatusLabel_idle_timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 223);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.timer_groupe_box);
            this.Controls.Add(this.display_groupe_box);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.timer_groupe_box.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minutes_field)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hours_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.display_groupe_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox timer_groupe_box;
        private System.Windows.Forms.NumericUpDown minutes_field;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reminderToolStripMenuItem;
        private System.Windows.Forms.PictureBox play_btn;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.PictureBox pause_btn;
        private System.Windows.Forms.PictureBox stop_btn;
        private System.Windows.Forms.GroupBox display_groupe_box;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown hours_field;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reminderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockWorkstationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockWorkstationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_idle_timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_reminder_timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_test_close_mode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_test_lock_mode;
    }
}


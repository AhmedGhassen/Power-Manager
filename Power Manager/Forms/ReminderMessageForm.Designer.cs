namespace PowerManager.Forms
{
    partial class ReminderMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderMessageForm));
            this.labe1 = new System.Windows.Forms.Label();
            this.label_diplay_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labe1
            // 
            this.labe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.labe1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labe1.Location = new System.Drawing.Point(14, 10);
            this.labe1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(528, 91);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Remaining time  before closing : ";
            this.labe1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_diplay_message
            // 
            this.label_diplay_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F);
            this.label_diplay_message.ForeColor = System.Drawing.Color.Red;
            this.label_diplay_message.Location = new System.Drawing.Point(14, 101);
            this.label_diplay_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diplay_message.Name = "label_diplay_message";
            this.label_diplay_message.Size = new System.Drawing.Size(528, 114);
            this.label_diplay_message.TabIndex = 1;
            this.label_diplay_message.Text = "00 : 00 : 00";
            this.label_diplay_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReminderMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 225);
            this.Controls.Add(this.label_diplay_message);
            this.Controls.Add(this.labe1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReminderMessageForm";
            this.Text = "Reminder Message";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReminderMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label_diplay_message;
    }
}
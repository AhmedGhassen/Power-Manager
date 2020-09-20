namespace PowerManager.Forms
{
    partial class ClosingAlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClosingAlertForm));
            this.label_action = new System.Windows.Forms.Label();
            this.label_time_remaing = new System.Windows.Forms.Label();
            this.label_press = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_action
            // 
            this.label_action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label_action.Location = new System.Drawing.Point(17, 10);
            this.label_action.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_action.Name = "label_action";
            this.label_action.Size = new System.Drawing.Size(454, 39);
            this.label_action.TabIndex = 0;
            this.label_action.Text = "Computer will {action} in :";
            this.label_action.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_time_remaing
            // 
            this.label_time_remaing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time_remaing.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.label_time_remaing.Location = new System.Drawing.Point(12, 49);
            this.label_time_remaing.Name = "label_time_remaing";
            this.label_time_remaing.Size = new System.Drawing.Size(459, 105);
            this.label_time_remaing.TabIndex = 1;
            this.label_time_remaing.Text = "59 s";
            this.label_time_remaing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_press
            // 
            this.label_press.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_press.ForeColor = System.Drawing.Color.Red;
            this.label_press.Location = new System.Drawing.Point(19, 166);
            this.label_press.Name = "label_press";
            this.label_press.Size = new System.Drawing.Size(452, 31);
            this.label_press.TabIndex = 2;
            this.label_press.Text = "Press any key to cancel";
            this.label_press.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_press.Click += new System.EventHandler(this.label_press_Click);
            // 
            // ClosingAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 206);
            this.Controls.Add(this.label_press);
            this.Controls.Add(this.label_time_remaing);
            this.Controls.Add(this.label_action);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClosingAlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Manager | Closing Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClosingAlertForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_action;
        private System.Windows.Forms.Label label_time_remaing;
        private System.Windows.Forms.Label label_press;
    }
}
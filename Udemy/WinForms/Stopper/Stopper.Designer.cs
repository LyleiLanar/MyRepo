
namespace Stopper
{
    partial class Stopper
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
            this.TxtStartTime = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblStartTime = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.TxtEndTime = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblEllapsedTime = new System.Windows.Forms.Label();
            this.TxtEllapsedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtStartTime
            // 
            this.TxtStartTime.Location = new System.Drawing.Point(177, 12);
            this.TxtStartTime.Name = "TxtStartTime";
            this.TxtStartTime.ReadOnly = true;
            this.TxtStartTime.Size = new System.Drawing.Size(100, 20);
            this.TxtStartTime.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Location = new System.Drawing.Point(113, 15);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(58, 13);
            this.LblStartTime.TabIndex = 2;
            this.LblStartTime.Text = "Start Time:";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(12, 41);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "S&top";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Location = new System.Drawing.Point(113, 46);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(55, 13);
            this.LblEndTime.TabIndex = 4;
            this.LblEndTime.Text = "End Time:";
            // 
            // TxtEndTime
            // 
            this.TxtEndTime.Location = new System.Drawing.Point(177, 43);
            this.TxtEndTime.Name = "TxtEndTime";
            this.TxtEndTime.ReadOnly = true;
            this.TxtEndTime.Size = new System.Drawing.Size(100, 20);
            this.TxtEndTime.TabIndex = 5;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 70);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblEllapsedTime
            // 
            this.LblEllapsedTime.AutoSize = true;
            this.LblEllapsedTime.Location = new System.Drawing.Point(113, 75);
            this.LblEllapsedTime.Name = "LblEllapsedTime";
            this.LblEllapsedTime.Size = new System.Drawing.Size(50, 13);
            this.LblEllapsedTime.TabIndex = 7;
            this.LblEllapsedTime.Text = "Ellapsed:";
            // 
            // TxtEllapsedTime
            // 
            this.TxtEllapsedTime.Location = new System.Drawing.Point(177, 70);
            this.TxtEllapsedTime.Name = "TxtEllapsedTime";
            this.TxtEllapsedTime.ReadOnly = true;
            this.TxtEllapsedTime.Size = new System.Drawing.Size(100, 20);
            this.TxtEllapsedTime.TabIndex = 8;
            // 
            // Stopper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 115);
            this.Controls.Add(this.TxtEllapsedTime);
            this.Controls.Add(this.LblEllapsedTime);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtEndTime);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.LblStartTime);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtStartTime);
            this.Name = "Stopper";
            this.Text = "Stopper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtStartTime;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.TextBox TxtEndTime;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblEllapsedTime;
        private System.Windows.Forms.TextBox TxtEllapsedTime;
    }
}



namespace TorpTarnak
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
            this.label_torpokSzama = new System.Windows.Forms.Label();
            this.textBox_torpokSzama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_torpokSzama
            // 
            this.label_torpokSzama.AutoSize = true;
            this.label_torpokSzama.Location = new System.Drawing.Point(34, 40);
            this.label_torpokSzama.Name = "label_torpokSzama";
            this.label_torpokSzama.Size = new System.Drawing.Size(77, 13);
            this.label_torpokSzama.TabIndex = 0;
            this.label_torpokSzama.Text = "Törpök száma:";
            // 
            // textBox_torpokSzama
            // 
            this.textBox_torpokSzama.Location = new System.Drawing.Point(117, 37);
            this.textBox_torpokSzama.Multiline = true;
            this.textBox_torpokSzama.Name = "textBox_torpokSzama";
            this.textBox_torpokSzama.ReadOnly = true;
            this.textBox_torpokSzama.Size = new System.Drawing.Size(242, 148);
            this.textBox_torpokSzama.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 537);
            this.Controls.Add(this.textBox_torpokSzama);
            this.Controls.Add(this.label_torpokSzama);
            this.Name = "MainForm";
            this.Text = "Törp tárnák";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_torpokSzama;
        private System.Windows.Forms.TextBox textBox_torpokSzama;
    }
}


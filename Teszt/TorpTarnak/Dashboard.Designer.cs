
namespace TorpTarnak
{
    partial class Dashboard
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
            this.ListBox_Entities = new System.Windows.Forms.ListBox();
            this.ComboBox_Entities = new System.Windows.Forms.ComboBox();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.textBox_SearchField = new System.Windows.Forms.TextBox();
            this.lbl_SearchField = new System.Windows.Forms.Label();
            this.button_SrchOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_Entities
            // 
            this.ListBox_Entities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBox_Entities.FormattingEnabled = true;
            this.ListBox_Entities.Location = new System.Drawing.Point(12, 45);
            this.ListBox_Entities.Name = "ListBox_Entities";
            this.ListBox_Entities.Size = new System.Drawing.Size(120, 537);
            this.ListBox_Entities.TabIndex = 0;
            this.ListBox_Entities.SelectedValueChanged += new System.EventHandler(this.ListBox_Entities_SelectedValueChanged);
            // 
            // ComboBox_Entities
            // 
            this.ComboBox_Entities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Entities.FormattingEnabled = true;
            this.ComboBox_Entities.Location = new System.Drawing.Point(12, 12);
            this.ComboBox_Entities.Name = "ComboBox_Entities";
            this.ComboBox_Entities.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Entities.TabIndex = 2;
            this.ComboBox_Entities.SelectedValueChanged += new System.EventHandler(this.ComboBox_Entities_SelectedValueChanged);
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Details.Location = new System.Drawing.Point(142, 45);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(266, 508);
            this.groupBox_Details.TabIndex = 3;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Text = "Details";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(295, 559);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(52, 23);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // Btn_New
            // 
            this.Btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_New.Location = new System.Drawing.Point(353, 559);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(52, 23);
            this.Btn_New.TabIndex = 6;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete.Location = new System.Drawing.Point(142, 559);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(52, 23);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // textBox_SearchField
            // 
            this.textBox_SearchField.Location = new System.Drawing.Point(186, 12);
            this.textBox_SearchField.Name = "textBox_SearchField";
            this.textBox_SearchField.Size = new System.Drawing.Size(108, 20);
            this.textBox_SearchField.TabIndex = 8;
            // 
            // lbl_SearchField
            // 
            this.lbl_SearchField.AutoSize = true;
            this.lbl_SearchField.Location = new System.Drawing.Point(139, 15);
            this.lbl_SearchField.Name = "lbl_SearchField";
            this.lbl_SearchField.Size = new System.Drawing.Size(41, 13);
            this.lbl_SearchField.TabIndex = 9;
            this.lbl_SearchField.Text = "Search";
            // 
            // button_SrchOk
            // 
            this.button_SrchOk.Location = new System.Drawing.Point(300, 10);
            this.button_SrchOk.Name = "button_SrchOk";
            this.button_SrchOk.Size = new System.Drawing.Size(52, 23);
            this.button_SrchOk.TabIndex = 10;
            this.button_SrchOk.Text = "OK";
            this.button_SrchOk.UseVisualStyleBackColor = true;
            this.button_SrchOk.Click += new System.EventHandler(this.button_SrchOk_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 608);
            this.Controls.Add(this.button_SrchOk);
            this.Controls.Add(this.lbl_SearchField);
            this.Controls.Add(this.textBox_SearchField);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.ComboBox_Entities);
            this.Controls.Add(this.ListBox_Entities);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Entities;
        private System.Windows.Forms.ComboBox ComboBox_Entities;
        private System.Windows.Forms.GroupBox groupBox_Details;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox textBox_SearchField;
        private System.Windows.Forms.Label lbl_SearchField;
        private System.Windows.Forms.Button button_SrchOk;
    }
}



namespace TorpTarnak_V2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.torpetarnaDataSet = new TorpTarnak_V2.torpetarnaDataSet();
            this.torpekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torpekTableAdapter = new TorpTarnak_V2.torpetarnaDataSetTableAdapters.torpekTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magassagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpetarnaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.klanDataGridViewTextBoxColumn,
            this.nemDataGridViewTextBoxColumn,
            this.sulyDataGridViewTextBoxColumn,
            this.magassagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.torpekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // torpetarnaDataSet
            // 
            this.torpetarnaDataSet.DataSetName = "torpetarnaDataSet";
            this.torpetarnaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // torpekBindingSource
            // 
            this.torpekBindingSource.DataMember = "torpek";
            this.torpekBindingSource.DataSource = this.torpetarnaDataSet;
            // 
            // torpekTableAdapter
            // 
            this.torpekTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // klanDataGridViewTextBoxColumn
            // 
            this.klanDataGridViewTextBoxColumn.DataPropertyName = "klan";
            this.klanDataGridViewTextBoxColumn.HeaderText = "klan";
            this.klanDataGridViewTextBoxColumn.Name = "klanDataGridViewTextBoxColumn";
            // 
            // nemDataGridViewTextBoxColumn
            // 
            this.nemDataGridViewTextBoxColumn.DataPropertyName = "nem";
            this.nemDataGridViewTextBoxColumn.HeaderText = "nem";
            this.nemDataGridViewTextBoxColumn.Name = "nemDataGridViewTextBoxColumn";
            // 
            // sulyDataGridViewTextBoxColumn
            // 
            this.sulyDataGridViewTextBoxColumn.DataPropertyName = "suly";
            this.sulyDataGridViewTextBoxColumn.HeaderText = "suly";
            this.sulyDataGridViewTextBoxColumn.Name = "sulyDataGridViewTextBoxColumn";
            // 
            // magassagDataGridViewTextBoxColumn
            // 
            this.magassagDataGridViewTextBoxColumn.DataPropertyName = "magassag";
            this.magassagDataGridViewTextBoxColumn.HeaderText = "magassag";
            this.magassagDataGridViewTextBoxColumn.Name = "magassagDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpetarnaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private torpetarnaDataSet torpetarnaDataSet;
        private System.Windows.Forms.BindingSource torpekBindingSource;
        private torpetarnaDataSetTableAdapters.torpekTableAdapter torpekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magassagDataGridViewTextBoxColumn;
    }
}


namespace infoApp
{
    partial class atwork_record
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
            this.qRScannerDataSet1 = new infoApp.QRScannerDataSet1();
            this.qRScannerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qRScannerDataSet2 = new infoApp.QRScannerDataSet2();
            this.aTWORKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTWORKTableAdapter = new infoApp.QRScannerDataSet2TableAdapters.ATWORKTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERSONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.qRScannerDataSet3 = new infoApp.QRScannerDataSet3();
            this.rECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rECORDSTableAdapter = new infoApp.QRScannerDataSet3TableAdapters.RECORDSTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERSONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTERDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEAVEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qRScannerDataSet4 = new infoApp.QRScannerDataSet4();
            this.aTWORKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aTWORKTableAdapter1 = new infoApp.QRScannerDataSet4TableAdapters.ATWORKTableAdapter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDPERSONDataGridViewTextBoxColumn,
            this.eNTERDataGridViewTextBoxColumn,
            this.lEAVEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTWORKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(262, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // qRScannerDataSet1
            // 
            this.qRScannerDataSet1.DataSetName = "QRScannerDataSet1";
            this.qRScannerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qRScannerDataSet1BindingSource
            // 
            this.qRScannerDataSet1BindingSource.DataSource = this.qRScannerDataSet1;
            this.qRScannerDataSet1BindingSource.Position = 0;
            // 
            // qRScannerDataSet2
            // 
            this.qRScannerDataSet2.DataSetName = "QRScannerDataSet2";
            this.qRScannerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTWORKBindingSource
            // 
            this.aTWORKBindingSource.DataMember = "ATWORK";
            this.aTWORKBindingSource.DataSource = this.qRScannerDataSet2;
            // 
            // aTWORKTableAdapter
            // 
            this.aTWORKTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPERSONDataGridViewTextBoxColumn
            // 
            this.iDPERSONDataGridViewTextBoxColumn.DataPropertyName = "ID_PERSON";
            this.iDPERSONDataGridViewTextBoxColumn.HeaderText = "ID_PERSON";
            this.iDPERSONDataGridViewTextBoxColumn.Name = "iDPERSONDataGridViewTextBoxColumn";
            // 
            // eNTERDataGridViewTextBoxColumn
            // 
            this.eNTERDataGridViewTextBoxColumn.DataPropertyName = "ENTER";
            this.eNTERDataGridViewTextBoxColumn.HeaderText = "ENTER";
            this.eNTERDataGridViewTextBoxColumn.Name = "eNTERDataGridViewTextBoxColumn";
            // 
            // lEAVEDataGridViewTextBoxColumn
            // 
            this.lEAVEDataGridViewTextBoxColumn.DataPropertyName = "LEAVE";
            this.lEAVEDataGridViewTextBoxColumn.HeaderText = "LEAVE";
            this.lEAVEDataGridViewTextBoxColumn.Name = "lEAVEDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDPERSONDataGridViewTextBoxColumn1,
            this.eNTERDataGridViewTextBoxColumn1,
            this.lEAVEDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.rECORDSBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(262, 219);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // qRScannerDataSet3
            // 
            this.qRScannerDataSet3.DataSetName = "QRScannerDataSet3";
            this.qRScannerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECORDSBindingSource
            // 
            this.rECORDSBindingSource.DataMember = "RECORDS";
            this.rECORDSBindingSource.DataSource = this.qRScannerDataSet3;
            // 
            // rECORDSTableAdapter
            // 
            this.rECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDPERSONDataGridViewTextBoxColumn1
            // 
            this.iDPERSONDataGridViewTextBoxColumn1.DataPropertyName = "ID_PERSON";
            this.iDPERSONDataGridViewTextBoxColumn1.HeaderText = "ID_PERSON";
            this.iDPERSONDataGridViewTextBoxColumn1.Name = "iDPERSONDataGridViewTextBoxColumn1";
            // 
            // eNTERDataGridViewTextBoxColumn1
            // 
            this.eNTERDataGridViewTextBoxColumn1.DataPropertyName = "ENTER";
            this.eNTERDataGridViewTextBoxColumn1.HeaderText = "ENTER";
            this.eNTERDataGridViewTextBoxColumn1.Name = "eNTERDataGridViewTextBoxColumn1";
            // 
            // lEAVEDataGridViewTextBoxColumn1
            // 
            this.lEAVEDataGridViewTextBoxColumn1.DataPropertyName = "LEAVE";
            this.lEAVEDataGridViewTextBoxColumn1.HeaderText = "LEAVE";
            this.lEAVEDataGridViewTextBoxColumn1.Name = "lEAVEDataGridViewTextBoxColumn1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AT WORK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RECORDS";
            // 
            // qRScannerDataSet4
            // 
            this.qRScannerDataSet4.DataSetName = "QRScannerDataSet4";
            this.qRScannerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTWORKBindingSource1
            // 
            this.aTWORKBindingSource1.DataMember = "ATWORK";
            this.aTWORKBindingSource1.DataSource = this.qRScannerDataSet4;
            // 
            // aTWORKTableAdapter1
            // 
            this.aTWORKTableAdapter1.ClearBeforeFill = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 113);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // atwork_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 381);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "atwork_record";
            this.Text = "atwork_record";
            this.Load += new System.EventHandler(this.atwork_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qRScannerDataSet1BindingSource;
        private QRScannerDataSet1 qRScannerDataSet1;
        private QRScannerDataSet2 qRScannerDataSet2;
        private System.Windows.Forms.BindingSource aTWORKBindingSource;
        private QRScannerDataSet2TableAdapters.ATWORKTableAdapter aTWORKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERSONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private QRScannerDataSet3 qRScannerDataSet3;
        private System.Windows.Forms.BindingSource rECORDSBindingSource;
        private QRScannerDataSet3TableAdapters.RECORDSTableAdapter rECORDSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERSONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEAVEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QRScannerDataSet4 qRScannerDataSet4;
        private System.Windows.Forms.BindingSource aTWORKBindingSource1;
        private QRScannerDataSet4TableAdapters.ATWORKTableAdapter aTWORKTableAdapter1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
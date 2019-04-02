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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERSONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTWORKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qRScannerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERSONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTERDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEAVEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aTWORKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.qRScannerDataSet = new infoApp.QRScannerDataSet();
            this.aTWORKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aTWORKTableAdapter2 = new infoApp.QRScannerDataSetTableAdapters.ATWORKTableAdapter();
            this.rECORDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rECORDSTableAdapter1 = new infoApp.QRScannerDataSetTableAdapters.RECORDSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.aTWORKBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(349, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 185);
            this.dataGridView1.TabIndex = 0;
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
            // aTWORKBindingSource
            // 
            this.aTWORKBindingSource.DataMember = "ATWORK";
            // 
            // qRScannerDataSet2
            // 
            // 
            // qRScannerDataSet1
            // 
            // 
            // qRScannerDataSet1BindingSource
            // 
            this.qRScannerDataSet1BindingSource.Position = 0;
            // 
            // aTWORKTableAdapter
            //             // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDPERSONDataGridViewTextBoxColumn1,
            this.eNTERDataGridViewTextBoxColumn1,
            this.lEAVEDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.rECORDSBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(349, 270);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(592, 185);
            this.dataGridView2.TabIndex = 1;
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
            // rECORDSBindingSource
            // 
            this.rECORDSBindingSource.DataMember = "RECORDS";
            // 
            // qRScannerDataSet3
            // 
            // 
            // rECORDSTableAdapter
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "AT WORK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RECORDS";
            // 
            // qRScannerDataSet4
            // 
            // 
            // aTWORKBindingSource1
            // 
            this.aTWORKBindingSource1.DataMember = "ATWORK";
            // 
            // aTWORKTableAdapter1
            // 
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 139);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // qRScannerDataSet
            // 
            this.qRScannerDataSet.DataSetName = "QRScannerDataSet";
            this.qRScannerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTWORKBindingSource2
            // 
            this.aTWORKBindingSource2.DataMember = "ATWORK";
            this.aTWORKBindingSource2.DataSource = this.qRScannerDataSet;
            // 
            // aTWORKTableAdapter2
            // 
            this.aTWORKTableAdapter2.ClearBeforeFill = true;
            // 
            // rECORDSBindingSource1
            // 
            this.rECORDSBindingSource1.DataMember = "RECORDS";
            this.rECORDSBindingSource1.DataSource = this.qRScannerDataSet;
            // 
            // rECORDSTableAdapter1
            // 
            this.rECORDSTableAdapter1.ClearBeforeFill = true;
            // 
            // atwork_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 469);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "atwork_record";
            this.Text = "atwork_record";
            this.Load += new System.EventHandler(this.atwork_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRScannerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTWORKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECORDSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qRScannerDataSet1BindingSource;
        private System.Windows.Forms.BindingSource aTWORKBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERSONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource rECORDSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERSONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEAVEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource aTWORKBindingSource1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private QRScannerDataSet qRScannerDataSet;
        private System.Windows.Forms.BindingSource aTWORKBindingSource2;
        private QRScannerDataSetTableAdapters.ATWORKTableAdapter aTWORKTableAdapter2;
        private System.Windows.Forms.BindingSource rECORDSBindingSource1;
        private QRScannerDataSetTableAdapters.RECORDSTableAdapter rECORDSTableAdapter1;
    }
}
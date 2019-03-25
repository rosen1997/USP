namespace QRScan
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
            this.CMB_cameras = new System.Windows.Forms.ComboBox();
            this.BTN_start = new System.Windows.Forms.Button();
            this.BTN_stop = new System.Windows.Forms.Button();
            this.BTN_scan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_test = new System.Windows.Forms.Label();
            this.BTN_startCapturing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CMB_cameras
            // 
            this.CMB_cameras.FormattingEnabled = true;
            this.CMB_cameras.Location = new System.Drawing.Point(263, 15);
            this.CMB_cameras.Name = "CMB_cameras";
            this.CMB_cameras.Size = new System.Drawing.Size(121, 24);
            this.CMB_cameras.TabIndex = 0;
            // 
            // BTN_start
            // 
            this.BTN_start.Location = new System.Drawing.Point(263, 55);
            this.BTN_start.Name = "BTN_start";
            this.BTN_start.Size = new System.Drawing.Size(121, 28);
            this.BTN_start.TabIndex = 1;
            this.BTN_start.Text = "Start camera";
            this.BTN_start.UseVisualStyleBackColor = true;
            this.BTN_start.Click += new System.EventHandler(this.BTN_start_Click);
            // 
            // BTN_stop
            // 
            this.BTN_stop.Location = new System.Drawing.Point(263, 84);
            this.BTN_stop.Name = "BTN_stop";
            this.BTN_stop.Size = new System.Drawing.Size(121, 28);
            this.BTN_stop.TabIndex = 2;
            this.BTN_stop.Text = "Stop camera";
            this.BTN_stop.UseVisualStyleBackColor = true;
            this.BTN_stop.Click += new System.EventHandler(this.BTN_stop_Click);
            // 
            // BTN_scan
            // 
            this.BTN_scan.Location = new System.Drawing.Point(263, 451);
            this.BTN_scan.Name = "BTN_scan";
            this.BTN_scan.Size = new System.Drawing.Size(121, 23);
            this.BTN_scan.TabIndex = 3;
            this.BTN_scan.Text = "Scan";
            this.BTN_scan.UseVisualStyleBackColor = true;
            this.BTN_scan.Click += new System.EventHandler(this.BTN_scan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_test
            // 
            this.LBL_test.AutoSize = true;
            this.LBL_test.Location = new System.Drawing.Point(35, 30);
            this.LBL_test.Name = "LBL_test";
            this.LBL_test.Size = new System.Drawing.Size(46, 17);
            this.LBL_test.TabIndex = 5;
            this.LBL_test.Text = "label1";
            // 
            // BTN_startCapturing
            // 
            this.BTN_startCapturing.Location = new System.Drawing.Point(497, 84);
            this.BTN_startCapturing.Name = "BTN_startCapturing";
            this.BTN_startCapturing.Size = new System.Drawing.Size(117, 28);
            this.BTN_startCapturing.TabIndex = 6;
            this.BTN_startCapturing.Text = "Start Capturing";
            this.BTN_startCapturing.UseVisualStyleBackColor = true;
            this.BTN_startCapturing.Click += new System.EventHandler(this.BTN_startCapturing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 514);
            this.Controls.Add(this.BTN_startCapturing);
            this.Controls.Add(this.LBL_test);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_scan);
            this.Controls.Add(this.BTN_stop);
            this.Controls.Add(this.BTN_start);
            this.Controls.Add(this.CMB_cameras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_cameras;
        private System.Windows.Forms.Button BTN_start;
        private System.Windows.Forms.Button BTN_stop;
        private System.Windows.Forms.Button BTN_scan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_test;
        private System.Windows.Forms.Button BTN_startCapturing;
    }
}


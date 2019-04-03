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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CMB_cameras = new System.Windows.Forms.ComboBox();
            this.BTN_start = new System.Windows.Forms.Button();
            this.BTN_stop = new System.Windows.Forms.Button();
            this.BTN_scan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_startCapturing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CMB_cameras
            // 
            this.CMB_cameras.FormattingEnabled = true;
            this.CMB_cameras.Location = new System.Drawing.Point(62, 309);
            this.CMB_cameras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_cameras.Name = "CMB_cameras";
            this.CMB_cameras.Size = new System.Drawing.Size(92, 21);
            this.CMB_cameras.TabIndex = 0;
            // 
            // BTN_start
            // 
            this.BTN_start.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_start.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_start.Location = new System.Drawing.Point(224, 277);
            this.BTN_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_start.Name = "BTN_start";
            this.BTN_start.Size = new System.Drawing.Size(102, 44);
            this.BTN_start.TabIndex = 1;
            this.BTN_start.Text = "Start camera";
            this.BTN_start.UseVisualStyleBackColor = false;
            this.BTN_start.Click += new System.EventHandler(this.BTN_start_Click);
            // 
            // BTN_stop
            // 
            this.BTN_stop.BackColor = System.Drawing.Color.Pink;
            this.BTN_stop.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_stop.Location = new System.Drawing.Point(346, 277);
            this.BTN_stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_stop.Name = "BTN_stop";
            this.BTN_stop.Size = new System.Drawing.Size(108, 44);
            this.BTN_stop.TabIndex = 2;
            this.BTN_stop.Text = "Stop camera";
            this.BTN_stop.UseVisualStyleBackColor = false;
            this.BTN_stop.Click += new System.EventHandler(this.BTN_stop_Click);
            // 
            // BTN_scan
            // 
            this.BTN_scan.Location = new System.Drawing.Point(2, 398);
            this.BTN_scan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_scan.Name = "BTN_scan";
            this.BTN_scan.Size = new System.Drawing.Size(91, 19);
            this.BTN_scan.TabIndex = 3;
            this.BTN_scan.Text = "Scan";
            this.BTN_scan.UseVisualStyleBackColor = true;
            this.BTN_scan.Visible = false;
            this.BTN_scan.Click += new System.EventHandler(this.BTN_scan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_startCapturing
            // 
            this.BTN_startCapturing.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_startCapturing.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_startCapturing.Location = new System.Drawing.Point(62, 351);
            this.BTN_startCapturing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_startCapturing.Name = "BTN_startCapturing";
            this.BTN_startCapturing.Size = new System.Drawing.Size(108, 33);
            this.BTN_startCapturing.TabIndex = 6;
            this.BTN_startCapturing.Text = "Start Capturing";
            this.BTN_startCapturing.UseVisualStyleBackColor = false;
            this.BTN_startCapturing.Click += new System.EventHandler(this.BTN_startCapturing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select camera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_startCapturing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_scan);
            this.Controls.Add(this.BTN_stop);
            this.Controls.Add(this.BTN_start);
            this.Controls.Add(this.CMB_cameras);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button BTN_startCapturing;
        private System.Windows.Forms.Label label1;
    }
}


namespace OOP
{
    partial class frmDaq
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
            this.txtSampling = new System.Windows.Forms.TextBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSampling = new System.Windows.Forms.GroupBox();
            this.btnSampling = new System.Windows.Forms.Button();
            this.lblSampling = new System.Windows.Forms.Label();
            this.grpLogging = new System.Windows.Forms.GroupBox();
            this.btnLogging = new System.Windows.Forms.Button();
            this.lblLogging = new System.Windows.Forms.Label();
            this.txtLogging = new System.Windows.Forms.TextBox();
            this.txtSensors = new System.Windows.Forms.TextBox();
            this.grpSensor = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumbLog = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            this.grpSampling.SuspendLayout();
            this.grpLogging.SuspendLayout();
            this.grpSensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSampling
            // 
            this.txtSampling.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSampling.Location = new System.Drawing.Point(140, 37);
            this.txtSampling.Name = "txtSampling";
            this.txtSampling.Size = new System.Drawing.Size(169, 22);
            this.txtSampling.TabIndex = 0;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(668, 28);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // grpSampling
            // 
            this.grpSampling.Controls.Add(this.btnSampling);
            this.grpSampling.Controls.Add(this.lblSampling);
            this.grpSampling.Controls.Add(this.txtSampling);
            this.grpSampling.Location = new System.Drawing.Point(12, 51);
            this.grpSampling.Name = "grpSampling";
            this.grpSampling.Size = new System.Drawing.Size(309, 104);
            this.grpSampling.TabIndex = 2;
            this.grpSampling.TabStop = false;
            this.grpSampling.Text = "Sampling";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(26, 69);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(81, 29);
            this.btnSampling.TabIndex = 2;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(6, 37);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(133, 17);
            this.lblSampling.TabIndex = 1;
            this.lblSampling.Text = "Next Sampling Time";
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.btnLogging);
            this.grpLogging.Controls.Add(this.lblLogging);
            this.grpLogging.Controls.Add(this.txtLogging);
            this.grpLogging.Location = new System.Drawing.Point(12, 177);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Size = new System.Drawing.Size(309, 104);
            this.grpLogging.TabIndex = 3;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(26, 67);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(113, 31);
            this.btnLogging.TabIndex = 2;
            this.btnLogging.Text = "Logging on file";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.Location = new System.Drawing.Point(7, 32);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(130, 17);
            this.lblLogging.TabIndex = 1;
            this.lblLogging.Text = "Next Logging Time ";
            // 
            // txtLogging
            // 
            this.txtLogging.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLogging.Location = new System.Drawing.Point(143, 32);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.Size = new System.Drawing.Size(166, 22);
            this.txtLogging.TabIndex = 0;
            // 
            // txtSensors
            // 
            this.txtSensors.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSensors.Location = new System.Drawing.Point(6, 16);
            this.txtSensors.Multiline = true;
            this.txtSensors.Name = "txtSensors";
            this.txtSensors.Size = new System.Drawing.Size(278, 208);
            this.txtSensors.TabIndex = 4;
            // 
            // grpSensor
            // 
            this.grpSensor.Controls.Add(this.txtSensors);
            this.grpSensor.Location = new System.Drawing.Point(347, 51);
            this.grpSensor.Name = "grpSensor";
            this.grpSensor.Size = new System.Drawing.Size(290, 230);
            this.grpSensor.TabIndex = 5;
            this.grpSensor.TabStop = false;
            this.grpSensor.Text = "Sensor Values";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(72, 291);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(46, 17);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nummbers of logging";
            // 
            // lblNumbLog
            // 
            this.lblNumbLog.AutoSize = true;
            this.lblNumbLog.Location = new System.Drawing.Point(444, 291);
            this.lblNumbLog.Name = "lblNumbLog";
            this.lblNumbLog.Size = new System.Drawing.Size(46, 17);
            this.lblNumbLog.TabIndex = 8;
            this.lblNumbLog.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "File:";
            // 
            // frmDaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumbLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.grpSensor);
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.grpSampling);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmDaq";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DAQ Simulator";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.grpSampling.ResumeLayout(false);
            this.grpSampling.PerformLayout();
            this.grpLogging.ResumeLayout(false);
            this.grpLogging.PerformLayout();
            this.grpSensor.ResumeLayout(false);
            this.grpSensor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSampling;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSampling;
        private System.Windows.Forms.GroupBox grpLogging;
        private System.Windows.Forms.TextBox txtLogging;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.Label lblLogging;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.TextBox txtSensors;
        private System.Windows.Forms.GroupBox grpSensor;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumbLog;
        private System.Windows.Forms.Label label4;
    }
}


namespace ShiaiTimer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.whitePoints = new System.Windows.Forms.TableLayoutPanel();
            this.whiteFaultButton = new System.Windows.Forms.Button();
            this.whitePointButton = new System.Windows.Forms.Button();
            this.whiteOsaekomiButton = new System.Windows.Forms.Button();
            this.bluePoints = new System.Windows.Forms.TableLayoutPanel();
            this.bluefaultButton = new System.Windows.Forms.Button();
            this.bluePointButton = new System.Windows.Forms.Button();
            this.blueOsaekomiButton = new System.Windows.Forms.Button();
            this.pointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.blueFaultLabel = new System.Windows.Forms.Label();
            this.whitePointLabel = new System.Windows.Forms.Label();
            this.bluePointLabel = new System.Windows.Forms.Label();
            this.whiteOsaekomiLabel = new System.Windows.Forms.Label();
            this.whiteFaultLabel = new System.Windows.Forms.Label();
            this.blueOsaekomiLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.matchTimeLabel = new System.Windows.Forms.Label();
            this.startTimeButton = new System.Windows.Forms.Button();
            this.matchTimer = new System.Windows.Forms.Timer(this.components);
            this.whiteOsaekomiTimer = new System.Windows.Forms.Timer(this.components);
            this.blueOsaekomiTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.whitePoints.SuspendLayout();
            this.bluePoints.SuspendLayout();
            this.pointPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.whitePoints, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bluePoints, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pointPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(375, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 124);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // whitePoints
            // 
            this.whitePoints.ColumnCount = 1;
            this.whitePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.whitePoints.Controls.Add(this.whiteFaultButton, 0, 2);
            this.whitePoints.Controls.Add(this.whitePointButton, 0, 0);
            this.whitePoints.Controls.Add(this.whiteOsaekomiButton, 0, 1);
            this.whitePoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitePoints.Location = new System.Drawing.Point(3, 133);
            this.whitePoints.Name = "whitePoints";
            this.whitePoints.RowCount = 3;
            this.whitePoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.whitePoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.whitePoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.whitePoints.Size = new System.Drawing.Size(118, 125);
            this.whitePoints.TabIndex = 2;
            // 
            // whiteFaultButton
            // 
            this.whiteFaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whiteFaultButton.Location = new System.Drawing.Point(40, 85);
            this.whiteFaultButton.Name = "whiteFaultButton";
            this.whiteFaultButton.Size = new System.Drawing.Size(75, 21);
            this.whiteFaultButton.TabIndex = 2;
            this.whiteFaultButton.Text = "Fault";
            this.whiteFaultButton.UseVisualStyleBackColor = true;
            // 
            // whitePointButton
            // 
            this.whitePointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whitePointButton.Location = new System.Drawing.Point(40, 3);
            this.whitePointButton.Name = "whitePointButton";
            this.whitePointButton.Size = new System.Drawing.Size(75, 23);
            this.whitePointButton.TabIndex = 0;
            this.whitePointButton.Text = "Point";
            this.whitePointButton.UseVisualStyleBackColor = true;
            this.whitePointButton.Click += new System.EventHandler(this.whitePointButton_Click);
            // 
            // whiteOsaekomiButton
            // 
            this.whiteOsaekomiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whiteOsaekomiButton.Location = new System.Drawing.Point(40, 44);
            this.whiteOsaekomiButton.Name = "whiteOsaekomiButton";
            this.whiteOsaekomiButton.Size = new System.Drawing.Size(75, 23);
            this.whiteOsaekomiButton.TabIndex = 1;
            this.whiteOsaekomiButton.Text = "Osaekomi";
            this.whiteOsaekomiButton.UseVisualStyleBackColor = true;
            this.whiteOsaekomiButton.Click += new System.EventHandler(this.whiteOsaekomiButton_Click);
            // 
            // bluePoints
            // 
            this.bluePoints.ColumnCount = 1;
            this.bluePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bluePoints.Controls.Add(this.bluefaultButton, 0, 2);
            this.bluePoints.Controls.Add(this.bluePointButton, 0, 0);
            this.bluePoints.Controls.Add(this.blueOsaekomiButton, 0, 1);
            this.bluePoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bluePoints.Location = new System.Drawing.Point(375, 133);
            this.bluePoints.Name = "bluePoints";
            this.bluePoints.RowCount = 3;
            this.bluePoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.63153F));
            this.bluePoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.18423F));
            this.bluePoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.18423F));
            this.bluePoints.Size = new System.Drawing.Size(119, 125);
            this.bluePoints.TabIndex = 3;
            // 
            // bluefaultButton
            // 
            this.bluefaultButton.Location = new System.Drawing.Point(3, 86);
            this.bluefaultButton.Name = "bluefaultButton";
            this.bluefaultButton.Size = new System.Drawing.Size(75, 23);
            this.bluefaultButton.TabIndex = 3;
            this.bluefaultButton.Text = "Fault";
            this.bluefaultButton.UseVisualStyleBackColor = true;
            // 
            // bluePointButton
            // 
            this.bluePointButton.Location = new System.Drawing.Point(3, 3);
            this.bluePointButton.Name = "bluePointButton";
            this.bluePointButton.Size = new System.Drawing.Size(75, 23);
            this.bluePointButton.TabIndex = 1;
            this.bluePointButton.Text = "Point";
            this.bluePointButton.UseVisualStyleBackColor = true;
            this.bluePointButton.Click += new System.EventHandler(this.bluePointButton_Click);
            // 
            // blueOsaekomiButton
            // 
            this.blueOsaekomiButton.Location = new System.Drawing.Point(3, 45);
            this.blueOsaekomiButton.Name = "blueOsaekomiButton";
            this.blueOsaekomiButton.Size = new System.Drawing.Size(75, 23);
            this.blueOsaekomiButton.TabIndex = 2;
            this.blueOsaekomiButton.Text = "Osaekomi";
            this.blueOsaekomiButton.UseVisualStyleBackColor = true;
            this.blueOsaekomiButton.Click += new System.EventHandler(this.blueOsaekomiButton_Click);
            // 
            // pointPanel
            // 
            this.pointPanel.ColumnCount = 2;
            this.pointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pointPanel.Controls.Add(this.blueFaultLabel, 1, 2);
            this.pointPanel.Controls.Add(this.whitePointLabel, 0, 0);
            this.pointPanel.Controls.Add(this.bluePointLabel, 1, 0);
            this.pointPanel.Controls.Add(this.whiteOsaekomiLabel, 0, 1);
            this.pointPanel.Controls.Add(this.whiteFaultLabel, 0, 2);
            this.pointPanel.Controls.Add(this.blueOsaekomiLabel, 1, 1);
            this.pointPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointPanel.Location = new System.Drawing.Point(127, 133);
            this.pointPanel.Name = "pointPanel";
            this.pointPanel.RowCount = 3;
            this.pointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pointPanel.Size = new System.Drawing.Size(242, 125);
            this.pointPanel.TabIndex = 4;
            // 
            // blueFaultLabel
            // 
            this.blueFaultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueFaultLabel.AutoSize = true;
            this.blueFaultLabel.Location = new System.Drawing.Point(204, 82);
            this.blueFaultLabel.Name = "blueFaultLabel";
            this.blueFaultLabel.Size = new System.Drawing.Size(35, 13);
            this.blueFaultLabel.TabIndex = 5;
            this.blueFaultLabel.Text = "label4";
            // 
            // whitePointLabel
            // 
            this.whitePointLabel.AutoSize = true;
            this.whitePointLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitePointLabel.Location = new System.Drawing.Point(3, 0);
            this.whitePointLabel.Name = "whitePointLabel";
            this.whitePointLabel.Size = new System.Drawing.Size(115, 41);
            this.whitePointLabel.TabIndex = 0;
            this.whitePointLabel.Text = "0 0 0";
            // 
            // bluePointLabel
            // 
            this.bluePointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bluePointLabel.AutoSize = true;
            this.bluePointLabel.Location = new System.Drawing.Point(208, 0);
            this.bluePointLabel.Name = "bluePointLabel";
            this.bluePointLabel.Size = new System.Drawing.Size(31, 13);
            this.bluePointLabel.TabIndex = 1;
            this.bluePointLabel.Text = "0 0 0";
            // 
            // whiteOsaekomiLabel
            // 
            this.whiteOsaekomiLabel.AutoSize = true;
            this.whiteOsaekomiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteOsaekomiLabel.Location = new System.Drawing.Point(3, 41);
            this.whiteOsaekomiLabel.Name = "whiteOsaekomiLabel";
            this.whiteOsaekomiLabel.Size = new System.Drawing.Size(115, 41);
            this.whiteOsaekomiLabel.TabIndex = 2;
            this.whiteOsaekomiLabel.Text = "0";
            // 
            // whiteFaultLabel
            // 
            this.whiteFaultLabel.AutoSize = true;
            this.whiteFaultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteFaultLabel.Location = new System.Drawing.Point(3, 82);
            this.whiteFaultLabel.Name = "whiteFaultLabel";
            this.whiteFaultLabel.Size = new System.Drawing.Size(115, 43);
            this.whiteFaultLabel.TabIndex = 3;
            this.whiteFaultLabel.Text = "label2";
            // 
            // blueOsaekomiLabel
            // 
            this.blueOsaekomiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueOsaekomiLabel.AutoSize = true;
            this.blueOsaekomiLabel.Location = new System.Drawing.Point(226, 41);
            this.blueOsaekomiLabel.Name = "blueOsaekomiLabel";
            this.blueOsaekomiLabel.Size = new System.Drawing.Size(13, 13);
            this.blueOsaekomiLabel.TabIndex = 4;
            this.blueOsaekomiLabel.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.matchTimeLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.startTimeButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 124);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // matchTimeLabel
            // 
            this.matchTimeLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.matchTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.matchTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.matchTimeLabel.Name = "matchTimeLabel";
            this.matchTimeLabel.Size = new System.Drawing.Size(236, 93);
            this.matchTimeLabel.TabIndex = 0;
            this.matchTimeLabel.Text = "5 : 00";
            this.matchTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTimeButton
            // 
            this.startTimeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimeButton.Location = new System.Drawing.Point(83, 97);
            this.startTimeButton.Name = "startTimeButton";
            this.startTimeButton.Size = new System.Drawing.Size(75, 23);
            this.startTimeButton.TabIndex = 1;
            this.startTimeButton.Text = "start";
            this.startTimeButton.UseVisualStyleBackColor = true;
            this.startTimeButton.Click += new System.EventHandler(this.startTimeButton_Click);
            // 
            // matchTimer
            // 
            this.matchTimer.Interval = 1000;
            this.matchTimer.Tick += new System.EventHandler(this.matchTimer_Tick);
            // 
            // whiteOsaekomiTimer
            // 
            this.whiteOsaekomiTimer.Interval = 1000;
            this.whiteOsaekomiTimer.Tick += new System.EventHandler(this.whiteOsaekomiTimer_Tick);
            // 
            // blueOsaekomiTimer
            // 
            this.blueOsaekomiTimer.Interval = 1000;
            this.blueOsaekomiTimer.Tick += new System.EventHandler(this.blueOsaekomiTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ShiaiTimer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.whitePoints.ResumeLayout(false);
            this.bluePoints.ResumeLayout(false);
            this.pointPanel.ResumeLayout(false);
            this.pointPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel whitePoints;
        private System.Windows.Forms.Button whitePointButton;
        private System.Windows.Forms.Button whiteOsaekomiButton;
        private System.Windows.Forms.Button whiteFaultButton;
        private System.Windows.Forms.TableLayoutPanel bluePoints;
        private System.Windows.Forms.Button bluePointButton;
        private System.Windows.Forms.Button bluefaultButton;
        private System.Windows.Forms.Button blueOsaekomiButton;
        private System.Windows.Forms.TableLayoutPanel pointPanel;
        private System.Windows.Forms.Label whitePointLabel;
        private System.Windows.Forms.Label bluePointLabel;
        private System.Windows.Forms.Timer matchTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label matchTimeLabel;
        private System.Windows.Forms.Button startTimeButton;
        private System.Windows.Forms.Label blueFaultLabel;
        private System.Windows.Forms.Label whiteOsaekomiLabel;
        private System.Windows.Forms.Label whiteFaultLabel;
        private System.Windows.Forms.Label blueOsaekomiLabel;
        private System.Windows.Forms.Timer whiteOsaekomiTimer;
        private System.Windows.Forms.Timer blueOsaekomiTimer;
    }
}


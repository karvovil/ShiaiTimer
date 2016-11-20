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
            this.button3 = new System.Windows.Forms.Button();
            this.whitePointButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bluePoints = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.bluePointButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.whitePointLabel = new System.Windows.Forms.Label();
            this.bluePointLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.matchTimeLabel = new System.Windows.Forms.Label();
            this.startTimeButton = new System.Windows.Forms.Button();
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
            this.whitePoints.Controls.Add(this.button3, 0, 2);
            this.whitePoints.Controls.Add(this.whitePointButton, 0, 0);
            this.whitePoints.Controls.Add(this.button2, 0, 1);
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(40, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // whitePointButton
            // 
            this.whitePointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whitePointButton.Location = new System.Drawing.Point(40, 3);
            this.whitePointButton.Name = "whitePointButton";
            this.whitePointButton.Size = new System.Drawing.Size(75, 23);
            this.whitePointButton.TabIndex = 0;
            this.whitePointButton.Text = "point";
            this.whitePointButton.UseVisualStyleBackColor = true;
            this.whitePointButton.Click += new System.EventHandler(this.whitePointButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(40, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bluePoints
            // 
            this.bluePoints.ColumnCount = 1;
            this.bluePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bluePoints.Controls.Add(this.button6, 0, 2);
            this.bluePoints.Controls.Add(this.bluePointButton, 0, 0);
            this.bluePoints.Controls.Add(this.button5, 0, 1);
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bluePointButton
            // 
            this.bluePointButton.Location = new System.Drawing.Point(3, 3);
            this.bluePointButton.Name = "bluePointButton";
            this.bluePointButton.Size = new System.Drawing.Size(75, 23);
            this.bluePointButton.TabIndex = 1;
            this.bluePointButton.Text = "point";
            this.bluePointButton.UseVisualStyleBackColor = true;
            this.bluePointButton.Click += new System.EventHandler(this.bluePointButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pointPanel
            // 
            this.pointPanel.ColumnCount = 2;
            this.pointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pointPanel.Controls.Add(this.whitePointLabel, 0, 0);
            this.pointPanel.Controls.Add(this.bluePointLabel, 1, 0);
            this.pointPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointPanel.Location = new System.Drawing.Point(127, 133);
            this.pointPanel.Name = "pointPanel";
            this.pointPanel.RowCount = 1;
            this.pointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.pointPanel.Size = new System.Drawing.Size(242, 125);
            this.pointPanel.TabIndex = 4;
            // 
            // whitePointLabel
            // 
            this.whitePointLabel.AutoSize = true;
            this.whitePointLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitePointLabel.Location = new System.Drawing.Point(3, 0);
            this.whitePointLabel.Name = "whitePointLabel";
            this.whitePointLabel.Size = new System.Drawing.Size(115, 125);
            this.whitePointLabel.TabIndex = 0;
            this.whitePointLabel.Text = "0";
            // 
            // bluePointLabel
            // 
            this.bluePointLabel.AutoSize = true;
            this.bluePointLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bluePointLabel.Location = new System.Drawing.Point(124, 0);
            this.bluePointLabel.Name = "bluePointLabel";
            this.bluePointLabel.Size = new System.Drawing.Size(115, 125);
            this.bluePointLabel.TabIndex = 1;
            this.bluePointLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.matchTimeLabel.AutoSize = true;
            this.matchTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.matchTimeLabel.Name = "matchTimeLabel";
            this.matchTimeLabel.Size = new System.Drawing.Size(236, 93);
            this.matchTimeLabel.TabIndex = 0;
            this.matchTimeLabel.Text = "label1";
            // 
            // startTimeButton
            // 
            this.startTimeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimeButton.Location = new System.Drawing.Point(83, 97);
            this.startTimeButton.Name = "startTimeButton";
            this.startTimeButton.Size = new System.Drawing.Size(75, 23);
            this.startTimeButton.TabIndex = 1;
            this.startTimeButton.Text = "button1";
            this.startTimeButton.UseVisualStyleBackColor = true;
            this.startTimeButton.Click += new System.EventHandler(this.startTimeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.whitePoints.ResumeLayout(false);
            this.bluePoints.ResumeLayout(false);
            this.pointPanel.ResumeLayout(false);
            this.pointPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel whitePoints;
        private System.Windows.Forms.Button whitePointButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel bluePoints;
        private System.Windows.Forms.Button bluePointButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel pointPanel;
        private System.Windows.Forms.Label whitePointLabel;
        private System.Windows.Forms.Label bluePointLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label matchTimeLabel;
        private System.Windows.Forms.Button startTimeButton;
    }
}


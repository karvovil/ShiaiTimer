namespace ShiaiTimer
{
    partial class PointPopup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.yukoButton = new System.Windows.Forms.Button();
            this.wazaAriButton = new System.Windows.Forms.Button();
            this.ipponButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.yukoButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.wazaAriButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ipponButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(3, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // yukoButton
            // 
            this.yukoButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yukoButton.Location = new System.Drawing.Point(3, 133);
            this.yukoButton.Name = "yukoButton";
            this.yukoButton.Size = new System.Drawing.Size(75, 23);
            this.yukoButton.TabIndex = 2;
            this.yukoButton.Text = "Yuko";
            this.yukoButton.UseVisualStyleBackColor = true;
            this.yukoButton.Click += new System.EventHandler(this.yukoButton_Click);
            // 
            // wazaAriButton
            // 
            this.wazaAriButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.wazaAriButton.Location = new System.Drawing.Point(3, 68);
            this.wazaAriButton.Name = "wazaAriButton";
            this.wazaAriButton.Size = new System.Drawing.Size(75, 23);
            this.wazaAriButton.TabIndex = 1;
            this.wazaAriButton.Text = "Waza-Ari";
            this.wazaAriButton.UseVisualStyleBackColor = true;
            this.wazaAriButton.Click += new System.EventHandler(this.wazaAriButton_Click);
            // 
            // ipponButton
            // 
            this.ipponButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ipponButton.Location = new System.Drawing.Point(3, 3);
            this.ipponButton.Name = "ipponButton";
            this.ipponButton.Size = new System.Drawing.Size(75, 23);
            this.ipponButton.TabIndex = 0;
            this.ipponButton.Text = "Ippon";
            this.ipponButton.UseVisualStyleBackColor = true;
            this.ipponButton.Click += new System.EventHandler(this.ipponButton_Click);
            // 
            // PointPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PointPopup";
            this.Text = "PointPopup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button yukoButton;
        private System.Windows.Forms.Button wazaAriButton;
        private System.Windows.Forms.Button ipponButton;
    }
}
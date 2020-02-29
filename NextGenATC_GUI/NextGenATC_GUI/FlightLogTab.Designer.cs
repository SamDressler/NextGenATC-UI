namespace NextGenATC_GUI
{
    partial class FlightLogTab
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
            this.flightLogTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flightLogInfoLabel = new System.Windows.Forms.Label();
            this.takeoffLandingLogTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.departurePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.flightLogTLPanel.SuspendLayout();
            this.takeoffLandingLogTLPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.departurePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightLogTLPanel
            // 
            this.flightLogTLPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flightLogTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.flightLogTLPanel.ColumnCount = 1;
            this.flightLogTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flightLogTLPanel.Controls.Add(this.flightLogInfoLabel, 0, 0);
            this.flightLogTLPanel.Controls.Add(this.takeoffLandingLogTLPanel, 0, 1);
            this.flightLogTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightLogTLPanel.Location = new System.Drawing.Point(0, 0);
            this.flightLogTLPanel.Name = "flightLogTLPanel";
            this.flightLogTLPanel.RowCount = 2;
            this.flightLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.flightLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.flightLogTLPanel.Size = new System.Drawing.Size(319, 313);
            this.flightLogTLPanel.TabIndex = 1;
            // 
            // flightLogInfoLabel
            // 
            this.flightLogInfoLabel.AutoSize = true;
            this.flightLogInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightLogInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightLogInfoLabel.ForeColor = System.Drawing.Color.White;
            this.flightLogInfoLabel.Location = new System.Drawing.Point(6, 3);
            this.flightLogInfoLabel.Name = "flightLogInfoLabel";
            this.flightLogInfoLabel.Size = new System.Drawing.Size(307, 27);
            this.flightLogInfoLabel.TabIndex = 0;
            this.flightLogInfoLabel.Text = "Airport Flight Log";
            this.flightLogInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeoffLandingLogTLPanel
            // 
            this.takeoffLandingLogTLPanel.BackColor = System.Drawing.Color.Navy;
            this.takeoffLandingLogTLPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.takeoffLandingLogTLPanel.ColumnCount = 1;
            this.takeoffLandingLogTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.takeoffLandingLogTLPanel.Controls.Add(this.panel2, 0, 3);
            this.takeoffLandingLogTLPanel.Controls.Add(this.label1, 0, 0);
            this.takeoffLandingLogTLPanel.Controls.Add(this.departurePanel, 0, 1);
            this.takeoffLandingLogTLPanel.Controls.Add(this.label2, 0, 2);
            this.takeoffLandingLogTLPanel.Location = new System.Drawing.Point(6, 36);
            this.takeoffLandingLogTLPanel.Name = "takeoffLandingLogTLPanel";
            this.takeoffLandingLogTLPanel.RowCount = 4;
            this.takeoffLandingLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.takeoffLandingLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.takeoffLandingLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.takeoffLandingLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.takeoffLandingLogTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.takeoffLandingLogTLPanel.Size = new System.Drawing.Size(307, 271);
            this.takeoffLandingLogTLPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.vScrollBar2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 100);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 27);
            this.panel3.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar2.Enabled = false;
            this.vScrollBar2.Location = new System.Drawing.Point(280, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 100);
            this.vScrollBar2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departures";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departurePanel
            // 
            this.departurePanel.Controls.Add(this.panel1);
            this.departurePanel.Controls.Add(this.vScrollBar1);
            this.departurePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departurePanel.Location = new System.Drawing.Point(3, 33);
            this.departurePanel.Name = "departurePanel";
            this.departurePanel.Size = new System.Drawing.Size(301, 99);
            this.departurePanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 27);
            this.panel1.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Enabled = false;
            this.vScrollBar1.Location = new System.Drawing.Point(280, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 99);
            this.vScrollBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrivals";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlightLogTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 313);
            this.Controls.Add(this.flightLogTLPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightLogTab";
            this.Text = "LogTabcs";
            this.flightLogTLPanel.ResumeLayout(false);
            this.flightLogTLPanel.PerformLayout();
            this.takeoffLandingLogTLPanel.ResumeLayout(false);
            this.takeoffLandingLogTLPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.departurePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label flightLogInfoLabel;
        public System.Windows.Forms.TableLayoutPanel flightLogTLPanel;
        private System.Windows.Forms.TableLayoutPanel takeoffLandingLogTLPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel departurePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}
namespace NextGenATC_GUI
{
    partial class WeatherTab
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
            this.WeatherBaseTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.weatherStatusLabel = new System.Windows.Forms.Label();
            this.weatherInfoTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precipitationPercentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weatherAdvisoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.advisorySeverityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowWeatherOverlayLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WeatherBaseTLPanel.SuspendLayout();
            this.weatherInfoTLPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherBaseTLPanel
            // 
            this.WeatherBaseTLPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeatherBaseTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.WeatherBaseTLPanel.ColumnCount = 1;
            this.WeatherBaseTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WeatherBaseTLPanel.Controls.Add(this.weatherStatusLabel, 0, 0);
            this.WeatherBaseTLPanel.Controls.Add(this.weatherInfoTLPanel, 0, 1);
            this.WeatherBaseTLPanel.Controls.Add(this.ShowWeatherOverlayLabel, 0, 2);
            this.WeatherBaseTLPanel.Location = new System.Drawing.Point(0, 0);
            this.WeatherBaseTLPanel.Name = "WeatherBaseTLPanel";
            this.WeatherBaseTLPanel.RowCount = 3;
            this.WeatherBaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.WeatherBaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.WeatherBaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.WeatherBaseTLPanel.Size = new System.Drawing.Size(319, 311);
            this.WeatherBaseTLPanel.TabIndex = 1;
            // 
            // weatherStatusLabel
            // 
            this.weatherStatusLabel.AutoSize = true;
            this.weatherStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherStatusLabel.ForeColor = System.Drawing.Color.White;
            this.weatherStatusLabel.Location = new System.Drawing.Point(6, 3);
            this.weatherStatusLabel.Name = "weatherStatusLabel";
            this.weatherStatusLabel.Size = new System.Drawing.Size(307, 22);
            this.weatherStatusLabel.TabIndex = 0;
            this.weatherStatusLabel.Text = "Weather Status";
            this.weatherStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherInfoTLPanel
            // 
            this.weatherInfoTLPanel.BackColor = System.Drawing.Color.White;
            this.weatherInfoTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.weatherInfoTLPanel.ColumnCount = 2;
            this.weatherInfoTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.97623F));
            this.weatherInfoTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.02378F));
            this.weatherInfoTLPanel.Controls.Add(this.label7, 1, 2);
            this.weatherInfoTLPanel.Controls.Add(this.label5, 1, 1);
            this.weatherInfoTLPanel.Controls.Add(this.label4, 1, 0);
            this.weatherInfoTLPanel.Controls.Add(this.label2, 0, 2);
            this.weatherInfoTLPanel.Controls.Add(this.precipitationPercentLabel, 0, 0);
            this.weatherInfoTLPanel.Controls.Add(this.label1, 0, 1);
            this.weatherInfoTLPanel.Controls.Add(this.label3, 0, 4);
            this.weatherInfoTLPanel.Controls.Add(this.pictureBox1, 1, 4);
            this.weatherInfoTLPanel.Controls.Add(this.weatherAdvisoryLabel, 0, 5);
            this.weatherInfoTLPanel.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.weatherInfoTLPanel.Location = new System.Drawing.Point(6, 31);
            this.weatherInfoTLPanel.Name = "weatherInfoTLPanel";
            this.weatherInfoTLPanel.RowCount = 6;
            this.weatherInfoTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.weatherInfoTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.weatherInfoTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.weatherInfoTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9403F));
            this.weatherInfoTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0597F));
            this.weatherInfoTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.weatherInfoTLPanel.Size = new System.Drawing.Size(307, 213);
            this.weatherInfoTLPanel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "North";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "12 mph";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "15 %";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wind Direction\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precipitationPercentLabel
            // 
            this.precipitationPercentLabel.AutoSize = true;
            this.precipitationPercentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.precipitationPercentLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationPercentLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.precipitationPercentLabel.Location = new System.Drawing.Point(4, 1);
            this.precipitationPercentLabel.Name = "precipitationPercentLabel";
            this.precipitationPercentLabel.Size = new System.Drawing.Size(224, 22);
            this.precipitationPercentLabel.TabIndex = 1;
            this.precipitationPercentLabel.Text = "Precipitation Chance";
            this.precipitationPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wind Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 63);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weather Advisories";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherAdvisoryLabel
            // 
            this.weatherAdvisoryLabel.AutoSize = true;
            this.weatherAdvisoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherAdvisoryLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherAdvisoryLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.weatherAdvisoryLabel.Location = new System.Drawing.Point(4, 143);
            this.weatherAdvisoryLabel.Name = "weatherAdvisoryLabel";
            this.weatherAdvisoryLabel.Size = new System.Drawing.Size(224, 69);
            this.weatherAdvisoryLabel.TabIndex = 11;
            this.weatherAdvisoryLabel.Text = "None";
            this.weatherAdvisoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.advisorySeverityLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(235, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(68, 63);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // advisorySeverityLabel
            // 
            this.advisorySeverityLabel.AutoSize = true;
            this.advisorySeverityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advisorySeverityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisorySeverityLabel.Location = new System.Drawing.Point(3, 31);
            this.advisorySeverityLabel.Name = "advisorySeverityLabel";
            this.advisorySeverityLabel.Size = new System.Drawing.Size(62, 32);
            this.advisorySeverityLabel.TabIndex = 1;
            this.advisorySeverityLabel.Text = "---";
            this.advisorySeverityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Severity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowWeatherOverlayLabel
            // 
            this.ShowWeatherOverlayLabel.AutoSize = true;
            this.ShowWeatherOverlayLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowWeatherOverlayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowWeatherOverlayLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowWeatherOverlayLabel.ForeColor = System.Drawing.Color.Blue;
            this.ShowWeatherOverlayLabel.Location = new System.Drawing.Point(6, 251);
            this.ShowWeatherOverlayLabel.Name = "ShowWeatherOverlayLabel";
            this.ShowWeatherOverlayLabel.Size = new System.Drawing.Size(307, 57);
            this.ShowWeatherOverlayLabel.TabIndex = 2;
            this.ShowWeatherOverlayLabel.Text = "Display Current Weather Radar";
            this.ShowWeatherOverlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowWeatherOverlayLabel.Click += new System.EventHandler(this.ShowWeatherOverlayLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NextGenATC_GUI.Properties.Resources.sunIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(235, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // WeatherTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 313);
            this.Controls.Add(this.WeatherBaseTLPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeatherTab";
            this.Text = "WeatherTab";
            this.WeatherBaseTLPanel.ResumeLayout(false);
            this.WeatherBaseTLPanel.PerformLayout();
            this.weatherInfoTLPanel.ResumeLayout(false);
            this.weatherInfoTLPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label weatherStatusLabel;
        public System.Windows.Forms.TableLayoutPanel WeatherBaseTLPanel;
        private System.Windows.Forms.TableLayoutPanel weatherInfoTLPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label precipitationPercentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label weatherAdvisoryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label advisorySeverityLabel;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label ShowWeatherOverlayLabel;
    }
}
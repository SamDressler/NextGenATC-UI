namespace NextGenATC_GUI
{
    partial class QueueTabForm
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
            this.QbaseTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.queueStatusLabel = new System.Windows.Forms.Label();
            this.queueIntermediateTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.landingQueueListView = new System.Windows.Forms.ListView();
            this.Landing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.takeoffQueueLengthLabel = new System.Windows.Forms.Label();
            this.landingQueueLengthLabel = new System.Windows.Forms.Label();
            this.takeoffQueueListView = new System.Windows.Forms.ListView();
            this.QbaseTLPanel.SuspendLayout();
            this.queueIntermediateTLPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QbaseTLPanel
            // 
            this.QbaseTLPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QbaseTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.QbaseTLPanel.ColumnCount = 1;
            this.QbaseTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QbaseTLPanel.Controls.Add(this.queueStatusLabel, 0, 0);
            this.QbaseTLPanel.Controls.Add(this.queueIntermediateTLPanel, 0, 1);
            this.QbaseTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QbaseTLPanel.Location = new System.Drawing.Point(0, 0);
            this.QbaseTLPanel.Name = "QbaseTLPanel";
            this.QbaseTLPanel.RowCount = 2;
            this.QbaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.QbaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.QbaseTLPanel.Size = new System.Drawing.Size(319, 313);
            this.QbaseTLPanel.TabIndex = 0;
            // 
            // queueStatusLabel
            // 
            this.queueStatusLabel.AutoSize = true;
            this.queueStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueStatusLabel.ForeColor = System.Drawing.Color.White;
            this.queueStatusLabel.Location = new System.Drawing.Point(6, 3);
            this.queueStatusLabel.Name = "queueStatusLabel";
            this.queueStatusLabel.Size = new System.Drawing.Size(307, 27);
            this.queueStatusLabel.TabIndex = 0;
            this.queueStatusLabel.Text = "Takeoff/Landing Queue Status";
            this.queueStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queueIntermediateTLPanel
            // 
            this.queueIntermediateTLPanel.BackColor = System.Drawing.Color.DarkRed;
            this.queueIntermediateTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.queueIntermediateTLPanel.ColumnCount = 1;
            this.queueIntermediateTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queueIntermediateTLPanel.Controls.Add(this.landingQueueListView, 0, 3);
            this.queueIntermediateTLPanel.Controls.Add(this.takeoffQueueLengthLabel, 0, 0);
            this.queueIntermediateTLPanel.Controls.Add(this.landingQueueLengthLabel, 0, 2);
            this.queueIntermediateTLPanel.Controls.Add(this.takeoffQueueListView, 0, 1);
            this.queueIntermediateTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueIntermediateTLPanel.Location = new System.Drawing.Point(6, 36);
            this.queueIntermediateTLPanel.Name = "queueIntermediateTLPanel";
            this.queueIntermediateTLPanel.RowCount = 4;
            this.queueIntermediateTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.queueIntermediateTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.queueIntermediateTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.queueIntermediateTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.queueIntermediateTLPanel.Size = new System.Drawing.Size(307, 271);
            this.queueIntermediateTLPanel.TabIndex = 1;
            // 
            // landingQueueListView
            // 
            this.landingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Landing});
            this.landingQueueListView.HideSelection = false;
            this.landingQueueListView.Location = new System.Drawing.Point(5, 160);
            this.landingQueueListView.Name = "landingQueueListView";
            this.landingQueueListView.Size = new System.Drawing.Size(289, 103);
            this.landingQueueListView.TabIndex = 3;
            this.landingQueueListView.UseCompatibleStateImageBehavior = false;
            // 
            // takeoffQueueLengthLabel
            // 
            this.takeoffQueueLengthLabel.AutoSize = true;
            this.takeoffQueueLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeoffQueueLengthLabel.ForeColor = System.Drawing.Color.White;
            this.takeoffQueueLengthLabel.Location = new System.Drawing.Point(5, 2);
            this.takeoffQueueLengthLabel.Name = "takeoffQueueLengthLabel";
            this.takeoffQueueLengthLabel.Size = new System.Drawing.Size(254, 18);
            this.takeoffQueueLengthLabel.TabIndex = 0;
            this.takeoffQueueLengthLabel.Text = "Current Takeoff Queue Length: 0\r\n";
            // 
            // landingQueueLengthLabel
            // 
            this.landingQueueLengthLabel.AutoSize = true;
            this.landingQueueLengthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.landingQueueLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingQueueLengthLabel.ForeColor = System.Drawing.Color.White;
            this.landingQueueLengthLabel.Location = new System.Drawing.Point(5, 137);
            this.landingQueueLengthLabel.Name = "landingQueueLengthLabel";
            this.landingQueueLengthLabel.Size = new System.Drawing.Size(297, 18);
            this.landingQueueLengthLabel.TabIndex = 1;
            this.landingQueueLengthLabel.Text = "Current Landing Queue Length: 0";
            // 
            // takeoffQueueListView
            // 
            this.takeoffQueueListView.HideSelection = false;
            this.takeoffQueueListView.Location = new System.Drawing.Point(5, 25);
            this.takeoffQueueListView.Name = "takeoffQueueListView";
            this.takeoffQueueListView.Size = new System.Drawing.Size(289, 107);
            this.takeoffQueueListView.TabIndex = 2;
            this.takeoffQueueListView.UseCompatibleStateImageBehavior = false;
            // 
            // QueueTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 313);
            this.Controls.Add(this.QbaseTLPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QueueTabForm";
            this.Text = "queueTab";
            this.QbaseTLPanel.ResumeLayout(false);
            this.QbaseTLPanel.PerformLayout();
            this.queueIntermediateTLPanel.ResumeLayout(false);
            this.queueIntermediateTLPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel queueIntermediateTLPanel;
        private System.Windows.Forms.Label takeoffQueueLengthLabel;
        private System.Windows.Forms.Label landingQueueLengthLabel;
        private System.Windows.Forms.ColumnHeader Landing;
        public System.Windows.Forms.TableLayoutPanel QbaseTLPanel;
        public System.Windows.Forms.Label queueStatusLabel;
        public System.Windows.Forms.ListView takeoffQueueListView;
        public System.Windows.Forms.ListView landingQueueListView;
    }
}
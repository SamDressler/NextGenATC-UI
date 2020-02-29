namespace NextGenATC_GUI
{
    partial class TestCaseForm
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
            this.TestCaseTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.testCaseLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TestCaseFourButton = new System.Windows.Forms.Button();
            this.testCaseOneButton = new System.Windows.Forms.Button();
            this.TestCaseTwoButton = new System.Windows.Forms.Button();
            this.TestCaseThreeButton = new System.Windows.Forms.Button();
            this.TestCaseTLPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestCaseTLPanel
            // 
            this.TestCaseTLPanel.BackColor = System.Drawing.Color.Black;
            this.TestCaseTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.TestCaseTLPanel.ColumnCount = 1;
            this.TestCaseTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TestCaseTLPanel.Controls.Add(this.testCaseLabel, 0, 0);
            this.TestCaseTLPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TestCaseTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCaseTLPanel.Location = new System.Drawing.Point(0, 0);
            this.TestCaseTLPanel.Name = "TestCaseTLPanel";
            this.TestCaseTLPanel.RowCount = 2;
            this.TestCaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TestCaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TestCaseTLPanel.Size = new System.Drawing.Size(319, 313);
            this.TestCaseTLPanel.TabIndex = 0;
            // 
            // testCaseLabel
            // 
            this.testCaseLabel.AutoSize = true;
            this.testCaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCaseLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCaseLabel.ForeColor = System.Drawing.Color.White;
            this.testCaseLabel.Location = new System.Drawing.Point(6, 3);
            this.testCaseLabel.Name = "testCaseLabel";
            this.testCaseLabel.Size = new System.Drawing.Size(307, 30);
            this.testCaseLabel.TabIndex = 0;
            this.testCaseLabel.Text = "Test Cases";
            this.testCaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TestCaseFourButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.testCaseOneButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TestCaseTwoButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TestCaseThreeButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 268);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TestCaseFourButton
            // 
            this.TestCaseFourButton.BackColor = System.Drawing.Color.DarkRed;
            this.TestCaseFourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestCaseFourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCaseFourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestCaseFourButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCaseFourButton.ForeColor = System.Drawing.Color.White;
            this.TestCaseFourButton.Location = new System.Drawing.Point(3, 204);
            this.TestCaseFourButton.Name = "TestCaseFourButton";
            this.TestCaseFourButton.Size = new System.Drawing.Size(301, 61);
            this.TestCaseFourButton.TabIndex = 3;
            this.TestCaseFourButton.Text = "4. Aircraft Collision";
            this.TestCaseFourButton.UseVisualStyleBackColor = false;
            this.TestCaseFourButton.Click += new System.EventHandler(this.TestCaseFourButton_Click);
            // 
            // testCaseOneButton
            // 
            this.testCaseOneButton.BackColor = System.Drawing.Color.DarkRed;
            this.testCaseOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testCaseOneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCaseOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testCaseOneButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCaseOneButton.ForeColor = System.Drawing.Color.White;
            this.testCaseOneButton.Location = new System.Drawing.Point(3, 3);
            this.testCaseOneButton.Name = "testCaseOneButton";
            this.testCaseOneButton.Size = new System.Drawing.Size(301, 61);
            this.testCaseOneButton.TabIndex = 0;
            this.testCaseOneButton.Text = "1. Aircraft Landing";
            this.testCaseOneButton.UseVisualStyleBackColor = true;
            this.testCaseOneButton.Click += new System.EventHandler(this.TestCaseOneButton_Click_1);
            // 
            // TestCaseTwoButton
            // 
            this.TestCaseTwoButton.BackColor = System.Drawing.Color.DarkRed;
            this.TestCaseTwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestCaseTwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCaseTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestCaseTwoButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCaseTwoButton.ForeColor = System.Drawing.Color.White;
            this.TestCaseTwoButton.Location = new System.Drawing.Point(3, 70);
            this.TestCaseTwoButton.Name = "TestCaseTwoButton";
            this.TestCaseTwoButton.Size = new System.Drawing.Size(301, 61);
            this.TestCaseTwoButton.TabIndex = 1;
            this.TestCaseTwoButton.Text = "2. Aircraft Takeoff";
            this.TestCaseTwoButton.UseVisualStyleBackColor = false;
            this.TestCaseTwoButton.Click += new System.EventHandler(this.TestCaseTwoButton_Click);
            // 
            // TestCaseThreeButton
            // 
            this.TestCaseThreeButton.BackColor = System.Drawing.Color.DarkRed;
            this.TestCaseThreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestCaseThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCaseThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestCaseThreeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCaseThreeButton.ForeColor = System.Drawing.Color.White;
            this.TestCaseThreeButton.Location = new System.Drawing.Point(3, 137);
            this.TestCaseThreeButton.Name = "TestCaseThreeButton";
            this.TestCaseThreeButton.Size = new System.Drawing.Size(301, 61);
            this.TestCaseThreeButton.TabIndex = 2;
            this.TestCaseThreeButton.Text = "3. Aircraft Collision Avoidance";
            this.TestCaseThreeButton.UseVisualStyleBackColor = false;
            this.TestCaseThreeButton.Click += new System.EventHandler(this.TestCaseThreeButton_Click);
            // 
            // TestCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 313);
            this.Controls.Add(this.TestCaseTLPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestCaseForm";
            this.Text = "TestCaseForm";
            this.TestCaseTLPanel.ResumeLayout(false);
            this.TestCaseTLPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label testCaseLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TableLayoutPanel TestCaseTLPanel;
        public System.Windows.Forms.Button TestCaseFourButton;
        public System.Windows.Forms.Button testCaseOneButton;
        public System.Windows.Forms.Button TestCaseTwoButton;
        public System.Windows.Forms.Button TestCaseThreeButton;
    }
}
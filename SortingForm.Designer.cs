namespace AlgorithmVisualizer
{
    partial class SortingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelVisualizer = new System.Windows.Forms.Panel();
            this.comboAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblComparisons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelVisualizer
            // 
            this.panelVisualizer.BackColor = System.Drawing.Color.White;
            this.panelVisualizer.Location = new System.Drawing.Point(12, 80);
            this.panelVisualizer.Name = "panelVisualizer";
            this.panelVisualizer.Size = new System.Drawing.Size(776, 280);
            this.panelVisualizer.TabIndex = 0;
            this.panelVisualizer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVisualizer_Paint);
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.Items.AddRange(new object[] {
            "Insertion Sort"});
            this.comboAlgorithm.Location = new System.Drawing.Point(120, 15);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(150, 24);
            this.comboAlgorithm.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(280, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(390, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(688, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 30);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblComparisons
            // 
            this.lblComparisons.AutoSize = true;
            this.lblComparisons.Location = new System.Drawing.Point(500, 18);
            this.lblComparisons.Name = "lblComparisons";
            this.lblComparisons.Size = new System.Drawing.Size(100, 16);
            this.lblComparisons.TabIndex = 6;
            this.lblComparisons.Text = "Comparisons: 0";
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComparisons);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboAlgorithm);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panelVisualizer);
            this.Name = "SortingForm";
            this.Text = "Sorting Visualizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SortingForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVisualizer;
        private System.Windows.Forms.ComboBox comboAlgorithm;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblComparisons;
    }
}
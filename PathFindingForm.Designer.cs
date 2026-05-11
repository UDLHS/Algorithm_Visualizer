namespace AlgorithmVisualizer
{
    partial class PathfindingForm
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
            this.panelGrid = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboAlgorithm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Location = new System.Drawing.Point(12, 60);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(776, 320);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            this.panelGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseDown);
            this.panelGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseMove);
            this.panelGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(120, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Grid";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(688, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(230, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(280, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Click to place Start, then End, then draw Walls";
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.Items.AddRange(new object[] {
            "Breadth-First Search"});
            this.comboAlgorithm.Location = new System.Drawing.Point(520, 15);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(150, 24);
            this.comboAlgorithm.TabIndex = 5;
            // 
            // PathfindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboAlgorithm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelGrid);
            this.Name = "PathfindingForm";
            this.Text = "Pathfinding Visualizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PathfindingForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboAlgorithm;
    }
}
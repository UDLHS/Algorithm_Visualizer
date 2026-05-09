namespace AlgorithmVisualizer
{
    partial class MainForm
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
            this.btnSorting = new System.Windows.Forms.Button();
            this.btnPathfinding = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSorting
            // 
            this.btnSorting.Location = new System.Drawing.Point(175, 191);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(140, 69);
            this.btnSorting.TabIndex = 0;
            this.btnSorting.Text = "Sorting Visualizer";
            this.btnSorting.UseVisualStyleBackColor = true;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // btnPathfinding
            // 
            this.btnPathfinding.Location = new System.Drawing.Point(456, 191);
            this.btnPathfinding.Name = "btnPathfinding";
            this.btnPathfinding.Size = new System.Drawing.Size(140, 69);
            this.btnPathfinding.TabIndex = 1;
            this.btnPathfinding.Text = "PathFinding Visualizer";
            this.btnPathfinding.UseVisualStyleBackColor = true;
            this.btnPathfinding.Click += new System.EventHandler(this.btnPathfinding_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(648, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPathfinding);
            this.Controls.Add(this.btnSorting);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.Button btnPathfinding;
        private System.Windows.Forms.Button btnExit;
    }
}
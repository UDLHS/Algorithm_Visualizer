namespace AlgorithmVisualizer
{
    partial class SettingsForm
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
            this.numArraySize = new System.Windows.Forms.NumericUpDown();
            this.numGridRows = new System.Windows.Forms.NumericUpDown();
            this.numAnimationDelay = new System.Windows.Forms.NumericUpDown();
            this.numGridCols = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numArraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimationDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridCols)).BeginInit();
            this.SuspendLayout();
            // 
            // numArraySize
            // 
            this.numArraySize.Location = new System.Drawing.Point(405, 69);
            this.numArraySize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numArraySize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numArraySize.Name = "numArraySize";
            this.numArraySize.Size = new System.Drawing.Size(120, 22);
            this.numArraySize.TabIndex = 0;
            this.numArraySize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numGridRows
            // 
            this.numGridRows.Location = new System.Drawing.Point(405, 185);
            this.numGridRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGridRows.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGridRows.Name = "numGridRows";
            this.numGridRows.Size = new System.Drawing.Size(120, 22);
            this.numGridRows.TabIndex = 1;
            this.numGridRows.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numAnimationDelay
            // 
            this.numAnimationDelay.Location = new System.Drawing.Point(405, 125);
            this.numAnimationDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAnimationDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAnimationDelay.Name = "numAnimationDelay";
            this.numAnimationDelay.Size = new System.Drawing.Size(120, 22);
            this.numAnimationDelay.TabIndex = 2;
            this.numAnimationDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numGridCols
            // 
            this.numGridCols.Location = new System.Drawing.Point(405, 245);
            this.numGridCols.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGridCols.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGridCols.Name = "numGridCols";
            this.numGridCols.Size = new System.Drawing.Size(120, 22);
            this.numGridCols.TabIndex = 3;
            this.numGridCols.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(42, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 69);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(612, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 69);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Array Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Animation Delay (ms):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grid Rows:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grid Columns:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numGridCols);
            this.Controls.Add(this.numAnimationDelay);
            this.Controls.Add(this.numGridRows);
            this.Controls.Add(this.numArraySize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numArraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimationDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numArraySize;
        private System.Windows.Forms.NumericUpDown numGridRows;
        private System.Windows.Forms.NumericUpDown numAnimationDelay;
        private System.Windows.Forms.NumericUpDown numGridCols;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
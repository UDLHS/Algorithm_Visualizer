using System;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class SettingsForm : Form
    {
        // This holds the SAME settings object passed in from the caller
        // We modify it directly so the caller sees the changes
        public VisualizerSettings Settings { get; private set; }

        public SettingsForm(VisualizerSettings currentSettings)
        {
            InitializeComponent();

            // Store reference to the SAME object (not a copy!)
            Settings = currentSettings;

            // Load current values into controls
            numArraySize.Value = currentSettings.ArraySize;
            numAnimationDelay.Value = currentSettings.AnimationDelayMs;
            numGridRows.Value = currentSettings.GridRows;
            numGridCols.Value = currentSettings.GridCols;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save values back to the SAME settings object
            Settings.ArraySize = (int)numArraySize.Value;
            Settings.AnimationDelayMs = (int)numAnimationDelay.Value;
            Settings.GridRows = (int)numGridRows.Value;
            Settings.GridCols = (int)numGridCols.Value;

            // Close with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
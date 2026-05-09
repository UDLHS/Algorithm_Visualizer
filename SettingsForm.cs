using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class SettingsForm : Form
    {
        // This holds the settings object passed in and modified
        public VisualizerSettings Settings { get; private set; }

        // Constructor receives current settings so we can show them
        public SettingsForm(VisualizerSettings currentSettings)
        {
            InitializeComponent();

            // Store reference
            Settings = currentSettings;

            // Load current values into the controls
            numArraySize.Value = currentSettings.ArraySize;
            numAnimationDelay.Value = currentSettings.AnimationDelayMs;
            numGridRows.Value = currentSettings.GridRows;
            numGridCols.Value = currentSettings.GridCols;
        }

        // Save button clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate and save values back to Settings object
            Settings.ArraySize = (int)numArraySize.Value;
            Settings.AnimationDelayMs = (int)numAnimationDelay.Value;
            Settings.GridRows = (int)numGridRows.Value;
            Settings.GridCols = (int)numGridCols.Value;

            // Close with OK result so the caller knows settings were saved
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel button clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close with Cancel result — caller will ignore changes
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}


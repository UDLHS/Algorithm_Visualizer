using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class SortingForm : Form
    {
        // === Core Data ===
        private int[] _array;
        private List<SortStep> _steps;
        private int _currentStepIndex;
        private SortingAlgorithm _algorithm;
        private System.Windows.Forms.Timer _animationTimer;

        // IMPORTANT: Single settings instance shared with SettingsForm
        private VisualizerSettings _settings = new VisualizerSettings();

        // === Constructor ===
        public SortingForm()
        {
            InitializeComponent();

            // Setup timer
            _animationTimer = new System.Windows.Forms.Timer();
            _animationTimer.Tick += AnimationTimer_Tick;

            // Select first algorithm by default
            if (comboAlgorithm.Items.Count > 0)
                comboAlgorithm.SelectedIndex = 0;

            // Generate initial array
            GenerateArray();
        }

        // === Generate Random Array ===
        private void GenerateArray()
        {
            Random rnd = new Random();
            _array = new int[_settings.ArraySize];

            for (int i = 0; i < _array.Length; i++)
                _array[i] = rnd.Next(10, 400);

            _steps = null;
            _currentStepIndex = 0;
            lblComparisons.Text = "Comparisons: 0";

            panelVisualizer.Invalidate();
        }

        // === Start Sorting ===
        private void btnStart_Click(object sender, EventArgs e)
        {
            string selected = comboAlgorithm.SelectedItem?.ToString();

            if (selected == "Insertion Sort")
                _algorithm = new InsertionSort();
            else
            {
                MessageBox.Show("Please select an algorithm!");
                return;
            }

            _steps = _algorithm.Run((int[])_array.Clone());
            _currentStepIndex = 0;

            _animationTimer.Interval = _settings.AnimationDelayMs;
            _animationTimer.Start();

            btnStart.Enabled = false;
            btnGenerate.Enabled = false;
            comboAlgorithm.Enabled = false;
        }

        // === Timer Tick: Advance One Step ===
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (_currentStepIndex >= _steps.Count)
            {
                _animationTimer.Stop();
                btnStart.Enabled = true;
                btnGenerate.Enabled = true;
                comboAlgorithm.Enabled = true;
                return;
            }

            _currentStepIndex++;
            panelVisualizer.Invalidate();
        }

        // === Reset ===
        private void btnReset_Click(object sender, EventArgs e)
        {
            _animationTimer.Stop();
            _steps = null;
            _currentStepIndex = 0;
            lblComparisons.Text = "Comparisons: 0";
            panelVisualizer.Invalidate();
        }

        // === THE PAINT EVENT: Draw the Bars ===
        private void panelVisualizer_Paint(object sender, PaintEventArgs e)
        {
            if (_array == null || _array.Length == 0) return;

            Graphics g = e.Graphics;
            int panelWidth = panelVisualizer.Width;
            int panelHeight = panelVisualizer.Height;

            int[] arrayToDraw = _array;
            SortStep currentStep = null;

            if (_steps != null && _currentStepIndex > 0 && _currentStepIndex <= _steps.Count)
            {
                currentStep = _steps[_currentStepIndex - 1];
                arrayToDraw = currentStep.Array;
            }

            int barWidth = panelWidth / arrayToDraw.Length;
            int maxValue = arrayToDraw.Max();

            for (int i = 0; i < arrayToDraw.Length; i++)
            {
                int barHeight = (int)((arrayToDraw[i] / (float)maxValue) * (panelHeight - 20));
                int x = i * barWidth;
                int y = panelHeight - barHeight;

                Brush brush = Brushes.Gray;

                if (currentStep != null)
                {
                    if (currentStep.SortedIndices.Contains(i))
                        brush = Brushes.Green;
                    else if (currentStep.SwappingIndices.Contains(i))
                        brush = Brushes.Red;
                    else if (currentStep.ComparingIndices.Contains(i))
                        brush = Brushes.Yellow;
                }

                g.FillRectangle(brush, x, y, barWidth - 1, barHeight);
            }

            if (currentStep != null)
                lblComparisons.Text = $"Comparisons: {currentStep.ComparisonCount}";
        }

        // === SETTINGS: Open Settings Form ===
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Pass the SAME settings object (by reference)
            using (var settingsForm = new SettingsForm(_settings))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Settings were saved! Apply them now.
                    ApplySettings();
                }
            }
        }

        // === SETTINGS: Apply new settings values ===
        private void ApplySettings()
        {
            // 1. Update timer interval if animation is running
            if (_animationTimer != null)
                _animationTimer.Interval = _settings.AnimationDelayMs;

            // 2. If array size changed, regenerate the array
            if (_array == null || _array.Length != _settings.ArraySize)
            {
                _animationTimer.Stop();
                _steps = null;
                _currentStepIndex = 0;
                GenerateArray();
            }

            // Show confirmation (optional — remove after testing)
            MessageBox.Show(
                $"Settings applied!\n\n" +
                $"Array Size: {_settings.ArraySize}\n" +
                $"Animation Delay: {_settings.AnimationDelayMs}ms",
                "Settings Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // === Generate Button ===
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateArray();
        }

        // === Clean up on close ===
        private void SortingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _animationTimer?.Stop();
        }
    }
}
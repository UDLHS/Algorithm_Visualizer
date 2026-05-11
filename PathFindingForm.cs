using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class PathfindingForm : Form
    {
        // === Core Data ===
        private GridTile[,] _grid;
        private int _rows = 20;
        private int _cols = 30;
        private int _cellSize = 25;
        private (int r, int c)? _startPos = null;
        private (int r, int c)? _endPos = null;
        private bool _isMouseDown = false;
        private bool _isRunning = false;
        private (int r, int c)? _lastDrawnCell = null;

        // Animation
        private PathfindingAlgorithm _algorithm;
        private List<PathfindingStep> _steps;
        private int _currentStep;
        private System.Windows.Forms.Timer _animationTimer;

        // IMPORTANT: Single settings instance shared with SettingsForm
        private VisualizerSettings _settings = new VisualizerSettings();

        // Placement state: 0=none, 1=start placed, 2=end placed, 3=ready for walls
        private int _placementState = 0;

        public PathfindingForm()
        {
            InitializeComponent();

            _animationTimer = new System.Windows.Forms.Timer();
            _animationTimer.Tick += AnimationTimer_Tick;

            if (comboAlgorithm.Items.Count > 0)
                comboAlgorithm.SelectedIndex = 0;

            InitializeGrid();
        }

        // === Initialize / Resize Grid ===
        private void InitializeGrid()
        {
            _rows = _settings.GridRows;
            _cols = _settings.GridCols;
            _grid = new GridTile[_rows, _cols];

            for (int r = 0; r < _rows; r++)
                for (int c = 0; c < _cols; c++)
                    _grid[r, c] = new GridTile { Row = r, Col = c };

            _startPos = null;
            _endPos = null;
            _placementState = 0;
            _lastDrawnCell = null;
            lblStatus.Text = "Click to place Start, then End, then drag to draw Walls";

            panelGrid.Invalidate();
        }

        // === Grid Paint Event ===
        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            if (_grid == null) return;

            Graphics g = e.Graphics;

            _cellSize = Math.Min(panelGrid.Width / _cols, panelGrid.Height / _rows);
            if (_cellSize < 1) _cellSize = 1;

            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    int x = c * _cellSize;
                    int y = r * _cellSize;

                    Brush brush = Brushes.White;

                    switch (_grid[r, c].Type)
                    {
                        case TileType.Wall: brush = Brushes.Black; break;
                        case TileType.Start: brush = Brushes.Green; break;
                        case TileType.End: brush = Brushes.Red; break;
                        case TileType.Visited: brush = Brushes.LightBlue; break;
                        case TileType.Path: brush = Brushes.Yellow; break;
                    }

                    g.FillRectangle(brush, x, y, _cellSize - 1, _cellSize - 1);
                    g.DrawRectangle(Pens.Gray, x, y, _cellSize - 1, _cellSize - 1);
                }
            }
        }

        // === Mouse Interaction ===
        private void panelGrid_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _lastDrawnCell = null;
            HandleGridClick(e);
        }

        private void panelGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown) return;
            HandleGridClick(e);
        }

        private void panelGrid_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            _lastDrawnCell = null;
        }

        private void HandleGridClick(MouseEventArgs e)
        {
            if (_isRunning) return;

            int c = e.X / _cellSize;
            int r = e.Y / _cellSize;

            if (r < 0 || r >= _rows || c < 0 || c >= _cols) return;

            var tile = _grid[r, c];
            var currentCell = (r, c);

            if (_placementState == 0) // Place start
            {
                if (tile.Type == TileType.Empty)
                {
                    tile.Type = TileType.Start;
                    _startPos = (r, c);
                    _placementState = 1;
                    lblStatus.Text = "Now click to place End point";
                    panelGrid.Invalidate();
                }
            }
            else if (_placementState == 1) // Place end
            {
                if (tile.Type == TileType.Empty)
                {
                    tile.Type = TileType.End;
                    _endPos = (r, c);
                    _placementState = 2;
                    lblStatus.Text = "Drag to draw walls (Right-click to erase)";
                    panelGrid.Invalidate();
                }
            }
            else if (_placementState == 2) // Draw walls / erase
            {
                if (tile.Type == TileType.Start || tile.Type == TileType.End)
                    return;

                if (_lastDrawnCell.HasValue && _lastDrawnCell.Value == currentCell)
                    return;

                if (e.Button == MouseButtons.Left)
                {
                    if (tile.Type == TileType.Empty)
                    {
                        tile.Type = TileType.Wall;
                        _lastDrawnCell = currentCell;
                        panelGrid.Invalidate();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (tile.Type == TileType.Wall)
                    {
                        tile.Type = TileType.Empty;
                        _lastDrawnCell = currentCell;
                        panelGrid.Invalidate();
                    }
                }
            }
        }

        // === Start Pathfinding ===
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_startPos == null || _endPos == null)
            {
                MessageBox.Show("Please place both Start and End tiles!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int r = 0; r < _rows; r++)
                for (int c = 0; c < _cols; c++)
                    if (_grid[r, c].Type == TileType.Visited || _grid[r, c].Type == TileType.Path)
                        _grid[r, c].Type = TileType.Empty;

            _grid[_startPos.Value.r, _startPos.Value.c].Type = TileType.Start;
            _grid[_endPos.Value.r, _endPos.Value.c].Type = TileType.End;

            string selected = comboAlgorithm.SelectedItem?.ToString();
            if (selected == "Breadth-First Search")
                _algorithm = new BFSAlgorithm();
            else
            {
                MessageBox.Show("Please select an algorithm!");
                return;
            }

            _steps = _algorithm.Run(_grid, _startPos.Value, _endPos.Value);
            _currentStep = 0;
            _isRunning = true;

            btnStart.Enabled = false;
            btnClear.Enabled = false;

            _animationTimer.Interval = _settings.AnimationDelayMs;
            _animationTimer.Start();
        }

        // === Animation Timer ===
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (_currentStep >= _steps.Count)
            {
                _animationTimer.Stop();
                _isRunning = false;
                btnStart.Enabled = true;
                btnClear.Enabled = true;
                return;
            }

            var step = _steps[_currentStep];

            foreach (var (r, c) in step.NewlyVisited)
            {
                if (_grid[r, c].Type != TileType.Start && _grid[r, c].Type != TileType.End)
                    _grid[r, c].Type = TileType.Visited;
            }

            if (step.IsComplete)
            {
                foreach (var (r, c) in step.FinalPath)
                {
                    if (_grid[r, c].Type != TileType.Start && _grid[r, c].Type != TileType.End)
                        _grid[r, c].Type = TileType.Path;
                }

                if (step.FinalPath.Count == 0)
                    lblStatus.Text = "No path found!";
                else
                    lblStatus.Text = $"Path found! Length: {step.FinalPath.Count}";
            }

            _currentStep++;
            panelGrid.Invalidate();
        }

        // === Clear Grid ===
        private void btnClear_Click(object sender, EventArgs e)
        {
            _animationTimer?.Stop();
            _isRunning = false;
            InitializeGrid();
            btnStart.Enabled = true;
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

            // 2. If grid size changed, rebuild the grid
            if (_rows != _settings.GridRows || _cols != _settings.GridCols)
            {
                _animationTimer.Stop();
                _steps = null;
                _currentStep = 0;
                _isRunning = false;
                InitializeGrid();
                btnStart.Enabled = true;
            }

            // Show confirmation (optional — remove after testing)
            MessageBox.Show(
                $"Settings applied!\n\n" +
                $"Grid Size: {_settings.GridRows} x {_settings.GridCols}\n" +
                $"Animation Delay: {_settings.AnimationDelayMs}ms",
                "Settings Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // === Clean up ===
        private void PathfindingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _animationTimer?.Stop();
        }
    }
}
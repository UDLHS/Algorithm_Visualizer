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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            var form = new SortingForm();
            this.Hide();           // Hide main form
            form.FormClosed += (s, args) => this.Show(); // Show it again when closed
            form.Show();
        }

        private void btnPathfinding_Click(object sender, EventArgs e)
        {
            var form = new PathfindingForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

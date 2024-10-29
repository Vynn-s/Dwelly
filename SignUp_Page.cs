using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dwelly
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            // Define the radius for rounded corners (increased to 30)
            int radius = 30;

            // Create a path with rounded corners
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(LoginPanel.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(LoginPanel.Width - radius, LoginPanel.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, LoginPanel.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseAllFigures();

            // Apply the path to the panel's region
            LoginPanel.Region = new Region(path);

            // Optionally, you can add a border
            e.Graphics.DrawPath(new Pen(Color.Black, 2), path); // Black border with 2px width
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

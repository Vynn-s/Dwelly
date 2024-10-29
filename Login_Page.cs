using Dwelly.ModelViews;
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
    public partial class Login_Page : Form
    {
        private UsersMV usersMV;
        public Login_Page()
        {
            InitializeComponent();
            usersMV = new UsersMV();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usersMV.Users;
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

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home signUpPage = new Home();
            signUpPage.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if the login fields (e.g., TextBoxes) are empty
            if (string.IsNullOrWhiteSpace(textUser.Text) || string.IsNullOrWhiteSpace(textPass.Text))
            {

                MessageBox.Show("Error! The fields are empty, needs to be filled", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proceed with login logic 


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using Dwelly.Views;
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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            Timer1.Interval = 2000;
            Timer1.Start();

        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                Login_Page loginPage = new Login_Page();
                loginPage.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 5; // Increase the progress bar value by 10 each tick
            }
            else
            {
                // Stop the timer when progress reaches 100
                Timer1.Stop();

                // Redirect to the Login_Page form
                Login_Page loginPage = new Login_Page();
                loginPage.Show();

                // Hide or close the current Home form
                this.Hide(); // Or use this.Close() if you want to close the form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersView usersView = new UsersView();
            usersView.Show(); // Use ShowDialog() if you want it to be modal
        }
    }
}

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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 42);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(-1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 83);
            panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 241;
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 31;
            comboBox1.Location = new Point(79, 21);
            comboBox1.MaximumSize = new Size(300, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 39);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Location = new Point(647, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // Home_Page
            // 
            ClientSize = new Size(1468, 731);
            Controls.Add(panel2);
            Name = "Home_Page";
            Text = "Home";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel2;
        private Button button1;
        private ComboBox comboBox1;
    }
}

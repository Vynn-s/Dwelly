namespace Dwelly
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPanel = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(48, 46, 42);
            LoginPanel.Controls.Add(textBox5);
            LoginPanel.Controls.Add(dateTimePicker1);
            LoginPanel.Controls.Add(label8);
            LoginPanel.Controls.Add(textBox6);
            LoginPanel.Controls.Add(label5);
            LoginPanel.Controls.Add(label6);
            LoginPanel.Controls.Add(textBox3);
            LoginPanel.Controls.Add(textBox4);
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(textBox2);
            LoginPanel.Controls.Add(button1);
            LoginPanel.Controls.Add(textBox1);
            LoginPanel.Location = new Point(166, 164);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(602, 478);
            LoginPanel.TabIndex = 0;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(309, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(70, 127);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 14;
            label8.Text = "Enter Full Name*";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(68, 151);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 39);
            textBox6.TabIndex = 13;
            textBox6.Tag = "";
            textBox6.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(310, 268);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 12;
            label5.Text = "Student ID*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(310, 199);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 11;
            label6.Text = "Date of Birth*";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(307, 293);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 39);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(308, 223);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 39);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(70, 268);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Email*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(70, 199);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 6;
            label3.Text = "Enter Username*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(82, 47);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 4;
            label1.Text = "Welcome to Dwelly!";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(67, 293);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 39);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(67, 372);
            button1.Name = "button1";
            button1.Size = new Size(462, 56);
            button1.TabIndex = 2;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(68, 223);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 39);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 42);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 67);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dwelly;
            pictureBox1.Location = new Point(884, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(307, 151);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 39);
            textBox5.TabIndex = 15;
            textBox5.Tag = "";
            textBox5.Text = "Last Name";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 236, 234);
            ClientSize = new Size(1468, 731);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(LoginPanel);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up ";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
    }
}
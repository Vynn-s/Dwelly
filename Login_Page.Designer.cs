
namespace Dwelly
{
    partial class Login_Page
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
            linkSignUp = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textPass = new TextBox();
            btnLogin = new Button();
            textUser = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(48, 46, 42);
            LoginPanel.Controls.Add(linkSignUp);
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(textPass);
            LoginPanel.Controls.Add(btnLogin);
            LoginPanel.Controls.Add(textUser);
            LoginPanel.Location = new Point(145, 123);
            LoginPanel.Margin = new Padding(3, 2, 3, 2);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(527, 358);
            LoginPanel.TabIndex = 0;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // linkSignUp
            // 
            linkSignUp.ActiveLinkColor = Color.Lime;
            linkSignUp.AutoSize = true;
            linkSignUp.LinkColor = Color.White;
            linkSignUp.Location = new Point(404, 106);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(48, 15);
            linkSignUp.TabIndex = 8;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign Up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(61, 193);
            label4.Name = "label4";
            label4.Size = new Size(72, 16);
            label4.TabIndex = 7;
            label4.Text = "Password*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(61, 136);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 6;
            label3.Text = "Username*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(60, 106);
            label2.Name = "label2";
            label2.Size = new Size(171, 16);
            label2.TabIndex = 5;
            label2.Text = "Don't have an account yet?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(72, 54);
            label1.Name = "label1";
            label1.Size = new Size(352, 44);
            label1.TabIndex = 4;
            label1.Text = "Welcome to Dwelly!";
            label1.Click += label1_Click;
            // 
            // textPass
            // 
            textPass.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPass.Location = new Point(59, 212);
            textPass.Margin = new Padding(3, 2, 3, 2);
            textPass.Multiline = true;
            textPass.Name = "textPass";
            textPass.Size = new Size(404, 30);
            textPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(59, 273);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(404, 48);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textUser
            // 
            textUser.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUser.Location = new Point(60, 154);
            textUser.Margin = new Padding(3, 2, 3, 2);
            textUser.Multiline = true;
            textUser.Name = "textUser";
            textUser.Size = new Size(404, 30);
            textUser.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 42);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1288, 50);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dwelly;
            pictureBox1.Location = new Point(774, 164);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(247, 558);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 236, 234);
            ClientSize = new Size(1284, 786);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(LoginPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel LoginPanel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private TextBox textUser;
        private TextBox textPass;
        private Label label1;
        private Label label2;
        private LinkLabel linkSignUp;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
namespace Kurs
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            label1 = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(30, 110);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(30, 161);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Пайдаланушы";
            usernameTextbox.Size = new Size(252, 39);
            usernameTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(30, 235);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Құпиясөз";
            passwordTextbox.Size = new Size(252, 39);
            passwordTextbox.TabIndex = 1;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.Goldenrod;
            loginButton.Location = new Point(72, 305);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(168, 42);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(95, 375);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "Менде аккаунт жоқ";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(usernameTextbox);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passwordTextbox);
            panel1.Location = new Point(47, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 430);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 562);
            Controls.Add(panel1);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += loginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button loginButton;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
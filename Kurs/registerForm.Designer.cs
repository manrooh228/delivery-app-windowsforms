namespace Kurs
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            textboxConfirmPassword = new TextBox();
            usernameTextbox = new TextBox();
            label1 = new Label();
            passwordTextbox = new TextBox();
            registerButton = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textboxConfirmPassword
            // 
            textboxConfirmPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textboxConfirmPassword.Location = new Point(26, 286);
            textboxConfirmPassword.Name = "textboxConfirmPassword";
            textboxConfirmPassword.PlaceholderText = "Кұпиясөзді тексеру";
            textboxConfirmPassword.Size = new Size(252, 39);
            textboxConfirmPassword.TabIndex = 2;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(26, 147);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Пайдаланушы";
            usernameTextbox.Size = new Size(252, 39);
            usernameTextbox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(26, 105);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 4;
            label1.Text = "Регистрация";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(26, 216);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Құпиясөз";
            passwordTextbox.Size = new Size(252, 39);
            passwordTextbox.TabIndex = 2;
            // 
            // registerButton
            // 
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = Color.Goldenrod;
            registerButton.Location = new Point(61, 350);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(168, 42);
            registerButton.TabIndex = 5;
            registerButton.Text = "кіру";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(90, 423);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Менде аккаунт бар";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(usernameTextbox);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(textboxConfirmPassword);
            panel1.Controls.Add(passwordTextbox);
            panel1.Location = new Point(44, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 468);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 562);
            Controls.Add(panel1);
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textboxConfirmPassword;
        private TextBox usernameTextbox;
        private Label label1;
        private TextBox passwordTextbox;
        private Button registerButton;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
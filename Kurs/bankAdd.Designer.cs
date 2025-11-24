namespace Kurs
{
    partial class bankAdd
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
            label4 = new Label();
            label3 = new Label();
            loginButton = new Button();
            nameTextbox = new TextBox();
            binTextbox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(88, 167);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 14;
            label4.Text = "БИН";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 15;
            label3.Text = "Банктын аты";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Green;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.Goldenrod;
            loginButton.Location = new Point(123, 241);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(193, 57);
            loginButton.TabIndex = 11;
            loginButton.Text = "Қосу";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // nameTextbox
            // 
            nameTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextbox.Location = new Point(165, 112);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(252, 39);
            nameTextbox.TabIndex = 8;
            // 
            // binTextbox
            // 
            binTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            binTextbox.Location = new Point(165, 167);
            binTextbox.Name = "binTextbox";
            binTextbox.Size = new Size(252, 39);
            binTextbox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(112, 24);
            label1.Name = "label1";
            label1.Size = new Size(188, 50);
            label1.TabIndex = 7;
            label1.Text = "Bank қосу";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(binTextbox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 326);
            panel1.TabIndex = 16;
            // 
            // bankAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 409);
            Controls.Add(panel1);
            Name = "bankAdd";
            Text = "d";
            Load += bankAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Button loginButton;
        private TextBox nameTextbox;
        private TextBox binTextbox;
        private Label label1;
        private Panel panel1;
    }
}
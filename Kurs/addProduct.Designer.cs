namespace Kurs
{
    partial class addProduct
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
            label1 = new Label();
            loginButton = new Button();
            amountTextbox = new TextBox();
            costTextbox = new TextBox();
            nameTextbox = new TextBox();
            typeCombo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(89, 26);
            label1.Name = "label1";
            label1.Size = new Size(254, 50);
            label1.TabIndex = 0;
            label1.Text = "Product қосу";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Green;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.Goldenrod;
            loginButton.Location = new Point(118, 502);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(193, 57);
            loginButton.TabIndex = 4;
            loginButton.Text = "Қосу";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // amountTextbox
            // 
            amountTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            amountTextbox.Location = new Point(150, 442);
            amountTextbox.Name = "amountTextbox";
            amountTextbox.Size = new Size(252, 39);
            amountTextbox.TabIndex = 3;
            // 
            // costTextbox
            // 
            costTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            costTextbox.Location = new Point(150, 397);
            costTextbox.Name = "costTextbox";
            costTextbox.Size = new Size(252, 39);
            costTextbox.TabIndex = 3;
            // 
            // nameTextbox
            // 
            nameTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextbox.Location = new Point(150, 352);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(252, 39);
            nameTextbox.TabIndex = 3;
            // 
            // typeCombo
            // 
            typeCombo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            typeCombo.FormattingEnabled = true;
            typeCombo.Items.AddRange(new object[] { "Кишкентай жане сынгыш", "Кишкентай", "Орташа жане сынгыш", "Орташа", "Улкен жане сынгыш", "Улкен" });
            typeCombo.Location = new Point(150, 306);
            typeCombo.Name = "typeCombo";
            typeCombo.Size = new Size(252, 40);
            typeCombo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(18, 309);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 6;
            label2.Text = "Категроия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(88, 355);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 6;
            label3.Text = "Аты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(82, 400);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 6;
            label4.Text = "Баға";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Goldenrod;
            label5.Location = new Point(72, 445);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 6;
            label5.Text = "Саны";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(typeCombo);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(costTextbox);
            panel1.Controls.Add(amountTextbox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 598);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Goldenrod;
            button1.Location = new Point(135, 246);
            button1.Name = "button1";
            button1.Size = new Size(158, 34);
            button1.TabIndex = 7;
            button1.Text = "select image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 654);
            Controls.Add(panel1);
            Name = "addProduct";
            Text = "d";
            Load += addProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button loginButton;
        private TextBox amountTextbox;
        private TextBox costTextbox;
        private TextBox nameTextbox;
        private ComboBox typeCombo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
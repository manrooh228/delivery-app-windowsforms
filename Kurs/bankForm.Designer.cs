namespace Kurs
{
    partial class bankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankForm));
            bankButton = new Button();
            productsButton = new Button();
            bankCombo = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            giveSalaryButton = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // bankButton
            // 
            bankButton.BackColor = Color.Navy;
            bankButton.FlatAppearance.BorderSize = 0;
            bankButton.FlatStyle = FlatStyle.Flat;
            bankButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bankButton.ForeColor = Color.White;
            bankButton.Location = new Point(68, 195);
            bankButton.Name = "bankButton";
            bankButton.Size = new Size(106, 40);
            bankButton.TabIndex = 14;
            bankButton.Text = "Банк";
            bankButton.TextAlign = ContentAlignment.MiddleLeft;
            bankButton.UseVisualStyleBackColor = false;
            bankButton.Click += bankButton_Click;
            // 
            // productsButton
            // 
            productsButton.BackColor = Color.Navy;
            productsButton.FlatAppearance.BorderSize = 0;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productsButton.ForeColor = Color.White;
            productsButton.Location = new Point(66, 130);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(106, 37);
            productsButton.TabIndex = 15;
            productsButton.Text = "Товарлар";
            productsButton.TextAlign = ContentAlignment.MiddleLeft;
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // bankCombo
            // 
            bankCombo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bankCombo.FormattingEnabled = true;
            bankCombo.Location = new Point(488, 43);
            bankCombo.Name = "bankCombo";
            bankCombo.Size = new Size(176, 28);
            bankCombo.TabIndex = 19;
            bankCombo.TextChanged += bankCombo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(259, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 41);
            label1.TabIndex = 20;
            label1.Text = "Банк";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Goldenrod;
            dataGridView1.Location = new Point(259, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(405, 212);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // giveSalaryButton
            // 
            giveSalaryButton.BackColor = Color.Navy;
            giveSalaryButton.FlatAppearance.BorderSize = 0;
            giveSalaryButton.FlatStyle = FlatStyle.Flat;
            giveSalaryButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            giveSalaryButton.ForeColor = Color.White;
            giveSalaryButton.Location = new Point(102, 18);
            giveSalaryButton.Name = "giveSalaryButton";
            giveSalaryButton.Size = new Size(200, 41);
            giveSalaryButton.TabIndex = 22;
            giveSalaryButton.Text = "Жұмысшыларға жалақы жберу";
            giveSalaryButton.UseVisualStyleBackColor = false;
            giveSalaryButton.Click += giveSalaryButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(102, 112);
            button1.Name = "button1";
            button1.Size = new Size(200, 41);
            button1.TabIndex = 23;
            button1.Text = "Шот косу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(102, 65);
            button2.Name = "button2";
            button2.Size = new Size(200, 41);
            button2.TabIndex = 23;
            button2.Text = "Банк косу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(productsButton);
            panel1.Controls.Add(bankButton);
            panel1.ForeColor = Color.CornflowerBlue;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 494);
            panel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(37, 432);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Goldenrod;
            button3.Location = new Point(83, 432);
            button3.Name = "button3";
            button3.Size = new Size(88, 35);
            button3.TabIndex = 28;
            button3.Text = "Шығу";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(22, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(178, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(giveSalaryButton);
            panel2.Location = new Point(259, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 170);
            panel2.TabIndex = 28;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // bankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(693, 493);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(bankCombo);
            Name = "bankForm";
            Text = "bankButton";
            Load += bankForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bankButton;
        private Button productsButton;
        private ComboBox bankCombo;
        private ComboBox accountCombo;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button giveSalaryButton;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Button button3;
        private Panel panel2;
        private PictureBox pictureBox3;
    }
}
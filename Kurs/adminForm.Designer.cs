namespace Kurs
{
    partial class adminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            dataGridView1 = new DataGridView();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            isAdminTextbox = new TextBox();
            isDriverTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            saveButton = new Button();
            changeButton = new Button();
            deleteButton = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Navy;
            dataGridView1.Location = new Point(24, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Navy;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(561, 385);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(14, 104);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(232, 29);
            usernameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(14, 154);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(232, 29);
            passwordTextbox.TabIndex = 4;
            // 
            // isAdminTextbox
            // 
            isAdminTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isAdminTextbox.Location = new Point(14, 204);
            isAdminTextbox.Name = "isAdminTextbox";
            isAdminTextbox.Size = new Size(232, 29);
            isAdminTextbox.TabIndex = 4;
            // 
            // isDriverTextbox
            // 
            isDriverTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isDriverTextbox.Location = new Point(14, 254);
            isDriverTextbox.Name = "isDriverTextbox";
            isDriverTextbox.Size = new Size(232, 29);
            isDriverTextbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(14, 86);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Паудаланушы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(14, 136);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Құпиясөз";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(14, 236);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "isDriver";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(14, 186);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "isAdmin";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DarkGoldenrod;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(47, 362);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(165, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "Сақтау";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // changeButton
            // 
            changeButton.BackColor = Color.FromArgb(192, 64, 0);
            changeButton.FlatAppearance.BorderSize = 0;
            changeButton.FlatStyle = FlatStyle.Flat;
            changeButton.ForeColor = Color.White;
            changeButton.Location = new Point(47, 397);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(165, 29);
            changeButton.TabIndex = 6;
            changeButton.Text = "Өзгерту";
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(192, 0, 0);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(47, 432);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(165, 29);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Өшіру";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(359, 26);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(512, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(465, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(558, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(14, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 29);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(14, 287);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "isBuhgalter";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(changeButton);
            panel1.Controls.Add(usernameTextbox);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(passwordTextbox);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(isAdminTextbox);
            panel1.Controls.Add(isDriverTextbox);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 496);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(60, 32);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 0;
            label6.Text = "Басқару бөлігі";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(5, 16);
            label7.Name = "label7";
            label7.Size = new Size(230, 30);
            label7.TabIndex = 0;
            label7.Text = "Қолданушылар тізімі";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(287, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 474);
            panel2.TabIndex = 10;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(900, 493);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "adminForm";
            Text = "adminForm";
            Load += adminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private TextBox isAdminTextbox;
        private TextBox isDriverTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button saveButton;
        private Button changeButton;
        private Button deleteButton;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Panel panel2;
    }
}
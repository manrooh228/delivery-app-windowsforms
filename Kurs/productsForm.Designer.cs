namespace Kurs
{
    partial class productsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productsForm));
            searchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            changeButton = new Button();
            saveButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            amountTextbox = new TextBox();
            costTextbox = new TextBox();
            nameTexxtbox = new TextBox();
            idTextbox = new TextBox();
            label5 = new Label();
            addButton = new Button();
            typeTextbox = new ComboBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // searchTextbox
            // 
            searchTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextbox.Location = new Point(482, 22);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.PlaceholderText = "Search";
            searchTextbox.Size = new Size(199, 29);
            searchTextbox.TabIndex = 15;
            searchTextbox.TextChanged += searchTextbox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(388, 314);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Navy;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(88, 180);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(210, 48);
            deleteButton.TabIndex = 24;
            deleteButton.Text = "Өшіру";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // changeButton
            // 
            changeButton.BackColor = Color.Navy;
            changeButton.FlatAppearance.BorderSize = 0;
            changeButton.FlatStyle = FlatStyle.Flat;
            changeButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            changeButton.ForeColor = Color.White;
            changeButton.Location = new Point(88, 127);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(210, 48);
            changeButton.TabIndex = 25;
            changeButton.Text = "Өзгерту";
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Navy;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(88, 21);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(210, 48);
            saveButton.TabIndex = 26;
            saveButton.Text = "Сақтау";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(26, 393);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 20;
            label4.Text = "Құны";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(26, 449);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 21;
            label3.Text = "Саны";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(27, 334);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 22;
            label2.Text = "Аты";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(27, 273);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 23;
            label1.Text = "Артикул";
            // 
            // amountTextbox
            // 
            amountTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountTextbox.Location = new Point(26, 467);
            amountTextbox.Name = "amountTextbox";
            amountTextbox.Size = new Size(192, 29);
            amountTextbox.TabIndex = 16;
            // 
            // costTextbox
            // 
            costTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            costTextbox.Location = new Point(26, 411);
            costTextbox.Name = "costTextbox";
            costTextbox.Size = new Size(192, 29);
            costTextbox.TabIndex = 17;
            // 
            // nameTexxtbox
            // 
            nameTexxtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTexxtbox.Location = new Point(26, 355);
            nameTexxtbox.Name = "nameTexxtbox";
            nameTexxtbox.Size = new Size(222, 29);
            nameTexxtbox.TabIndex = 18;
            // 
            // idTextbox
            // 
            idTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTextbox.Location = new Point(27, 300);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(221, 29);
            idTextbox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Goldenrod;
            label5.Location = new Point(27, 503);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 21;
            label5.Text = "Типі";
            // 
            // addButton
            // 
            addButton.BackColor = Color.Navy;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(88, 73);
            addButton.Name = "addButton";
            addButton.Size = new Size(210, 48);
            addButton.TabIndex = 26;
            addButton.Text = "Қосу";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // typeTextbox
            // 
            typeTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            typeTextbox.FormattingEnabled = true;
            typeTextbox.Items.AddRange(new object[] { "Кишкентай жане сынгыш", "Кишкентай", "Орташа жане сынгыш", "Орташа", "Улкен жане сынгыш", "Улкен" });
            typeTextbox.Location = new Point(27, 521);
            typeTextbox.Name = "typeTextbox";
            typeTextbox.Size = new Size(191, 29);
            typeTextbox.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(typeTextbox);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(amountTextbox);
            panel1.Controls.Add(costTextbox);
            panel1.Controls.Add(nameTexxtbox);
            panel1.Controls.Add(idTextbox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 665);
            panel1.TabIndex = 29;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 597);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Goldenrod;
            button4.Location = new Point(72, 597);
            button4.Name = "button4";
            button4.Size = new Size(88, 35);
            button4.TabIndex = 30;
            button4.Text = "Шығу";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(54, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(178, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 119);
            button1.Name = "button1";
            button1.Size = new Size(106, 37);
            button1.TabIndex = 31;
            button1.Text = "Товарлар";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 221);
            button3.Name = "button3";
            button3.Size = new Size(263, 40);
            button3.TabIndex = 30;
            button3.Text = "___________________________________";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(72, 184);
            button2.Name = "button2";
            button2.Size = new Size(106, 40);
            button2.TabIndex = 30;
            button2.Text = "Банк";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(changeButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(saveButton);
            panel2.Location = new Point(293, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 246);
            panel2.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(293, 18);
            button5.Name = "button5";
            button5.Size = new Size(168, 35);
            button5.TabIndex = 30;
            button5.Text = "Товарлар тізімі";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button4_Click;
            // 
            // productsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(693, 662);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(searchTextbox);
            Controls.Add(dataGridView1);
            Name = "productsForm";
            Text = "productsForm";
            Load += productsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextbox;
        private DataGridView dataGridView1;
        private Button deleteButton;
        private Button changeButton;
        private Button saveButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox amountTextbox;
        private TextBox costTextbox;
        private TextBox nameTexxtbox;
        private TextBox idTextbox;
        private Label label5;
        private Button addButton;
        private ComboBox typeTextbox;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button5;
    }
}
namespace Kurs
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            logoutButton = new Button();
            searchTextbox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panelContainer = new FlowLayoutPanel();
            button2 = new Button();
            categoryGroupBox = new GroupBox();
            priceGroupBox = new GroupBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.Navy;
            logoutButton.Location = new Point(741, 25);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(65, 34);
            logoutButton.TabIndex = 14;
            logoutButton.Text = "Шығу";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // searchTextbox
            // 
            searchTextbox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextbox.Location = new Point(266, 89);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.PlaceholderText = "Search";
            searchTextbox.Size = new Size(206, 32);
            searchTextbox.TabIndex = 15;
            searchTextbox.TextChanged += searchTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(33, 529);
            label2.Name = "label2";
            label2.Size = new Size(191, 21);
            label2.TabIndex = 17;
            label2.Text = "Жеткізуші болғым келеді";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(693, 65);
            button1.Name = "button1";
            button1.Size = new Size(113, 35);
            button1.TabIndex = 18;
            button1.Text = "Тапсырыстар";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.White;
            panelContainer.FlowDirection = FlowDirection.TopDown;
            panelContainer.Location = new Point(266, 142);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(540, 424);
            panelContainer.TabIndex = 19;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(266, 48);
            button2.Name = "button2";
            button2.Size = new Size(162, 35);
            button2.TabIndex = 20;
            button2.Text = "Товарлар тізімі";
            button2.UseVisualStyleBackColor = true;
            // 
            // categoryGroupBox
            // 
            categoryGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            categoryGroupBox.ForeColor = Color.White;
            categoryGroupBox.Location = new Point(33, 121);
            categoryGroupBox.Name = "categoryGroupBox";
            categoryGroupBox.Size = new Size(200, 150);
            categoryGroupBox.TabIndex = 21;
            categoryGroupBox.TabStop = false;
            categoryGroupBox.Text = "Категория";
            // 
            // priceGroupBox
            // 
            priceGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            priceGroupBox.ForeColor = Color.White;
            priceGroupBox.Location = new Point(33, 299);
            priceGroupBox.Name = "priceGroupBox";
            priceGroupBox.Size = new Size(200, 150);
            priceGroupBox.TabIndex = 21;
            priceGroupBox.TabStop = false;
            priceGroupBox.Text = "Баға";
            priceGroupBox.Enter += priceGroupBox_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(33, 498);
            label1.Name = "label1";
            label1.Size = new Size(188, 21);
            label1.TabIndex = 17;
            label1.Text = "Бухгалтер болғым келеді";
            label1.Click += label12_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(45, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(178, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 37;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(priceGroupBox);
            panel1.Controls.Add(categoryGroupBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 655);
            panel1.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 455);
            button3.Name = "button3";
            button3.Size = new Size(251, 40);
            button3.TabIndex = 31;
            button3.Text = "___________________________________";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(826, 644);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(panelContainer);
            Controls.Add(button1);
            Controls.Add(searchTextbox);
            Controls.Add(logoutButton);
            ForeColor = Color.Coral;
            Name = "userForm";
            Text = "userForm";
            Load += userForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addOrder;
        private Button logoutButton;
        private TextBox searchTextbox;
        private Label label2;
        private Button button1;
        private FlowLayoutPanel panelContainer;
        private Button button2;
        private GroupBox categoryGroupBox;
        private GroupBox priceGroupBox;
        private Label label1;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button button3;
    }
}
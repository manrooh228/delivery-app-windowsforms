namespace Kurs
{
    partial class addOrderForm
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
            productLabel = new Label();
            articuleLabel = new Label();
            nameTextbox = new TextBox();
            label1 = new Label();
            orgTextbox = new TextBox();
            label2 = new Label();
            amountTextbox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            lastCostLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productLabel.ForeColor = Color.Navy;
            productLabel.Location = new Point(44, 43);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(88, 21);
            productLabel.TabIndex = 0;
            productLabel.Text = "Тапсырыс:";
            // 
            // articuleLabel
            // 
            articuleLabel.AutoSize = true;
            articuleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            articuleLabel.ForeColor = Color.Navy;
            articuleLabel.Location = new Point(42, 76);
            articuleLabel.Name = "articuleLabel";
            articuleLabel.Size = new Size(90, 25);
            articuleLabel.TabIndex = 0;
            articuleLabel.Text = "Артикул:";
            // 
            // nameTextbox
            // 
            nameTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextbox.Location = new Point(190, 121);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(211, 39);
            nameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(42, 130);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Толық атыңыз:";
            // 
            // orgTextbox
            // 
            orgTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            orgTextbox.Location = new Point(190, 175);
            orgTextbox.Name = "orgTextbox";
            orgTextbox.Size = new Size(211, 39);
            orgTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(118, 238);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Саны:";
            // 
            // amountTextbox
            // 
            amountTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            amountTextbox.Location = new Point(190, 229);
            amountTextbox.Name = "amountTextbox";
            amountTextbox.Size = new Size(211, 39);
            amountTextbox.TabIndex = 1;
            amountTextbox.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(50, 184);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 0;
            label3.Text = "Организация:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(102, 330);
            button1.Name = "button1";
            button1.Size = new Size(237, 54);
            button1.TabIndex = 2;
            button1.Text = "Заказ жберу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lastCostLabel
            // 
            lastCostLabel.AutoSize = true;
            lastCostLabel.ForeColor = Color.Navy;
            lastCostLabel.Location = new Point(190, 280);
            lastCostLabel.Name = "lastCostLabel";
            lastCostLabel.Size = new Size(73, 15);
            lastCostLabel.TabIndex = 3;
            lastCostLabel.Text = "Сонғы баға:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lastCostLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(amountTextbox);
            panel1.Controls.Add(orgTextbox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(articuleLabel);
            panel1.Controls.Add(productLabel);
            panel1.Location = new Point(31, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 445);
            panel1.TabIndex = 4;
            // 
            // addOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 560);
            Controls.Add(panel1);
            Name = "addOrderForm";
            Text = "addOrderForm";
            Load += addOrderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label productLabel;
        private Label articuleLabel;
        private TextBox nameTextbox;
        private Label label1;
        private TextBox orgTextbox;
        private Label label2;
        private TextBox amountTextbox;
        private Label label3;
        private Button button1;
        private Label lastCostLabel;
        private Panel panel1;
    }
}
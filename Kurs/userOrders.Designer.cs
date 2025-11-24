namespace Kurs
{
    partial class userOrders
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
            ordersLabel = new Label();
            acceptedLabel = new Label();
            delieveredLabel = new Label();
            SuspendLayout();
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ordersLabel.Location = new Point(31, 65);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(267, 25);
            ordersLabel.TabIndex = 0;
            ordersLabel.Text = "Сіздің заказдарыңыздің саны:";
            // 
            // acceptedLabel
            // 
            acceptedLabel.AutoSize = true;
            acceptedLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            acceptedLabel.Location = new Point(31, 128);
            acceptedLabel.Name = "acceptedLabel";
            acceptedLabel.Size = new Size(295, 25);
            acceptedLabel.TabIndex = 0;
            acceptedLabel.Text = "Қабылданған заказдардың саны:";
            // 
            // delieveredLabel
            // 
            delieveredLabel.AutoSize = true;
            delieveredLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delieveredLabel.Location = new Point(31, 194);
            delieveredLabel.Name = "delieveredLabel";
            delieveredLabel.Size = new Size(278, 25);
            delieveredLabel.TabIndex = 0;
            delieveredLabel.Text = "Жеткізілгең заказдардың саны:";
            // 
            // userOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 285);
            Controls.Add(delieveredLabel);
            Controls.Add(acceptedLabel);
            Controls.Add(ordersLabel);
            Name = "userOrders";
            Text = "userOrders";
            Load += userOrders_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordersLabel;
        private Label acceptedLabel;
        private Label delieveredLabel;
    }
}
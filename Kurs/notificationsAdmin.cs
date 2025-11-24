using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class notificationsAdmin : Form
    {
        private FlowLayoutPanel panelContainer; // контейнер для панелей
        private VScrollBar vScrollBar;
        private Panel topPanel;
        DataBase database = new DataBase();
        public notificationsAdmin()
        {
            InitializeComponents();
            InitializeComponent();
        }
        private void InitializeComponents()
        {

            panelContainer = new FlowLayoutPanel();
            panelContainer.Dock = DockStyle.Fill; // Заполняет оставшееся пространство под topPanel
            panelContainer.FlowDirection = FlowDirection.LeftToRight;
            panelContainer.AutoScroll = true; // Включаем автоматическую прокрутку
            Label backLabel = new Label();
            backLabel.Text = "<";
            backLabel.ForeColor = Color.Goldenrod;
            backLabel.Font = new Font("Segoe UI Semibold", 24, FontStyle.Bold);
            backLabel.AutoSize = true;
            backLabel.Location = new Point(10, 20);
            backLabel.Click += new EventHandler(label_Click);
            Controls.Add(backLabel);
            Controls.Add(panelContainer);


            Controls.Add(topPanel);




            database.openConnection();

            // Подключение к базе данных


            // Запрос к базе данных
            string query = "SELECT id_query, type_query, text_query FROM queryWork";

            SqlCommand command = new SqlCommand(query, database.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Label label1 = new Label();
            label1.ForeColor = Color.Navy;
            label1.Text = "NOTIFICATIONS";
            label1.Font = new Font("Segoe UI Semibold", 24, FontStyle.Bold);//Segoe UI Semibold; 20,25pt; style = Bold
            label1.AutoSize = true;
            label1.Margin = new Padding(120, 50, 0, 50);

            panelContainer.Controls.Add(label1);

            // Создание панели для каждой строки в таблице
            foreach (DataRow row in dataTable.Rows)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.None;
                panel.BackColor = Color.Navy;
                panel.Width = 350;
                panel.Height = 120;
                panel.Margin = new Padding(90, 10, 0, 0);

                Label label = new Label();
                label.Font = new Font("Segoe UI", 12, FontStyle.Regular);//Segoe UI Semibold; 20,25pt; style = Bold
                label.ForeColor = Color.White;
                label.Text = $"ID: {row["id_query"]}\nType: {row["type_query"]}\nText: {row["text_query"]}";
                label.MaximumSize = new Size(250, 0);
                label.Dock = DockStyle.Fill;
                panel.Controls.Add(label);

                // Добавление панели в panelContainer
                panelContainer.Controls.Add(panel);

            }

        }
        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void notificationsAdmin_Load(object sender, EventArgs e)
        {

        }
        private void label_Click(object sender, EventArgs e)
        {
            adminForm adminWindow = new adminForm();
            adminWindow.Show();
            this.Hide();
        }
    }
}

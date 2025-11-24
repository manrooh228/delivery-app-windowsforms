using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = System.Drawing.Font;
using Button = System.Windows.Forms.Button;
using Image = System.Drawing.Image;

namespace Kurs
{
    public partial class userForm : Form
    {
        public string Id_product { get; set; }
        public string Name_product { get; set; }
        public string Cost_product { get; set; }
        public string Amount_product { get; set; }
        public string Type_product { get; set; }


        private loginForm loginFormInstance;
        private userForm userFormInstance;
        public userForm(loginForm loginFormInstance)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.loginFormInstance = loginFormInstance;
            userFormInstance = this;

            CheckBox[] categoryCheckBoxes = new CheckBox[6];
            string[] categories = { "Кишкентай жане сынгыш", "Кишкентай", "Орташа жане сынгыш", "Орташа", "Улкен жане сынгыш", "Улкен" };

            for (int i = 0; i < categories.Length; i++)
            {
                categoryCheckBoxes[i] = new CheckBox();
                categoryCheckBoxes[i].Text = categories[i];
                categoryCheckBoxes[i].Location = new Point(10, 20 + i * 20);
                categoryCheckBoxes[i].AutoSize = true;
                categoryCheckBoxes[i].CheckedChanged += new EventHandler(FilterChanged);
                categoryGroupBox.Controls.Add(categoryCheckBoxes[i]);
            }
            CheckBox[] priceCheckBoxes = new CheckBox[4];
            string[] priceRanges = { "0-1000", "1000-5000", "5000-10000", "20000-50000" };

            for (int i = 0; i < priceRanges.Length; i++)
            {
                priceCheckBoxes[i] = new CheckBox();
                priceCheckBoxes[i].Text = priceRanges[i];
                priceCheckBoxes[i].Location = new Point(10, 20 + i * 20);
                priceCheckBoxes[i].AutoSize = true;
                priceCheckBoxes[i].CheckedChanged += new EventHandler(FilterChanged);
                priceGroupBox.Controls.Add(priceCheckBoxes[i]);
            }
        }

        DataBase database = new DataBase();

        public void CreatePdf()
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Накладная/Накладная.pdf", FileMode.Create));
            doc.Open();
            Paragraph elements = new Paragraph($"{loginFormInstance.Username} аккаунты бар адам осы товарды = {userFormInstance.Name_product} сатып алды");
            doc.Add(elements);
            doc.Close();
            MessageBox.Show("Накладной pdf Форматта сакталды!");
        }

        private void LoadData(string filter = "", List<string> categories = null, List<Tuple<int, int>> priceRanges = null)
        {
            database.openConnection();
            DataTable dataTable = GetData(filter, categories, priceRanges);
            HashSet<int> processedIds = new HashSet<int>();

            panelContainer.Controls.Clear(); // Очищаем предыдущие панели

            foreach (DataRow row in dataTable.Rows)
            {
                int productId = Convert.ToInt32(row["id_product"]);

                if (processedIds.Contains(productId))
                {
                    continue;
                }

                processedIds.Add(productId);

                Panel panel = new Panel
                {
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = 250,
                    Height = 300,
                    Margin = new Padding(10)
                };

                PictureBox pic = new PictureBox
                {
                    Image = Image.FromFile(row["image_product"].ToString()),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 200,
                    Height = 150,
                    Location = new Point(25, 10),

                };
                pic.Click += (sender, e) =>
                {
                    userFormInstance.Name_product = Convert.ToString(row["name_product"]);
                    userFormInstance.Id_product = Convert.ToString(row["id_product"]);
                    userFormInstance.Cost_product = Convert.ToString(row["cost_product"]);
                    userFormInstance.Type_product = Convert.ToString(row["type_product"]);
                    addOrderForm addOrderForm = new addOrderForm(userFormInstance, loginFormInstance);
                    addOrderForm.ShowDialog();
                };

                Label nameLabel = new Label
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    Text = row["name_product"].ToString(),
                    ForeColor = Color.Navy,
                    AutoSize = true,
                    Location = new Point(10, 170),
                    MaximumSize = new Size(230, 0)
                };

                Label priceLabel = new Label
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Text = $"Price: {row["cost_product"]} ₸",
                    ForeColor = Color.LightSlateGray,
                    AutoSize = true,
                    Location = new Point(10, 200),
                    MaximumSize = new Size(230, 0)
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);

                panelContainer.Controls.Add(panel);
            }


            database.closeConnection();
        }
        private void TovarClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void FilterChanged(object sender, EventArgs e)
        {
            List<string> selectedCategories = new List<string>();
            foreach (CheckBox checkBox in categoryGroupBox.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    selectedCategories.Add(checkBox.Text);
                }
            }

            List<Tuple<int, int>> selectedPriceRanges = new List<Tuple<int, int>>();
            foreach (CheckBox checkBox in priceGroupBox.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    string[] range = checkBox.Text.Split('-');
                    int minPrice = int.Parse(range[0]);
                    int maxPrice = int.Parse(range[1]);
                    selectedPriceRanges.Add(new Tuple<int, int>(minPrice, maxPrice));
                }
            }

            string filter = searchTextbox.Text;
            LoadData(filter, selectedCategories, selectedPriceRanges);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var addQuery = $"insert into queryWork (text_query) values ('{loginFormInstance.Username} логины бар адам жеткизуши болып кирем диды!')";
            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("Сіздің жұмысқа кірем дегең сұрауңыз өнделіп жатыр!");
        }
        private void label12_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var addQuery = $"insert into queryWork (text_query) values ('{loginFormInstance.Username} логины бар адам бухгалтер болып кирем диды!')";
            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("Сіздің жұмысқа кірем дегең сұрауңыз өнделіп жатыр!");
        }
        private DataTable GetData(string filter = "", List<string> categories = null, List<Tuple<int, int>> priceRanges = null)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Products WHERE 1=1";

            if (!string.IsNullOrEmpty(filter))
            {
                query += " AND name_product LIKE @filter";
            }

            if (categories != null && categories.Count > 0)
            {
                string categoryFilter = string.Join(" OR ", categories.Select(c => $"type_product = '{c}'"));
                query += $" AND ({categoryFilter})";
            }

            if (priceRanges != null && priceRanges.Count > 0)
            {
                string priceFilter = string.Join(" OR ", priceRanges.Select(pr => $"(cost_product >= {pr.Item1} AND cost_product <= {pr.Item2})"));
                query += $" AND ({priceFilter})";
            }

            using (SqlCommand command = new SqlCommand(query, database.GetConnection()))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    command.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userOrders userOrders = new userOrders(loginFormInstance);
            userOrders.ShowDialog();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string filter = searchTextbox.Text;
            LoadData(filter);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void priceGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }














    /*
    private void addOrder_Click(object sender, EventArgs e)
    {
        addOrderForm addOrderForm = new addOrderForm(userFormInstance, loginFormInstance);
        addOrderForm.ShowDialog();
    }

    private void userForm_Load(object sender, EventArgs e)
    {

    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        loginForm loginForm = new loginForm();
        loginForm.Show();
        this.Hide();
    }

    private void searchTextbox_TextChanged(object sender, EventArgs e)
    {

    }


    private void label2_Click(object sender, EventArgs e)
    {
        database.openConnection();
        var addQuery = $"insert into queryWork (text_query) values ('{loginFormInstance.Username} логины бар адам жумыска кирем диды!')";
        var command = new SqlCommand(addQuery, database.GetConnection());
        command.ExecuteNonQuery();
        database.closeConnection();
        MessageBox.Show("Сіздің жұмысқа кірем дегең сұрауңыз өнделіп жатыр!");
    }


    private void button1_Click(object sender, EventArgs e)
    {
        userOrders userOrders = new userOrders(loginFormInstance);
        userOrders.ShowDialog();
    }
    */
}


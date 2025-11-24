using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kurs
{
    public partial class addProduct : Form
    {
        string selectedImagePath;
        public addProduct()
        {
            InitializeComponent();
        }
        DataBase database = new DataBase();
        private void loginButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var type = typeCombo.Text;
            var name = nameTextbox.Text;
            int cost;
            int amount;

            if (type != "" || name != "" || selectedImagePath != "")
            {
                if (int.TryParse(costTextbox.Text, out cost))
                {
                    if (int.TryParse(amountTextbox.Text, out amount))
                    {
                        var addQuery = $"insert into Products (name_product, cost_product,amount_product,type_product,image_product) values ('{name}','{cost}','{amount}','{type}','{selectedImagePath}')";//добовляет продукт
                        var command = new SqlCommand(addQuery, database.GetConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Жаңа товар сәтті қосылды!");
                        productsForm products = new productsForm();
                        products.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Товардың саны саңдық түрде болу керек!");
                    }
                }
                else
                {
                    MessageBox.Show("Баға саңдық форматта болу керек");
                }
            }
            else
            {
                MessageBox.Show("Мәндерді енгізіңіз");
            }
            database.closeConnection();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";// мтавим картинку на товар
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                // Display the selected imag
                pictureBox1.Image = Image.FromFile(selectedImagePath);

            }
        }




    }
}

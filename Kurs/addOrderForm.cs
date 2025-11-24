using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Xml.Linq;


namespace Kurs
{

    public partial class addOrderForm : Form
    {

        private userForm userFormInstance;
        private loginForm loginFormInstance;
        DataBase database = new DataBase();

        public addOrderForm(userForm userFormInstance, loginForm loginFormInstance)
        {
            InitializeComponent();


            this.loginFormInstance = loginFormInstance;
            StartPosition = FormStartPosition.CenterScreen;
            this.userFormInstance = userFormInstance;
        }


        private void addOrderForm_Load(object sender, EventArgs e)
        {
            productLabel.Text = $"Тапсырыс: {userFormInstance.Name_product}";
            articuleLabel.Text = $"Артикул: {userFormInstance.Id_product}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//выоводит сумму 
        {
            int amount;
            int lastCost;
            if (int.TryParse(amountTextbox.Text, out amount))
            {
                int cost = int.Parse(userFormInstance.Cost_product);
                lastCost = cost * amount;


                lastCostLabel.Text = $"Сонғы баға:{lastCost}";
            }
            else
            {
                lastCostLabel.Text = "Саны сан ретіңде болу керек";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            if (nameTextbox.Text != "" || orgTextbox.Text != "")
            {
                int cost = int.Parse(userFormInstance.Cost_product);

                var login = loginFormInstance.Username;

                var name = nameTextbox.Text;

                var product = userFormInstance.Name_product;

                var organ = orgTextbox.Text;
                int amount = int.Parse(amountTextbox.Text);
                int lastCost = cost * amount;

                var type = userFormInstance.Type_product;

                var addQuery = $"insert into Orders (login_user, name_user, name_product, org_order, amount_order, cost_product, type_product) values ('{login}','{name}','{product}','{organ}','{amount}','{lastCost}','{type}')";//Добавляет таблцу заказов заданый заказ эта таблица уходит курьеру
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                string amountQuery = $"UPDATE Products SET amount_product = amount_product - {amount} WHERE name_product = '{product}'";//Обвновляет количество продукта на складе
                SqlCommand amountCmd = new SqlCommand(amountQuery, database.GetConnection());
                amountCmd.ExecuteNonQuery();

                string accountQuery = $"UPDATE AccountBank SET balance_acc = balance_acc + {lastCost} WHERE id_acc = 1";//Обновляет счет администратора
                SqlCommand accountCommand = new SqlCommand(accountQuery, database.GetConnection());
                accountCommand.ExecuteNonQuery();

                MessageBox.Show("Тапсырыс жберілді!");


                this.Hide();
            }
            else
            {
                MessageBox.Show("Мәліметті толықтырыныз!");
            }
            database.closeConnection();

        }
    }
}

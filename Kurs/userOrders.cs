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
    public partial class userOrders : Form
    {   
        DataBase database = new DataBase();
        private loginForm loginFormInstance;
        public userOrders(loginForm loginFormInstance)
        {
            InitializeComponent();
            this.loginFormInstance = loginFormInstance;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Orders()
        {

            string query = $"SELECT COUNT(*) FROM Orders where login_user ='{loginFormInstance.Username}'";

            database.openConnection();
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            int rowCount = (int)command.ExecuteScalar();

            ordersLabel.Text = $"Сіздің заказдарыңыздің саны: {rowCount}";
        }
        private void Accepted()
        {


            // SQL-запрос для подсчета количества рядов в вашей таблице
            string query = $"SELECT COUNT(*) FROM AcceptedOrders where login_user ='{loginFormInstance.Username}'";

            database.openConnection();
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            int rowCount = (int)command.ExecuteScalar();

            acceptedLabel.Text = $"Қабылданған заказдардың саны: {rowCount}";
        }
        private void Delievered()
        {


            // SQL-запрос для подсчета количества рядов в вашей таблице
            string query = $"SELECT COUNT(*) FROM DeliveredOrders where login_user ='{loginFormInstance.Username}'";

            database.openConnection();
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            int rowCount = (int)command.ExecuteScalar();

            delieveredLabel.Text = $"Жеткізілгең заказдардың саны: {rowCount}";
        }
        private void userOrders_Load(object sender, EventArgs e)
        {
            Orders(); 
            Accepted();
            Delievered();

        }
    }
}

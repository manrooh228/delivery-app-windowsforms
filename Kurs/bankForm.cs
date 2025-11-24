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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kurs
{

    public partial class bankForm : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        DataBase database = new DataBase();
        int selectedRow;
        private loginForm loginFormInstance;
        public bankForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreatColumns()
        {
            dataGridView1.Columns.Add("id_acc", "id");
            dataGridView1.Columns.Add("name_acc", "Account");
            dataGridView1.Columns.Add("name_bank", "Bank");
            dataGridView1.Columns.Add("balance_acc", "Balance");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSinleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), RowState.ModifiedNew);


        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from AccountBank";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinleRow(dgw, reader);
            }
            reader.Close();
        }



        private void FillBankCombo()
        {
            database.openConnection();

            string query = "SELECT name_bank FROM Bank";
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string namePub = reader["name_bank"].ToString();
                bankCombo.Items.Add(namePub);
            }

            reader.Close();
            database.closeConnection();
        }


        private void salary(int accountId)
        {
            // Шаг 1: Получение количества водителей
            database.openConnection();
            string userQuery = "SELECT COUNT(*) FROM Users WHERE is_driver = 1";
            SqlCommand userCommand = new SqlCommand(userQuery, database.GetConnection());
            int numberOfDrivers = (int)userCommand.ExecuteScalar();
            database.closeConnection();

            // Шаг 2: Рассчет суммы для уменьшения баланса
            int decreaseAmount = numberOfDrivers * 30000;

            // Шаг 3: Обновление баланса в таблице AccountBank для конкретного счета
            database.openConnection();
            string accountQuery = $"UPDATE AccountBank SET balance_acc = balance_acc - {decreaseAmount} WHERE id_acc = {accountId}";
            SqlCommand accountCommand = new SqlCommand(accountQuery, database.GetConnection());
            accountCommand.ExecuteNonQuery();
            database.closeConnection();
        }
        /*
        private void credit(int accountId)
        {
            // Шаг 2: Рассчет суммы для уменьшения баланса
            int credit = 100000;

            // Шаг 3: Обновление баланса в таблице AccountBank для конкретного счета
            database.openConnection();
            string accountQuery = $"UPDATE AccountBank SET balance_acc = balance_acc + {credit} WHERE id_acc = {accountId}";
            SqlCommand accountCommand = new SqlCommand(accountQuery, database.GetConnection());
            accountCommand.ExecuteNonQuery();
            database.closeConnection();
        }
        */










        private void selectBank(DataGridView dgw)
        {
            if (bankCombo.Text == "")
            {
                RefreshDataGrid(dgw);
            }
            else
            {
                dgw.Rows.Clear();



                string searchString = $"select * from AccountBank where concat (id_acc,name_bank) like '%" + bankCombo.Text + "%'";

                SqlCommand com = new SqlCommand(searchString, database.GetConnection());

                database.openConnection();

                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    ReadSinleRow(dgw, read);
                }
                read.Close();// выбор банка
            }
        }










        private void bankCombo_TextChanged(object sender, EventArgs e)
        {
            selectBank(dataGridView1);
        }

        private void bankForm_Load(object sender, EventArgs e)// загрузка
        {
            FillBankCombo();

            bankCombo.KeyPress += (sender, e) => e.Handled = true;


            CreatColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Получаем значение id_acc из выбранной строки
                int accountId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_acc"].Value);

                // Выполняем списание на основе id_acc
                salary(accountId);
                //credit(accountId);
            }
        }
        private void giveSalaryButton_Click(object sender, EventArgs e)
        {
            salary(selectedRow);
            RefreshDataGrid(dataGridView1);//зарплта 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bankAccountAdd bankAccountAdd = new bankAccountAdd();
            bankAccountAdd.Show();
            this.Hide();// добавление счета
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankAdd bankAdd = new bankAdd();
            bankAdd.Show();
            this.Hide();// добавление счета
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            //credit(selectedRow);
            RefreshDataGrid(dataGridView1);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            adminForm userform = new adminForm();
            userform.Show();
            this.Hide();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            productsForm product = new productsForm();
            product.Show();
            this.Hide();//переход на страницу товаров
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void notificationsButton_Click(object sender, EventArgs e)
        {
            notificationsAdmin notificationsAdmin = new notificationsAdmin();
            notificationsAdmin.ShowDialog();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notificationsAdmin notificationsAdmin = new notificationsAdmin();
            notificationsAdmin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }
    }
}

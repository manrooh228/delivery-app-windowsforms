using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class acceptedDriver : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        private loginForm loginFormInstance;
        public acceptedDriver(loginForm loginFormInstance)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.loginFormInstance = loginFormInstance;
        }


        private void CreatColumns()
        {
            dataGridView1.Columns.Add("id_order", "ID");
            dataGridView1.Columns.Add("login_user", "UserName");
            dataGridView1.Columns.Add("login_driver", "DriverName");
            dataGridView1.Columns.Add("name_product", "Product");
            dataGridView1.Columns.Add("amount_product", "Amount");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSinleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);


        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from AcceptedOrders";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinleRow(dgw, reader);
            }
            reader.Close();
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }
        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {

                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {

                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from AcceptedOrders where id_order = {id}";


                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        private void Confirm()//Приколюха для добавления в Таблицу Доставленых заказов.
        {
            var user = label1.Text;
            var driver = label2.Text;
            var product = label3.Text;
            int amount = int.Parse(label4.Text);
            if (label1.Text != "")
            {
                database.openConnection();
                var addQuery = $"insert into DeliveredOrders (login_user,login_driver,name_product,amount_product) values ('{user}','{driver}','{product}','{amount}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Жұмысыңызға көп алғыс!");
            }
            else
            {
                MessageBox.Show("Заказ танданыз!");
            }

        }








        private void acceptedDriver_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightBlue,
                SelectionForeColor = Color.Black,

            };

            CreatColumns();
            RefreshDataGrid(dataGridView1);

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driverForm driverForm = new driverForm(loginFormInstance);
            driverForm.Show();
            this.Hide();
        }

        private void complitedButton_Click(object sender, EventArgs e)
        {
            Confirm();
            deleteRow();
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                var name = row.Cells[0].Value.ToString();

                label1.Text = row.Cells[1].Value.ToString();
                label2.Text = row.Cells[2].Value.ToString();
                label3.Text = row.Cells[3].Value.ToString();
                label4.Text = row.Cells[4].Value.ToString();



                selectedOrder.Text = $"Таңдалған заказ: {name}";
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

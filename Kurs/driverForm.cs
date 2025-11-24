using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kurs
{
    public partial class driverForm : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        private loginForm loginFormInstance;
        DataBase database = new DataBase();
        int selectedRow;

        public driverForm(loginForm loginFormInstance)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.loginFormInstance = loginFormInstance;
            this.loginFormInstance = loginFormInstance;
        }
        private void CreatColumns()
        {
            dataGridView1.Columns.Add("id_order", "ID");
            dataGridView1.Columns.Add("login_user", "UserName");
            dataGridView1.Columns.Add("name_user", "FullName");
            dataGridView1.Columns.Add("name_product", "Product");
            dataGridView1.Columns.Add("org_order", "Organization");
            dataGridView1.Columns.Add("amount_order", "Amount");//5
            dataGridView1.Columns.Add("cost_product", "Cost");
            dataGridView1.Columns.Add("type_product", "Type");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSinleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7), RowState.ModifiedNew);


        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Orders";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinleRow(dgw, reader);
            }
            reader.Close();
        }
        /*
            Газель
            Легковушка
            Джип
            Трак
         */

        /*
            Кишкентай жане сынгыш
            Кишкентай
            Орташа жане сынгыш
            Орташа
            Улкен жане сынгыш
            Улкен
         */
        private void Sort(DataGridView dgw)
        {
            if (comboBox1.Text == "Трак")
            {
                RefreshDataGrid(dgw);
            }
            else if (comboBox1.Text == "Джип")
            {
                dgw.Rows.Clear();

                string searchString = $"select * from Orders where concat (type_product, '') like 'Орташа%'";

                SqlCommand com = new SqlCommand(searchString, database.GetConnection());

                database.openConnection();

                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    ReadSinleRow(dgw, read);
                }
                read.Close();

            }
            else if (comboBox1.Text == "Газель")
            {
                RefreshDataGrid(dgw);
            }
            else if (comboBox1.Text == "Легковушка")
            {
                dgw.Rows.Clear();

                string searchString = $"select * from Orders where concat (type_product,'') like 'Кишкентай%'";

                SqlCommand com = new SqlCommand(searchString, database.GetConnection());

                database.openConnection();

                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    ReadSinleRow(dgw, read);
                }
                read.Close();
            }
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
        }
        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {

                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                {

                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Orders where id_order = {id}";


                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        private void Accept()
        {
            var user = label2.Text;
            var driver = loginFormInstance.Username;
            var product = label3.Text;
            int amount = int.Parse(label4.Text);
            if (label1.Text != "")
            {
                database.openConnection();
                var addQuery = $"insert into AcceptedOrders (login_user,login_driver,name_product,amount_product) values ('{user}','{driver}','{product}','{amount}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("Заказ қабылданды!");
            }
            else
            {
                MessageBox.Show("Заказ танданыз!");
            }

        }




        private void acceptButton_Click(object sender, EventArgs e)
        {
            Accept();
            deleteRow();
            Update();
            RefreshDataGrid(dataGridView1);
        }

        private void driverForm_Load(object sender, EventArgs e)
        {
            CreatColumns();
            RefreshDataGrid(dataGridView1);

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                var name = row.Cells[0].Value.ToString();

                label1.Text = row.Cells[0].Value.ToString();
                label2.Text = row.Cells[1].Value.ToString();
                label3.Text = row.Cells[3].Value.ToString();
                label4.Text = row.Cells[5].Value.ToString();



                selectedOrder.Text = $"Таңдалған заказ: {name}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acceptedDriver accepted = new acceptedDriver(loginFormInstance);
            accepted.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            acceptedDriver accepted = new acceptedDriver(loginFormInstance);
            accepted.Show();
            this.Hide();
        }
    }
}

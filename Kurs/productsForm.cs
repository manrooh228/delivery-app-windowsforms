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
    public partial class productsForm : Form
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

        public productsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreatColumns()
        {
            dataGridView1.Columns.Add("id_product", "Articule");
            dataGridView1.Columns.Add("name_product", "Name");
            dataGridView1.Columns.Add("cost_product", "Cost");
            dataGridView1.Columns.Add("amount_product", "Amount");
            dataGridView1.Columns.Add("type_product", "TypeProduct");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSinleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4), RowState.ModifiedNew);


        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Products";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();



            string searchString = $"select * from Products where concat (id_product, name_product) like '%" + searchTextbox.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.GetConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSinleRow(dgw, read);
            }
            read.Close();
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
                    var deleteQuery = $"delete from Products where id_product = {id}";


                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();

                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();

                    var cost = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var amount = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var type = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update Products set name_product = '{name}', cost_product = '{cost}', amount_product = '{amount}', type_product = '{type}' where id_product = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Change()
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = idTextbox.Text;
            var name = nameTexxtbox.Text;
            var cost = costTextbox.Text;
            var amount = amountTextbox.Text;
            var type = typeTextbox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {

                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, cost, amount, type);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;

            }
            else
            {
                MessageBox.Show("Енгизилген малиметтин форматы дурыс емес!");
            }
        }

        private void ClearFields()
        {
            idTextbox.Text = "";
            nameTexxtbox.Text = "";
            costTextbox.Text = "";
            amountTextbox.Text = "";
            typeTextbox.Text = "";
        }







        private void productsForm_Load(object sender, EventArgs e)
        {
            CreatColumns();
            RefreshDataGrid(dataGridView1);
            typeTextbox.KeyPress += (sender, e) => e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                idTextbox.Text = row.Cells[0].Value.ToString();
                nameTexxtbox.Text = row.Cells[1].Value.ToString();
                costTextbox.Text = row.Cells[2].Value.ToString();
                amountTextbox.Text = row.Cells[3].Value.ToString();
                typeTextbox.Text = row.Cells[4].Value.ToString();

            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void refreshbButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addProduct addProduct = new addProduct();
            addProduct.Show();
            this.Hide();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            adminForm.Show();
            this.Hide();
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            bankForm bankForm = new bankForm();
            bankForm.Show();
            this.Hide();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankForm bankForm = new bankForm();
            bankForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

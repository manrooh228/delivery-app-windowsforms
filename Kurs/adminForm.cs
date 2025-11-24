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
using System.Reflection;

namespace Kurs
{
    public partial class adminForm : Form
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
        public adminForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreatColumns()
        {
            dataGridView1.Columns.Add("id_user", "id");
            dataGridView1.Columns.Add("login_user", "Username");
            dataGridView1.Columns.Add("password_user", "Password");
            dataGridView1.Columns.Add("is_admin", "isAdmin");
            dataGridView1.Columns.Add("is_driver", "isDriver");
            dataGridView1.Columns.Add("is_buhgalter", "isBuhgalter");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSinleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3), record.GetBoolean(4), record.GetBoolean(5), RowState.ModifiedNew);


        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Users";

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



            string searchString = $"select * from Users where concat (id_user, login_user) like '%" + textBox1.Text + "%'";

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
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {

                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                {

                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Users where id_user = {id}";


                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();

                    var username = dataGridView1.Rows[index].Cells[1].Value.ToString();

                    var password = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var isAdmin = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var isDriver = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var isBuh = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update Users set login_user = '{username}', password_user = '{password}', is_admin = '{isAdmin}', is_driver = '{isDriver}', is_buhgalter = '{isBuh}' where id_user = '{id}'";

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
            var id = row.Cells[0].Value.ToString();
            var password = passwordTextbox.Text;
            var username = usernameTextbox.Text;
            var isAdmin = isAdminTextbox.Text;
            var isDriver = isDriverTextbox.Text;
            var isBuh = textBox2.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {

                dataGridView1.Rows[selectedRowIndex].SetValues(id, username, password, isAdmin, isDriver, isBuh);
                dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;

            }
            else
            {
                MessageBox.Show("Енгизилген малиметтин форматы дурыс емес!");
            }
        }


        private void ClearFields()
        {
            usernameTextbox.Text = "";
            passwordTextbox.Text = "";
            isAdminTextbox.Text = "";
            isDriverTextbox.Text = "";
            textBox2.Text = "";
        }




        private void saveButton_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            CreatColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                usernameTextbox.Text = row.Cells[1].Value.ToString();
                passwordTextbox.Text = row.Cells[2].Value.ToString();
                isAdminTextbox.Text = row.Cells[3].Value.ToString();
                isDriverTextbox.Text = row.Cells[4].Value.ToString();
                textBox2.Text = row.Cells[5].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);// поискк
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();// обновление 
        }

        private void refreshbButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);// обновление страницы
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsForm productsForm = new productsForm();// страница продукта
            productsForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)//logout
        {
            loginForm loginForm = new loginForm();
            this.Hide();
            loginForm.Show();

        }

        private void bankButton_Click(object sender, EventArgs e)//страница банка
        {
            bankForm bankForm = new bankForm();
            bankForm.Show();
            this.Hide();
        }

        private void notificationsButton_Click(object sender, EventArgs e)
        {
            notificationsAdmin notificationsAdmin = new notificationsAdmin();// запрос
            notificationsAdmin.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notificationsAdmin notificationsAdmin = new notificationsAdmin();
            notificationsAdmin.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            
            loginForm.Show();

            this.Hide();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {

        }
    }
}

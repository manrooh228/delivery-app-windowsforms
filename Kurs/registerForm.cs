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
    public partial class registerForm : Form
    {
        DataBase database = new DataBase();
        public registerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var password = passwordTextbox.Text;
            var login = usernameTextbox.Text;

            string querystring = $"insert into users (login_user, password_user) values ('{login}','{password}')";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account succesfully created!", "SUCCESS");
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account not created!", "ERROR");
            }
            database.closeConnection();
        }
        private Boolean checkuser()
        {
            var loginUser = usernameTextbox.Text;
            var passUser = passwordTextbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select * from Users where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Account already been created!");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

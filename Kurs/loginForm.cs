using System.Data.SqlClient;
using System.Data;

namespace Kurs
{
    public partial class loginForm : Form
    {
        DataBase dataBase = new DataBase();

        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        private loginForm loginFormInstance;
        public loginForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            loginFormInstance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextbox.Text;
            var password = passwordTextbox.Text;
            Username = usernameTextbox.Text;
            Password = passwordTextbox.Text;
            // Проверка логина и пароля

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin, is_driver, is_buhgalter from Users where login_user = '{username}' and password_user = '{password}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {

                bool isAdmin = Convert.ToBoolean(table.Rows[0]["is_admin"]);
                bool isDriver = Convert.ToBoolean(table.Rows[0]["is_driver"]);
                bool isBuh = Convert.ToBoolean(table.Rows[0]["is_buhgalter"]);

                if (isAdmin)
                {
                    adminForm adminForm = new adminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (isDriver)
                {
                    driverForm driverForm = new driverForm(loginFormInstance);
                    driverForm.Show();
                    this.Hide();
                }
                else if (isBuh)
                {
                    productsForm driver1Form = new productsForm();
                    driver1Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kosh keldiniz!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userForm userWindow = new userForm(loginFormInstance);
                    userWindow.Show();
                    this.Hide();
                }
                Id = Convert.ToInt32(table.Rows[0]["id_user"]);


            }
            else
            {
                MessageBox.Show("Bundai accaunt zhok!", "ERROR111", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
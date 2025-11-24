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

    public partial class bankAccountAdd : Form
    {

        DataBase database = new DataBase();

        public bankAccountAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void fillCombo()
        {
            database.openConnection();

            string query = "SELECT name_bank FROM Bank";
            SqlCommand command = new SqlCommand(query, database.GetConnection());// пополняет таблицу банка
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string namePub = reader["name_bank"].ToString();
                bankCombo.Items.Add(namePub);
            }

            reader.Close();
            database.closeConnection();
        }





        private void loginButton_Click(object sender, EventArgs e)
        {

            database.openConnection();

            var name = nameTextbox.Text;// счет добавляет
            var bank = bankCombo.Text;
            int balance = 0;

            if (name != "" || bank != "")
            {

                var addQuery = $"insert into AccountBank (name_acc, name_bank, balance_acc) values ('{name}','{bank}','{balance}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Жаңа Шот сәтті қосылды!");
                bankForm bankForm = new bankForm();
                bankForm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Мәндерді енгізіңіз");
            }
            database.closeConnection();
        }

        private void bankAccountAdd_Load(object sender, EventArgs e)
        {
            bankCombo.KeyPress += (sender, e) => e.Handled = true;
            fillCombo();// при входе на страгицу
        }
    }
}

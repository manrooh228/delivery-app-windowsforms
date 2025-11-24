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
    public partial class bankAdd : Form
    {
        DataBase database = new DataBase();

        public bankAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bankAdd_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = nameTextbox.Text;
            int bin;


            if (name != "")
            {
                if (int.TryParse(binTextbox.Text, out bin))
                {

                    var addQuery = $"insert into Bank (name_bank, rnn_bank) values ('{name}','{bin}')";
                    var command = new SqlCommand(addQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Жаңа Bank сәтті қосылды!");
                    bankForm bankForm = new bankForm();
                    bankForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("БИН саңдық форматта болу керек");
                }
            }
            else
            {
                MessageBox.Show("Мәндерді енгізіңіз");
            }
            database.closeConnection();
        }
    }
}

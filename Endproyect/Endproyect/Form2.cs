using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Endproyect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Registrar()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT from user where username = '" + textBox1.Text + "' AND password = SHA1('" + textBox2.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";

                if (reader.Read())
                {
                    MessageBox.Show("REGISTRO EXITOSO");
                    databaseConnection.Close();
                }
                else
                {
                    MessageBox.Show("REGISTRO FALLIDO");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar();
            Form4 menu = new Form4();
            menu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}

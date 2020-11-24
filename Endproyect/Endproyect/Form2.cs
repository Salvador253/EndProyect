//Diaz Martinez Salvador
//Oviedo Vargas Luis Eduardo
//Suarez Rubio Guadalupe
//Vazquez Barreto Yesenia 
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

        private void INICIO()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM usuarios where nombre = '" + textBox1.Text + "' AND password = ('" + textBox2.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                textBox1.Text = "";
                textBox2.Text = "";

                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido.");
                    this.Hide();
                    Form4 menu = new Form4();
                    menu.Show();
                }
                else
                {
                    label3.Visible = true;
                }
                databaseConnection.Close();
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
            INICIO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 login = new Form3();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://sites.google.com/view/x-raycompany/inicio");
        }
    }
}

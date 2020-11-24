using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.MySql.Client;

namespace Endpryect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buscardatos()
        {
            string Connect = "datasorce=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM clientes where id1= '" + textBox1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        textBox1.Text = row[1];
                        textBox3.Text = row[2];
                        textBox4.Text = row[3];
                        textBox2.Text = row[4];
                        
                    }
                }
                else
                {
                    MessageBox.Show("se han buscado los datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void actualizardatos()
        {
            string Connect = "datasorce=localhost;port=3306;username=root;password=;database=xray";
            string query = "UPDATE `clientes` SET `nombre`='" + textBox3.Text + "',`contraseña`='" + textBox2.Text + "',`id1`='" + textBox1.Text + "',`no_serie`='" + textBox4.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("datos actualizados");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void borrardatos()
        {
            string Connect = "datasorce=localhost;port=3306;username=root;password=;database=xray";
            string query = "DELETE FROM clientes WHERE id1 = '" + textBox1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("datos eliminados");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                   
}

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void registrarcliente()
        {
            string Connect = "datasorce=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT from clientes where  `nombre` SET `nombre`='" + textBox3.Text + "',`contraseña`='" + textBox2.Text + "',`no_serie`='" + textBox4.Text + "' AND id1 ='" + textBox1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("se ha registrado datos del cliente");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

               if(reader.Read))
               {

                    MessageBox.Show("Registro exitoso");
                    databaseConnection.Close;

                }

                 else
                {
                    MessageBox.Show("Registro fallido");
                }

           }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}

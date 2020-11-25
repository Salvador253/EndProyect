   
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM empleados ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Existen datos");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Registro()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "INSERT INTO empleados(`id3`, `apellido`, `nombre`, `correo`, `n_contacto`, `especialidad`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' ,'" + textBox4.Text + "' ,'" + textBox5.Text + "')";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Registro exitoso.");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarDato()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM empleados where id3='" + textBox6.Text + "' ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Existen datos");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Buscar()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM empleados where id3= '" + textBox6.Text + "'";
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
                        textBox3.Text = row[3];
                        textBox4.Text = row[4];
                        textBox2.Text = row[2];
                        textBox5.Text = row[5];
                    }
                }
                else
                {
                    MessageBox.Show("Registro inexistente.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modificardato()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "UPDATE `empleados` SET `nombre`='" + textBox1.Text + "',`apellido`='" + textBox2.Text + "',`n_contacto`='" + textBox3.Text + "',`correo`='" + textBox4.Text + "',`especialidad`='" + textBox5.Text + "' WHERE id3='" + textBox6.Text +  "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("DATO ACTIALIZADO");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Eliminar()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "DELETE FROM empleados WHERE id3 = '" + textBox6.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("Eliminado");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NOMBRE_Click(object sender, EventArgs e)
        {

        }

        private void APELLIDO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarDato();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No se modifico ningun nombre ");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("No se modifico apellido");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No se modifico contacto");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No se modifico correo");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No se modifico especialidad");
            }
            else
            {
                Modificardato();
                MostrarDato();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_admins menu2 = new menu_admins();
            menu2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
    }

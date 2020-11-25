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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM clientes";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("No se puedo accesar");
                }
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void actualizardatos()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "UPDATE `clientes` SET `id1`='" + textBox1.Text + "',`nombrehe`='" + textBox2.Text + "',`encargado`='" + textBox3.Text + "',`equipo`='" + textBox4.Text + "',`no_serie` ='" + textBox5.Text + "',`marca` = '" + textBox6.Text + "', `modelo`='" + textBox7.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("Datos actualizados");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox7.Text = "";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Buscardatos()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
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
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                        textBox1.Text = row[1];
                        textBox3.Text = row[3];
                        textBox2.Text = row[2];
                        textBox4.Text = row[4];
                        textBox5.Text = row[5];
                        textBox6.Text = row[6];
                        textBox7.Text = row[7];
                    }   
                }
                else
                {
                     MessageBox.Show("No se han buscado los datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void borrardatos()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
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
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Actualizarlist()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM clientes where id1 = '" + textBox1.Text + "'";
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
                    MessageBox.Show("Empresa no encontrada.");

                }
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registrarcliente()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "INSERT INTO nombre(`id1`, `nombrehe`,`encargado`, `equipo`, `no_serie`,`marca`,`modelo`) VALUES( NULL, '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
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
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("No tienes nombre");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No tienes encargado");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No pusiste un equipo");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No pusiste numero de serie");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("No pusiste marca");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("No pusiste modelo");
            }
            else
            {
                Buscardatos();
                actualizardatos();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscardatos();
            Actualizarlist();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("No tienes nombre");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No tienes encargado");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No pusiste un equipo");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No pusiste numero de serie");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("No pusiste marca");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("No pusiste modelo");
            }
            else
            {
                registrarcliente();
                actualizardatos();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar esta empresa?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                borrardatos();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_admins menu2 = new menu_admins();
            menu2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            actualizardatos();
        }
    }
}

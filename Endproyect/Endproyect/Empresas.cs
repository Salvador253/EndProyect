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
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM empresas";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();//abre la coneccion con la DB
                reader = databaseCommand.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())//Coneccion de la base con el listView
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No se puedo accesar");
                }
                conectionDatabase.Close();//Cierra la conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NuevoRegistro()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "INSERT INTO empresas (`id4`, `nombre`, `nom_titular`, `marca`, `contacto`, `correo`) VALUES (NULL,'" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text +"', '" + textBox5.Text+ "', '"+ textBox6.Text+ "')";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Empresa agregado.");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Actualizar()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM empresas";
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
                        var ListViewItem = new ListViewItem(row);
                        listView1.Items.Add(ListViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Actualizados");
                }
                conectionDatabase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Buscar()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM empresas where id4= '" + textBox2.Text + "'";
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
                        textBox5.Text = row[4];
                        textBox6.Text = row[5];
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

        private void ActualizarRegistro()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "UPDATE `empresas` SET `id4`='" + textBox2.Text + "',`nombre`='" + textBox1.Text + "',`nom_titular`='" + textBox3.Text + "',`marca`='" + textBox4.Text + "',`contacto`='" + textBox5.Text + "',`correo`='" + textBox6.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("Empresa Actualizada");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Eliminar()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "DELETE FROM empresas WHERE id4 = '"+textBox2.Text+"'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("Empresa eliminada.");
                databaseConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No tienes nombre de la empresa");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No tienes nombre del titular");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No pusiste marca");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No pusiste número de contacto");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("No pusiste correo");
            }
            else
            {
                NuevoRegistro();
                Actualizar();
                textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No tienes nombre de la empresa");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No tienes nombre del titular");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No pusiste marca");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No pusiste número de contacto");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("No pusiste correo");
            }
            else
            {
                ActualizarRegistro();
                Actualizar();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de eliminar esta empresa?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Eliminar();
            }
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_admins menu2 = new menu_admins();
            menu2.Show();
        }
    }
}

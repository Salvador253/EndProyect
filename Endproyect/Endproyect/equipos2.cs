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
    public partial class equipos2 : Form
    {
        public equipos2()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM equipos where id5 = '" + textBox1.Text + "'";
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
                        textBox1.Text = row[0];
                        textBox2.Text = row[1];
                        textBox3.Text = row[2];
                        textBox4.Text = row[3];
                        textBox5.Text = row[4];
                        textBox6.Text = row[5];
                    }
                }
                else
                {
                    MessageBox.Show("equipo inexistente inexistente.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Actualizar()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM equipos where id5 = '" + textBox1.Text + "'";
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
                    Console.WriteLine("EQUIPO INEXISTENTE");

                }
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NuevoEquipo()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "INSERT INTO equipos (`id5`, `equipo`, `marca`, `modelo`, `estado`, `tipo`) VALUES (NULL,'" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
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

        private void ActualizarEquipo()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "UPDATE `equipos` SET `id5`='" + textBox1.Text + "',`equipo`='" + textBox2.Text + "',`marca`='" + textBox3.Text + "',`modelo`='" + textBox4.Text + "',`estado`='" + textBox5.Text + "',`tipo`='" + textBox6.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("Equipo Actualizada");
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
            string query = "DELETE FROM equipos WHERE id5 = '" + textBox1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myRead = commandDatabase.ExecuteReader();
                MessageBox.Show("Equipo eliminado.");
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

        private void equipos2_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "SELECT * FROM equipos";
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
                    Console.WriteLine("EQUIPO INEXISTENTE");

                }
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
            Actualizar();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("No contiene equipo");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No contiene modelo");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No contiene marca");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No contiene estado");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("No contiene tipo");
            }
            else
            {
                NuevoEquipo();
                Actualizar();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("No contiene equipo");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No cntiene marca");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No contiene modelo");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("No contiene estado");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("No contiene tipo");
            }
            else
            {
                ActualizarEquipo();
                Actualizar();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar este equipo?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Eliminar();
            }
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_admins menu2 = new menu_admins();
            menu2.Show();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void login()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=xray";
            string query = "INSERT INTO usuarios(`id6`,`nombre`, `password`,`permiso`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', 1)";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Registro Exitoso.", "Registro");
                databaseConnection.Close();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No se ha ingrasado un usuaro.");
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("No se ha ingrasado una contaseña.");
            }
            else
            {
                login();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 INICIO = new Form2();
            INICIO.Show();
        }
    }
}

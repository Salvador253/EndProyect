﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient

namespace Endproyect
{
    public partial class menu_admin : Form
    {
        private void menu2()
        {

        }
        public menu_admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1_Load = new Form1();
            Form1_Load.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes Clientes_Load = new Clientes();
            Clientes_Load.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Costos Costos_Load = new Costos();
            Costos_Load.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresas Empresas_Load = new Empresas();
            Empresas_Load.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Registrar = new Form2();
            Registrar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipos_2 Equipos_2_Load = new Equipos_2();
            Equipos_2_Load.Show();
        }
    }
}

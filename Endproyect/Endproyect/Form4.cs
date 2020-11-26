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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void menu()
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados empresa = new Empleados();
            empresa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 equipos = new Form5();
            equipos.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Registrar = new Form2();
            Registrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes_2 cliente = new Clientes_2();
            cliente.Show();
        }
    }
}

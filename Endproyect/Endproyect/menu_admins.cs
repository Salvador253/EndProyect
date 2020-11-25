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
    public partial class menu_admins : Form
    {
        public menu_admins()
        {
            InitializeComponent();
        }

        private void menu2()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Costos Costos_Load = new Costos();
            Costos_Load.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1_Load = new Form1();
            Form1_Load.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresas Empresas_Load = new Empresas();
            Empresas_Load.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

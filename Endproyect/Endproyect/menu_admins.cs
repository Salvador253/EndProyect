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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresas Empresas_Load = new Empresas();
            Empresas_Load.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            equipos2 equipos2_Load = new equipos2();
            equipos2_Load.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Registrar = new Form2();
            Registrar.Show();
        }

        private void menu_admins_Load(object sender, EventArgs e)
        {

        }
    }
}

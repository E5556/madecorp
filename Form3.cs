using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm_ingreso = new Proveedores();
            frm_ingreso.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm_ingreso = new VENTAS();
            frm_ingreso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm_ingreso = new clientes();
            frm_ingreso.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm_ingreso = new Usuarios();
            frm_ingreso.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm_ingreso = new Compras();
            frm_ingreso.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm_ingreso = new inventario();
            frm_ingreso.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

            Form frm_ingreso = new Proveedores();
            frm_ingreso.Show();
        }
    }
}

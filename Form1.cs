using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            int n = Productos.Rows.Add();

            Productos.Rows[n].Cells[0].Value = txcodigo.Text;
            Productos.Rows[n].Cells[1].Value = txtnombre.Text;
            Productos.Rows[n].Cells[2].Value = txtprecio.Text;

            txcodigo.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
            txcodigo.Focus();

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            Productos.Rows.Remove(Productos.CurrentRow);

        }
    }
}

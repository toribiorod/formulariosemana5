using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManagment.Domain.Entities;

namespace CourseManagment
{
    public partial class frmClientes : Form
    {
        private Cliente clientesBL;
        public frmClientes()
        {
            this.clientesBL = new Cliente();
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            cli.Nombre = textBox1.Text;
            cli.Apellido = textBox2.Text;
            cli.Direccion = textBox3.Text;
            cli.Rut = textBox4.Text;
            cli.Cuenta = textBox5.Text;

            clientesBL.agregarClientes(cli);

            dataGridView1.DataSource = clientesBL.obtenerClientes();
            dataGridView1.Refresh();
        }
    }
}

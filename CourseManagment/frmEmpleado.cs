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
    public partial class frmEmpleado : Form
    {
        private Empleado empleadobl;
        public frmEmpleado()
        {
            this.empleadobl = new Empleado();
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado epl = new Empleado();

            epl.Nombre = txtNombre.Text;
            epl.Apellido = txtApellido.Text;
            epl.Direccion = txtDireccion.Text;
            epl.Rut = txtRUT.Text;
            int numberint;
            decimal numberdecimal;
            bool successint = Int32.TryParse(txtCodigo.Text, out numberint);
            if (successint)
            {
                epl.Codigo = Convert.ToInt32(txtCodigo.Text);
            }
            else {
                MessageBox.Show("Debe ser entero el codigo");
            }
            bool successdecimal = decimal.TryParse(txtSueldo.Text, out numberdecimal);
            if (successdecimal)
            {
                epl.Sueldo = Convert.ToDecimal(txtSueldo.Text);
            }
            else
            {
                MessageBox.Show("Debe ser entero el codigo");
            }
            //


            this.empleadobl.agregarEmpleado(epl);
            dgvEmpleado.DataSource = this.empleadobl.obtenerEmpleados().ToArray();
            dgvEmpleado.Refresh();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

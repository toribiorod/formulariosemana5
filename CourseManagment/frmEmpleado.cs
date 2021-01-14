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
            epl.Codigo = int.Parse(txtCodigo.Text);
            epl.Sueldo = Convert.ToDecimal(txtSueldo.Text);

            this.empleadobl.agregarEmpleado(epl);
            dgvEmpleado.DataSource = this.empleadobl.obtenerEmpleados();
            dgvEmpleado.Refresh();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManagment.Domain.Entities;
using CourseManagment.Domain.BL;

namespace CourseManagment
{
    public partial class frmEmpleado : Form
    {
        //private Empleado empleadobl;
        private EmpleadoBL empleadobl;
        public frmEmpleado()
        {
            //this.empleadobl = new Empleado();
            this.empleadobl = new EmpleadoBL();
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado epl = new Empleado() { 

            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Direccion = txtDireccion.Text,
            Rut = txtRUT.Text,
            Codigo = Convert.ToInt32(txtCodigo.Text),
            Sueldo = Convert.ToDecimal(txtSueldo.Text),
        };

            //
            this.empleadobl.guardar(epl);
            // this.empleadobl.agregarEmpleado(epl);
            //  dgvEmpleado.DataSource = this.empleadobl.obtenerEmpleados().ToArray();
            CargaEmpleados();
            LimpiarCampos();
            dgvEmpleado.Refresh();



        }

        private void CargaEmpleados()
        {
            this.dgvEmpleado.DataSource = this.empleadobl.obtenerRegistro().ToArray();
            this.dgvEmpleado.Refresh();
            //this.dgvProfesores.DataSource = this.profesorBL.obtenerRegistro.ToArray();
            //this.dgvProfesores.Refresh();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtRUT.Text = string.Empty;
            txtSueldo.Text = string.Empty;


            txtNombre.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow dataGridView = this.dgvEmpleado.Rows[e.RowIndex];
                txtNombre.Text = dataGridView.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dataGridView.Cells["Direccion"].Value.ToString();
                txtRUT.Text = dataGridView.Cells["Rut"].Value.ToString();
                txtCodigo.Text = dataGridView.Cells["Codigo"].Value.ToString();
                txtSueldo.Text = dataGridView.Cells["Sueldo"].Value.ToString();
           }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {

                MessageBox.Show("El codigo del empleado es requerido.", "Eliminar profesor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            Empleado empleado = this.empleadobl.obtenerIntety(Convert.ToInt32(txtCodigo.Text));
            this.empleadobl.eliminar(empleado);
            LimpiarCampos();
            CargaEmpleados();
            dgvEmpleado.Refresh();
            MessageBox.Show("Empleado eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
      
        }
    }
}

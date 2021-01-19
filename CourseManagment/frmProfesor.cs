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
    public partial class frmProfesor : Form
    {
        private ProfesorBL profesorBL;
        public frmProfesor()
        {
            this.profesorBL = new ProfesorBL();
            InitializeComponent();
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*Profesor pro = new Profesor();
             pro.Nombre = txtNombre.Text;
             pro.Apellido = txtApellido.Text;
             pro.Direccion = txtDireccion.Text;
             pro.Rut = txtRUT.Text;
             pro.Codigo = txtCodigo.Text;
             pro.Carrera = txtCarrera.Text;
             pro.Departamento = txtDepartamento.Text;*/
            Profesor pro = new Profesor()
            {
                Nombre = txtNombre.Text,
                Apellido= txtApellido.Text,
                Direccion = txtDireccion.Text,
                Rut = txtRUT.Text,
                Codigo = txtCodigo.Text,
                Carrera = txtCarrera.Text,
                Departamento = txtDepartamento.Text
        };

            //this.profesorBL.agregarProfesores(pro);
            //dgvProfesor.DataSource = this.profesorBL.obtenerProfesores().ToArray();
            this.profesorBL.guardar(pro);
            CargaProfesores();
            LimpiarCampos();
            dgvProfesor.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaProfesores()
        {
            this.dgvProfesor.DataSource = this.profesorBL.obtenerRegistro().ToArray();
            this.dgvProfesor.Refresh();
            //this.dgvProfesores.DataSource = this.profesorBL.obtenerRegistro.ToArray();
            //this.dgvProfesores.Refresh();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCarrera.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtRUT.Text = string.Empty;
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text)) {

                MessageBox.Show("El codigo del profesor es requerido.", "Eliminar profesor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();       
            }
            Profesor profesor = this.profesorBL.ObtenerProfesorPorCodigo(txtCodigo.Text);
            this.profesorBL.eliminar(profesor);
            LimpiarCampos();
            CargaProfesores();
            dgvProfesor.Refresh();
            MessageBox.Show("Profesor eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {

                DataGridViewRow dataGridView = this.dgvProfesor.Rows[e.RowIndex];
                txtNombre.Text = dataGridView.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dataGridView.Cells["Direccion"].Value.ToString();
                txtRUT.Text = dataGridView.Cells["Rut"].Value.ToString();
                txtCodigo.Text = dataGridView.Cells["Codigo"].Value.ToString();
                txtCarrera.Text = dataGridView.Cells["Carrera"].Value.ToString();
                txtDepartamento.Text = dataGridView.Cells["Departamento"].Value.ToString();              


            }
        }
    }
}

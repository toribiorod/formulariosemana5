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
    public partial class frmProfesor : Form
    {
        private Profesor profesorBL;
        public frmProfesor()
        {
            this.profesorBL = new Profesor();
            InitializeComponent();
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor pro = new Profesor();
            pro.Nombre = txtNombre.Text;
            pro.Apellido = txtApellido.Text;
            pro.Direccion = txtDireccion.Text;
            pro.Rut = txtRUT.Text;
            pro.Codigo = txtCodigo.Text;
            pro.Carrera = txtCarrera.Text;
            pro.Departamento = txtDepartamento.Text;

            this.profesorBL.agregarProfesores(pro);
            dgvProfesor.DataSource = this.profesorBL.obtenerProfesores().ToArray();
            dgvProfesor.Refresh();
        }
    }
}

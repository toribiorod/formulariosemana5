using System;
using System.Windows.Forms;
using CourseManagment.Domain.Entities;
using CourseManagment.Domain.BL;
using CourseManagment.Domain.Excepcions;

namespace CourseManagment
{
    public partial class frmClientes : Form
    {
        private ClienteBL clientesBL;
        public frmClientes()
        {
            this.clientesBL = new ClienteBL();
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Cliente cli = new Cliente() {

                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Rut = txtRut.Text,
                    Cuenta = txtCuenta.Text,

                };
                //clientesBL.agregarClientes(cli);
                //dataGridView1.DataSource = clientesBL.obtenerClientes().ToArray();
                this.clientesBL.guardar(cli);
                CargarClientes();
                LimpiarCampos();
                dgvClientes.Refresh();
                MessageBox.Show("El cliente agregado correctamente", "Información");
            }
            catch (ClienteException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Error al agregar un nuevo cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarClientes() {
            this.dgvClientes.DataSource = this.clientesBL.obtenerRegistro().ToArray();
            this.dgvClientes.Refresh();
        
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtRut.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            txtNombre.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuenta.Text))
            {

                MessageBox.Show("El codigo del Cliente es requerido.", "Eliminar profesor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
            }
            Cliente clie = this.clientesBL.obtenerIntety(Convert.ToInt32(txtCuenta.Text));
            this.clientesBL.eliminar(clie);
            LimpiarCampos();
            CargarClientes();
            dgvClientes.Refresh();
            MessageBox.Show("Cliente eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow dataGridView = this.dgvClientes.Rows[e.RowIndex];
                txtNombre.Text = dataGridView.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dataGridView.Cells["Direccion"].Value.ToString();
                txtRut.Text = dataGridView.Cells["Rut"].Value.ToString();
                txtCuenta.Text = dataGridView.Cells["Cuenta"].Value.ToString();
            }
        }
    }
}

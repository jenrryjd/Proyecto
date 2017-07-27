using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MENSAJES;
using NEGOCIO;

namespace ProyectoParcial2
{
    public partial class MedicamentoFrm : Form
    {
        public MedicamentoFrm()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        public MedicamentoFrm(MedicamentosMensaje paso)
        {
            InitializeComponent();
            txtId.Text = (string)paso.Id.ToString();
            txtNombre.Text = Convert.ToString(paso.Nombre);
            cmbTipo.Text = paso.Tipo;
            txtDescripcion.Text = Convert.ToString(paso.Descripcion);
            txtId.Enabled = false;
            btnActualizar.Visible = true;
        }

        private void MedicamentoFrm_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaMedicamentos(dataGridMedicamento);
            MetodosBasicos.CargarTablaMedicamentos(dataGridMedicamentoEliminar);
            MetodosBasicos.CargarBoxMedi(cmbTipo);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtTipo.Text = "";
            cmbTipo.Enabled = true;
            cmbTipo.Text = "";
            txtBuscar.Text = "";
            txtTipo.Visible = false;
            lblTipoNuevo.Visible = false;
            txtId.Focus();
            errorProvider1.Clear();
        }

        private void ActualizarDatos()
        {
            MedicamentosMensaje medicamentoActualizar = new MedicamentosMensaje();
            medicamentoActualizar.Id = Convert.ToInt32(txtId.Text);
            medicamentoActualizar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                medicamentoActualizar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(medicamentoActualizar.Tipo);
            }
            else
            {
                medicamentoActualizar.Tipo = cmbTipo.SelectedText;
            }

            medicamentoActualizar.Descripcion = txtDescripcion.Text;

            var resultado = MedicamentoNegocio.ActualizarMedicamento(medicamentoActualizar);
            MessageBox.Show("Medicamento Actualizado con Exito...!!");
            Limpiar();
            MetodosBasicos.CargarTabla(dataGridMedicamento);
            this.Hide();

            BuscarMedicamento buscarMedicamento = new BuscarMedicamento();
            buscarMedicamento.MdiParent = MenuPrincipal.ActiveForm;
            buscarMedicamento.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }

            InsertarDatos();
        }

        private void InsertarDatos()
        {
            MedicamentosMensaje medicamentoAgregar = new MedicamentosMensaje();
            medicamentoAgregar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                medicamentoAgregar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(medicamentoAgregar.Tipo);
                MedicamentoNegocio.InsertarTipoMedicamentos(medicamentoAgregar.Tipo);
            }
            else
            {
                medicamentoAgregar.Tipo = cmbTipo.SelectedText;
            }

            medicamentoAgregar.Descripcion = txtDescripcion.Text;

            var resultado = MedicamentoNegocio.InsertarMedicamento(medicamentoAgregar);
            MessageBox.Show("Medicamento Guardado con Exito...!!");
            Limpiar();
            MetodosBasicos.CargarTablaMedicamentos(dataGridMedicamento);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                txtTipo.Visible = true;
                cmbTipo.Enabled = false;
                lblTipoNuevo.Visible = true;
            }
        }

        private void EliminarDatos()
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Tiene que tener datos");
            }
            else
            {
                MedicamentosMensaje medicamentoEliminar = new MedicamentosMensaje();
                medicamentoEliminar.Id = Convert.ToInt32(txtId.Text);
                medicamentoEliminar.Nombre = txtNombre.Text;

                if (cmbTipo.SelectedItem.Equals("OTRO"))
                {
                    medicamentoEliminar.Tipo = txtTipo.Text;
                    cmbTipo.Properties.Items.Add(medicamentoEliminar.Tipo);
                }
                else
                {
                    medicamentoEliminar.Tipo = cmbTipo.SelectedText;
                }

                medicamentoEliminar.Descripcion = txtDescripcion.Text;

                var resultado = MedicamentoNegocio.EliminarMedicamento(medicamentoEliminar);
                MessageBox.Show("Medicamento Eliminado con Exito...!!");
                Limpiar();
                MetodosBasicos.CargarTablaMedicamentos(dataGridMedicamentoEliminar);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el Medicamento?", "Eliminar Medicamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EliminarDatos();
            }
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarMedicamento medicamentoBuscar = new BuscarMedicamento();
            medicamentoBuscar.MdiParent = MenuPrincipal.ActiveForm;
            medicamentoBuscar.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtBuscar.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtBuscar.Text = "";
            dataGridMedicamentoEliminar.Enabled = true;
        }

        private void dataGridMedicamentoEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dataGridMedicamento.Rows[e.RowIndex].Cells[0].Value);

            txtBuscar.Text = (string)dataGridMedicamentoEliminar.Rows[e.RowIndex].Cells[1].Value;
            cmbTipo.Text = (string)dataGridMedicamentoEliminar.Rows[e.RowIndex].Cells[2].Value;
            txtDescripcion.Text = (string)dataGridMedicamentoEliminar.Rows[e.RowIndex].Cells[3].Value;

            dataGridMedicamentoEliminar.Enabled = false;

            btnCancelarEliminar.Visible = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MedicamentoNegocio obj = new MedicamentoNegocio();
            var lista = obj.DevolverListaMedicamentosNombre(txtBuscar.Text);
            dataGridMedicamentoEliminar.DataSource = lista.Tables[0];
        }

        private bool Verificar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
                return false;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbTipo, "Seleccione un Tipo");
                return false;
            }

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                if (string.IsNullOrEmpty(txtTipo.Text))
                {
                    errorProvider1.SetError(txtTipo, "Ingrese un  Tipo");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Ingrese una Descripcion");
                return false;
            }
            return true;
        }
    }
}

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
    public partial class EnfermedadesFrm : Form
    {
        public EnfermedadesFrm()
        {
            InitializeComponent();
            txtId.Enabled = false;
         }

        public EnfermedadesFrm(EnfermedadesMensajes paso)
        {
            InitializeComponent();
            txtId.Text = (string)paso.Id.ToString();
            txtNombre.Text = Convert.ToString(paso.Nombre);
            cmbTipo.Text = paso.Tipo;
            txtDescripcion.Text = Convert.ToString(paso.Descripcion);
            txtId.Enabled = false;
            btnActualizar.Visible = true;
        }

        private void EnfermedadesFrm_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaEnfermedades(dataGridEnfermedades);
            MetodosBasicos.CargarTablaEnfermedades(dataGridEnfermedadesEliminar);
            MetodosBasicos.CargarBox(cmbTipo);
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
            txtTipo.Visible = false;
            lblTipoNuevo.Visible = false;
            txtId.Focus();
            errorProvider1.Clear();
        }

        private void ActualizarDatos()
        {
            EnfermedadesMensajes enfermedadActualizar = new EnfermedadesMensajes();
            enfermedadActualizar.Id = Convert.ToInt32(txtId.Text);
            enfermedadActualizar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                enfermedadActualizar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(enfermedadActualizar.Tipo);
            }
            else
            {
                enfermedadActualizar.Tipo = cmbTipo.SelectedText;
            }

            enfermedadActualizar.Descripcion = txtDescripcion.Text;

            var resultado = EnfermedadNegocio.ActualizarEnfermedad(enfermedadActualizar);
            MessageBox.Show("Enfermedad Actualizada con Exito...!!");
            Limpiar();
            MetodosBasicos.CargarTabla(dataGridEnfermedades);
            this.Hide();

            BuscarEnfermedades buscarEnfermedad = new BuscarEnfermedades();
            buscarEnfermedad.MdiParent = MenuPrincipal.ActiveForm;
            buscarEnfermedad.Show();
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
            EnfermedadesMensajes enfermedadAgregar = new EnfermedadesMensajes();
            enfermedadAgregar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                enfermedadAgregar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(enfermedadAgregar.Tipo);
                EnfermedadNegocio.InsertarTipoEnfermedad(enfermedadAgregar.Tipo);
            }
            else
            {
                enfermedadAgregar.Tipo = cmbTipo.SelectedText;
            }

            enfermedadAgregar.Descripcion = txtDescripcion.Text;

            var resultado = EnfermedadNegocio.InsertarEnfermedad(enfermedadAgregar);
            MessageBox.Show("Enfermedad Guardada con Exito...!!");
            Limpiar();
            MetodosBasicos.CargarTablaEnfermedades(dataGridEnfermedades);
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
                EnfermedadesMensajes enfermedadEliminar = new EnfermedadesMensajes();
                enfermedadEliminar.Id = Convert.ToInt32(txtId.Text);
                enfermedadEliminar.Nombre = txtNombre.Text;

                if (cmbTipo.SelectedItem.Equals("OTRO"))
                {
                    enfermedadEliminar.Tipo = txtTipo.Text;
                    cmbTipo.Properties.Items.Add(enfermedadEliminar.Tipo);
                }
                else
                {
                    enfermedadEliminar.Tipo = cmbTipo.SelectedText;
                }

                enfermedadEliminar.Descripcion = txtDescripcion.Text;

                var resultado = EnfermedadNegocio.EliminarEnfermedad(enfermedadEliminar);
                MessageBox.Show("Enfermedad Eliminada con Exito...!!");
                Limpiar();
                MetodosBasicos.CargarTablaEnfermedades(dataGridEnfermedadesEliminar);

            }

        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtBuscar.Text = "";
            dataGridEnfermedadesEliminar.Enabled = true;
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarEnfermedades enfermedadBuscar = new BuscarEnfermedades();
            enfermedadBuscar.MdiParent = MenuPrincipal.ActiveForm;
            enfermedadBuscar.Show();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea eliminar la enfermedad?", "Eliminar Enfermedad", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EliminarDatos();
            }
            
        }

        private void dataGridEnfermedadesEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dataGridEnfermedades.Rows[e.RowIndex].Cells[0].Value);

            txtBuscar.Text = (string)dataGridEnfermedadesEliminar.Rows[e.RowIndex].Cells[1].Value;
            cmbTipo.Text = (string)dataGridEnfermedadesEliminar.Rows[e.RowIndex].Cells[2].Value;
            txtDescripcion.Text = (string)dataGridEnfermedadesEliminar.Rows[e.RowIndex].Cells[3].Value;

            dataGridEnfermedadesEliminar.Enabled = false;

            btnCancelarEliminar.Visible = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnfermedadNegocio obj = new EnfermedadNegocio();
            var lista = obj.DevolverListaEnfermedadNombre(txtBuscar.Text);
            dataGridEnfermedadesEliminar.DataSource = lista.Tables[0];
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

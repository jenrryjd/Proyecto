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
    public partial class AlergiasFrm : Form
    {

        public AlergiasFrm()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        public AlergiasFrm(AlergiaMensajes paso)
        {
            InitializeComponent();
            txtId.Text =(string) paso.Id.ToString();
            txtNombre.Text = Convert.ToString(paso.Nombre);
            txtDescripcion.Text = Convert.ToString(paso.Descripcion);
            txtId.Enabled = false;
            btnActualizar.Visible = true;            
        }

        private void AlergiasFrm_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTabla(dataGridAlergias);
            MetodosBasicos.CargarTabla(dataGridAlergiasEliminar);
            MetodosBasicos.CargarBoxAler(cmbTipo);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            InsertarDatos();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                txtTipo.Visible = true;
                lblTipoNuevo.Visible = true;
                cmbTipo.Enabled = false;
            }
        }

        /// <summary>
        /// Metodos usados para limpiar y cargar datos de la base
        /// </summary>
        
        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtTipo.Text = "";
            cmbTipo.Enabled = true;
            cmbTipo.Text="";
            txtTipo.Visible = false;
            lblTipoNuevo.Visible = false;
            txtId.Focus();
            errorProvider1.Clear();
        }

        private void InsertarDatos()
        {
            AlergiaMensajes alergiaAgregar = new AlergiaMensajes();
            alergiaAgregar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                alergiaAgregar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(alergiaAgregar.Tipo);
                AlergiaNegocio.InsertarTipoAlergia(alergiaAgregar.Tipo);
            }
            else
            {
                alergiaAgregar.Tipo = cmbTipo.SelectedText;
            }

            alergiaAgregar.Descripcion = txtDescripcion.Text;

            var resultado = AlergiaNegocio.InsertarAlergia(alergiaAgregar);
            MessageBox.Show("Alergia Guardada con Exito...!!");
            Limpiar();
            errorProvider1.Clear();
            MetodosBasicos.CargarTabla(dataGridAlergias);
        }

        private void ActualizarDatos()
        {
            AlergiaMensajes alergiaActualizar = new AlergiaMensajes();
            alergiaActualizar.Id =Convert.ToInt32(txtId.Text);
            alergiaActualizar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                alergiaActualizar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(alergiaActualizar.Tipo);
            }
            else
            {
                alergiaActualizar.Tipo = cmbTipo.SelectedText;
            }

            alergiaActualizar.Descripcion = txtDescripcion.Text;

            var resultado = AlergiaNegocio.ActualizarAlergia(alergiaActualizar);
            MessageBox.Show("Alergia Actualizada con Exito...!!");
            Limpiar();
            MetodosBasicos.CargarTabla(dataGridAlergias);
            this.Hide();

            BuscarAlergia buscarAlergia = new BuscarAlergia();
            buscarAlergia.MdiParent = MenuPrincipal.ActiveForm;
            buscarAlergia.Show();
        }

        private void EliminarDatos()
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Tiene que tener datos");
            }
            else { 
            AlergiaMensajes alergiaEliminar = new AlergiaMensajes();
            alergiaEliminar.Id = Convert.ToInt32(txtId.Text);
            alergiaEliminar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                alergiaEliminar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(alergiaEliminar.Tipo);
            }
            else
            {
                alergiaEliminar.Tipo = cmbTipo.SelectedText;
            }

            alergiaEliminar.Descripcion = txtDescripcion.Text;

            var resultado = AlergiaNegocio.EliminarAlergia(alergiaEliminar);
            MessageBox.Show("Alergia Eliminada con Exito...!!");
            Limpiar();
            MetodosBasicos.CargarTabla(dataGridAlergiasEliminar);

            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtBuscar.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarAlergia buscarAlergia = new BuscarAlergia();
            buscarAlergia.MdiParent = MenuPrincipal.ActiveForm;
            buscarAlergia.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar Alergia?", "Eliminar Alergia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EliminarDatos();
            }
        }

        private void dataGridAlergiasEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtId.Text =Convert.ToString(dataGridAlergias.Rows[e.RowIndex].Cells[0].Value);

            txtBuscar.Text = (string)dataGridAlergiasEliminar.Rows[e.RowIndex].Cells[1].Value;
            cmbTipo.Text = (string)dataGridAlergiasEliminar.Rows[e.RowIndex].Cells[2].Value;
            txtDescripcion.Text = (string)dataGridAlergiasEliminar.Rows[e.RowIndex].Cells[3].Value;

            dataGridAlergiasEliminar.Enabled = false;

            btnCancelarEliminar.Visible = true;        
        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtBuscar.Text = "";
            dataGridAlergiasEliminar.Enabled = true;            
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
            AlergiaNegocio obj = new AlergiaNegocio();
            var lista = obj.DevolverListaAlergiaNombre(txtBuscar.Text);
            dataGridAlergiasEliminar.DataSource = lista.Tables[0];
        }

        private bool Verificar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre,"Ingrese un Nombre");
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtBuscar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

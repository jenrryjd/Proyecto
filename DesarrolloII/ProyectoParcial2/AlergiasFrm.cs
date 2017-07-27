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
            cmbTipo.Text = paso.Tipo;
            txtDescripcion.Text = Convert.ToString(paso.Descripcion);
            txtId.Enabled = false;
            btnActualizar.Visible = true;
            
        }

        private void AlergiasFrm_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTabla(dataGridAlergias);
         }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarDatos();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                txtTipo.Visible = true;
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
            cmbTipo.SelectedIndex=0;
            txtId.Focus();
        }

        

        private void InsertarDatos()
        {
            AlergiaMensajes alergiaAgregar = new AlergiaMensajes();
            alergiaAgregar.Nombre = txtNombre.Text;

            if (cmbTipo.SelectedItem.Equals("OTRO"))
            {
                alergiaAgregar.Tipo = txtTipo.Text;
                cmbTipo.Properties.Items.Add(alergiaAgregar.Tipo);
            }
            else
            {
                alergiaAgregar.Tipo = cmbTipo.SelectedText;
            }

            alergiaAgregar.Descripcion = txtDescripcion.Text;

            var resultado = AlergiaNegocio.InsertarAlergia(alergiaAgregar);
            MessageBox.Show("Alergia Guardada con Exito...!!");
            Limpiar();
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void dataGridAlergias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class BuscarAlergia : Form
    {
        public BuscarAlergia()
        {
            InitializeComponent();
        }

        private void BuscarAlergia_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTabla(dataGridAlergias);
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRazonSocial.SelectedText.Equals("Codigo Alergia"))
                lblBuscarPor.Text = "Codigo Alergia";            
            if (cmbRazonSocial.SelectedText.Equals("Nombre"))
                lblBuscarPor.Text = "Nombre: ";
            if (cmbRazonSocial.SelectedText.Equals("Tipo"))
                lblBuscarPor.Text = "Tipo: ";

            txtRazonBuscar.Enabled = true;
        }


        private void dataGridAlergias_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AlergiaMensajes paso = new AlergiaMensajes();
            paso.Id =(int)dataGridAlergias.Rows[e.RowIndex].Cells[0].Value;

            paso.Nombre = (string)dataGridAlergias.Rows[e.RowIndex].Cells[1].Value;
            paso.Tipo = (string)dataGridAlergias.Rows[e.RowIndex].Cells[2].Value;
            paso.Descripcion = (string)dataGridAlergias.Rows[e.RowIndex].Cells[3].Value;

            AlergiasFrm modificar = new AlergiasFrm(paso);
            this.Hide();
            modificar.Text = "Modificar Alergia";
            modificar.MdiParent = MenuPrincipal.ActiveForm;
            modificar.btnActualizar.Visible = true;
            modificar.btnCancelarActualizacion.Visible = true;
            modificar.btnInsertar.Visible = false;
            modificar.dataGridAlergias.Visible = true;
            modificar.dataGridAlergias.Enabled = false;
            modificar.btnSalir.Visible = false;
            modificar.txtNombre.Visible = true;
            modificar.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtRazonBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cmbRazonSocial.SelectedText.Equals("Codigo Alergia"))
            {
                MetodosBasicos.SoloNumerosEnteros(e);
                AlergiaNegocio obj = new AlergiaNegocio();
                var lista = obj.DevolverListaAlergiaId(txtRazonBuscar.Text);
                dataGridAlergias.DataSource = lista.Tables[0];
            }
            if (cmbRazonSocial.SelectedText.Equals("Nombre"))
            {
                MetodosBasicos.SoloLetras(e);
                AlergiaNegocio obj = new AlergiaNegocio();
                var lista = obj.DevolverListaAlergiaNombre(txtRazonBuscar.Text);
                dataGridAlergias.DataSource = lista.Tables[0];
            }
            if (cmbRazonSocial.SelectedText.Equals("Tipo"))
            {
                AlergiaNegocio obj = new AlergiaNegocio();
                var lista = obj.DevolverListaAlergiaTipo(txtRazonBuscar.Text);
                dataGridAlergias.DataSource = lista.Tables[0];
            }
        }

        private void dataGridAlergias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

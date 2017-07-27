using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using MENSAJES;

namespace ProyectoParcial2
{
    public partial class BuscarEnfermedades : Form
    {
        public BuscarEnfermedades()
        {
            InitializeComponent();
        }

        private void BuscarEnfermedades_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaEnfermedades(dataGridEnfermedades);
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRazonSocial.SelectedText.Equals("Codigo Enfermedad"))
                lblBuscarPor.Text = "Codigo Enfermedad";
            if (cmbRazonSocial.SelectedText.Equals("Nombre"))
                lblBuscarPor.Text = "Nombre: ";
            if (cmbRazonSocial.SelectedText.Equals("Tipo"))
                lblBuscarPor.Text = "Tipo: ";
            txtRazonBuscar.Enabled = true;
        }

        private void txtRazonBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbRazonSocial.SelectedText.Equals("Codigo Enfermedad"))
            {
                MetodosBasicos.SoloNumerosEnteros(e);
                EnfermedadNegocio obj = new EnfermedadNegocio();
                var lista = obj.DevolverListaEnfermedadId(txtRazonBuscar.Text);
                dataGridEnfermedades.DataSource = lista.Tables[0];
            }
            if (cmbRazonSocial.SelectedText.Equals("Nombre"))
            {
                MetodosBasicos.SoloLetras(e);
                EnfermedadNegocio obj = new EnfermedadNegocio();
                var lista = obj.DevolverListaEnfermedadNombre(txtRazonBuscar.Text);
                dataGridEnfermedades.DataSource = lista.Tables[0];
            }
            if (cmbRazonSocial.SelectedText.Equals("Tipo"))
            {
                EnfermedadNegocio obj = new EnfermedadNegocio();
                var lista = obj.DevolverListaEnfermedadTipo(txtRazonBuscar.Text);
                dataGridEnfermedades.DataSource = lista.Tables[0];
            }
        }

        private void dataGridEnfermedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnfermedadesMensajes paso = new EnfermedadesMensajes();
            paso.Id = (int)dataGridEnfermedades.Rows[e.RowIndex].Cells[0].Value;

            paso.Nombre = (string)dataGridEnfermedades.Rows[e.RowIndex].Cells[1].Value;
            paso.Tipo = (string)dataGridEnfermedades.Rows[e.RowIndex].Cells[2].Value;
            paso.Descripcion = (string)dataGridEnfermedades.Rows[e.RowIndex].Cells[3].Value;

            EnfermedadesFrm modificar = new EnfermedadesFrm(paso);
            this.Hide();
            modificar.Text = "Modificar Enfermedad";
            modificar.MdiParent = MenuPrincipal.ActiveForm;
            modificar.btnActualizar.Visible = true;
            modificar.btnCancelarActualizacion.Visible = true;
            modificar.btnInsertar.Visible = false;
            modificar.dataGridEnfermedades.Visible = true;
            modificar.dataGridEnfermedades.Enabled = false;
            modificar.btnSalir.Visible = false;
            modificar.txtNombre.Visible = true;
            modificar.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

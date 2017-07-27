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
    public partial class BuscarMedicamento : Form
    {
        public BuscarMedicamento()
        {
            InitializeComponent();
        }

        private void BuscarMedicamento_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaMedicamentos(dataGridMedicamentos);
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRazonSocial.SelectedText.Equals("Codigo Medicamento"))
                lblBuscarPor.Text = "Codigo Medicamento";
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
                MedicamentoNegocio obj = new MedicamentoNegocio();
                var lista = obj.DevolverListaMedicamentosId(txtRazonBuscar.Text);
                dataGridMedicamentos.DataSource = lista.Tables[0];
            }
            if (cmbRazonSocial.SelectedText.Equals("Nombre"))
            {
                MetodosBasicos.SoloLetras(e);
                MedicamentoNegocio obj = new MedicamentoNegocio();
                var lista = obj.DevolverListaMedicamentosNombre(txtRazonBuscar.Text);
                dataGridMedicamentos.DataSource = lista.Tables[0];
            }
            if (cmbRazonSocial.SelectedText.Equals("Tipo"))
            {
                MedicamentoNegocio obj = new MedicamentoNegocio();
                var lista = obj.DevolverListaMedicamentoTipo(txtRazonBuscar.Text);
                dataGridMedicamentos.DataSource = lista.Tables[0];
            }
        }

        private void dataGridMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicamentosMensaje paso = new MedicamentosMensaje();
            paso.Id = (int)dataGridMedicamentos.Rows[e.RowIndex].Cells[0].Value;

            paso.Nombre = (string)dataGridMedicamentos.Rows[e.RowIndex].Cells[1].Value;
            paso.Tipo = (string)dataGridMedicamentos.Rows[e.RowIndex].Cells[2].Value;
            paso.Descripcion = (string)dataGridMedicamentos.Rows[e.RowIndex].Cells[3].Value;

            MedicamentoFrm modificar = new MedicamentoFrm(paso);
            this.Hide();
            modificar.Text = "Modificar Medicamento";
            modificar.MdiParent = MenuPrincipal.ActiveForm;
            modificar.btnActualizar.Visible = true;
            modificar.btnCancelarActualizacion.Visible = true;
            modificar.btnInsertar.Visible = false;
            modificar.dataGridMedicamento.Visible = true;
            modificar.dataGridMedicamento.Enabled = false;
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

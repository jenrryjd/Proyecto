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
    public partial class EliminarMedico : Form
    {
        public EliminarMedico()
        {
            InitializeComponent();
            lblPce.Enabled = false;
        }

        private void btnEliminarModMed_Click(object sender, EventArgs e)
        {
            MedicoMensaje pac = new MedicoMensaje();
            pac.Cedula =lblPce.Text;
            PersonaTestNegocio.EliminarMedico(pac);
            MessageBox.Show("Se a eliminado con exito");
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBuscar.SelectedText.Equals("Cedula"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaCedulaMed(textBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("Nombre"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaMedNombre(textBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("Apellido"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaMedApellido(textBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
        }

        private void EliminarMedico_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaMedico(dataGridPacientes);
        }

        private void dataGridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBuscar.Text = Convert.ToString(dataGridPacientes.Rows[e.RowIndex].Cells[0].Value);
        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBuscar.SelectedItem.Equals("Cedula"))
            {
                lblTituloBusqueda.Text = "Cedula";
            }
            else if (comboBuscar.SelectedItem.Equals("Nombre"))
            {
                lblTituloBusqueda.Text = "Nombre";
            }
            else if (comboBuscar.SelectedItem.Equals("Apellido"))
            {
                lblTituloBusqueda.Text = "Apellido";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

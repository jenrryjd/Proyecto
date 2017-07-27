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
    public partial class ModificarPacientes : Form
    {
        public ModificarPacientes()
        {
            InitializeComponent();

        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBuscar.SelectedText.Equals("Cedula"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaCedula(txtRazonBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("Nombre"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaPacienteNombre(txtRazonBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("Apellido"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaPacienteApellido(txtRazonBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ModificarPacientes_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaPacientes(dataGridPacientes);
        }

        private void dataGridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PacienteMensaje pac = new PacienteMensaje();

            pac.Cedula= Convert.ToString( dataGridPacientes.Rows[e.RowIndex].Cells[0].Value);
            pac.Nombre = (string)dataGridPacientes.Rows[e.RowIndex].Cells[1].Value;
            pac.Apellido = (string)dataGridPacientes.Rows[e.RowIndex].Cells[2].Value;
            pac.Telefono = (string)dataGridPacientes.Rows[e.RowIndex].Cells[3].Value;
            pac.Celular = (string)dataGridPacientes.Rows[e.RowIndex].Cells[4].Value;
            pac.Direccion = (string)dataGridPacientes.Rows[e.RowIndex].Cells[5].Value;
            ParaModificarPaciente modpac = new ParaModificarPaciente(pac);
            this.Hide();
            modpac.Show();

        }

        private void btnEliminarMed_Click(object sender, EventArgs e)
        {
          
        }

        private void txtRazonBuscar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTituloBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}

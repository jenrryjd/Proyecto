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
    public partial class EliminarPacientes : Form
    {
        public EliminarPacientes()
        {
            InitializeComponent();
            labelEliminarPaci.Visible = false;
        }

        private void btnEliminarMed_Click(object sender, EventArgs e)
        {
            PacienteMensaje pac = new PacienteMensaje();
            pac.Cedula = labelEliminarPaci.Text;
            PersonaTestNegocio.EliminarrPaciente(pac);
            
        }

        private void dataGridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBuscar.Text = Convert.ToString(dataGridPacientes.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dataGridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarPacientes_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaPacientes(dataGridPacientes);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbEliminarPac.SelectedText.Equals("Cedula"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaCedula(textBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
            if (cmbEliminarPac.SelectedText.Equals("Nombre"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaPacienteNombre(textBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
            if (cmbEliminarPac.SelectedText.Equals("Apellido"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaPacienteApellido(textBuscar.Text);
                dataGridPacientes.DataSource = lista.Tables[0];
            }
        }
    }
}

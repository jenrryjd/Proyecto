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
    public partial class ModificarMedicos : Form
    {
        public ModificarMedicos()
        {
            InitializeComponent();
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

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBuscar.SelectedText.Equals("Cedula"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaCedulaMed(textBuscare.Text);
                dataGridMedicos.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("Nombre"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaMedNombre(textBuscare.Text);
                dataGridMedicos.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("Apellido"))
            {
                PersonaTestNegocio obj = new PersonaTestNegocio();
                var lista = obj.DevolverListaMedApellido(textBuscare.Text);
                dataGridMedicos.DataSource = lista.Tables[0];
            }
            }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicoMensaje med = new MedicoMensaje();
            med.Cedula = Convert.ToString(dataGridMedicos.Rows[e.RowIndex].Cells[0].Value);
            med.Nombre = (string)dataGridMedicos.Rows[e.RowIndex].Cells[1].Value;
            med.Apellido = (string)dataGridMedicos.Rows[e.RowIndex].Cells[2].Value;
            med.Fecha= Convert.ToDateTime( dataGridMedicos.Rows[e.RowIndex].Cells[3].Value);
            med.Genero = Convert.ToString(dataGridMedicos.Rows[e.RowIndex].Cells[4].Value);
            med.EstCivi = Convert.ToString(dataGridMedicos.Rows[e.RowIndex].Cells[5].Value);
            med.Telefono = (int)dataGridMedicos.Rows[e.RowIndex].Cells[6].Value;
            med.Celular = (int)dataGridMedicos.Rows[e.RowIndex].Cells[7].Value;
            med.Direccion = (string)dataGridMedicos.Rows[e.RowIndex].Cells[8].Value;
            med.LicenMed = Convert.ToString(dataGridMedicos.Rows[e.RowIndex].Cells[9].Value);
            med.Especialidad = Convert.ToString(dataGridMedicos.Rows[e.RowIndex].Cells[10].Value);

            ParaModificarMedicos modpac = new ParaModificarMedicos(med);
            this.Hide();
            modpac.Show();
        }

        private void dataGridMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarMedicos_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaMedico(dataGridMedicos); ;
        }
    }
}

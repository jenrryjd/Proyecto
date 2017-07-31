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
    public partial class ModificarPacientes : Form
    {
        public ModificarPacientes()
        {
            InitializeComponent();
            dataGridEliminarPaciente.Visible = false;
            dataGridPacientes.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dataGridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PacienteMensaje paso = new PacienteMensaje();
            try { 
            paso.Cedula = (string)dataGridPacientes.Rows[e.RowIndex].Cells[0].Value;
            paso.Nombre = (string)dataGridPacientes.Rows[e.RowIndex].Cells[1].Value;
            paso.Apellido = (string)dataGridPacientes.Rows[e.RowIndex].Cells[2].Value;
            paso.Telefono = (string)dataGridPacientes.Rows[e.RowIndex].Cells[3].Value;
            paso.Celular = (string)dataGridPacientes.Rows[e.RowIndex].Cells[4].Value;
            paso.Direccion = (string)dataGridPacientes.Rows[e.RowIndex].Cells[5].Value;
            paso.Fecha = (DateTime)dataGridPacientes.Rows[e.RowIndex].Cells[6].Value;
            paso.Genero = (string)dataGridPacientes.Rows[e.RowIndex].Cells[7].Value;
                PMPacientes modificar = new PMPacientes(paso);
                this.Hide();
                modificar.Text = "Modificar Pacientes";
                modificar.MdiParent = MenuPrincipal.ActiveForm;
                modificar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Fila seleccionada vacia","Advertencia");
            }

            
        }

        private void ModificarPacientes_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            
            MetodosBasicos.CargarTablaPaciente(dataGridPacientes);
            MetodosBasicos.CargarTablaPaciente(dataGridEliminarPaciente);
        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBuscar.SelectedText.Equals("Cedula"))
                lblEtiqueta.Text = "Cedula";
            if (comboBuscar.SelectedText.Equals("Nombre"))
                lblEtiqueta.Text = "Nombre: ";
            if (comboBuscar.SelectedText.Equals("Apellido"))
                lblEtiqueta.Text = "Apellido: ";

            txtBuscar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar este Paciente", "Eliminar Paciente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EliminarDatos();
            }
        }

        private void EliminarDatos()
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("Tiene que tener datos");
            }
            else
            {
                PacienteMensaje pacienteEliminar = new PacienteMensaje();
                pacienteEliminar.Cedula = (txtBuscar.Text);
              
                var resultado = PersonaTestNegocio.EliminarPaciente(pacienteEliminar);
                
                txtBuscar.Text = "";
                MetodosBasicos.CargarTabla(dataGridEliminarPaciente);

            }

        }
       
        private void dataGridEliminarPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBuscar.Text = (string)dataGridPacientes.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Fila vacia","Adevertencia");
            }


        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBuscar.SelectedItem.Equals("Cedula")) { 
                lblEtiqueta.Text = "Cedula";

            PersonaTestNegocio obj = new PersonaTestNegocio();
            var lista = obj.DevolverListaPacientesCedula(txtBuscar.Text);
            dataGridPacientes.DataSource = lista.Tables[0];
        }
            if (comboBuscar.SelectedItem.Equals("Nombre")) { 
                lblEtiqueta.Text = "Nombre: ";
            PersonaTestNegocio obj2 = new PersonaTestNegocio();
            var lista1 = obj2.DevolverListaPacienteNombre(txtBuscar.Text);
            dataGridPacientes.DataSource = lista1.Tables[0];
        }
            if (comboBuscar.SelectedItem.Equals("Apellido")) { 
                lblEtiqueta.Text = "Apellido: ";
            PersonaTestNegocio obj3 = new PersonaTestNegocio();
            var lista2 = obj3.DevolverListaPacienteApellido(txtBuscar.Text);
            dataGridPacientes.DataSource = lista2.Tables[0];
        }
        }
    }
}

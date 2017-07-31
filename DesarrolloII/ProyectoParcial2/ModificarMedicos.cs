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
            dataGridElimanrMedico.Visible = false;
            dataGridMedico.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ModificarMedicos_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled=false;
            MetodosBasicos.CargarTablaMedicos(dataGridMedico);
            MetodosBasicos.CargarTablaMedicos(dataGridElimanrMedico);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicoMensaje paso = new MedicoMensaje();
            try
            {
                paso.Cedula = (string)dataGridMedico.Rows[e.RowIndex].Cells[0].Value;

                paso.Nombre = (string)dataGridMedico.Rows[e.RowIndex].Cells[1].Value;
                paso.Apellido = (string)dataGridMedico.Rows[e.RowIndex].Cells[2].Value;
                paso.Fecha = (DateTime)dataGridMedico.Rows[e.RowIndex].Cells[3].Value;
                paso.Genero = (string)dataGridMedico.Rows[e.RowIndex].Cells[4].Value;
                paso.EstCivi = (string)dataGridMedico.Rows[e.RowIndex].Cells[5].Value;
                paso.Telefono = (int)dataGridMedico.Rows[e.RowIndex].Cells[6].Value;
                paso.Celular = (int)dataGridMedico.Rows[e.RowIndex].Cells[7].Value;
                paso.Direccion = (string)dataGridMedico.Rows[e.RowIndex].Cells[8].Value;
                paso.LicenMed = (string)dataGridMedico.Rows[e.RowIndex].Cells[9].Value;
                paso.Especialidad = (string)dataGridMedico.Rows[e.RowIndex].Cells[10].Value;

                PMMedicos modificar = new PMMedicos(paso);
                this.Hide();
                modificar.Text = "Modificar Medicos";
                modificar.MdiParent = MenuPrincipal.ActiveForm;
                modificar.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Fila seleccionada vacia", "Advertencia");
            }
            
        }

        private void btnEliminarModMed_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar este Medico", "Eliminar Medico", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                MedicoMensaje pacienteEliminar = new MedicoMensaje();
                pacienteEliminar.Cedula = (txtBuscar.Text);

                var resultado = PersonaTestNegocio.EliminarMedico(pacienteEliminar);
                // MessageBox.Show("Paciente Eliminado con Exito...!!");
                txtBuscar.Text = "";
                MetodosBasicos.CargarTabla(dataGridElimanrMedico);

            }
        }

        private void dataGridElimanrMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBuscar.Text = (string)dataGridElimanrMedico.Rows[e.RowIndex].Cells[0].Value;

            }
            catch (Exception)
            {

                MessageBox.Show("Fila selecionada vacia","Advertencia");
            }
            
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBuscar.SelectedItem.Equals("Cedula")) { 
                lblEtiqueta.Text = "Cedula";
            PersonaTestNegocio obj = new PersonaTestNegocio();
            var lista = obj.DevolverListaMedicosCedula(txtBuscar.Text);
            dataGridMedico.DataSource = lista.Tables[0];
        }
            if (comboBuscar.SelectedItem.Equals("Nombre"))
            {
                lblEtiqueta.Text = "Nombre: ";
                PersonaTestNegocio obj2 = new PersonaTestNegocio();
                var lista1 = obj2.DevolverListaMedicosNombre(txtBuscar.Text);
                dataGridMedico.DataSource = lista1.Tables[0];
            }
            if (comboBuscar.SelectedItem.Equals("Apellido"))
            {
                lblEtiqueta.Text = "Apellido: ";
                PersonaTestNegocio obj3 = new PersonaTestNegocio();
                var lista2 = obj3.DevolverListaMedicosApellido(txtBuscar.Text);
                dataGridMedico.DataSource = lista2.Tables[0];
            }
        }
    }
}

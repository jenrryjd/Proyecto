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
    public partial class AgendarCita : Form
    {
        public AgendarCita(string p)
        {
            InitializeComponent();
        }

        public AgendarCita(int numCita)
        {
            InitializeComponent();
            txtNCita.Text =Convert.ToString(numCita);
        }

        public AgendarCita(CitaMensajes a)
        {
            //txtCedDoc.Text = a.CedDoc;
            //txtNCita.Text =Convert.ToString(a.Id);
            //txtCedula.Text = a.CedPac;
        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarBoxEspecialidad(cmbEspecialidad);
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            
            PersonaTestNegocio obj = new PersonaTestNegocio();
            var nombre = obj.DevolverNombrePaciente(txtCedula.Text);
            if (nombre.ToString().Equals(""))
            {
                MessageBox.Show("Ingreso nuevo");
            }
            txtNombre.Text = nombre.ToString();

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonaTestNegocio obj = new PersonaTestNegocio();
            obj.CargarDoctores(cmbEspecialidad.SelectedItem.ToString(),txtCedDoc,txtNomDoc);
            CitaNegocio.CargarHorarios(txtCedDoc,dateTimeFechaCita,comboBoxHorario);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CitaMensajes cita = new CitaMensajes();
            cita.CedDoc = txtCedDoc.Text;
            cita.CedPac = txtCedula.Text;
            cita.Hora =comboBoxHorario.SelectedItem.ToString();
            cita.FechaCita = dateTimeFechaCita.Text;
            cita.Especialidad = cmbEspecialidad.SelectedItem.ToString();

            CitaNegocio.InsertaCita(cita);
            MessageBox.Show("Cita Guardada con Exito...!!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EliminarDatos();
            }
        }

        private void EliminarDatos()
        {
            CitaNegocio.EliminarCita(txtNCita.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
            CitaNegocio obj = new CitaNegocio();
            var cita = obj.DevolverListaCitas(txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }

        }
    

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
        public AgendarCita()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CONSTRUCTOR PARA LLENAR DATOS. LOS DATOS VIENEN DESDE FORMULARIO BUSCAR CITA
        /// </summary>
        /// <param name="datos"></param>
        public AgendarCita(CitaMensajes datos)
        {
            InitializeComponent();
            txtCedDoc.Text = datos.CedDoc;
            txtCedula.Text = datos.CedPac;
            txtNCita.Text = datos.Id.ToString();
            comboBoxHorario.Text = "";
            cmbEspecialidad.Text = datos.Especialidad;

            PersonaTestNegocio obj = new PersonaTestNegocio();
            var nombre = obj.DevolverNombrePaciente(txtCedula.Text);
            txtNombre.Text = nombre.ToString();
            obj.CargarDoctores(cmbEspecialidad.Text, txtCedDoc, txtNomDoc);            
            CitaNegocio.CargarHorarios(txtCedDoc, dateTimeFechaCita, comboBoxHorario);
        }

        public AgendarCita(string cedula)
        {
            InitializeComponent();
            txtCedula.Text = cedula;
        }

        public AgendarCita(int numCita)
        {
            InitializeComponent();
            txtNCita.Text =Convert.ToString(numCita);
        }


        private void AgendarCita_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarBoxEspecialidad(cmbEspecialidad);
        }

       
        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
                if (!VerificarCedu())
                {
                    return;
                }

            string cedula = txtCedula.Text;

            PersonaTestNegocio obj = new PersonaTestNegocio();
            var nombre = obj.DevolverNombrePaciente(txtCedula.Text);

            if (nombre.ToString().Trim().Equals(""))
            {
                if (MessageBox.Show("Desea agregar nuevo paciente?", "Agregar Paciente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Hide();
                    RegistroPacientes nuevo = new RegistroPacientes(cedula);
                    nuevo.btnGuardarCita.Visible = true;
                    nuevo.Show();
                }                
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
            errorProvider1.Clear();
            if (!Verificar())
            {
                return;
            }
            InsertarDatos();
        }

        /// <summary>
        /// TOMA LOS DATOS DEL FORMULARIO PARA INSERTAR
        /// </summary>
        private void InsertarDatos()
        {

            CitaMensajes cita = new CitaMensajes();
            cita.CedDoc = txtCedDoc.Text;
            cita.CedPac = txtCedula.Text;
            cita.Hora = comboBoxHorario.SelectedItem.ToString();
            cita.FechaCita = dateTimeFechaCita.Text;
            cita.Especialidad = cmbEspecialidad.SelectedItem.ToString();
            cita.Estado = "EN ESPERA";
            CitaNegocio.InsertaCita(cita);
            Limpiar();            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }

        /// <summary>
        /// METODO PARA ELIMINAR UNA TUPLA EN LA BASE DE DATOS
        /// </summary>
        private void EliminarDatos()
        {
            if (MessageBox.Show("Seguro que desea eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CitaNegocio.cancelarCita(txtNCita.Text, "CANCELADA");
                this.Hide();
                BuscarCitas ci = new BuscarCitas();
                ci.MdiParent = MenuPrincipal.ActiveForm;
                ci.dataGridCitasEliminar.Visible = true;
                ci.Show();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// LIMPIA LOS CAMPOS DEL FORMULARIO
        /// </summary>
        /// <returns></returns>
        private bool Verificar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese Nombre del Paciente");
                return false;
            }
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEspecialidad, "Seleccione una Especialidad");
                return false;
            }
            if (string.IsNullOrEmpty(txtCedDoc.Text))
            {
                errorProvider1.SetError(txtCedDoc, "Ingrese Cedula del Doctor.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNomDoc.Text))
            {
                errorProvider1.SetError(txtNomDoc, "Ingrese Nombre del Doctor.");
                return false;
            }
            if (comboBoxHorario.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxHorario, "Seleccione una Horario");
                return false;
            }
            return true;
        }

        /// <summary>
        /// VERIFICA EXISTENCIA DE DATOS EN EL CAMPO CEDULA
        /// </summary>
        /// <returns></returns>
        private bool VerificarCedu()
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                errorProvider1.SetError(txtCedula, "Ingrese una Cedula de Paciente");
                return false;
            }
            return true;
        }

        /// <summary>
        /// LIMPIAR LOS CAMPOS DE FORMULARIO
        /// </summary>
        /// <returns></returns>
        private void Limpiar()
        {
            txtCedDoc.Text = "";
            txtCedula.Text = "";
            txtNCita.Text = "";
            txtNombre.Text = "";
            txtNomDoc.Text = "";
            comboBoxHorario.Text = "";
            cmbEspecialidad.Text = "";
        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        /// <summary>
        /// ACTUALIZAR LOS DATOS DEL FORMULARIO
        /// </summary>
        private void ActualizarDatos()
        {
            CitaMensajes citaActualizar = new CitaMensajes();
            citaActualizar.Id = Convert.ToInt32(txtNCita.Text);
            citaActualizar.FechaCita = dateTimeFechaCita.Text;
            citaActualizar.Especialidad = cmbEspecialidad.SelectedItem.ToString();
            citaActualizar.Hora = comboBoxHorario.SelectedItem.ToString();
            citaActualizar.Especialidad = cmbEspecialidad.SelectedItem.ToString();
            citaActualizar.CedDoc = txtCedDoc.Text;

            var resultado = CitaNegocio.ActualizarCita(citaActualizar);
            Limpiar();
            this.Hide();

            BuscarCitas buscarCita= new BuscarCitas();
            buscarCita.MdiParent = MenuPrincipal.ActiveForm;
            buscarCita.dataGridCitas.Visible = true;
            buscarCita.Show();
        }
    }



}
    

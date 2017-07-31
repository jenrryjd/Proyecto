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
    public partial class RegistroPacientes : Form
    {
        public RegistroPacientes(string cedula)
        {

            InitializeComponent();
            txtCedula.Text = cedula;
        }

        private void appointmentLabelEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroPacientes_Load(object sender, EventArgs e)
        {
            btnGuardarCita.Visible = false;
            txtCedula.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            guardar();

        }

        private void limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateFechaNac.Text = "";

            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
          
        }
        private void guardar()
        {
            PacienteMensaje pac = new PacienteMensaje();
            pac.Cedula = txtCedula.Text;
            pac.Nombre = txtNombre.Text;
            pac.Apellido = txtApellido.Text;
            pac.Telefono = (txtTelefono.Text);
            pac.Celular = (txtCelular.Text);
            pac.Direccion = txtDireccion.Text;
            pac.Fecha = Convert.ToDateTime(dateFechaNac.Text);
            if (radbtnFemenino.Checked == true)
            {
                pac.Genero = radbtnFemenino.Text;
            }
            else if (radbtnMasculino.Checked == true)
            {
                pac.Genero = radbtnMasculino.Text;
            }


            var resultado = PersonaTestNegocio.GuardarPacienteMensaje(pac);

        }
        private bool Verificar()

        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                dxErrorProvider1.SetError(txtCedula, "Ingrese una Descripcion");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                dxErrorProvider1.SetError(txtNombre, "Ingrese sus nombres");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                dxErrorProvider1.SetError(txtApellido, "Ingrese sus apellidos");
                return false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                dxErrorProvider1.SetError(txtDireccion, "Ingrese su direccion");
                return false;
            }

            if (string.IsNullOrEmpty(dateFechaNac.Text))
            {
                dxErrorProvider1.SetError(dateFechaNac, "Selecione su fecha de naciento");
                return false;
            }
           
            

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            AgendarCita agc = new AgendarCita(txtCedula.Text);
            agc.MdiParent = MenuPrincipal.ActiveForm;
            agc.Text = "Agendar Cita";
            this.Hide();
            agc.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            MetodosBasicos.SoloNumerosEnteros(e);
        }
    }
}

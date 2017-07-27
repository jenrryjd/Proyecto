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
        public RegistroPacientes()
        {
            InitializeComponent();
        }

        private void appointmentLabelEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroPacientes_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PacienteMensaje pac = new PacienteMensaje();
            pac.Cedula = txtCedula.Text;
            pac.Nombre = txtNombre.Text;
            pac.Apellido = txtApellido.Text;
            pac.Telefono = (txtTelefono.Text);
            pac.Celular = (txtCelular.Text);
            pac.Direccion = txtDireccion.Text;
       


            var resultado = PersonaTestNegocio.GuardarPacienteMensaje(pac);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCedula.Text="";
             txtNombre.Text="";
             txtApellido.Text="";
            txtTelefono.Text="";
            txtCelular.Text="";
            txtDireccion.Text="";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

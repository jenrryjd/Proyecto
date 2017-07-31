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
    public partial class ParaModificarPaciente : Form
    {
        public ParaModificarPaciente(PacienteMensaje paci)
        {
            InitializeComponent();
            textCedula.Enabled = false;
            textCedula.Text = paci.Cedula;
            textNombre.Text = paci.Nombre;
            textApellido.Text = paci.Apellido;
            textDireccion.Text = paci.Direccion;
            textTelefono.Text = paci.Telefono;
            textCelular.Text = paci.Celular;

        }
      


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PacienteMensaje pc=new PacienteMensaje();
            
            pc.Cedula = textCedula.Text;
            pc.Nombre = textNombre.Text;
            pc.Apellido = textApellido.Text;
            pc.Telefono = (textTelefono.Text);
            pc.Celular = (textCelular.Text);
            pc.Direccion = textDireccion.Text;
            PersonaTestNegocio.ActualizarPaciente(pc);
            MessageBox.Show("Paciente actualizado con exito","INFORMACION");
            ModificarPacientes modpc = new ModificarPacientes();
            modpc.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textCelular_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textApellido.Text = "";
            textCedula.Text = "";

            textNombre.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textCelular.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

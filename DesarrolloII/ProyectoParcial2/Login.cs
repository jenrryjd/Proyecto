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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!VerificarCredenciales())
            {
                return;
            }
            ingresarSistema();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestro servicio.");
            Dispose();
        }
        /// <summary>
        /// VERIFICA TEXTO EN EL USUARIO Y CONTRASEÑA
        /// </summary>
        /// <returns></returns>
        private bool VerificarCredenciales()
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                errorProvider1.SetError(txtUser, "Ingrese Usuario.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Ingrese una Clave.");
                return false;
            }
            return true;
        }
        /// <summary>
        /// VALIDAMOS LOS DATOS DESDE LA DB
        /// </summary>
        private void ingresarSistema()
        {
            LoginMensajes credenciales = new LoginMensajes();
            credenciales.Usuario = txtUser.Text.ToUpper();
            credenciales.Contrasenia = txtPass.Text;

            LoginMensajes datos = new LoginMensajes();
            datos = LoginNegocio.VerificarDatos(credenciales);

            if ((datos.NombreUsuario == null))
            {
                MessageBox.Show("Usuario o Contraseña invalidos.\nVuelva a Intentarlo. ");
            }
            else
            {
                MessageBox.Show("Bienvenido:\n" + datos.Perfil.Trim() + ": " + datos.NombreUsuario);
                MenuPrincipal p = new MenuPrincipal(datos);
                p.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

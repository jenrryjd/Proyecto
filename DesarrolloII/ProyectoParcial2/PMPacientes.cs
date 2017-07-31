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
    public partial class PMPacientes : Form
    {
        PacienteMensaje mm;
        public PMPacientes(PacienteMensaje pas)
        {
            InitializeComponent();
           
                mm = pas;
                txtCedula.Text = mm.Cedula;
                txtNombre.Text = mm.Nombre;
                txtApellido.Text = mm.Apellido;

                dateFechaNac.Text = Convert.ToString(mm.Fecha);



                if (mm.Genero.Equals("Femenino"))
                {
                    radbtnFemenino.Checked = true;

                }
                else if (mm.Genero.Equals("Masculino"))
                {
                    radbtnMasculino.Checked = true;
                }

                if (mm.Celular.Equals(""))
                {
                    txtCelular.Text = "";
                }
                if (mm.Telefono.Equals(""))
                {
                    txtTelefono.Text = "";
                }
                txtCelular.Text = mm.Celular.ToString();
                txtTelefono.Text = mm.Telefono.ToString();
                txtDireccion.Text = mm.Direccion;
           
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            modificar();

        }

        private void modificar()
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


            var resultado = PersonaTestNegocio.ModificarPaciente(pac);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ModificarPacientes p = new ModificarPacientes();
            p.Text = "Modificar Pacientes";
            p.MdiParent = MenuPrincipal.ActiveForm;
            p.dataGridPacientes.Visible = true;
            p.Show();
            this.Hide();
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


            if (!radbtnFemenino.Checked)
            {
                dxErrorProvider1.SetError(radbtnFemenino, "Seleccione Genero");
                return false;
            }
            if ( !radbtnMasculino.Checked)
            {
                dxErrorProvider1.SetError(radbtnMasculino, "Seleccione Genero");
                return false;
            }

            return true;
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

        private void PMPacientes_Load(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
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

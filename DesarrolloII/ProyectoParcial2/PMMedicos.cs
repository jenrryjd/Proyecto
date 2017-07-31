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
    public partial class PMMedicos : Form
    {
        MedicoMensaje mm;

        public PMMedicos(MedicoMensaje pas)
        {
            InitializeComponent();
            mm = pas;
            txtCedula.Text = mm.Cedula;
            txtNombre.Text = mm.Nombre;
            txtApellidos.Text = mm.Apellido;
            dateFechaNac.Text =Convert.ToString( mm.Fecha);
            if (mm.Genero.Equals("Femenino"))
            {
                radbtnFemenino.Checked = true;

            }else if(mm.Genero.Equals("Masculino"))
            {
                radbtnMasculino.Checked =true;
            }
            comboCivil.Text = mm.EstCivi;
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
            txtLicen.Text = mm.LicenMed;
            comboEspe.Text = mm.Especialidad;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ModificarMedicos m = new ModificarMedicos();
            m.Text = "Modificar Medicos";
            m.MdiParent = MenuPrincipal.ActiveForm;
            m.dataGridMedico.Visible = true;
            m.Show();
            this.Hide();
          
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            modificar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dateFechaNac.Text = "";

            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtLicen.Text = "";
        }

        private void PMMedicos_Load(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            txtNombre.Focus();
        }

        private void modificar()
        {
           
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
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                dxErrorProvider1.SetError(txtApellidos, "Ingrese sus apellidos");
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
            if (comboCivil.SelectedIndex == -1)
            {
                dxErrorProvider1.SetError(comboCivil, "Seleccione su estado civil");
                return false;
            }


            if (radbtnFemenino.Checked == false || radbtnMasculino.Checked == false)
            {
                dxErrorProvider1.SetError(radioGroup1, "Seleccione Genero");
                return false;
            }
            if (comboEspe.SelectedIndex == -1)
            {
                dxErrorProvider1.SetError(comboEspe, "Seleccione Especializacion");
                return false;
            }
            if (string.IsNullOrEmpty(txtLicen.Text))
            {
                dxErrorProvider1.SetError(txtLicen, "Ingrese su codigo de licencia");
                return false;
            }
            return true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {

            MetodosBasicos.SoloLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void txtLicen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLicen_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }
    }
}

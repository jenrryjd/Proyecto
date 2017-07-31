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
 using DevExpress.XtraEditors;
namespace ProyectoParcial2
{
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
    
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            guardar();
        }

        private void guardar()
        {
            MedicoMensaje med = new MedicoMensaje();
            med.Cedula = txtCedula.Text;
            med.Nombre = txtNombre.Text;
            med.Apellido = txtApellidos.Text;
            med.Fecha = Convert.ToDateTime(dateFechaNac.Text);
            if (radbtnFemenino.Checked == true)
            {
                med.Genero = radbtnFemenino.Text;
            }
            else if (radbtnMasculino.Checked == true)
            {
                med.Genero = radbtnMasculino.Text;
            }

            med.EstCivi = comboCivil.SelectedItem.ToString();
            med.Telefono = Convert.ToInt32(txtTelefono.Text);
            med.Celular = Convert.ToInt32(txtCelular.Text);
            med.Direccion = txtDireccion.Text;
            med.LicenMed = txtLicen.Text;
            med.Especialidad = comboEspc.SelectedItem.ToString();



            var resultado = PersonaTestNegocio.GuardarMedicoMensaje(med);
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

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
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
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtLicen_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
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
         

         
            if (comboEspc.SelectedIndex == -1)
            {
                dxErrorProvider1.SetError(comboEspc, "Seleccione Especializacion");
                return false;
            }
            if (string.IsNullOrEmpty(txtLicen.Text))
            {
                dxErrorProvider1.SetError(txtLicen, "Ingrese su codigo de licencia");
                return false;
            }
            return true;
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarBoxEspecialidad(comboEspc);
        }
    }
}

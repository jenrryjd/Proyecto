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
    public partial class ParaModificarMedicos : Form
    {
        public ParaModificarMedicos(MedicoMensaje med)
        {
            InitializeComponent();

          txtCelula.Text=  med.Cedula;
         txtNombre.Text=   med.Nombre;
            txtApellido.Text= med.Apellido;
            txtFecha.Text= Convert.ToString( med.Fecha);

            if (med.Genero.Equals("FEMENINO"))
            {
                btnFemenino.Checked=true;
            }
            else if (med.Genero.Equals("MASCULINO"))
            {
                btnMasculino.Checked =true;
            }
            

            cmbEstCi.SelectedItem= med.EstCivi.ToLowerInvariant();
            txtTelefono.Text=Convert.ToString( med.Telefono);
           txtCelular.Text= Convert.ToString( med.Celular);
          txtDireccion.Text=  med.Direccion;
            txtLicencia.Text= med.LicenMed;
       comboEspecializacion.Text= med.Especialidad;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MedicoMensaje medico = new MedicoMensaje();
            medico.Cedula = txtCelula.Text;
            medico.Nombre = txtNombre.Text;
            medico.Apellido = txtApellido.Text;
            medico.Fecha = Convert.ToDateTime(txtFecha.Text);
            if (btnFemenino.Checked == true)
            {
                medico.Genero = btnFemenino.Text;
            }
            else if (btnMasculino.Checked == true)
            {
                medico.Genero = btnMasculino.Text;
            }

            medico.EstCivi = cmbEstCi.SelectedItem.ToString();
            medico.Telefono = Convert.ToInt32(txtTelefono.Text);
            medico.Celular = Convert.ToInt32(txtCelular.Text);
            medico.Direccion = txtDireccion.Text;
            medico.LicenMed = txtLicencia.Text;
            medico.Especialidad = comboEspecializacion.SelectedItem.ToString();
            PersonaTestNegocio.ActualizarMedico(medico);
            MessageBox.Show("Medico actualizado con exito", "INFORMACION");
            Medicos modpc = new Medicos();
            modpc.Show();
            this.Hide();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtCelula.Text="";
            txtNombre.Text="";
            txtApellido.Text="";
            txtFecha.Text="";


            cmbEstCi.Text = "";
        txtTelefono.Text="";
            txtCelular.Text="";
             txtDireccion.Text="";
             txtLicencia.Text="";
             comboEspecializacion.Text="";
        }
    }
}

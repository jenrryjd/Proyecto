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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Medico med = new Medico();
            //med.Cedula = txtCedula.Text;
            //med.Nombre = txtNombre.Text;
            //med.Apellido = txtApellido.Text;
            //med.Fecha = Convert.ToDateTime( dateFechNac.Text);
            //if (radioBMacu.Capture)
            //{
            //    med.Genero = radioBMacu.Text;
            //}else if(radioBFemenino.Capture)
            //{
            //    med.Genero = radioBFemenino.Text;
            //}
            //med.EstCivi = comboBEspec.SelectedItem.ToString();
            //med.Telefono = Convert.ToInt32(txtTelefono.Text);
            //med.Celular = Convert.ToInt32( txtCelular.Text);
            //med.Direccion = txtDireccion.Text;
            //med.LicenMed = txtLicencia.Text;
            //med.Especialidad=comboBEspec.SelectedItem.ToString();
         


            //var resultado = MedicoNegocio.GuardarPersonaMedicoNegocio(med);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MedicoMensaje med = new MedicoMensaje();
            med.Cedula = txtCedula.Text;
            med.Nombre = txtNombre.Text;
            med.Apellido = txtApellidos.Text;
            med.Fecha = Convert.ToDateTime(dateFechaNac.Text);
            if (radbtnFemenino.Checked==true)
            {
                med.Genero = radbtnFemenino.Text;
            }
            else if (radbtnMasculino.Checked==true)
            {
                med.Genero = radbtnMasculino.Text;
            }

            med.EstCivi = comboCivil.SelectedItem.ToString();
            med.Telefono = Convert.ToInt32(txtTelefono.Text);
            med.Celular = Convert.ToInt32(txtCelular.Text);
            med.Direccion = txtDireccion.Text;
            med.LicenMed = txtLicen.Text;
            med.Especialidad = comboEspe.SelectedItem.ToString();



            var resultado = PersonaTestNegocio.GuardarMedicoMensaje(med);
        }
    }
}

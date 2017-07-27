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
    public partial class Especialidad : Form
    {
        public Especialidad()
        {
            InitializeComponent();
        }

        private void btnInsertarEspecia_Click(object sender, EventArgs e)
        {
            EspecialidadMensaje espe = new EspecialidadMensaje();
            espe.CodigoEsp = txtCodigo.Text;
            espe.NomEsp = txtEspe.Text;
            var resultado = EspecialidadNegocio.GuardarEspecialidad(espe);

        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBuscar.SelectedItem.Equals("CODIGO"))
            {
                lblCambiante.Text = "Codigo";
            }
            else if (comboBuscar.SelectedItem.Equals( "ESPECIALIDAD"))
            {
                lblCambiante.Text = "Especialidad";
            }
        }
    }
}

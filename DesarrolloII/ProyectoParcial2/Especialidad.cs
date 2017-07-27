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
            MessageBox.Show("Se insirteo Correctamente","INFORMACION");
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

        private void btnElimnarEspe_Click(object sender, EventArgs e)
        {
            EspecialidadMensaje espe = new EspecialidadMensaje();
            espe.CodigoEsp = txtCodigo.Text;
            espe.NomEsp = txtEspe.Text;
            var resultado = EspecialidadNegocio.EliminarEspecialidad (espe);
            MessageBox.Show("Se elimino correctamente", "INFORMACION");
        }

        private void btnModificarEspe_Click(object sender, EventArgs e)
        {
            EspecialidadMensaje espe = new EspecialidadMensaje();
            espe.CodigoEsp = txtCodigo.Text;
            espe.NomEsp = txtEspe.Text;
            var resultado = EspecialidadNegocio.ActualizarEspecialidad(espe);
            MessageBox.Show("Se actualizo correctamente", "INFORMACION");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          txtCodigo.Text = Convert.ToString(dataGridEspecialidades.Rows[e.RowIndex].Cells[0].Value);
           txtEspe.Text = Convert.ToString(dataGridEspecialidades.Rows[e.RowIndex].Cells[1].Value);



        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            EspecialidadNegocio obj = new EspecialidadNegocio();
                var lista = obj.DevolverListaEspecialidad();
                dataGridEspecialidades.DataSource = lista.Tables[0];
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBuscar.SelectedText.Equals("CODIGO"))
            {
                EspecialidadNegocio obj = new EspecialidadNegocio();
                var lista = obj.DevolverListaEspeCodigo(txtBuscarMas.Text);
                dataGridEspecialidades.DataSource = lista.Tables[0];
            }
            if (comboBuscar.SelectedText.Equals("ESPECIALIDAD"))
            {
                EspecialidadNegocio obj = new EspecialidadNegocio();
                var lista = obj.DevolverListaEspeEspecificacion(txtBuscarMas.Text);
                dataGridEspecialidades.DataSource = lista.Tables[0];
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtCodigo.Text="";
             txtEspe.Text="";
        }
    }
}

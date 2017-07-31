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
            txtEspe.Enabled = false;
            txtCodigo.Enabled = false;
            dataGridView1.Enabled = false;
            comboBuscar.Enabled = false;
            txtBuscar.Enabled = false;

        }

        private void btnInsertarEspecia_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            guardar();
        }

        private void eliminar()
        {

            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("Tiene que tener datos");
            }
            else
            {
                EspecialidadMensaje pacienteEliminar = new EspecialidadMensaje();
                pacienteEliminar.CodigoEsp = (txtBuscar.Text);

                var resultado = EspecialidadNegocio.ActualizarEspecialidad(pacienteEliminar);
                // MessageBox.Show("Paciente Eliminado con Exito...!!");
                txtBuscar.Text = "";
                MetodosBasicos.CargarTabla(dataGridView1);

            }
        }
        private void actualizar()
        {
            if (!Verificar())
            {
                return;
            }
           EspecialidadMensaje pac = new EspecialidadMensaje();
            pac.CodigoEsp = txtCodigo.Text;
            pac.NomEsp = txtEspe.Text;
       

            var resultado = EspecialidadNegocio.ActualizarEspecialidad(pac);
        }

        private void guardar()
        {
            EspecialidadMensaje espe = new EspecialidadMensaje();
            espe.CodigoEsp = txtCodigo.Text;
            espe.NomEsp = txtEspe.Text;
            var resultado = EspecialidadNegocio.GuardarEspecialidad(espe);

        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBuscar.SelectedItem.Equals("Codigo"))
            {
                lblCambiante.Text = "Codigo";
                txtBuscar.Enabled = true;
            }
            else if (comboBuscar.SelectedItem.Equals( "Especialidad"))
            {
                lblCambiante.Text = "Especialidad";
                txtBuscar.Enabled = true;
            }
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EspecialidadMensaje paso = new EspecialidadMensaje();
            try
            {
                txtCodigo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                txtEspe.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Esta fila no contiene ningun valor");
            }
          
        
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            MetodosBasicos.CargarTablaEspecialidades(dataGridView1);
        }

        private void btnModificarEspe_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            actualizar();
        }

        private void btnElimnarEspe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar esta Especialidad", "Eliminar Especialidad", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                eliminar();
            }
        }

        private bool Verificar()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                dxErrorProvider1.SetError(txtCodigo, "Ingrese un codigo");
                return false;
            }

            if (string.IsNullOrEmpty(txtEspe.Text))
            {
                dxErrorProvider1.SetError(txtEspe, "Ingrese Especificacion");
                return false;
            }
            return true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtEspe.Text = "";
            comboBuscar.Text = "";
            txtBuscar.Text = "";
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBuscar.SelectedItem.Equals("Codigo"))
            {
                lblCambiante.Text = "Codigo";
                txtBuscar.Enabled = true;
                
                EspecialidadNegocio obj = new EspecialidadNegocio();
                var lista = obj.DevolverListaEspecialidadesId(txtBuscar.Text);
                dataGridView1.DataSource = lista.Tables[0];
            }
            else if (comboBuscar.SelectedItem.Equals("Especialidad"))
            {
                lblCambiante.Text = "Especialidad";
                txtBuscar.Enabled = true;

               
                EspecialidadNegocio obj1 = new EspecialidadNegocio();
                var lista1 = obj1.DevolverListaEspecialidadesNombre(txtBuscar.Text);
                dataGridView1.DataSource = lista1.Tables[0];
            }
        }

        private void txtBuscar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEspe_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

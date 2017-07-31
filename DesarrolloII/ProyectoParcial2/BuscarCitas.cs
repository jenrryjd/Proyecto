using System;
using System.Windows.Forms;
using NEGOCIO;

namespace ProyectoParcial2
{
    public partial class BuscarCitas : Form
    {
        public BuscarCitas()
        {
            InitializeComponent();
        }

        private void BuscarCitas_Load(object sender, EventArgs e)
        {

        }

        private void txtRazonBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CitaMensajes paso = new CitaMensajes();
            paso.Id = (int)dataGridCitas.Rows[e.RowIndex].Cells[0].Value;
            paso.CedPac = (string)dataGridCitas.Rows[e.RowIndex].Cells[1].Value;
            paso.CedDoc = (string)dataGridCitas.Rows[e.RowIndex].Cells[2].Value;
            //paso.Hora = (string)dataGridCitas.Rows[e.RowIndex].Cells[3].Value;
            //paso.FechaCita = dataGridCitas.Rows[e.RowIndex].Cells[4].Value;
            paso.Especialidad = (string)dataGridCitas.Rows[e.RowIndex].Cells[5].Value;

            AgendarCita modificar = new AgendarCita(paso);
            this.Hide();

            modificar.Text = "Modificar Cita";
            modificar.btnActualizar.Visible = true;
            modificar.btnBuscarPac.Visible = false;
            modificar.txtCedula.Enabled = false;
            //btnCancelarActualizacion.Visible = true;
            modificar.btnSalir.Visible = true;
            modificar.MdiParent = MenuPrincipal.ActiveForm;
            modificar.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
            if (!VerificarNombre())
            {
                return;
            }
            
            CitaNegocio obj = new CitaNegocio();
            var lista = obj.DevolverListaCitas(txtRazonBuscar.Text);
            dataGridCitas.DataSource = lista.Tables[0];
            dataGridCitasEliminar.DataSource = lista.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("No tiene datos.");
            }
        }

        /// <summary>
        /// VERIFICAR SI EXISTE NOMBRE PARA BUSCAR CITAS
        /// </summary>
        /// <returns></returns>
        private bool VerificarNombre()
        {
            if (string.IsNullOrEmpty(txtRazonBuscar.Text))
            {
                errorProvider1.SetError(txtRazonBuscar, "Ingrese Nombre del Paciente");
                return false;
            }
            return true;
        }

        private void dataGridCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridCitasEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CitaMensajes paso = new CitaMensajes();
            paso.Id = (int)dataGridCitas.Rows[e.RowIndex].Cells[0].Value;
            paso.CedPac = (string)dataGridCitas.Rows[e.RowIndex].Cells[1].Value;
            paso.CedDoc = (string)dataGridCitas.Rows[e.RowIndex].Cells[2].Value;
            //paso.Hora = (string)dataGridCitas.Rows[e.RowIndex].Cells[3].Value;
            //paso.FechaCita = dataGridCitas.Rows[e.RowIndex].Cells[4].Value;
            paso.Especialidad = (string)dataGridCitas.Rows[e.RowIndex].Cells[5].Value;

            AgendarCita modificar = new AgendarCita(paso);
            this.Hide();
            modificar.Text = "Cancelar Cita";
            modificar.btnSalir.Visible = true;
            modificar.btnEliminar.Visible = true;
            modificar.btnBuscarPac.Visible = false;
            modificar.MdiParent = MenuPrincipal.ActiveForm;
            modificar.Show();
        }

        private void dataGridCitasEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRazonBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
        }
    }
}

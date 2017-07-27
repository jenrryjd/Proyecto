using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using NEGOCIO;
using MENSAJES;

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
            CitaNegocio obj = new CitaNegocio();
            var lista = obj.DevolverListaCitas(txtRazonBuscar.Text);
            dataGridCitas.DataSource = lista.Tables[0];
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // CitaMensajes paso = new CitaMensajes();
           // paso.Id = (int)dataGridCitas.Rows[e.RowIndex].Cells[0].Value;
           // paso.CedPac = (string)dataGridCitas.Rows[e.RowIndex].Cells[1].Value;
           // paso.CedDoc = (string)dataGridCitas.Rows[e.RowIndex].Cells[2].Value;
           //// paso.Hora = (string)dataGridCitas.Rows[e.RowIndex].Cells[3].Value;
           //// paso.FechaCita = (string)dataGridCitas.Rows[e.RowIndex].Cells[4].Value;
           // paso.Especialidad = (string)dataGridCitas.Rows[e.RowIndex].Cells[5].Value;

           // AgendarCita modificar = new AgendarCita(paso);
           // this.Hide();
           // modificar.Text = "Cita";
           // modificar.MdiParent = MenuPrincipal.ActiveForm;
           // modificar.Show();
        }
    }
}

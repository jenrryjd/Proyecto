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
    public partial class CitasAsignadas : Form
    {
        public CitasAsignadas()
        {
            InitializeComponent();
        }

        public CitasAsignadas(string Cargo)
        {
            InitializeComponent();
            try
            {
                CitaNegocio obj = new CitaNegocio();
                var lista = obj.DevolverListaCitasCargo(Cargo);
                dataGridCitasAsignadas.DataSource = lista.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("No existen citas para este Especialista.");
            }
        }


        private void dataGridCitasAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string cedula = (string)dataGridCitasAsignadas.Rows[e.RowIndex].Cells[1].Value;
            int idCita = (int)dataGridCitasAsignadas.Rows[e.RowIndex].Cells[0].Value;
            try
            {
                HistoriaMedicaMensajes a = new HistoriaMedicaMensajes();
                HistoriaMedicaNegocio consultarHM = new HistoriaMedicaNegocio();
                a = consultarHM.ConsultarHistoriaMedica(cedula);

                SignosMensajes b = new SignosMensajes();
                SignosNegocio consultarSig = new SignosNegocio();
                b=consultarSig.ConsultarSignos(idCita.ToString());
                

                if (a.Id.Equals(0) || b.Id.Equals(0))
                {
                    MessageBox.Show("*Usted NO tiene Historial Medico o\n*No se tomo los signos Vitales");
                }
                else
                {

                    CitaMensajes datosAten = new CitaMensajes();
                    datosAten.Id = (int)dataGridCitasAsignadas.Rows[e.RowIndex].Cells[0].Value;
                    datosAten.CedPac = (string)dataGridCitasAsignadas.Rows[e.RowIndex].Cells[1].Value;
                    datosAten.Especialidad = (string)dataGridCitasAsignadas.Rows[e.RowIndex].Cells[5].Value;

                    AtencionTratamientoFrm pasoCitaCedula = new AtencionTratamientoFrm(datosAten);
                    this.Hide();
                    pasoCitaCedula.MdiParent = MenuPrincipal.ActiveForm;
                    pasoCitaCedula.Show();
                }
                                
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una cita.");
            }
                     
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CitasAsignadas_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridCitasAsignadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

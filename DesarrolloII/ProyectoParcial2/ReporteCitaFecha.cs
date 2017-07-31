using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial2
{
    public partial class ReporteCitaFecha : Form
    {
        public ReporteCitaFecha()
        {
            InitializeComponent();
        }

        private void ReporteCitaFecha_Load(object sender, EventArgs e)
        {
            
        }

        private bool verificar()
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                dxErrorProvider1.SetError(dateTimePicker1, "Selecione su fecha de naciento");
                return false;
            }

            return true;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'CitaFecha.CITA' Puede moverla o quitarla según sea necesario.
            DateTime fecha;
            fecha =Convert.ToDateTime(dateTimePicker1.Text);
            this.CITATableAdapter.Fill(this.CitaFecha.CITA,Convert.ToString(fecha));

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class ReportesEstado : Form
    {
        public ReportesEstado()
        {
            InitializeComponent();
            simpleButton1.Enabled = false;
            textEdit1.Enabled = false;
        }

        private void ReportesEstado_Load(object sender, EventArgs e)
        {
          
        }
   

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Asistidas.CITA' Puede moverla o quitarla según sea necesario.

            this.CITATableAdapter.Fill(this.Asistidas.CITA,textEdit1.Text);

            this.reportViewer1.RefreshReport();
        }
        public bool verificar()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                dxErrorProvider1.SetError(comboBox1, "Seleccione uno de los items");
                return false;
            }

            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!verificar())
            {
                return;
            }

            if (comboBox1.SelectedItem.Equals("ASISTIDO"))
            {
                textEdit1.Text = "ASISTIDO";
                simpleButton1.Enabled = true;
            }
            if (comboBox1.SelectedItem.Equals("NO ASISTIDO"))
            {
                textEdit1.Text = "NO ASISTIDO";
                simpleButton1.Enabled = true;
            }
            if (comboBox1.SelectedItem.Equals("EN ESPERA"))
            {
                textEdit1.Text = "EN ESPERA";
                simpleButton1.Enabled = true;
            }
            if (comboBox1.SelectedItem.Equals("CANCELADO"))
            {
                textEdit1.Text = "CANCELADO";
                simpleButton1.Enabled = true;
            }
        }
    }
}

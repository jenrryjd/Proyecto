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
    public partial class ModificarCita : Form
    {
        public ModificarCita()
        {
            InitializeComponent();
        }

        private void dataGridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AgendarCita modificar = new AgendarCita(1);
            this.Hide();
            modificar.Text = "Modificar Cita";
            modificar.MdiParent=MenuPrincipal.ActiveForm;
            modificar.btnAgendar.Visible = false;
            modificar.btnModificar.Visible = true;
            modificar.Show();
        }

        private void dataGridCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

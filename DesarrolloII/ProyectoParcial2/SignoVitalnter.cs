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
    public partial class SignoVital : Form
    {
        public SignoVital()
        {
            InitializeComponent();
            txtAltura.Enabled = false;
            txtPeso.Enabled = false;
            txtPresion.Enabled = false;
            txtRitmpCardiaco.Enabled=false;
            txtNumCita.Enabled = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            guardar();
        }

        private bool Verificar()

        {
            if (string.IsNullOrEmpty(txtNumCita.Text))
            {
                dxErrorProvider1.SetError(txtNumCita, "Numero de cita no asignada");
                return false;
            }

            if (string.IsNullOrEmpty(txtAltura.Text))
            {
                dxErrorProvider1.SetError(txtAltura, "Ingrese su altura ");
                return false;
            }
            if (string.IsNullOrEmpty(txtPeso.Text))
            {
                dxErrorProvider1.SetError(txtPeso, "Ingrese su peso");
                return false;
            }

            if (string.IsNullOrEmpty(txtPresion.Text))
            {
                dxErrorProvider1.SetError(txtPresion, "Ingrese su Presion");
                return false;
            }

            if (string.IsNullOrEmpty(txtRitmpCardiaco.Text))
            {
                dxErrorProvider1.SetError(txtRitmpCardiaco, "Ingrese Ritmo Cardiaco");
                return false;
            }

            return true;
        }

        private void guardar()
        {
         SignosVitales pac = new SignosVitales();
            pac.Id_C=Convert.ToInt32( txtNumCita.Text);

            pac.Peso = Convert.ToInt32( txtPeso.Text);

            pac.Presion = txtPresion.Text;
            pac.RitmoCardiaco = Convert.ToInt32(txtRitmpCardiaco.Text);
            pac.Altura =Convert.ToDecimal (txtAltura.Text);
          
         


            var resultado = SignosVitalesNegocio.InsertarSignoVital(pac);

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            SignosVitalesNegocio obj = new SignosVitalesNegocio();
            var lista = obj.DevolverListaCita((txtBuscar.Text));
            dataGridCitas.DataSource = lista.Tables[0];

        }

        private void btnSlir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtPresion.Text = "";
            txtRitmpCardiaco.Text = "";
            txtNumCita.Text = "";
            dataGridCitas.Enabled = true;
            txtBuscar.Enabled = true;
            txtBuscar.Focus();
            dataGridCitas.Refresh();
        }

        private void dataGridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtAltura.Enabled = true;
            txtPeso.Enabled = true;
            txtPresion.Enabled = true;
            txtRitmpCardiaco.Enabled = true;
            dataGridCitas.Enabled = false;
            txtBuscar.Enabled = false;
            txtNumCita.Text = Convert.ToString( dataGridCitas.Rows[e.RowIndex].Cells[0].Value);

        }

        private void SignoVital_Load(object sender, EventArgs e)
        {
           
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosDecimales(e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtPresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }

        private void txtRitmpCardiaco_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloNumerosEnteros(e);
        }
    }
}

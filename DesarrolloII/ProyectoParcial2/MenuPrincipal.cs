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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RegistroPacientes ventanaPaci = new RegistroPacientes();
            ventanaPaci.MdiParent = this;
            ventanaPaci.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgendarCita agendar = new AgendarCita();
            agendar.MdiParent = this;
            agendar.btnAgendar.Visible = true;
            agendar.btnModificar.Visible = false;
            agendar.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Especialidad espe = new Especialidad();
            espe.btnInsertarEspecia.Visible = false;
            espe.btnModificarEspe.Visible = true;
            espe.btnElimnarEspe.Visible =false;
            espe.MdiParent = this;
            espe.txtCodigo.Enabled = false;
            espe.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medicos med = new Medicos();
            med.MdiParent = this;
            med.Show();
        }

        private void btnModMedico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarMedicos modMed = new ModificarMedicos();
          //  modMed.btnEliminarModMed.Visible = false;
            modMed.MdiParent = this;
            modMed.Show();
        }

        private void btnEliMedico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EliminarMedico modMed = new EliminarMedico();
          //  modMed.btnEliminarModMed.Visible = true;
            modMed.MdiParent = this;
            modMed.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Especialidad espe = new Especialidad();
            espe.btnInsertarEspecia.Visible = true;
            espe.btnModificarEspe.Visible = false;
            espe.btnElimnarEspe.Visible = false;
            espe.MdiParent = this;
            espe.txtCodigo.Enabled = true;
            espe.comboBuscar.Enabled = false;
            espe.txtBuscarMas.Enabled = false;
            espe.Show();
        }

        private void btnElimnarEsp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Especialidad espe = new Especialidad();
            espe.btnInsertarEspecia.Visible = false;
            espe.btnModificarEspe.Visible = false;
            espe.btnElimnarEspe.Visible = true;
            espe.MdiParent = this;
            espe.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarCita modificarCita = new ModificarCita();
            modificarCita.MdiParent = this;
            modificarCita.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EliminarCita eliminarCita = new EliminarCita();
            eliminarCita.MdiParent = this;
            eliminarCita.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AlergiasFrm alergias = new AlergiasFrm();
            alergias.MdiParent = this;
            alergias.btnInsertar.Visible = true;
            alergias.btnCancelar.Visible = true;
            alergias.btnSalir.Visible = true;
            alergias.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuscarAlergia buscarAlergia = new BuscarAlergia();
            buscarAlergia.MdiParent = this;
            buscarAlergia.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarPacientes buscarPac = new ModificarPacientes();
           
            buscarPac.MdiParent = this;
            buscarPac.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem9_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnPacienteModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarPacientes mdpa = new ModificarPacientes();
            mdpa.MdiParent = this;
            mdpa.Show();
        }

        private void btnEliminarPaciente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         EliminarPacientes m = new EliminarPacientes();
            
            m.MdiParent = this;
            m.Show();
        }
    }
}

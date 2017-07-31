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
            RegistroPacientes ventanaPaci = new RegistroPacientes("");
            ventanaPaci.Text = "Registro Pacientes";
            ventanaPaci.MdiParent = this;
            ventanaPaci.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lo hicimos...!!!");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgendarCita citaFrm = new AgendarCita("");
            citaFrm.Text = "Insertar Cita";
            citaFrm.MdiParent = this;
            citaFrm.btnInsertar.Visible = true;
            citaFrm.btnCancelar.Visible = true;
            citaFrm.btnSalir.Visible = true;
            citaFrm.Show();
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
            espe.txtEspe.Enabled = true;
            espe.comboBuscar.Enabled = true;
            espe.dataGridView1.Enabled = true;
            espe.Text = "Modificar Especialidad";
            espe.MdiParent = this;
            espe.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MedicamentoFrm eliminarMedicamento = new MedicamentoFrm();
            eliminarMedicamento.Text = "Eliminar Medicamento";
            eliminarMedicamento.labelControl2.Text = "Buscar Nombre";
            eliminarMedicamento.MdiParent = this;
            eliminarMedicamento.btnEliminar.Visible = true;
            eliminarMedicamento.btnCancelarEliminar.Visible = true;
            eliminarMedicamento.btnSalir.Visible = true;
            eliminarMedicamento.dataGridMedicamentoEliminar.Visible = true;
            eliminarMedicamento.txtBuscar.Visible = true;
            eliminarMedicamento.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medicos med = new Medicos();
            med.Text = "Registro Medicos";
            med.MdiParent = this;
            med.Show();
        }

        private void btnModMedico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarMedicos modMed = new ModificarMedicos();
            modMed.btnEliminarModMed.Visible = false;
            modMed.Text = "Modificar Medicos";
            modMed.MdiParent = this;
            modMed.dataGridMedico.Visible = true;
            modMed.Show();
        }

        private void btnEliMedico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarMedicos modMed = new ModificarMedicos();
            modMed.btnEliminarModMed.Visible = true;
            modMed.Text = "Eliminar Medicos";
            modMed.MdiParent = this;
            modMed.dataGridElimanrMedico.Visible = true;
            modMed.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Especialidad espe = new Especialidad();
            espe.btnInsertarEspecia.Visible = true;
            espe.btnModificarEspe.Visible = false;
            espe.btnElimnarEspe.Visible = false;
            espe.txtCodigo.Enabled = true;
            espe.txtEspe.Enabled = true;
            espe.Text = "Registrar Especialidad";
            espe.MdiParent = this;
            espe.Show();
        }

        private void btnElimnarEsp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Especialidad espe = new Especialidad();
            espe.btnInsertarEspecia.Visible = false;
            espe.btnModificarEspe.Visible = false;
            espe.btnElimnarEspe.Visible = true;
            espe.dataGridView1.Enabled = true;
            espe.comboBuscar.Enabled = true;
            espe.MdiParent = this;
            espe.Text = "Eliminar Especialidad";
            espe.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuscarCitas modificarCita = new BuscarCitas();
            modificarCita.MdiParent = this;
            modificarCita.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EliminarCita eliminarCita = new EliminarCita();
            eliminarCita.Text = "Eliminar Cita";
            eliminarCita.MdiParent = this;
            eliminarCita.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AlergiasFrm alergias = new AlergiasFrm();
            alergias.Text = "Insertar Alergia";
            alergias.MdiParent = this;
            alergias.btnInsertar.Visible = true;
            alergias.btnCancelar.Visible = true;
            alergias.btnSalir.Visible = true;
            alergias.dataGridAlergias.Visible = true;
            alergias.txtNombre.Visible = true;
            alergias.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuscarAlergia buscarAlergia = new BuscarAlergia();
            buscarAlergia.Text = "Modificar Alergia";
            buscarAlergia.MdiParent = this;
            buscarAlergia.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AlergiasFrm eliminarAlergia = new AlergiasFrm();
            eliminarAlergia.Text = "Eliminar Alergia";
            eliminarAlergia.labelControl2.Text="Buscar Nombre";
            eliminarAlergia.MdiParent = this;
            eliminarAlergia.btnEliminar.Visible = true;
            eliminarAlergia.btnCancelarEliminar.Visible = true;
            eliminarAlergia.btnSalir.Visible = true;
            eliminarAlergia.dataGridAlergiasEliminar.Visible = true;
            eliminarAlergia.txtBuscar.Visible = true;
            eliminarAlergia.Show();
       }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnfermedadesFrm enfermedades = new EnfermedadesFrm();
            enfermedades.Text = "Insertar Enfermedad";
            enfermedades.MdiParent = this;
            enfermedades.btnInsertar.Visible = true;
            enfermedades.btnCancelar.Visible = true;
            enfermedades.btnSalir.Visible = true;
            enfermedades.dataGridEnfermedades.Visible = true;
            enfermedades.txtNombre.Visible = true;
            enfermedades.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuscarEnfermedades buscarEnfermedad = new BuscarEnfermedades();
            buscarEnfermedad.Text = "Modificar Enfermedad";
            buscarEnfermedad.MdiParent = this;
            buscarEnfermedad.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnfermedadesFrm eliminarenfermedad = new EnfermedadesFrm();
            eliminarenfermedad.Text = "Eliminar Enfermedad";
            eliminarenfermedad.labelControl2.Text = "Buscar Nombre";
            eliminarenfermedad.MdiParent = this;
            eliminarenfermedad.btnEliminar.Visible = true;
            eliminarenfermedad.btnCancelarEliminar.Visible = true;
            eliminarenfermedad.btnSalir.Visible = true;
            eliminarenfermedad.dataGridEnfermedadesEliminar.Visible = true;
            eliminarenfermedad.txtBuscar.Visible = true;
            eliminarenfermedad.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MedicamentoFrm medicamentos = new MedicamentoFrm();
            medicamentos.Text = "Insertar Medicamento";
            medicamentos.MdiParent = this;
            medicamentos.btnInsertar.Visible = true;
            medicamentos.btnCancelar.Visible = true;
            medicamentos.btnSalir.Visible = true;
            medicamentos.dataGridMedicamento.Visible = true;
            medicamentos.txtNombre.Visible = true;
            medicamentos.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuscarMedicamento buscarMedicamento = new BuscarMedicamento();
            buscarMedicamento.Text = "Modificar Medicamento";
            buscarMedicamento.MdiParent = this;
            buscarMedicamento.Show();
        }

        private void btnModificarPac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarPacientes buscarMedicamento = new ModificarPacientes();
            buscarMedicamento.Text = "Modificar Paciente";
            buscarMedicamento.btnEliminar.Visible = false;
            buscarMedicamento.dataGridPacientes.Visible = true;
            buscarMedicamento.MdiParent = this;
            buscarMedicamento.Show();
        }

        private void btnEliminarPac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModificarPacientes buscarMedicamento = new ModificarPacientes();
            buscarMedicamento.Text = "Eliminar Paciente";
          
            buscarMedicamento.MdiParent = this;
            buscarMedicamento.dataGridEliminarPaciente.Visible = true;
            buscarMedicamento.Show();
        }

        private void btnSignoVitalInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SignoVital sgv = new SignoVital();
            sgv.Text = "Insertar Signo Vital";
            sgv.MdiParent = this;
            sgv.Show();
        }

        private void btnCitaporFecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           ReporteCitaFecha sgv = new ReporteCitaFecha();
            sgv.Text = "Reportes por Fecha";
            sgv.MdiParent = this;
            sgv.Show();
        }

        private void btnCitavariedad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportesEstado sgv = new ReportesEstado();
            sgv.Text = "Reportes por Estado";
            sgv.MdiParent = this;
            sgv.Show();
        }
    }
}

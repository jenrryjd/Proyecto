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
using Microsoft.VisualBasic;

namespace ProyectoParcial2
{
    public partial class AtencionTratamientoFrm : Form
    {
        private CitaMensajes datosAten;

        public AtencionTratamientoFrm()
        {
            InitializeComponent();
        }

        public AtencionTratamientoFrm(CitaMensajes datosAten)
        {
            InitializeComponent();
            this.datosAten = datosAten;
            lblNcita.Text = datosAten.Id.ToString();

            PersonaTestNegocio obj = new PersonaTestNegocio();
            var nombre = obj.DevolverNombrePaciente(datosAten.CedPac);
            lblCedulaPac.Text = datosAten.CedPac;
            lblNombrePac.Text = nombre.ToString();
            lblEspecialidad.Text = datosAten.Especialidad.Trim();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            MessageBox.Show("Datos Guardados.");
            if (MessageBox.Show("Desea Imprimir Receta?", "Imprimir Receta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("imprimir receta");
                CitasAsignadas volver = new CitasAsignadas(lblEspecialidad.Text);
                this.Hide();
                volver.MdiParent = MenuPrincipal.ActiveForm;
                volver.Show();
            }
        }
        /// <summary>
        /// GUARDA DATOS DE LAS TABLAS: ATENCIONMEDICA,TRATAMIENTO Y RECETA
        /// </summary>
        private void GuardarDatos()
        {
            CitaNegocio actualizaestado = new CitaNegocio();
            actualizaestado.ActualizaEstado(lblNcita.Text, observacionAtencionMedica);

            AtencionTratamientoMensajes datos = new AtencionTratamientoMensajes();
            datos.IdCita = Convert.ToInt32(lblNcita.Text);
            datos.ObsevacionAtencion = observacionAtencionMedica;
            datos.ObservacionTratamiento = ResumenCitaMedica.Text;

            AtencionTratamientoNegocio ingresoAtencion = new AtencionTratamientoNegocio();
            int nAtencioncion = ingresoAtencion.InsertarDatosAtencion(datos);

            datos.IdAtencionMedica = nAtencioncion;

            AtencionTratamientoNegocio ingresoTratamiento = new AtencionTratamientoNegocio();
            ingresoTratamiento.InsertarDatosTratamiento(datos);

            RecetaMensajes receta = new RecetaMensajes();
            foreach (DataGridViewRow row in dataGridReceta.Rows)
            {
                receta.IdTratamiento = Convert.ToInt32(row.Cells["Column1"].Value);
                receta.IdMedicamento = Convert.ToInt32(row.Cells["Column2"].Value);
                receta.NombreMedicamento = Convert.ToString(row.Cells["Column3"].Value);
                receta.Cantidad = Convert.ToInt32(row.Cells["Column4"].Value);
                receta.Indicaciones = Convert.ToString(row.Cells["Column5"].Value);

                RecetaNegocio inserta = new RecetaNegocio();
                inserta.Insertar(receta);
            }
        }

        string observacionAtencionMedica = null;
        private void checkBoxAsiste_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAsiste.Checked)
            {
                observacionAtencionMedica = "ASISTIDO";
                panel6.Enabled = true;
                panel4.Enabled = true;
                panel5.Enabled = true;
                dataGridMedicamentos.Enabled = true;
                ResumenCitaMedica.Enabled = true;
                btnInsertar.Enabled = true;
                btnSalir.Enabled = true;
                checkBoxNoAsiste.Enabled = false;
            }
            else
            {
                observacionAtencionMedica = "";
                panel6.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                dataGridMedicamentos.Enabled = false;
                ResumenCitaMedica.Enabled = false;
                btnInsertar.Enabled = false;
                btnSalir.Enabled = false;
                checkBoxNoAsiste.Enabled = true;
            }
            
        }

        private void checkBoxNoAsiste_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoAsiste.Checked)
            {
                observacionAtencionMedica = "NO ASISTIDO";
                ResumenCitaMedica.Text = "El paciente no asiste a su cita.";
                panel5.Enabled = true;
                btnSalir.Enabled = true;
                btnSalir.Enabled = true;
                checkBoxAsiste.Enabled = false;
            }
            else
            {
                observacionAtencionMedica = "";
                ResumenCitaMedica.Text = "";
                panel5.Enabled = false;
                btnSalir.Enabled = false;
                btnInsertar.Enabled = false;
                checkBoxAsiste.Enabled = true;
            }
        }

        private void AtencionTratamientoFrm_Load(object sender, EventArgs e)
        {
            CargarHMySignosVitales(lblCedulaPac.Text,lblNcita.Text);
            HistoriaMedicaNegocio nAten = new HistoriaMedicaNegocio();
            int nAtencion = nAten.ConsultarNumeroHistoriaMedica();
            lblNumerodeAtencion.Text = (nAtencion + 1).ToString();
            dataGridReceta.AllowUserToAddRows = false;
            dataGridMedicamentos.AllowUserToAddRows = false;
        }

        /// <summary>
        /// CARGAMOS LOS DATOS DE LA BD CON LA HISTORIA MEDICA Y LOS SIGNOS VITALES DEL PACIENTE
        /// QUE YA SE TENIAN EN LA BD.
        /// </summary>
        /// <param name="cedulaPaciente"></param>
        /// <param name="idCita"></param>
        private void CargarHMySignosVitales(string cedulaPaciente, string idCita)
        {
            SignosNegocio signos = new SignosNegocio();
            SignosMensajes signosVitales =new SignosMensajes();

            signosVitales=signos.ConsultarSignos(idCita);

            lblAltura.Text = signosVitales.Altura+" m.".ToString();
            lblPeso.Text = signosVitales.Peso+" kg.".ToString();
            lblPresion.Text = signosVitales.Presion + " mmHg".ToString();
            lblRitmoCardiaco.Text = signosVitales.RitmoCardiaco + " BPM".ToString();

            HistoriaMedicaNegocio historia = new HistoriaMedicaNegocio();
            HistoriaMedicaMensajes historiaMedica = new HistoriaMedicaMensajes();

            historiaMedica = historia.ConsultarHistoriaMedica(cedulaPaciente);

            lblTipoSangre.Text = historiaMedica.TipoSangre.ToString();
            memoAlergias.Text = historiaMedica.Alergias.ToString();
            memoEnfermedades.Text = historiaMedica.Enfermedades.ToString();
        }

        private void txtBuscarMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosBasicos.SoloLetras(e);
            MedicamentoNegocio obj = new MedicamentoNegocio();
            var lista = obj.DevolverListaMedicamentosNombre(txtBuscarMedicamento.Text);
            dataGridMedicamentos.DataSource = lista.Tables[0];
        }

        private void dataGridMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnviaDatosReceta(e);
        }
        /// <summary>
        /// PASA DATOS DEL DATAMEDICAMENTOS AL DATARECETA
        /// </summary>
        /// <param name="e"></param>
        private void EnviaDatosReceta(DataGridViewCellEventArgs e)
        {
            RecetaMensajes dato = new RecetaMensajes();
            try
            {
                string cantidad = Interaction.InputBox("Cantidad de Medicamento", "Ingrese la Cantidad del Medicamento",
                        "Cantidad del Medicamento");
                dato.Cantidad = Convert.ToInt32(cantidad);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese una cantidad correcta de medicamento.");
            }

            dato.Indicaciones = Interaction.InputBox("Uso del Medicamento:", "Indicaciones de Uso",
                        "Indicaciones");
            dato.IdTratamiento = Convert.ToInt32(lblNumerodeAtencion.Text);

            dato.IdMedicamento = (int)dataGridMedicamentos.Rows[e.RowIndex].Cells[0].Value;
            dato.NombreMedicamento = (string)dataGridMedicamentos.Rows[e.RowIndex].Cells[1].Value;

            dataGridReceta.Rows.Add(dato.IdTratamiento, dato.IdMedicamento, dato.NombreMedicamento, dato.Cantidad, dato.Indicaciones);

        }

        private void dataGridReceta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que desea eliminar este medicamento?", "Eliminar Medicamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (e.RowIndex > -1)
                    {
                        dataGridReceta.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la celda Eliminar");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

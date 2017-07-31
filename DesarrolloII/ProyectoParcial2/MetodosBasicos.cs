using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MENSAJES;
using NEGOCIO;

namespace ProyectoParcial2
{
    public class MetodosBasicos
    {

        internal static void CargarTabla(DataGridView tabla)
        {
            AlergiaNegocio datosTablaAlergias = new AlergiaNegocio();
            var listaAlergias = datosTablaAlergias.DevolverListaAlergias().Tables[0];
            tabla.DataSource = listaAlergias;
            
        }

        internal static void CargarTablaEnfermedades(DataGridView tabla)
        {
            EnfermedadNegocio datosTablaEnfermedades = new EnfermedadNegocio();
            var listaEnfermedad = datosTablaEnfermedades.DevolverListaEnfermedad().Tables[0];
            tabla.DataSource = listaEnfermedad;

        }

        internal static void CargarBoxEspecialidad(ComboBoxEdit cmbEspecialidad)
        {
            EspecialidadNegocio agregarbox = new EspecialidadNegocio();
            agregarbox.cargarDatosBoxEspecialidad(cmbEspecialidad);
        }

        internal static void CargarBox(ComboBoxEdit cmbTipo)
        {
            EnfermedadNegocio agregarbox = new EnfermedadNegocio();
            agregarbox.cargarDatosBox(cmbTipo);
        }

        internal static void CargarTablaMedicamentos(DataGridView dataGridMedicamento)
        {
            MedicamentoNegocio datosTablaMedicamentos = new MedicamentoNegocio();
            var listaEnfermedad = datosTablaMedicamentos.DevolverListaMedicamentos().Tables[0];
            dataGridMedicamento.DataSource = listaEnfermedad;
        }

        internal static void CargarBoxAler(ComboBoxEdit cmbTipo)
        {
            AlergiaNegocio agregarbox = new AlergiaNegocio();
            agregarbox.cargarDatosBox(cmbTipo);
        }

        internal static void CargarBoxMedi(ComboBoxEdit cmbTipo)
        {
            MedicamentoNegocio agregarbox = new MedicamentoNegocio();
            agregarbox.cargarDatosBox(cmbTipo);
        }

        internal static void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        internal static void SoloNumerosDecimales(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || (Char.IsPunctuation(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        internal static void SoloNumerosEnteros(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

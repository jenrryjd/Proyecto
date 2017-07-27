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
            PersonaTestNegocio perso = new PersonaTestNegocio();
            var listaPesonas = perso.DevolverListaPaciente().Tables[0];
            tabla.DataSource = listaPesonas;
        }

        internal static void CargarTablaMedico(DataGridView tabla)
        {
            PersonaTestNegocio perso = new PersonaTestNegocio();
            var listaPesonas = perso.DevolverListaMedico().Tables[0];
            tabla.DataSource = listaPesonas;
        }

        internal static void CargarBoxMedi(ComboBoxEdit cmbTipo)
        {
            MedicamentoNegocio agregarbox = new MedicamentoNegocio();
            agregarbox.cargarDatosBox(cmbTipo);
        }

        internal static void CargarTablaPacientes(DataGridView dataGridPacientes)
        {
            throw new NotImplementedException();
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

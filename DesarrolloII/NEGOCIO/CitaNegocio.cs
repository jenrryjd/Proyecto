using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data;

namespace NEGOCIO
{
    public class CitaNegocio
    {

        public static void InsertaCita(CitaMensajes citaIngreso)
        {
            Cita.Insertar(citaIngreso);
        }

        public static void CargarHorarios(TextEdit txtCedDoc, DateTimePicker dateTimeFechaCita, System.Windows.Forms.ComboBox combo)
        {
            Cita.ConsultaHorario(txtCedDoc,dateTimeFechaCita,combo);
        }

        public DataSet DevolverListaCitasCargo(string cargo)
        {
            return Cita.CargarListaDatos(CitasBuscar.DevuelveListaPorcargo(cargo));
        }

        public static void EliminarCita(string id)
        {
            CitaMensajes ms = new CitaMensajes();
            Cita.Eliminar(id);
        }

        public DataSet DevolverListaCitas(string text)
        {
            return Cita.CargarListaDatos(CitasBuscar.DevuelveListaPorNombre(text));
        }

        public static object ActualizarCita(CitaMensajes citaActualizar)
        {
            CitaMensajes ms = new CitaMensajes();
            ms = Cita.Actualizar(citaActualizar);
            return ms;
        }

        public void ActualizaEstado(string id, string observacionAtencionMedica)
        {
            CitaMensajes ms = new CitaMensajes();
            Cita.ActualizarEstado(id, observacionAtencionMedica);
        }

        public static void cancelarCita(string id,string v)
        {
            Cita.ActualizarEstado(id,v);            
        }
    }
}

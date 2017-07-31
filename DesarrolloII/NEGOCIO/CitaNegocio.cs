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

        public static void EliminarCita(string id)
        {
            CitaMensajes ms = new CitaMensajes();
            Cita.Eliminar(id);
        }

        public DataSet DevolverListaCitas(string text)
        {
            return Cita.CargarListaDatos(CitasBuscar.DevuelveListaPorNombre(text));
        }

    }
}

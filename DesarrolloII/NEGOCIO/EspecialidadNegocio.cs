using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;
using DevExpress.XtraEditors;
using System.Data;

namespace NEGOCIO
{
    public class EspecialidadNegocio
    {
        public static object GuardarEspecialidad(EspecialidadMensaje esp)
        {
            EspecialidadMensaje ms = new EspecialidadMensaje();
            ms = EspecialidadDAL.GuardarEspecialidad(esp);
            return ms;
        }

        public void cargarDatosBoxEspecialidad(ComboBoxEdit cmbEspecialidad)
        {
            EspecialidadDAL.CargarEspecialidadBox(cmbEspecialidad);
        }

        public void cargarDatosBoxEspecialidad1(ComboBoxEdit cmbEspecialidad)
        {
            EspecialidadDAL.CargarEspecialidadBox1(cmbEspecialidad);
        }

        public DataSet DevolverListaEspecialidades()
        {
            return EspecialidadDAL.CargarListaDatos(BuscarEspecialidadDAL.DevuelveListaEspecialidad());
        }


        public DataSet DevolverListaEspecialidadesId(string idEspecialidad)
        {
            return EspecialidadDAL.CargarListaDatos(BuscarEspecialidadDAL.DevuelveListaPorIdEspecialidad(idEspecialidad));
        }


        public DataSet DevolverListaEspecialidadesNombre(string nombreEspecialidad)
        {
            return EspecialidadDAL.CargarListaDatos(BuscarEspecialidadDAL.DevuelveListaPorNombreEspecialidad(nombreEspecialidad));
        }

        public static object ActualizarEspecialidad(EspecialidadMensaje enfermedaActualizar)
        {
            EspecialidadMensaje ms = new EspecialidadMensaje();
            ms = EspecialidadDAL.ActualizarEspecialidad(enfermedaActualizar);
            return ms;
        }

        public static object EliminarEspecialidad(EspecialidadMensaje enfermedadEliminar)
        {
            EspecialidadMensaje ms = new EspecialidadMensaje();
            ms = EspecialidadDAL.Eliminar(enfermedadEliminar);
            return ms;
        }

    }
}

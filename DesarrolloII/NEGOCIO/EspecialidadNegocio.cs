using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;
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

        public static object EliminarEspecialidad(EspecialidadMensaje especialidadEliminar)
        {
            EspecialidadMensaje ms = new EspecialidadMensaje();
            ms = EspecialidadDAL.EliminarEspecialidad(especialidadEliminar);
            return ms;
        }



        public static object ActualizarEspecialidad(EspecialidadMensaje especialidadActualizar)
        {
            EspecialidadMensaje ms = new EspecialidadMensaje();
            ms = EspecialidadDAL.ActualizarEspecialidad(especialidadActualizar);
            return ms;
        }

        public DataSet DevolverListaEspecialidad()
        {
            return Alergias.CargarListaDatos(EspecialidadesBuscar.DevuelveListaEspecialidaesCompleta());
        }

        public DataSet DevolverListaEspeEspecificacion(string nombre)
        {
            return Alergias.CargarListaDatos(EspecialidadesBuscar.DevuelveListaEspecialidadNombre(nombre));
        }

        public DataSet DevolverListaEspeCodigo(string codigo)
        {
            return Alergias.CargarListaDatos(EspecialidadesBuscar.DevuelveListaEspecialidadCodigo(codigo));
        }
    }
}

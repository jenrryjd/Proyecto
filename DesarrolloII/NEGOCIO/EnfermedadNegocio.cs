using MENSAJES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DevExpress.XtraEditors;

namespace NEGOCIO
{
    public class EnfermedadNegocio
    {
        public static object InsertarEnfermedad(EnfermedadesMensajes enfermedadIngreso)
        {
            EnfermedadesMensajes ms = new EnfermedadesMensajes();
            ms = Enfermedades.Insertar(enfermedadIngreso);
            return ms;
        }

        public DataSet DevolverListaEnfermedad()
        {
            return Enfermedades.CargarListaDatos(EnfermedadBuscar.DevuelveListaEnfermedadCompleta());
        }

        public DataSet DevolverListaEnfermedadId(string idEnfermedad)
        {
            return Enfermedades.CargarListaDatos(EnfermedadBuscar.DevuelveListaPorId(idEnfermedad));
        }

        public void cargarDatosBox(ComboBoxEdit cmbTipo)
        {
            Enfermedades.CargarTipoBox(cmbTipo);
        }

        public DataSet DevolverListaEnfermedadNombre(string nombreEnfermedad)
        {
            return Enfermedades.CargarListaDatos(EnfermedadBuscar.DevuelveListaPorNombre(nombreEnfermedad));
        }

        public DataSet DevolverListaEnfermedadTipo(string tipoEnfermedad)
        {
            return Enfermedades.CargarListaDatos(EnfermedadBuscar.DevuelveListaPorTipo(tipoEnfermedad));
        }

        public static object ActualizarEnfermedad(EnfermedadesMensajes enfermedaActualizar)
        {
            EnfermedadesMensajes ms = new EnfermedadesMensajes();
            ms = Enfermedades.Actualizar(enfermedaActualizar);
            return ms;
        }

        public static object EliminarEnfermedad(EnfermedadesMensajes enfermedadEliminar)
        {
            EnfermedadesMensajes ms = new EnfermedadesMensajes();
            ms = Enfermedades.Eliminar(enfermedadEliminar);
            return ms;
        }

        public static void InsertarTipoEnfermedad(string tipo)
        {
            EnfermedadesMensajes ms = new EnfermedadesMensajes();
            ms = Enfermedades.InsertarTipo(tipo);
        }

    }
}

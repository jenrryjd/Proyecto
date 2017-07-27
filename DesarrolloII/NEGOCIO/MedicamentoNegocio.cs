using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MENSAJES;
using System.Data;
using DevExpress.XtraEditors;

namespace NEGOCIO
{
    public class MedicamentoNegocio
    {
        public static object InsertarMedicamento(MedicamentosMensaje medicamentoIngreso)
        {
            MedicamentosMensaje ms = new MedicamentosMensaje();
            ms = Medicamentos.Insertar(medicamentoIngreso);
            return ms;
        }

        public DataSet DevolverListaMedicamentos()
        {
            return Medicamentos.CargarListaDatos(MedicamentosBuscar.DevuelveListaMedicamentosCompleta());
        }

        public DataSet DevolverListaMedicamentosId(string idMedicamento)
        {
            return Medicamentos.CargarListaDatos(MedicamentosBuscar.DevuelveListaPorId(idMedicamento));
        }

        public void cargarDatosBox(ComboBoxEdit cmbTipo)
        {
            Medicamentos.CargarTipoBox(cmbTipo);
        }

        public DataSet DevolverListaMedicamentosNombre(string nombreMedicamentos)
        {
            return Medicamentos.CargarListaDatos(MedicamentosBuscar.DevuelveListaPorNombre(nombreMedicamentos));
        }

        public DataSet DevolverListaMedicamentoTipo(string tipoMedicamento)
        {
            return Medicamentos.CargarListaDatos(MedicamentosBuscar.DevuelveListaPorTipo(tipoMedicamento));
        }

        public static object ActualizarMedicamento(MedicamentosMensaje medicamentoActualizar)
        {
            MedicamentosMensaje ms = new MedicamentosMensaje();
            ms = Medicamentos.Actualizar(medicamentoActualizar);
            return ms;
        }

        public static object EliminarMedicamento(MedicamentosMensaje medicamentoEliminar)
        {
            MedicamentosMensaje ms = new MedicamentosMensaje();
            ms = Medicamentos.Eliminar(medicamentoEliminar);
            return ms;
        }

        public static void InsertarTipoMedicamentos(string tipo)
        {
            MedicamentosMensaje ms = new MedicamentosMensaje();
            ms = Medicamentos.InsertarTipo(tipo);
        }
    }
}

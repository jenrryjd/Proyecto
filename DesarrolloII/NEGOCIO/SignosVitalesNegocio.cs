using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MENSAJES;
using System.Data;

namespace NEGOCIO
{
   public  class SignosVitalesNegocio
    {
        public DataSet DevolverListaCita(string idEnfermedad)
        {
            return SigninoVitalDAL.CargarListaDatos(BuscarSignosVitalesDAL.DevuelveListaSignosVitalesPorId(idEnfermedad));
        }

        public static object InsertarSignoVital(SignosVitales medicamentoIngreso)
        {
           SignosVitales ms = new SignosVitales();
            ms =SigninoVitalDAL.Insertar(medicamentoIngreso);
            return ms;
        }


    }
}

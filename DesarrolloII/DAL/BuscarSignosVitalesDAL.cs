using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using MENSAJES;
namespace DAL
{
    public class BuscarSignosVitalesDAL
    {
        public static string DevuelveListaSignosVitales()
        {
            return ("SELECT TOP 1000 [ID_SV]"+
      ",[ID_CITA_F]"+
      ",[ALTURA_SV]"+
      ",[PESO_SV]"+
      ",[PRESION_SV]"+
      ",[RIT_CAR_SV]"+
        "FROM[Clinica].[dbo].[SIGNOVITAL]");

        }

        public static string DevuelveListaSignosVitalesPorId(string NUM)
        {
            return ("SELECT TOP 1000 [ID_CITA]"+
      ",[CED_PAC_F]"+
      ",[CED_DOC_F]"+
      ",[HORA_CITA]"+
      ",[FECHA_CITA]"+
      ",[ESPECIALISTA_CITA]"+
      ",[ESTADO_CITA]"+
        "FROM[Clinica].[dbo].[CITA]"+
        "where  [ID_CITA] like '" + NUM + "%'");
        }


      





    }
}

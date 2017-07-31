using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class BuscarEspecialidadDAL
    {
        public static string DevuelveListaEspecialidad()
        {
            return ("SELECT TOP 100 [ID_ESPECIALIDAD]"+
    "  ,[NOM_ESPECIALIDAD]"+
     "   FROM[Clinica].[dbo].[ESPECIALIDAD]");

        }

        public static string DevuelveListaPorIdEspecialidad(string idAlergia)
        {
            return ("SELECT TOP 100 [ID_ESPECIALIDAD]" +
    "  ,[NOM_ESPECIALIDAD]" +
     "   FROM[Clinica].[dbo].[ESPECIALIDAD] where ID_ESPECIALIDAD like  '" + idAlergia + "%'");
        }

        public static string DevuelveListaPorNombreEspecialidad(string TipoAlergia)
        {
            return ("SELECT TOP 100 [ID_ESPECIALIDAD]" +
    "  ,[NOM_ESPECIALIDAD]" +
     "   FROM[Clinica].[dbo].[ESPECIALIDAD] where NOM_ESPECIALIDAD like  '" + TipoAlergia + "%'");
        }

    }
}

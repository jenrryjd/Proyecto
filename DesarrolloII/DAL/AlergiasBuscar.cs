using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AlergiasBuscar
    {
        public static string DevuelveListaAlergiasCompleta()
        {
            return ("SELECT TOP 1000[ID_ALER],[NOM_ALER],[TIPO_ALER],[DESCRIPCION] FROM[Clinica].[dbo].[ALERGIA]");
        }

        public static string DevuelveListaAlergiasTipo()
        {
            return ("SELECT TOP 1000 [TIPO_ALER]FROM[Clinica].[dbo].[ALERGIA]");
        }

        public static string DevuelveListaPorId(string idAlergia)
        {
            return ("SELECT TOP 100 [ID_ALER],[NOM_ALER],[TIPO_ALER],[DESCRIPCION]  FROM [Clinica].[dbo].[ALERGIA] where ID_ALER like  '"+ idAlergia + "%'");
        }

        public static string DevuelveListaPorTipo(string TipoAlergia)
        {
            return ("SELECT TOP 100 [ID_ALER],[NOM_ALER],[TIPO_ALER],[DESCRIPCION]  FROM [Clinica].[dbo].[ALERGIA] where TIPO_ALER like  '" + TipoAlergia + "%'");
        }

        public static string DevuelveListaPorNombre(string NombreAlergia)
        {
            return ("SELECT TOP 100 [ID_ALER],[NOM_ALER],[TIPO_ALER],[DESCRIPCION]  FROM [Clinica].[dbo].[ALERGIA] where NOM_ALER like  '" + NombreAlergia + "%'");
        }
    }
}

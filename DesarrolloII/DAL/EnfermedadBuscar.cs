using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EnfermedadBuscar
    {
        public static string DevuelveListaEnfermedadCompleta()
        {
            return ("SELECT TOP 1000[ID_ENF],[NOM_ENF],[TIP_ENF],[DES_ENF] FROM[Clinica].[dbo].[ENFERMEDAD]");
        }

        public static string DevuelveListaEnfermedadTipo()
        {
            return ("SELECT TOP 1000 [TIP_ENF]FROM[Clinica].[dbo].[ENFERMEDAD]");
        }

        public static string DevuelveListaPorId(string idEnfermedad)
        {
            return ("SELECT TOP 100 [ID_ENF],[NOM_ENF],[TIP_ENF],[DES_ENF]  FROM [Clinica].[dbo].[ENFERMEDAD] where ID_ENF like  '" + idEnfermedad + "%'");
        }

        public static string DevuelveListaPorTipo(string TipoEnfermedad)
        {
            return ("SELECT TOP 100 [ID_ENF],[NOM_ENF],[TIP_ENF],[DES_ENF]  FROM [Clinica].[dbo].[ENFERMEDAD] where TIP_ENF like  '" + TipoEnfermedad + "%'");
        }

        public static string DevuelveListaPorNombre(string NombreEnfermedad)
        {
            return ("SELECT TOP 100 [ID_ENF],[NOM_ENF],[TIP_ENF],[DES_ENF]  FROM [Clinica].[dbo].[ENFERMEDAD] where NOM_ENF like  '" + NombreEnfermedad + "%'");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicamentosBuscar
    {
        public static string DevuelveListaMedicamentosCompleta()
        {
            return ("SELECT TOP 1000[ID_MED],[NOM_MED],[TIP_MED],[DES_MED] FROM[Clinica].[dbo].[MEDICAMENTOS]");
        }

        public static string DevuelveListaEnfermedadTipo()
        {
            return ("SELECT TOP 1000 [TIP_MED]FROM[Clinica].[dbo].[MEDICAMENTOS]");
        }

        public static string DevuelveListaPorId(string idMedicamentos)
        {
            return ("SELECT TOP 100 [ID_MED],[NOM_MED],[TIP_MED],[DES_MED]  FROM [Clinica].[dbo].[MEDICAMENTOS] where ID_MED like  '" + idMedicamentos + "%'");
        }

        public static string DevuelveListaPorTipo(string TipoMedicamento)
        {
            return ("SELECT TOP 100 [ID_MED],[NOM_MED],[TIP_MED],[DES_MED]  FROM [Clinica].[dbo].[MEDICAMENTOS] where TIP_MED like  '" + TipoMedicamento + "%'");
        }

        public static string DevuelveListaPorNombre(string NombreMedicamento)
        {
            return ("SELECT TOP 100 [ID_MED],[NOM_MED],[TIP_MED],[DES_MED]  FROM [Clinica].[dbo].[MEDICAMENTOS] where NOM_MED like  '" + NombreMedicamento + "%'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicoBuscar
    {
        public static string DevuelveListaMedicosCompleta()
        {
            return ("SELECT TOP 1000 [CED_DOC]"+
    ",[NOM_DOC]"+
     " ,[APE_DOC]"+
     ",[FECH_NAC_DOC]"+
      ",[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
      ",[LICEN_MED]" +
      ",[ESPE_DOC]" +
      "FROM[Clinica].[dbo].[DOCTOR]");
        }



        public static string DevuelveListaPorCedula(string cedula)
        {
            return ("SELECT TOP 1000 [CED_DOC]" +
    ",[NOM_DOC]" +
     " ,[APE_DOC]" +
     ",[FECH_NAC_DOC]" +
      ",[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
      ",[LICEN_MED]" +
      ",[ESPE_DOC]" +
      "FROM[Clinica].[dbo].[DOCTOR] where CED_DOC like  '" + cedula + "%'");
        }

        public static string DevuelveListaPorNombre(string nombre)
        {
            return ("SELECT TOP 1000 [CED_DOC]" +
    ",[NOM_DOC]" +
     " ,[APE_DOC]" +
     ",[FECH_NAC_DOC]" +
      ",[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
      ",[LICEN_MED]" +
      ",[ESPE_DOC]" +
      "FROM[Clinica].[dbo].[DOCTOR] where NOM_DOC like  '" + nombre + "%'");
        }

        public static string DevuelveListaPorApellido(string apellido)
        {
            return ("SELECT TOP 1000 [CED_DOC]" +
    ",[NOM_DOC]" +
     " ,[APE_DOC]" +
     ",[FECH_NAC_DOC]" +
      ",[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
      ",[LICEN_MED]" +
      ",[ESPE_DOC]" +
      "FROM[Clinica].[dbo].[DOCTOR] where APE_DOC like  '" + apellido + "%'");
        }
    }
}

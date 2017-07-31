using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class MedicosBuscarDAL
    {
        public static string DevuelveListaMedicos()
        {
            return ("SELECT TOP 100 [CED_DOC]"+
      ",[NOM_DOC]" +
      ",[APE_DOC]"+
     " ,[FECH_NAC_DOC]"+
     " ,[SEXO_DOC]"+
      ",[EST_CIVIL_DOC]"+
      ",[TEL_DOC]"+
      ",[CEL_DOC]"+
      ",[DIR_DOC]"+
     " ,[LICEN_MED]"+
     " ,[ESPE_DOC]"+
     "   FROM[Clinica].[dbo].[DOCTOR]");
        }

        public static string DevuelveListaCedulaMedicos(string Cedula)
        {
            return ("SELECT TOP 100 [CED_DOC]" +
      ",[NOM_DOC]" +
      ",[APE_DOC]" +
     " ,[FECH_NAC_DOC]" +
     " ,[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
     " ,[LICEN_MED]" +
     " ,[ESPE_DOC]" +
     "   FROM[Clinica].[dbo].[DOCTOR] where CED_DOC like  '%" + Cedula + "%'");
        }

        public static string DevuelveListaNombreMedicos(string Nombre)
        {
            return ("SELECT TOP 100 [CED_DOC]" +
      ",[NOM_DOC]" +
      ",[APE_DOC]" +
     " ,[FECH_NAC_DOC]" +
     " ,[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
     " ,[LICEN_MED]" +
     " ,[ESPE_DOC]" +
     "   FROM[Clinica].[dbo].[DOCTOR] where NOM_DOC like  '%" + Nombre + "%'");
        }

        public static string DevuelveListaApellidoMedicos(string Apellido)
        {
            return ("SELECT TOP 100 [CED_DOC]" +
      ",[NOM_DOC]" +
      ",[APE_DOC]" +
     " ,[FECH_NAC_DOC]" +
     " ,[SEXO_DOC]" +
      ",[EST_CIVIL_DOC]" +
      ",[TEL_DOC]" +
      ",[CEL_DOC]" +
      ",[DIR_DOC]" +
     " ,[LICEN_MED]" +
     " ,[ESPE_DOC]" +
     "   FROM[Clinica].[dbo].[DOCTOR] where APE_DOC like  '%" + Apellido + "%'");
        }
    }
}

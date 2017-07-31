using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class PacientesBuscarDAL
    {
        public static string DevuelveListaPacientes()
        {
            return ("SELECT TOP 1000 [CED_PAC]"+
     " ,[NOM_PAC]"+
     " ,[APE_PAC]" +
      ",[TEL_PAC]" +
      ",[CEL_PAC]" +
      ",[DIR_PAC]" +
      ",[FECH_PAC]" +
      ",[GENERO_PAC]" +
       " FROM[Clinica].[dbo].[PACIENTE]");
        }

        public static string DevuelveListaCedulaPacientes(string Cedula)
        {
            return ("SELECT TOP 1000 [CED_PAC]" +
     " ,[NOM_PAC]" +
     " ,[APE_PAC]" +
      ",[TEL_PAC]" +
      ",[CEL_PAC]" +
      ",[DIR_PAC]" +
      ",[FECH_PAC]" +
      ",[GENERO_PAC]" +
       " FROM[Clinica].[dbo].[PACIENTE] where CED_PAC like  '" + Cedula + "%'");
        }

        public static string DevuelveListaNombrePacientes(string Nombre)
        {
            return ("SELECT TOP 1000 [CED_PAC]" +
     " ,[NOM_PAC]" +
     " ,[APE_PAC]" +
      ",[TEL_PAC]" +
      ",[CEL_PAC]" +
      ",[DIR_PAC]" +
      ",[FECH_PAC]" +
      ",[GENERO_PAC]" +
       " FROM[Clinica].[dbo].[PACIENTE] where NOM_PAC like  '" + Nombre + "%'");
        }

        public static string DevuelveListaApellidoPacientes(string Apellido)
        {
            return ("SELECT TOP 1000 [CED_PAC]" +
     " ,[NOM_PAC]" +
     " ,[APE_PAC]" +
      ",[TEL_PAC]" +
      ",[CEL_PAC]" +
      ",[DIR_PAC]" +
      ",[FECH_PAC]" +
      ",[GENERO_PAC]" +
       " FROM[Clinica].[dbo].[PACIENTE] where APE_PAC like  '" + Apellido + "%'");
        }
    }
}

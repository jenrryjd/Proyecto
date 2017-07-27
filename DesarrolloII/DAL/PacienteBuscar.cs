using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class PacienteBuscar
    {
        public static string DevuelveListaPacientesCompleta()
        {
            return ("SELECT TOP 1000 [CED_PAC],[NOM_PAC],[APE_PAC],[TEL_PAC],[CEL_PAC],[DIR_PAC]FROM[Clinica].[dbo].[PACIENTE]");
        }

       

        public static string DevuelveListaPorCedula(string cedula)
        {
            return ("SELECT TOP 1000 [CED_PAC],[NOM_PAC],[APE_PAC],[TEL_PAC],[CEL_PAC],[DIR_PAC]FROM[Clinica].[dbo].[PACIENTE] where CED_PAC like  '" + cedula + "%'");
        }

        public static string DevuelveListaPorNombre(string nombre)
        {
            return ("SELECT TOP 100 [CED_PAC],[NOM_PAC],[APE_PAC],[TEL_PAC],[CEL_PAC],[DIR_PAC]FROM[Clinica].[dbo].[PACIENTE] where NOM_PAC like  '" + nombre + "%'");
        }

        public static string DevuelveListaPorApellido(string apellido)
        {
            return ("SELECT TOP 1000 [CED_PAC],[NOM_PAC],[APE_PAC],[TEL_PAC],[CEL_PAC],[DIR_PAC]FROM[Clinica].[dbo].[PACIENTE] where APE_PAC like  '" + apellido + "%'");
        }
    }
}

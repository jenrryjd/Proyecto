using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EspecialidadesBuscar
    {
        public static string DevuelveListaEspecialidaesCompleta()
        {
            return ("SELECT TOP 1000 [ID_ESPECIALIDAD]"+
     " ,[NOM_ESPECIALIDAD]"+
      "  FROM[Clinica].[dbo].[ESPECIALIDAD]");
        }



        public static string DevuelveListaEspecialidadCodigo(string codigo)
        {
            return ("SELECT TOP 1000 [ID_ESPECIALIDAD]" +
     " ,[NOM_ESPECIALIDAD]" +
      "  FROM[Clinica].[dbo].[ESPECIALIDAD] where ID_ESPECIALIDAD like  '%" + codigo + "%'");
        }

        public static string DevuelveListaEspecialidadNombre(string nombre)
        {
            return ("SELECT TOP 1000 [ID_ESPECIALIDAD]" +
     " ,[NOM_ESPECIALIDAD]" +
      "  FROM[Clinica].[dbo].[ESPECIALIDAD] where  NOM_ESPECIALIDAD like'%" + nombre + "%'");
        }
    }
}

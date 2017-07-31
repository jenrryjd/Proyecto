using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CitasBuscar
    {
        public static string DevuelveListaPorNombre(string Nombre)
        {
            return "SELECT * FROM[dbo].[CITA] WHERE CED_PAC_F = (SELECT[CED_PAC] FROM[dbo].[PACIENTE] WHERE[NOM_PAC] LIKE '" + Nombre + "%');";
        }

    }
}

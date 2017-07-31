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
            return "SELECT * FROM[dbo].[CITA] WHERE ESTADO_CITA='EN ESPERA' AND CED_PAC_F = (SELECT[CED_PAC] FROM[dbo].[PACIENTE] WHERE[NOM_PAC] LIKE '%" + Nombre+"%')";
        }

        public static string DevuelveListaPorcargo(string cargo)
        {
            return "SELECT * FROM[dbo].[CITA] WHERE ESTADO_CITA='EN ESPERA' AND ESPECIALISTA_CITA='"+cargo+"'";
        }
    }
}

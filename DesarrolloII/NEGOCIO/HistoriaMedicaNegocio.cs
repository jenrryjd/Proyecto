using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;

namespace NEGOCIO
{
    public class HistoriaMedicaNegocio
    {
        public HistoriaMedicaMensajes ConsultarHistoriaMedica(string cedulaPaciente)
        {
            HistoriaMedicaMensajes datos = new HistoriaMedicaMensajes();
            datos = HistoriaMedicaDAL.ConsultarHistoriaMedica(cedulaPaciente);
            return datos;
        }

        public int ConsultarNumeroHistoriaMedica()
        {
            int N = HistoriaMedicaDAL.ConsultaNumeroHistoria();
            return N;
        }
    }
}

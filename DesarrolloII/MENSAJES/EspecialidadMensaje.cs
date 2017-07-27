using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
   public class EspecialidadMensaje
    {
        public string CodigoEsp { get; set; }
        public string NomEsp { get; set; }

        public EspecialidadMensaje()
        {

        }

        public EspecialidadMensaje(string codigoep,string nomesp)
        {
            this.CodigoEsp = codigoep;
            this.NomEsp = nomesp;
        }
    }
}

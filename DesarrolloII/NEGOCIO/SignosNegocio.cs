using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MENSAJES;

namespace NEGOCIO
{
    public class SignosNegocio
    {
        public SignosMensajes ConsultarSignos(string idCita)
        {
            SignosMensajes datos = new SignosMensajes();
            datos = SignosDal.ConsultarSignos(idCita);
            return datos;
        }
    }
}

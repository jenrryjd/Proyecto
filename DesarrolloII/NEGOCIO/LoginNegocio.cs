using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;

namespace NEGOCIO
{
    public class LoginNegocio
    {
        public static LoginMensajes VerificarDatos(LoginMensajes credenciales)
        {
            LoginMensajes ms = new LoginMensajes();
            ms = LoginDAL.Verificar(credenciales);
            return ms;
        }
    }
}

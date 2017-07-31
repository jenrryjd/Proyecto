using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;

namespace NEGOCIO
{
    public class AtencionTratamientoNegocio
    {
        public int InsertarDatosAtencion(AtencionTratamientoMensajes datos)
        {
            AtencionTratamientoDAL ingreso =new AtencionTratamientoDAL();
            int valor=ingreso.AgregarAtencion(datos);
            return valor;
        }

        public void InsertarDatosTratamiento(AtencionTratamientoMensajes datos)
        {
            AtencionTratamientoDAL ingreso = new AtencionTratamientoDAL();
            ingreso.AgregarTratamiento(datos);
        }
    }
}

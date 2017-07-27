using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
   public class PacienteMensaje
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
       public string Celular { get; set; }
        public string Direccion { get; set; }
        public PacienteMensaje()
        {

        }
        public PacienteMensaje(string cedula, string nombre, string apellido, string telefono, string celular, string direccion)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }
    }
}

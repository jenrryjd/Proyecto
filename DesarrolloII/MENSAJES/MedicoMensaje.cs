using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
   public class MedicoMensaje
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public string Genero { get; set; }
        public string EstCivi { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }
        public string LicenMed { get; set; }
        public string Especialidad { get; set; }

        public MedicoMensaje()
        {

        }

        public MedicoMensaje(string cedula, string nombre, string apellido, DateTime fecha, string genero, string estdociv, int telefono, int celular, string direccion, string licencia, string especialidad)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha = fecha;
            this.Genero = genero;
            this.EstCivi = estdociv;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Direccion = direccion;
            this.LicenMed = LicenMed;
            this.Especialidad = especialidad;

        }
    }
}

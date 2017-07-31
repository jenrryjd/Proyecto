using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class CitaMensajes
    {
        public int Id { get; set; }
        public string CedPac { get; set; }
        public string CedDoc { get; set; }
        public string Hora { get; set; }
        public string FechaCita { get; set; }
        public string Especialidad { get; set; }
        public string Estado { get; set; }

        public CitaMensajes()
        {

        }

        public CitaMensajes(int id, string cedPac,string cedDoc, string hora, string fechaCita,string especialista,string estado)
        {
            this.Id = id;
            this.CedPac = cedPac;
            this.CedDoc = cedDoc;
            this.Hora = hora;
            this.FechaCita = fechaCita;
            this.Especialidad = especialista;
            this.Estado = estado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class AtencionTratamientoMensajes
    {
        public int IdAtencionMedica { get; set; }
        public int IdCita { get; set; }
        public string ObsevacionAtencion { get; set; }
        public int IdTratamiento { get; set; }
        public string ObservacionTratamiento { get; set; }

        public AtencionTratamientoMensajes()
        {

        }

        public AtencionTratamientoMensajes(int idaten,int idcita,string observaatenc,int idtratamiento,string obsertra)
        {
            this.IdAtencionMedica = idaten;
            this.IdCita = idcita;
            this.ObsevacionAtencion = observaatenc;
            this.IdTratamiento = idtratamiento;
            this.ObservacionTratamiento = obsertra;
        }
    }
}

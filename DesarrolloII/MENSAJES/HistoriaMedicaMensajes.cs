using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class HistoriaMedicaMensajes
    {
        public int Id { get; set; }
        public string CedPaciente { get; set; }
        public string TipoSangre { get; set; }
        public string Alergias { get; set; }
        public string Enfermedades { get; set; }

        public HistoriaMedicaMensajes()
        {

        }

        public HistoriaMedicaMensajes(int id,string cedpaciente,string tipodesangre,string alergias,string enfermedades)
        {
            this.Id = id;
            this.CedPaciente = cedpaciente;
            this.TipoSangre = tipodesangre;
            this.Alergias = alergias;
            this.Enfermedades = enfermedades;
        }
    }
}

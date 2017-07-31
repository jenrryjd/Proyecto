using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class RecetaMensajes
    {
        public int IdTratamiento { get; set; }
        public int IdMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public int Cantidad { get; set; }
        public string Indicaciones { get; set; }

        public RecetaMensajes()
        {

        }

        public RecetaMensajes(int idtratamiento,int idmedicamento,string nombremedicamento,int cantidad,string indicaciones)
        {
            this.IdTratamiento = idtratamiento;
            this.IdMedicamento = idmedicamento;
            this.NombreMedicamento = nombremedicamento;
            this.Cantidad = cantidad;
            this.Indicaciones = indicaciones;
        }   
    }
}

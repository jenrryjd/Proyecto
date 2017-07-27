using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class EnfermedadesMensajes
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public EnfermedadesMensajes()
        {

        }

        public EnfermedadesMensajes(int id, string nombre, string tipo, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Descripcion = descripcion;
        }

    }
}

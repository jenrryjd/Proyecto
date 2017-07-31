using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;

namespace NEGOCIO
{
    public class RecetaNegocio
    {
        public void Insertar(RecetaMensajes receta)
        {
            RecetaDAL InsertaReceta = new RecetaDAL();
            InsertaReceta.Insertar(receta);
        }
    }
}

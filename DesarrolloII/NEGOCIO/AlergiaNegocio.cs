using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;
using System.Data;

namespace NEGOCIO
{
    public class AlergiaNegocio
    {
        public static object InsertarAlergia(AlergiaMensajes alergiaIngreso)
        {
            AlergiaMensajes ms = new AlergiaMensajes();
            ms = Alergias.Insertar(alergiaIngreso);
            return ms;
        }

        public DataSet DevolverListaAlergias()
        {
            return Alergias.CargarListaDatos(AlergiasBuscar.DevuelveListaAlergiasCompleta());
        }

        public DataSet DevolverListaAlergiaId(string idAlergia)
        {
            return Alergias.CargarListaDatos(AlergiasBuscar.DevuelveListaPorId(idAlergia));
        }

        public DataSet DevolverListaAlergiaNombre(string nombreAlergia)
        {
            return Alergias.CargarListaDatos(AlergiasBuscar.DevuelveListaPorNombre(nombreAlergia));
        }

        public DataSet DevolverListaAlergiaTipo(string tipoAlergia)
        {
            return Alergias.CargarListaDatos(AlergiasBuscar.DevuelveListaPorTipo(tipoAlergia));
        }

        public static object ActualizarAlergia(AlergiaMensajes alergiaActualizar)
        {
            AlergiaMensajes ms = new AlergiaMensajes();
            ms = Alergias.Actualizar(alergiaActualizar);
            return ms;
        }
    }
    }


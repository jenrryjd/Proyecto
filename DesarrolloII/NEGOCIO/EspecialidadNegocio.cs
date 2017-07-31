using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;
using DevExpress.XtraEditors;

namespace NEGOCIO
{
    public class EspecialidadNegocio
    {
        public static object GuardarEspecialidad(EspecialidadMensaje esp)
        {
            EspecialidadMensaje ms = new EspecialidadMensaje();
            ms = EspecialidadDAL.GuardarEspecialidad(esp);
            return ms;
        }

        public void cargarDatosBoxEspecialidad(ComboBoxEdit cmbEspecialidad)
        {
            EspecialidadDAL.CargarEspecialidadBox(cmbEspecialidad);
        }
    }
}

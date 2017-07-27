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
    public class PersonaTestNegocio
    {
        public static object GuardarMedicoMensaje(MedicoMensaje medico)
        {
            MedicoMensaje ms = new MedicoMensaje();
            ms = PersonaTestDAL.GuardarMedico(medico);
            return ms;
        }

        public static object GuardarPacienteMensaje(PacienteMensaje paciente)
        {
            PacienteMensaje md = new PacienteMensaje();
            md = PersonaTestDAL.GuardarPac(paciente);
            return md;
        }

        public static object ActualizarPaciente(PacienteMensaje pacienteActualizar)
        {
            PacienteMensaje ms = new PacienteMensaje();
            ms = PersonaTestDAL.ActualizarPaciente(pacienteActualizar);
            return ms;
        }

        public static object EliminarrPaciente(PacienteMensaje pacienteEliminar)
        {
            PacienteMensaje ms = new PacienteMensaje();
            ms = PersonaTestDAL.Eliminar(pacienteEliminar);
            return ms;
        }

   

        public static object ActualizarMedico(MedicoMensaje medicoActualizar)
        {
            MedicoMensaje ms = new MedicoMensaje();
            ms = PersonaTestDAL.ActualizarMedico(medicoActualizar);
            return ms;
        }

        public static object EliminarMedico(MedicoMensaje medicoEliminar)
        {
            MedicoMensaje ms = new MedicoMensaje();
            ms = PersonaTestDAL.EliminarMedico(medicoEliminar);
            return ms;
        }

        public DataSet DevolverListaMedico()
        {
            return Alergias.CargarListaDatos(MedicoBuscar.DevuelveListaMedicosCompleta());
        }

        public DataSet DevolverListaCedulaMed(string cedula)
        {
            return Alergias.CargarListaDatos(MedicoBuscar.DevuelveListaPorCedula(cedula));
        }

        public DataSet DevolverListaMedNombre(string nombre)
        {
            return Alergias.CargarListaDatos(MedicoBuscar.DevuelveListaPorNombre(nombre));
        }

        public DataSet DevolverListaMedApellido(string apellido)
        {
            return Alergias.CargarListaDatos(MedicoBuscar.DevuelveListaPorApellido(apellido));
        }







        public DataSet DevolverListaPaciente()
        {
            return Alergias.CargarListaDatos(PacienteBuscar.DevuelveListaPacientesCompleta());
        }

        public DataSet DevolverListaCedula(string cedula)
        {
            return Alergias.CargarListaDatos(PacienteBuscar.DevuelveListaPorCedula(cedula));
        }

        public DataSet DevolverListaPacienteNombre(string nombre)
        {
            return Alergias.CargarListaDatos(PacienteBuscar.DevuelveListaPorNombre(nombre));
        }

        public DataSet DevolverListaPacienteApellido(string apellido)
        {
            return Alergias.CargarListaDatos(PacienteBuscar.DevuelveListaPorApellido(apellido));
        }

     
    }
}

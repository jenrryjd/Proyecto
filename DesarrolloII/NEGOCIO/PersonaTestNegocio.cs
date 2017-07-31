using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using DAL;
using DevExpress.XtraEditors;
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

     

        public object DevolverNombrePaciente(string text)
        {
            string ms = PersonaTestDAL.ConsultaNombre(text);
            return ms;
        }

        public void CargarDoctores(string especialidad, TextEdit txtCedDoc, TextEdit txtNomDoc)
        {
            PersonaTestDAL.CargaDoctores(especialidad, txtCedDoc, txtNomDoc);
        }

        public DataSet DevolverListaMedicos()
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(MedicosBuscarDAL.DevuelveListaMedicos());
        }
        public DataSet DevolverListaMedicosCedula(string idMedico)
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(MedicosBuscarDAL.DevuelveListaCedulaMedicos(idMedico));
        }
        public DataSet DevolverListaMedicosNombre(string NombreMedico)
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(MedicosBuscarDAL.DevuelveListaNombreMedicos(NombreMedico));
        }
        public DataSet DevolverListaMedicosApellido(string ApellidoMedico)
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(MedicosBuscarDAL.DevuelveListaApellidoMedicos(ApellidoMedico));
        }


        public DataSet DevolverListaPacientes()
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(PacientesBuscarDAL.DevuelveListaPacientes());
        }

        public DataSet DevolverListaPacientesCedula(string idPaciente)
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(PacientesBuscarDAL.DevuelveListaCedulaPacientes(idPaciente));
        }

        public static object GuardarPacienteMensaje(PacienteMensaje paciente)
        {
            PacienteMensaje md = new PacienteMensaje();
            md = PersonaTestDAL.GuardarPac(paciente);
            return md;
        }


        public static object ModificarPaciente(PacienteMensaje actualizarPaciente)
        {
          
            PacienteMensaje ms = new PacienteMensaje();
            ms = PersonaTestDAL.ActualizarPaciente(actualizarPaciente);

            return ms;
    }
        public static object ModificarMedico(MedicoMensaje actualizarMedico)
        {

            MedicoMensaje ms = new MedicoMensaje();
            ms = PersonaTestDAL.ActualizarMedico(actualizarMedico);

            return ms;
        }

        public DataSet DevolverListaPacienteNombre(string NombrePaciente)
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(PacientesBuscarDAL.DevuelveListaNombrePacientes(NombrePaciente));
        }

        public DataSet DevolverListaPacienteApellido(string ApellidoPaciente)
        {
            return PersonaTestDAL.CargarListaDatosMedicosPacientes(PacientesBuscarDAL.DevuelveListaApellidoPacientes(ApellidoPaciente));
        }

        public static object EliminarPaciente(PacienteMensaje pacienteEliminar)
        {
            PacienteMensaje ms = new PacienteMensaje();
            ms = PersonaTestDAL.EliminarPac(pacienteEliminar);
            return ms;
        }

        public static object EliminarMedico(MedicoMensaje medicoEliminar)
        {
            MedicoMensaje ms = new MedicoMensaje();
            ms = PersonaTestDAL.EliminarMed(medicoEliminar);
            return ms;
        }

    }
}

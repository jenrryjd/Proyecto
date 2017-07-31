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

        public object DevolverNombrePaciente(string text)
        {
            string ms = PersonaTestDAL.ConsultaNombre(text);
            return ms;
        }

        public void CargarDoctores(string especialidad, TextEdit txtCedDoc, TextEdit txtNomDoc)
        {
            PersonaTestDAL.CargaDoctores(especialidad, txtCedDoc, txtNomDoc);
        }
    }
}

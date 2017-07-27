using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using System.Transactions;
using System.Data.SqlClient;
namespace DAL
{
   public class PersonaTestDAL
    {
        public static MedicoMensaje GuardarMedico(MedicoMensaje personaTestaGuardar)
        {
            
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[DOCTOR] ([CED_DOC],[NOM_DOC],[APE_DOC],[FECH_NAC_DOC],[SEXO_DOC],[EST_CIVIL_DOC],[TEL_DOC],[CEL_DOC],[DIR_DOC],[LICEN_MED],[ESPE_DOC])" +
                        " VALUES (@cedula,@nombre, @apellido, @fechnac, @genero,@estciv,@tele,@celu,@dir,@licen,@espe); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);

                    cmd.Parameters.AddWithValue("@cedula", personaTestaGuardar.Cedula);
                    cmd.Parameters.AddWithValue("@nombre", personaTestaGuardar.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", personaTestaGuardar.Apellido);
                    cmd.Parameters.AddWithValue("@fechnac", personaTestaGuardar.Fecha);
                    cmd.Parameters.AddWithValue("@genero", personaTestaGuardar.Genero);
                    cmd.Parameters.AddWithValue("@estciv", personaTestaGuardar.EstCivi);
                    cmd.Parameters.AddWithValue("@tele", personaTestaGuardar.Telefono);
                    cmd.Parameters.AddWithValue("@celu", personaTestaGuardar.Celular);
                    cmd.Parameters.AddWithValue("@dir", personaTestaGuardar.Direccion);
                    cmd.Parameters.AddWithValue("@licen", personaTestaGuardar.LicenMed);
                    cmd.Parameters.AddWithValue("@espe", personaTestaGuardar.Especialidad);
                    //var IdPersonaTest = cmd.ExecuteScalar();
                    //personaTestaGuardar.Cedula = Convert.ToString(IdPersonaTest);

                    connection.Close();
                    scope.Complete();
                    return personaTestaGuardar;
                }
            }
        }

        public static MedicoMensaje ActualizarMedico(MedicoMensaje medicoActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[DOCTOR] SET "+
                        "[NOM_DOC] = @nombre,"+
                        "[APE_DOC]=@apellido,"+
                        "[FECH_NAC]=@fec"+
                        "[SEXO_DOC]=@genero,"+
                        "[EST_CIVIL_DOC]=@estci,"+
                        "[TEL_DOC]=@tel,"+
                        "[CEL_DOC]=@celdoc,"+
                        "[DIR_DOC]=@dirdoc,"+
                        "[LICEN_MED]=@licenmed,"+
                        "[ESPE_DOC]=@espdoc "+
                        "WHERE [CED_DOC]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", medicoActualizar.Cedula);
                    cmd.Parameters.AddWithValue("@nombre", medicoActualizar.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", medicoActualizar.Apellido);
                    cmd.Parameters.AddWithValue("@fec", medicoActualizar.Fecha);
                    cmd.Parameters.AddWithValue("@genero", medicoActualizar.Genero);
                    cmd.Parameters.AddWithValue("@estci", medicoActualizar.EstCivi);
                    cmd.Parameters.AddWithValue("@tel", medicoActualizar.Telefono);
                    cmd.Parameters.AddWithValue("@celdoc", medicoActualizar.Celular);
                    cmd.Parameters.AddWithValue("@dirdoc", medicoActualizar.Direccion);
                    cmd.Parameters.AddWithValue("@licenmed", medicoActualizar.LicenMed);
                    cmd.Parameters.AddWithValue("@espdoc", medicoActualizar.Especialidad);
                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return medicoActualizar;
                }
            }
        }

        public static MedicoMensaje EliminarMedico(MedicoMensaje medicoEliminar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[DOCTOR] WHERE [CED_DOC]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", medicoEliminar.Cedula);




                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return medicoEliminar;
                }
            }
        }


        public static PacienteMensaje GuardarPac(PacienteMensaje pace)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[PACIENTE] ([CED_PAC],[NOM_PAC],[APE_PAC],[TEL_PAC],[CEL_PAC],[DIR_PAC]) " +
                       " VALUES (@cedula,@nombre, @apellido,@tele,@celu,@dir); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula", pace.Cedula);
                    cmd.Parameters.AddWithValue("@nombre", pace.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", pace.Apellido);
                    cmd.Parameters.AddWithValue("@tele", pace.Telefono);
                    cmd.Parameters.AddWithValue("@celu", pace.Celular);
                    cmd.Parameters.AddWithValue("@dir", pace.Direccion);
                    cmd.ExecuteScalar();
                   

                    connection.Close();
                    scope.Complete();
                    return pace;
                }
            }
        }

        public static PacienteMensaje ActualizarPaciente(PacienteMensaje pacienteActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[Paciente] SET [NOM_PAC] = @nombre,[APE_PAC]=@tipo,[TEL_PAC]=@descripcion,[CEL_PAC]=@celular,[DIR_PAC]=@direccion WHERE [CED_PAC]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", pacienteActualizar.Cedula);
                    cmd.Parameters.AddWithValue("@nombre", pacienteActualizar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo",    pacienteActualizar.Apellido);
                    cmd.Parameters.AddWithValue("@descripcion", pacienteActualizar.Telefono);
                    cmd.Parameters.AddWithValue("@celular", pacienteActualizar.Celular);
                    cmd.Parameters.AddWithValue("@direccion", pacienteActualizar.Direccion);



                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return pacienteActualizar;
                }
            }
        }

        public static PacienteMensaje Eliminar(PacienteMensaje pacienteEliminar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[Paciente] WHERE [CED_PAC]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", pacienteEliminar.Cedula);
                    



                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return pacienteEliminar;
                }
            }
        }


    }
}

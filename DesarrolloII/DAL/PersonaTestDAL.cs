using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using System.Transactions;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
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

        public static MedicoMensaje ActualizarMedico(MedicoMensaje personaTestaGuardar)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[DOCTOR] " +
                        "SET [NOM_DOC] = @nombre," +
                       " [APE_DOC]=@apellido," +
                        "[FEC_NAC_DOC]=@fechnac," +
                         "[EST_CIVIL_DOC]=@estciv," +
                        "[TEL_PAC]=@tele," +
                        "[CEL_PAC]=@celu," +
                        "[DIR_PAC]=@dir," +
                         "[LIC_MED]=@licen," +
                          "[ESPE_DOC]=@espe," +

                        "[GENERO_PAC]=@genero," +
                        "WHERE [CED_MED]=@cedula; ";
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

        public static PacienteMensaje ActualizarPaciente(PacienteMensaje actualizarPaci)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[PACIENTE] " +
                        "SET [NOM_PAC] = @nombre," +
                       " [APE_PAC]=@apellido," +
                        "[TEL_PAC]=@tele," +
                        "[CEL_PAC]=@celu," +
                        "[DIR_PAC]=@dir," +
                        "[FEC_PAC]=@fechnac," +
                        "[GENERO_PAC]=@genero," +
                        "WHERE [ID_ALER]=@cedula; ";

                     SqlCommand cmd = new SqlCommand(queryString, connection);

                    cmd.Parameters.AddWithValue("@cedula", actualizarPaci.Cedula);
                    cmd.Parameters.AddWithValue("@nombre", actualizarPaci.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", actualizarPaci.Apellido);
                    cmd.Parameters.AddWithValue("@fechnac", actualizarPaci.Fecha);
                    cmd.Parameters.AddWithValue("@genero", actualizarPaci.Genero);
                    
                    cmd.Parameters.AddWithValue("@tele", actualizarPaci.Telefono);
                    cmd.Parameters.AddWithValue("@celu", actualizarPaci.Celular);
                    cmd.Parameters.AddWithValue("@dir", actualizarPaci.Direccion);
                    
                    //var IdPersonaTest = cmd.ExecuteScalar();
                    //personaTestaGuardar.Cedula = Convert.ToString(IdPersonaTest);

                    connection.Close();
                    scope.Complete();
                    return actualizarPaci;
                }
            }

        }


        public static void CargaDoctores(string especialidad, TextEdit txtCedDoc, TextEdit txtNomDoc)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT TOP 1000 [CED_DOC],[NOM_DOC]FROM [Clinica].[dbo].[DOCTOR] WHERE [ESPE_DOC]=@espe;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@espe", especialidad);
                    var dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        txtNomDoc.Text=(dr["NOM_DOC"].ToString());
                        txtCedDoc.Text = (dr["CED_DOC"].ToString());
                    }
                    dr.Close();
                    connection.Close();
                    scope.Complete();
                }
            }
        }

      

        public static string ConsultaNombre(string text)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [NOM_PAC] FROM [dbo].[PACIENTE] WHERE [CED_PAC]=@cedula;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula",text);

                    var NombrePaciente = cmd.ExecuteScalar();

                    string nombre;
                    if (NombrePaciente==null)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = NombrePaciente.ToString();
                    }

                    connection.Close();
                    scope.Complete();
                    return nombre;
                }
            }
        }

        public static PacienteMensaje GuardarPac(PacienteMensaje pace)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    try { 
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[PACIENTE] ([CED_PAC],[NOM_PAC],[APE_PAC],[TEL_PAC],[CEL_PAC],[DIR_PAC],[FECH_PAC],[GENERO_PAC]) " +
                       " VALUES (@cedula,@nombre, @apellido,@tele,@celu,@dir,@fech,@genero); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula", pace.Cedula);
                    cmd.Parameters.AddWithValue("@nombre", pace.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", pace.Apellido);
                    cmd.Parameters.AddWithValue("@tele", pace.Telefono);
                    cmd.Parameters.AddWithValue("@celu", pace.Celular);
                    cmd.Parameters.AddWithValue("@dir", pace.Direccion);
                    cmd.Parameters.AddWithValue("@fech", pace.Fecha);
                    cmd.Parameters.AddWithValue("@genero", pace.Genero);

                    cmd.ExecuteScalar();


                    connection.Close();
                    scope.Complete();

                        MessageBox.Show("Se inserto correctamente ","Informe");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Operacion no completada correctamente ", "Informe");
                    }
                    return pace;
                }
            }
        }
        public static DataSet CargarListaDatosMedicosPacientes(string command)
        {
            using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
            {
                connection.Open();
                string queryString = command;
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }

        public static MedicoMensaje EliminarMed(MedicoMensaje medicoEliminar)
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

        public static PacienteMensaje EliminarPac(PacienteMensaje pacienteEliminar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[PACIENTE] WHERE [CED_PAC]=@id;";
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

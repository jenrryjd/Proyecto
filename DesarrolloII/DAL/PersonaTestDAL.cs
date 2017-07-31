using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using System.Transactions;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

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
            try
            {
                           
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [NOM_PAC],[APE_PAC] FROM [dbo].[PACIENTE] WHERE [CED_PAC]=@cedula;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula",text);

                        var dr = cmd.ExecuteReader();
                        string nombre=null, apellido=null, NombrePaciente=null;
                        if (dr.Read())
                        {
                            nombre = (dr["NOM_PAC"].ToString().Trim());
                            apellido= (dr["APE_PAC"].ToString());
                        }

                        NombrePaciente = nombre+" "+apellido;
                        dr.Close();                        
                            
                    if (NombrePaciente==" ")
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
            catch (Exception)
            {

                XtraMessageBox.Show("Error al Consutar nombre del paciente.");
                return "";
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


    }
}

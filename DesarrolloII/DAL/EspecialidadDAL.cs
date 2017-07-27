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
    public class EspecialidadDAL
    {

        public static EspecialidadMensaje GuardarEspecialidad(EspecialidadMensaje espec)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[ESPECIALIDAD] ([ID_ESPECIALIDAD],[NOM_ESPECIALIDAD]) " +
                       " VALUES (@cedula,@nombre); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedula", espec.CodigoEsp);
                    cmd.Parameters.AddWithValue("@nombre",espec.NomEsp);
                    cmd.ExecuteScalar();
                    


                    connection.Close();
                    scope.Complete();
                    return espec;
                }
            }
        }

        public static EspecialidadMensaje ActualizarEspecialidad(EspecialidadMensaje especActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[ESPECILIDAD] SET " +
                        "[ID_ESPECIALIDAD] = @id," +
                        "[NOMBRE_ESPECIALIDAD]=@apellido," +
                        "WHERE [CED_DOC]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", especActualizar.CodigoEsp);
                    cmd.Parameters.AddWithValue("@nombre", especActualizar.NomEsp);
                    
                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return especActualizar;
                }
            }
        }

        public static EspecialidadMensaje EliminarEspecialidad(EspecialidadMensaje especialidadElimnar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE[Clinica].[dbo].[ESPECILIDAD]" +
                        "WHERE [CED_DOC]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", especialidadElimnar.CodigoEsp);
                    
                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return especialidadElimnar;
                }
            }
        }
    }
}

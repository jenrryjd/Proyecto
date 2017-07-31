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

        public static EspecialidadMensaje ActualizarEspecialidad(EspecialidadMensaje alergiaActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[ESPECIALIDAD] SET [NOM_ESPECIALIDAD] = @nombre WHERE [ID_ESPECIALIDAD]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", alergiaActualizar.CodigoEsp);
                    cmd.Parameters.AddWithValue("@nombre", alergiaActualizar.NomEsp);


                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return alergiaActualizar;
                }
            }
        }

        public static EspecialidadMensaje Eliminar(EspecialidadMensaje alergiaActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[PACIENTE] WHERE [ID_ESPECIALIDAD]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", alergiaActualizar.CodigoEsp);
                  


                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return alergiaActualizar;
                }
            }
        }

        public static void CargarEspecialidadBox(ComboBoxEdit cmbTipo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [NOM_ESPECIALIDAD] FROM[dbo].[ESPECIALIDAD]";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbTipo.Properties.Items.Add(dr["NOM_ESPECIALIDAD"].ToString());
                    }
                    dr.Close();
                }
            }
        }

        public static void CargarEspecialidadBox1(ComboBoxEdit cmbTipo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [NOM_ESPECIALIDAD] FROM[dbo].[ESPECIALIDAD]";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbTipo.Properties.Items.Add(dr["NOM_ESPECIALIDAD"].ToString());
                    }
                    dr.Close();
                }
            }
        }
        public static DataSet CargarListaDatos(string command)
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

    }
}

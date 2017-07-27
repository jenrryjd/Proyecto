using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;
using DevExpress.XtraEditors;

namespace DAL
{
    public class Alergias
    {

        public static AlergiaMensajes Insertar(AlergiaMensajes AlergiaInsertar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[ALERGIA] ([NOM_ALER],[TIPO_ALER],[DESCRIPCION]) VALUES (@nombre, @tipo, @descripcion); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre", AlergiaInsertar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", AlergiaInsertar.Tipo);
                    cmd.Parameters.AddWithValue("@descripcion", AlergiaInsertar.Descripcion);

                    var IdAlergia = cmd.ExecuteScalar();
                    AlergiaInsertar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return AlergiaInsertar;
                }
            }
        }

        public static AlergiaMensajes Actualizar(AlergiaMensajes alergiaActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[ALERGIA] SET [NOM_ALER] = @nombre,[TIPO_ALER]=@tipo,[DESCRIPCION]=@descripcion WHERE [ID_ALER]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id",alergiaActualizar.Id);
                    cmd.Parameters.AddWithValue("@nombre", alergiaActualizar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", alergiaActualizar.Tipo);
                    cmd.Parameters.AddWithValue("@descripcion", alergiaActualizar.Descripcion);

                    cmd.ExecuteScalar();
                   // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return alergiaActualizar;
                }
            }
        }


        public static void CargarTipoBox(ComboBoxEdit cmbTipo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [NOMBRE_TIPO] FROM[dbo].[TIPOALERGIA]";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbTipo.Properties.Items.Add(dr["NOMBRE_TIPO"].ToString());
                    }
                    dr.Close();
                }
            }
        }

        public static AlergiaMensajes InsertarTipo(string tipo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[TIPOALERGIA] ([NOMBRE_TIPO]) VALUES (@tipo); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    var IdAlergia = cmd.ExecuteScalar();
                    //AlergiaInsertar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return null;
                }
            }
        }

        public static AlergiaMensajes Eliminar(AlergiaMensajes alergiaEliminar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[ALERGIA] WHERE [ID_ALER]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", alergiaEliminar.Id);

                    cmd.ExecuteScalar();
                    // alergiaActualizar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return alergiaEliminar;
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

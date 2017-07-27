using DevExpress.XtraEditors;
using MENSAJES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL
{
    public class Enfermedades
    {
        public static EnfermedadesMensajes Insertar(EnfermedadesMensajes EnfermedadInsertar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[ENFERMEDAD] ([NOM_ENF],[TIP_ENF],[DES_ENF]) VALUES (@nombre, @tipo, @descripcion); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre", EnfermedadInsertar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", EnfermedadInsertar.Tipo);
                    cmd.Parameters.AddWithValue("@descripcion", EnfermedadInsertar.Descripcion);

                    var IdAlergia = cmd.ExecuteScalar();
                    EnfermedadInsertar.Id = Convert.ToInt32(IdAlergia);

                    connection.Close();
                    scope.Complete();
                    return EnfermedadInsertar;
                }
            }
        }

        public static EnfermedadesMensajes Actualizar(EnfermedadesMensajes enfermedadActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[ENFERMEDAD] SET [NOM_ENF] = @nombre,[TIP_ENF]=@tipo,[DES_ENF]=@descripcion WHERE [ID_ENF]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", enfermedadActualizar.Id);
                    cmd.Parameters.AddWithValue("@nombre", enfermedadActualizar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", enfermedadActualizar.Tipo);
                    cmd.Parameters.AddWithValue("@descripcion", enfermedadActualizar.Descripcion);

                    cmd.ExecuteScalar();

                    connection.Close();
                    scope.Complete();
                    return enfermedadActualizar;
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
                    string queryString = "SELECT [NOMBRE_TIPO] FROM[dbo].[TIPOENFERMEDAD]";
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

        public static EnfermedadesMensajes InsertarTipo(string tipo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[TIPOENFERMEDAD] ([NOMBRE_TIPO]) VALUES (@tipo); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.ExecuteScalar();
                    connection.Close();
                    scope.Complete();
                    return null;
                }
            }
        }

        public static EnfermedadesMensajes Eliminar(EnfermedadesMensajes enfermedadEliminar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[ENFERMEDAD] WHERE [ID_ENF]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", enfermedadEliminar.Id);

                    cmd.ExecuteScalar();

                    connection.Close();
                    scope.Complete();
                    return enfermedadEliminar;
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

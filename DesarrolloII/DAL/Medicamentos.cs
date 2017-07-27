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

namespace DAL
{
    public class Medicamentos
    {
        public static MedicamentosMensaje Insertar(MedicamentosMensaje medicametoInsertar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[MEDICAMENTOS] ([NOM_MED],[TIP_MED],[DES_MED]) VALUES (@nombre, @tipo, @descripcion); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre", medicametoInsertar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", medicametoInsertar.Tipo);
                    cmd.Parameters.AddWithValue("@descripcion", medicametoInsertar.Descripcion);

                    var IdMedicamento = cmd.ExecuteScalar();
                    medicametoInsertar.Id = Convert.ToInt32(IdMedicamento);

                    connection.Close();
                    scope.Complete();
                    return medicametoInsertar;
                }
            }
        }

        public static MedicamentosMensaje Actualizar(MedicamentosMensaje medicamentoActualizar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "UPDATE [Clinica].[dbo].[MEDICAMENTOS] SET [NOM_MED] = @nombre,[TIP_MED]=@tipo,[DES_MED]=@descripcion WHERE [ID_MED]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", medicamentoActualizar.Id);
                    cmd.Parameters.AddWithValue("@nombre", medicamentoActualizar.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", medicamentoActualizar.Tipo);
                    cmd.Parameters.AddWithValue("@descripcion", medicamentoActualizar.Descripcion);
                    cmd.ExecuteScalar();
                    connection.Close();
                    scope.Complete();
                    return medicamentoActualizar;
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
                    string queryString = "SELECT [NOMBRE_TIPO] FROM[dbo].[TIPOMEDICAMENTOS]";
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

        public static MedicamentosMensaje InsertarTipo(string tipo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[TIPOMEDICAMENTOS] ([NOMBRE_TIPO]) VALUES (@tipo); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    cmd.ExecuteScalar();
                    connection.Close();
                    scope.Complete();
                    return null;
                }
            }
        }

        public static MedicamentosMensaje Eliminar(MedicamentosMensaje medicamentoEliminar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[MEDICAMENTOS] WHERE [ID_MED]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", medicamentoEliminar.Id);

                    cmd.ExecuteScalar();
                    connection.Close();
                    scope.Complete();
                    return medicamentoEliminar;
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

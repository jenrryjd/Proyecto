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

    }
}

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
    public class AtencionTratamientoDAL
    {
        public int AgregarAtencion(AtencionTratamientoMensajes datos)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[ATENCIONMEDICA] ([ID_CITA_F],[OBSERVACION]) VALUES (@IDCITA, @OBSERVACION); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@IDCITA", datos.IdCita);
                    cmd.Parameters.AddWithValue("@OBSERVACION", datos.ObsevacionAtencion.ToUpper());

                    var id=cmd.ExecuteScalar();
                    int idAten = Convert.ToInt32(id);
                    connection.Close();
                    scope.Complete();
                    return idAten;
                }
            }
        }

        public void AgregarTratamiento(AtencionTratamientoMensajes datos)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[TRATAMIENTO] ([ID_ATEN_MED_F],[OBSER_TRA]) VALUES (@IDATEN, @OBSER); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@IDATEN", datos.IdAtencionMedica);
                    cmd.Parameters.AddWithValue("@OBSER", datos.ObservacionTratamiento.ToUpper());
                    cmd.ExecuteScalar();
                    connection.Close();
                    scope.Complete();
                }
            }
        }
    }
}

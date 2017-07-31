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
    public class RecetaDAL
    {
        public void Insertar(RecetaMensajes receta)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[RECETA] ([ID_TRATAMIENTO_F],[ID_MEDICAMENTO],[NOM_MED],[CANTIDAD],[INDICACIONES]) VALUES (@IDTRA, @IDMEDI,@NOMMEDI,@CANT,@INDI); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@IDTRA", receta.IdTratamiento);
                    cmd.Parameters.AddWithValue("@IDMEDI", receta.IdMedicamento);
                    cmd.Parameters.AddWithValue("@NOMMEDI", receta.NombreMedicamento.ToUpper());
                    cmd.Parameters.AddWithValue("@CANT", receta.Cantidad);
                    cmd.Parameters.AddWithValue("@INDI", receta.Indicaciones.ToUpper());
                    cmd.ExecuteScalar();
                    connection.Close();
                    scope.Complete();
                }
            }
        }
    }
}

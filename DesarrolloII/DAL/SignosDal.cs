using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENSAJES;
using System.Transactions;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class SignosDal
    {
        public static SignosMensajes ConsultarSignos(string idCita)
        {
            try
            {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    SignosMensajes datos = new SignosMensajes();
                    connection.Open();
                    string queryString = "SELECT [ID_SV],[ALTURA_SV],[PESO_SV],[PRESION_SV],[RIT_CAR_SV] FROM[dbo].[SIGNOVITAL] WHERE ID_CITA_F=@idcita; ";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@idcita", idCita);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        datos.Id = Convert.ToInt32(dr["ID_SV"]);
                        datos.Altura = Convert.ToSingle(dr["ALTURA_SV"]);
                        datos.Peso = Convert.ToSingle(dr["PESO_SV"]);
                        datos.Presion = Convert.ToInt32(dr["PRESION_SV"]);
                        datos.RitmoCardiaco = Convert.ToInt32(dr["RIT_CAR_SV"]);
                    }
                    dr.Close();
                    connection.Close();
                    scope.Complete();
                    return datos;
                }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al consutar signos vitales.DAL");
                    return null;
            }
        }

    }
}

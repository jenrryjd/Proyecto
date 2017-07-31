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
   public  class SigninoVitalDAL
    {

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

       
            public static SignosVitales Insertar(SignosVitales medicametoInsertar)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                    {
                        connection.Open();
                        string queryString = "INSERT INTO [dbo].[SIGNOVT] ([ID_CITA_F],[ALTURA_SV],[PESO_SV],[PRESION_SV],[RIT_CAR_SV]) VALUES (@nombre, @tipo, @descripcion,@descripcion1,@descripcion2); SELECT SCOPE_IDENTITY()";
                        SqlCommand cmd = new SqlCommand(queryString, connection);
                        cmd.Parameters.AddWithValue("@nombre", medicametoInsertar.Id_C);
                        cmd.Parameters.AddWithValue("@tipo", medicametoInsertar.Altura);
                        cmd.Parameters.AddWithValue("@descripcion", medicametoInsertar.Peso);
                    cmd.Parameters.AddWithValue("@descripcion1", medicametoInsertar.Presion);
                    cmd.Parameters.AddWithValue("@descripcion2", medicametoInsertar.RitmoCardiaco);



                    var IdMedicamento = cmd.ExecuteScalar();
                        medicametoInsertar.Id = Convert.ToInt32(IdMedicamento);

                        connection.Close();
                        scope.Complete();
                        return medicametoInsertar;
                    }
                }
            }

            public static object ConsultarCita(string text)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    CitaMensajes datos = new CitaMensajes();
                    connection.Open();
                    string queryString = "SELECT [ID_CITA],[CED_PAC_F],[CED_DOC_F],[HORA_CITA],[FECHA_CITA],[ESPECIALISTA_CITA] FROM[dbo].[CITA] WHERE CED_PAC_F LIKE '%@nombre%'); ";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre", text);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        datos.Id = Convert.ToInt32(dr["ID_CITA"]);
                        datos.CedPac = Convert.ToString(dr["CED_PAC_F"]);
                        datos.CedDoc = Convert.ToString(dr["CED_DOC_F"]);
                        datos.Hora = Convert.ToString(dr["HORA_CITA"]);
                        datos.FechaCita = Convert.ToString(dr["FECHA_CITA"]);
                        datos.Especialidad = Convert.ToString(dr["ESPECIALISTA_CITA"]);
                        datos.Especialidad = Convert.ToString(dr["ESTADO_CITA"]);
                    }
                    dr.Close();
                    connection.Close();
                    scope.Complete();
                    return datos;
                }
            }
        }
    }
}

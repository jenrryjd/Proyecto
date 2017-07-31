using MENSAJES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data;
namespace DAL
{
    public class Cita
    {

        public static void Insertar(CitaMensajes citaInsertar)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[CITA]([CED_PAC_F],[CED_DOC_F],[HORA_CITA],[FECHA_CITA],[ESPECIALISTA_CITA])VALUES (@cedPac, @cedDoc, @hora,@fecha,@especialista); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedPac", citaInsertar.CedPac);
                    cmd.Parameters.AddWithValue("@cedDoc", citaInsertar.CedDoc);
                    cmd.Parameters.AddWithValue("@hora", citaInsertar.Hora);
                    cmd.Parameters.AddWithValue("@fecha", citaInsertar.FechaCita);
                    cmd.Parameters.AddWithValue("@especialista", citaInsertar.Especialidad);

                    cmd.ExecuteScalar();

                    connection.Close();
                    scope.Complete();
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
                    string queryString = "SELECT [ID_CITA],[CED_PAC_F],[CED_DOC_F],[HORA_CITA],[FECHA_CITA],[ESPECIALISTA_CITA] FROM[dbo].[CITA] WHERE CED_PAC_F = (SELECT[CED_PAC] FROM[dbo].[PACIENTE] WHERE[NOM_PAC] LIKE '%@nombre%'); ";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@nombre",text);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        datos.Id =Convert.ToInt32(dr["ID_CITA"]);
                        datos.CedPac= Convert.ToString(dr["CED_PAC_F"]);
                        datos.CedDoc = Convert.ToString(dr["CED_DOC_F"]);
                        datos.Hora = Convert.ToString(dr["HORA_CITA"]);
                        datos.FechaCita = Convert.ToString(dr["FECHA_CITA"]);
                        datos.Especialidad = Convert.ToString(dr["ESPECIALISTA_CITA"]);
                    }
                    dr.Close();
                    connection.Close();
                    scope.Complete();
                    return datos;                    
                }
            }
        }

        public static void Eliminar(string id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "DELETE [Clinica].[dbo].[CITA] WHERE [ID_CITA]=@id;";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteScalar();

                    connection.Close();
                    scope.Complete();
                }
            }
        }

        public static void ConsultaHorario(TextEdit txtCedDoc, DateTimePicker dateTimeFechaCita, System.Windows.Forms.ComboBox comboHorario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [HORA_CITA] FROM [dbo].[CITA] WHERE CED_DOC_F=@cedDoc AND [FECHA_CITA]=@fecha";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedDoc", txtCedDoc.Text);
                    cmd.Parameters.AddWithValue("@fecha", dateTimeFechaCita.Text.ToString());

                    var dr = cmd.ExecuteReader();
                    comboHorario.Refresh();
                    while (dr.Read())
                    {
                        comboHorario.Items.Remove(dr["HORA_CITA"].ToString());
                    }
                    dr.Close();

                    connection.Close();
                    scope.Complete();
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

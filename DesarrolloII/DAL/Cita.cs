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
            try
            {

            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "INSERT INTO [dbo].[CITA]([CED_PAC_F],[CED_DOC_F],[HORA_CITA],[FECHA_CITA],[ESPECIALISTA_CITA],[ESTADO_CITA])VALUES (@cedPac, @cedDoc, @hora,@fecha,@especialista,@estado); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedPac", citaInsertar.CedPac);
                    cmd.Parameters.AddWithValue("@cedDoc", citaInsertar.CedDoc);
                    cmd.Parameters.AddWithValue("@hora", citaInsertar.Hora);
                    cmd.Parameters.AddWithValue("@fecha", citaInsertar.FechaCita);
                    cmd.Parameters.AddWithValue("@especialista", citaInsertar.Especialidad);
                    cmd.Parameters.AddWithValue("@estado", citaInsertar.Estado);

                    cmd.ExecuteScalar();

                    connection.Close();
                    scope.Complete();

                    MessageBox.Show("Datos insertados con exito.");
                    }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Insertar Datos");
            }
        }

        /// <summary>
        /// ACTUALIZA ESTADO DE LA CITA
        /// </summary>
        /// <param name="v"></param>
        public static void ActualizarEstado(string id,string v)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                    {
                        connection.Open();
                        string queryString = "UPDATE [Clinica].[dbo].[CITA] SET [ESTADO_CITA]=@ESTADO WHERE [ID_CITA]=@id;";
                        SqlCommand cmd = new SqlCommand(queryString, connection);
                        cmd.Parameters.AddWithValue("@id",id );
                        cmd.Parameters.AddWithValue("@ESTADO", v);
                        cmd.ExecuteScalar();

                        connection.Close();
                        scope.Complete();
                        if (v.Equals("CANCELADA"))
                            MessageBox.Show("Su cita ha sido cancelada.");
                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede modificar la cita.");
            }
        }

        /// <summary>
        /// ACTUALIZAR LOS CAMPOS DE LAS CITAS
        /// </summary>
        /// <param name="citaActualizar"></param>
        /// <returns></returns>

        public static CitaMensajes Actualizar(CitaMensajes citaActualizar)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                    {
                        connection.Open();
                        string queryString = "UPDATE [Clinica].[dbo].[CITA] SET [HORA_CITA] = @HORA,[FECHA_CITA]=@FECHA,[ESPECIALISTA_CITA]=@ESPECIALISTA,[CED_DOC_F]=@CEDDOC WHERE [ID_CITA]=@id;";
                        SqlCommand cmd = new SqlCommand(queryString, connection);
                        cmd.Parameters.AddWithValue("@id", citaActualizar.Id);
                        cmd.Parameters.AddWithValue("@HORA", citaActualizar.Hora);
                        cmd.Parameters.AddWithValue("@FECHA", citaActualizar.FechaCita);
                        cmd.Parameters.AddWithValue("@ESPECIALISTA", citaActualizar.Especialidad);
                        cmd.Parameters.AddWithValue("@CEDDOC", citaActualizar.CedDoc);

                        cmd.ExecuteScalar();

                        connection.Close();
                        scope.Complete();
                        MessageBox.Show("Se ha actualizado la Cita");
                        return citaActualizar;
                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede modificar la cita.");
                return null ;
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
                        datos.Especialidad = Convert.ToString(dr["ESTADO_CITA"]);
                    }
                    dr.Close();
                    connection.Close();
                    scope.Complete();
                    return datos;                    
                }
            }
        }

        /// <summary>
        /// ELIMINAR DATOS DE LA TABLA CITA
        /// </summary>
        /// <param name="id"></param>

        public static void Eliminar(string id)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar la Cita."); ;
            }
        }

        public static void ConsultaHorario(TextEdit txtCedDoc, DateTimePicker dateTimeFechaCita, System.Windows.Forms.ComboBox comboHorario)
        {
            try
            {

            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT [HORA_CITA] FROM [dbo].[CITA] WHERE CED_DOC_F=@cedDoc AND [FECHA_CITA]=@fecha ";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@cedDoc", txtCedDoc.Text);
                    cmd.Parameters.AddWithValue("@fecha", dateTimeFechaCita.Text.ToString());

                    var dr = cmd.ExecuteReader();
                    //comboHorario.Refresh();
                    while (dr.Read())
                    {
                        comboHorario.Items.Remove(dr["HORA_CITA"].ToString());
                        MessageBox.Show(dr["HORA_CITA"].ToString());
                    }
                    dr.Close();

                    connection.Close();
                    scope.Complete();
                }
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar horario de especialista.");
            }
        }

        public static DataSet CargarListaDatos(string command)
        {
            try
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
            catch (Exception)
            {

                MessageBox.Show("Error al consultar datos. DAL CargarListaDatos");
                return null;
            }
            
        }
    }
}

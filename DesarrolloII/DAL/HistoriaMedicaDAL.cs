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
    public class HistoriaMedicaDAL
    {
        /// <summary>
        /// CONSULTA HISTORIA CLINICA DE UN PACIENTE SEGUN LA CEDULA
        /// </summary>
        /// <param name="cedulaPaciente"></param>
        /// <returns></returns>
        public static HistoriaMedicaMensajes ConsultarHistoriaMedica(string cedulaPaciente)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                    {
                        HistoriaMedicaMensajes datos = new HistoriaMedicaMensajes();
                        connection.Open();
                        string queryString = "SELECT [ID_HM],[TIP_SANGRE_HM],[ALERGIAS],[ENFERMEDADES] FROM[dbo].[HISTORIAMEDICA] WHERE CED_PAC_F=@cedulaPaciente; ";
                        SqlCommand cmd = new SqlCommand(queryString, connection);
                        cmd.Parameters.AddWithValue("@cedulaPaciente", cedulaPaciente);

                        var dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            datos.Id=Convert.ToInt32(dr["ID_HM"]);
                            datos.TipoSangre = dr["TIP_SANGRE_HM"].ToString();
                            datos.Alergias = dr["ALERGIAS"].ToString();
                            datos.Enfermedades = dr["ENFERMEDADES"].ToString();
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

                MessageBox.Show("Error al consutar Historia Clinica del paciente.DAL");
                return null;
            }
        }

        public static int ConsultaNumeroHistoria()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                    {
                        int numero=0;
                        connection.Open();
                        string queryString = "SELECT TOP 1 ID_ATEN_MED FROM [dbo].[ATENCIONMEDICA] ORDER BY	ID_ATEN_MED DESC ";
                        SqlCommand cmd = new SqlCommand(queryString, connection);

                        var dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            numero =Convert.ToInt32(dr["ID_ATEN_MED"]);
                        }
                        dr.Close();
                        connection.Close();
                        scope.Complete();
                        return numero;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al consutar Numero de Historia Clinica.DAL");
                return 0;
            }
        }
    }
}


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
    public class LoginDAL
    {
        /// <summary>
        /// VERIFICA LA EXISTENCIA DEL USUARIO CON SU CONTRASEÑA
        /// </summary>
        /// <param name="credenciales"></param>
        /// <returns></returns>
        public static LoginMensajes Verificar(LoginMensajes credenciales)
        {
            try
            {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(ConexionClinica.Default.Conexion))
                {
                    connection.Open();
                    string queryString = "SELECT * FROM[dbo].[LOGIN] WHERE [USUARIO]=@USER AND [CONTRASENIA]=@CONTRA";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@USER", credenciales.Usuario);
                    cmd.Parameters.AddWithValue("@CONTRA", credenciales.Contrasenia);
                    var dr = cmd.ExecuteReader();

                    if (!dr.Equals(null))
                    {
                        LoginMensajes datos = new LoginMensajes();
                        while (dr.Read())
                        {
                            datos.NombreUsuario = (dr["NOMBRE_USUARIO"].ToString());
                            datos.Perfil = (dr["PERFIL"].ToString());
                            datos.Cargo = (dr["CARGO"].ToString());
                            }
                        dr.Close();
                        connection.Close();
                        scope.Complete();
                        
                        return datos;
                    }
                     return null;
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al verificar datos.");
                return null;
            }
        }
    }
    }


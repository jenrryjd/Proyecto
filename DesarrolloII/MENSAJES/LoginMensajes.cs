using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class LoginMensajes
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string Perfil { get; set; }
        public string Cargo { get; set; }

        public LoginMensajes()
        {

        }

        public LoginMensajes(int id, string nombreusuario, string usuario, string contraseña, string perfil,string cargo)
        {
            this.Id = id;
            this.NombreUsuario = nombreusuario;
            this.Usuario = usuario;
            this.Contrasenia = contraseña;
            this.Perfil = perfil;
            this.Cargo = cargo;
        }


    }
}

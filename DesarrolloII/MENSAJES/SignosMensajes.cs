using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class SignosMensajes
    {
        public int Id { get; set; }
        public int IdCitaF { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public int Presion { get; set; }
        public int RitmoCardiaco { get; set; }

        public SignosMensajes()
        {

        }

        public SignosMensajes(int id,int idcita,float altura,float peso,int presion,int ritmocardiaco)
        {
            this.Id = id;
            this.IdCitaF = idcita;
            this.Altura = altura;
            this.Peso = peso;
            this.Presion = presion;
            this.RitmoCardiaco = ritmocardiaco;
        }

    }
}

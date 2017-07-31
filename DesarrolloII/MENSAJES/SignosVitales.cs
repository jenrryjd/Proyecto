using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAJES
{
    public class SignosVitales
    {
        public int Id { get; set; }
        public int Id_C{ get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Presion { get; set; }
        public int RitmoCardiaco { get; set; }

        public SignosVitales()
        {

        }
        public SignosVitales(int id,int id_c,decimal altura,decimal peso,string presion,int ridmocar)
        {
            this.Id = id;
            this.Id_C = id_c;
            this.Altura = altura;
            this.Peso = peso;
            this.Presion = presion;
            this.RitmoCardiaco = RitmoCardiaco;
        }
    }
}

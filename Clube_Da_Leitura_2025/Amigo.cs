using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_Da_Leitura_2025
{
   public  class Amigo
    {
        public int Id;
        public string NomeCompleto;
        public string NomeResponsavel;
        public string NumeroTelefone;


        public Amigo(string nomeCompleto, string nomeResponsavel, string numeroTelefone)
        {
            
            NomeCompleto = nomeCompleto;
            NomeResponsavel = nomeResponsavel;
            NumeroTelefone = numeroTelefone;
        }
    }
}

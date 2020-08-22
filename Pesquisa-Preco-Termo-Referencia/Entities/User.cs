using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_Preco_Termo_Referencia.Entities
{
    class User
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public int Cargo { get; set; }


        public User()
        {

        }

        public User(string nome, string rG, int cargo)
        {
            Nome = nome;
            RG = rG;
            Cargo = cargo;
        }
    }
}

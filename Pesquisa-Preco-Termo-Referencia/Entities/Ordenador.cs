using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_Preco_Termo_Referencia.Entities
{
    class Ordenador
    {
        public string OrdenadorNome { get; set; }
        public string OrdenadorRG { get; set; }
        public string OrdenadorCargo { get; set; }
        public string OrdenadorIsAtual { get; set; }

        public Ordenador()
        {

        }

        public Ordenador(string ordenadorNome, string ordenadorRG, string ordenadorCargo, string ordenadorIsAtual)
        {
            OrdenadorNome = ordenadorNome;
            OrdenadorRG = ordenadorRG;
            OrdenadorCargo = ordenadorCargo;
            OrdenadorIsAtual = ordenadorIsAtual;
        }
    }
}

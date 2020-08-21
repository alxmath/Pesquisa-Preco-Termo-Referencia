using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pesquisa_Preco_Termo_Referencia.Entities
{
    class Siafisico
    {
        public string Item { get; set; }
        public string CodigoSiafisico { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public string Descricao { get; set; }
        public string TipoLicitacao { get; set; }

        public Siafisico()
        {

        }

        public Siafisico(string item, string codigoSiafisico, string unidade,
            double quantidade, string descricao, string tipoLicitacao)
        {
            Item = item;
            CodigoSiafisico = codigoSiafisico;
            Unidade = unidade;
            Quantidade = quantidade;
            Descricao = descricao;
            TipoLicitacao = tipoLicitacao;
        }

        public override string ToString()
        {
            return Item + ", " + CodigoSiafisico + ", " + Unidade + ", " + Quantidade + ", " + Descricao;
        }
    }
}

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
        public string ProcessoPedido { get; set; }

        public string Nome { get; set; }
        public string RG { get; set; }
        public string Cargo { get; set; }
        public string Now { get; set; }

        public Siafisico()
        {

        }

        //public Siafisico(string item, string codigoSiafisico, string unidade,
        //    double quantidade, string descricao, string tipoLicitacao, string processoPedido)
        //{
        //    Item = item;
        //    CodigoSiafisico = codigoSiafisico;
        //    Unidade = unidade;
        //    Quantidade = quantidade;
        //    Descricao = descricao;
        //    TipoLicitacao = tipoLicitacao;
        //    ProcessoPedido = processoPedido;
        //}

        //public Siafisico(string item, string codigoSiafisico, string unidade, 
        //    double quantidade, string descricao, string tipoLicitacao, string processoPedido, 
        //    string nome, string rG, string cargo) : this(item, codigoSiafisico, unidade, quantidade, descricao, tipoLicitacao, processoPedido)
        //{
        //    Nome = nome;
        //    RG = rG;
        //    Cargo = cargo;
        //}

        public override string ToString()
        {
            return Item + ", " + CodigoSiafisico + ", " + Unidade + ", " + Quantidade + ", " + Descricao;
        }
    }
}

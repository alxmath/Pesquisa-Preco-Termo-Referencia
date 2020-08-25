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
        public string TipoLicitacaoLoteItem { get; set; }
        public string Assunto { get; set; }

        public Siafisico()
        {

        }

        public override string ToString()
        {
            return Item + ", " + CodigoSiafisico + ", " + Unidade + ", " + Quantidade + ", " + Descricao;
        }
    }
}

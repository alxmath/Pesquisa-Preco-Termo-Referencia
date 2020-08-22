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

        public override string ToString()
        {
            return Item + ", " + CodigoSiafisico + ", " + Unidade + ", " + Quantidade + ", " + Descricao;
        }
    }
}

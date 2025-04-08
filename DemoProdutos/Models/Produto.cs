namespace DemoProdutos.Models
{
    public class Produto
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public decimal Peso { get; set; } // em kg
        public string Categoria { get; set; } = string.Empty;
        public string FotoUrl { get; set; } = string.Empty;
    }
}
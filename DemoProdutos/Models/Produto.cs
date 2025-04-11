namespace DemoProdutos.Models;

public class Produto
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Referencia { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public string Imagem { get; set; } = string.Empty;
}
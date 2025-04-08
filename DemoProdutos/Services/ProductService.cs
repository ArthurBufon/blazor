// Services/ProductService.cs
public static class ProductService
{
    private static readonly string[] Categorias = new[]
    {
        "Eletrônicos", "Esportes", "Casa", "Moda", "Beleza", "Livros"
    };

    private static readonly Dictionary<string, string[]> DescricoesPorCategoria = new()
    {
        { "Eletrônicos", new[] { "Smartphone", "Notebook", "Tablet", "Smartwatch" } },
        { "Esportes", new[] { "Bola de Futebol", "Raquete", "Tênis", "Equipamento Academia" } },
        { "Casa", new[] { "Panela", "Liquidificador", "Jogo de Copos", "Cama" } },
        { "Moda", new[] { "Camiseta", "Calça Jeans", "Vestido", "Terno" } },
        { "Beleza", new[] { "Perfume", "Creme Facial", "Kit Maquiagem", "Secador de Cabelo" } },
        { "Livros", new[] { "Romance", "Ficção", "Técnico", "Biografia" } }
    };

    public static List<DemoProdutos.Models.Produto> GerarProdutosDummy(int quantidade)
    {
        var random = new Random();
        var produtos = new List<DemoProdutos.Models.Produto>();

        for (int i = 1; i <= quantidade; i++)
        {
            var categoria = Categorias[random.Next(Categorias.Length)];
            var descricao = DescricoesPorCategoria[categoria][random.Next(DescricoesPorCategoria[categoria].Length)] + $" Modelo {i}";

            produtos.Add(new DemoProdutos.Models.Produto
            {
                Descricao = descricao,
                Valor = Math.Round((decimal)(random.NextDouble() * 990 + 10), 2),
                Peso = Math.Round((decimal)(random.NextDouble() * 19.9 + 0.1), 2),
                Categoria = categoria,
                FotoUrl = GerarUrlImagem(categoria, descricao)
            });
        }

        return produtos;
    }

    private static string GerarUrlImagem(string categoria, string descricao)
    {
        var imagens = new[]
        {
        "https://images.kabum.com.br/produtos/fotos/sync_mirakl/519143/Celular-Apple-Iphone-15-128GB-Br-Mtp03br-a-Preto-Quadriband_1730143980_gg.jpg",
        "https://www.estadao.com.br/recomenda/wp-content/uploads/2023/09/AdobeStock_876086159_Editorial_Use_Only.jpeg.webp",
        "https://t2.tudocdn.net/720005?w=1200&h=1200"
    };

        var random = new Random();
        int index = random.Next(imagens.Length);

        return imagens[index];
    }

}
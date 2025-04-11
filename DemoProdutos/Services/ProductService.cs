// Services/ProductService.cs
using DemoProdutos.Models;

namespace DemoCatalogo.Services;

public class ProdutoService
{
    private readonly List<Produto> _products = new();
    private int _currentId = 1;

    public ProdutoService()
    {
        GenerateDummyProdutos(9);
    }

    private void GenerateDummyProdutos(int quantity)
    {
        var random = new Random();

        for (int i = 0; i < quantity; i++)
        {
            _products.Add(new Produto
            {
                Id = _currentId++,
                Descricao = $"Produto {_currentId}",
                Referencia = $"REF-{random.Next(1000, 9999)}",
                Valor = (decimal)(random.NextDouble() * 990 + 10),
                Imagem = $"https://picsum.photos/300/200?random={_currentId}"
            });
        }
    }

    public List<Produto> SearchProdutos(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return _products;

        return _products.Where(p =>
            p.Descricao.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            p.Referencia.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
        ).ToList();
    }

    public List<Produto> BuscarProdutosEmDestaque() => _products.Take(9).ToList();

}
using DemoCatalogo.Models;

namespace DemoCatalogo.Services
{
    public class ProdutoService
    {
        private readonly List<Produto> _produtos = new();
        private int _currentId = 1;

        public ProdutoService()
        {
            GenerateDummyProducts(50);
        }

        private void GenerateDummyProducts(int quantity)
        {
            var random = new Random();

            for (int i = 0; i < quantity; i++)
            {
                _produtos.Add(new Produto
                {
                    Id = _currentId++,
                    Descricao = $"Produto {_currentId}",
                    Referencia = $"REF-{random.Next(1000, 9999)}",
                    Valor = (decimal)(random.NextDouble() * 990 + 10),
                    Imagem = $"https://picsum.photos/300/200?random={_currentId}"
                });
            }
        }
        public List<Produto> BuscarEmDestaque() => _produtos.Take(9).ToList();

        public List<Produto> BuscarTodos(string termo)
        {
            return _produtos.Where(p =>
                p.Descricao.Contains(termo, StringComparison.OrdinalIgnoreCase) ||
                p.Referencia.Contains(termo, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }
    }
}

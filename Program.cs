namespace CadastroProdutos;

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de produtos");

        AdicionarProduto("Caneta", 2.50m, 100);
        AdicionarProduto("Caderno", 15.90m, 30);
        AdicionarProduto("Borracha", 1.20m, 200);

        ListarProdutos();

        var encontrado = BuscarPorNome("caderno");
        if (encontrado != null)
        {
            Console.WriteLine("\nEncontrado: " + encontrado);
        }
    }

    static void AdicionarProduto(string nome, decimal preco, int quantidade)
    {
        produtos.Add(new Produto(nome, preco, quantidade));
    }

    static void ListarProdutos()
    {
        foreach (var p in produtos)
        {
            Console.WriteLine(p);
        }
    }

    static Produto? BuscarPorNome(string nome)
    {
        // ignora maiuscula/minuscula na busca
        foreach (var p in produtos)
        {
            if (p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return p;
            }
        }
        return null;
    }
}

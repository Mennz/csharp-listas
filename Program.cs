namespace CadastroProdutos;

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        AdicionarProduto("Caneta", 2.50m, 100);
        AdicionarProduto("Caderno", 15.90m, 30);
        AdicionarProduto("Borracha", 1.20m, 200);

        bool rodando = true;
        while (rodando)
        {
            MostrarMenu();
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ListarProdutos();
                    break;
                case "2":
                    CadastrarNovoProduto();
                    break;
                case "3":
                    BuscarEMostrar();
                    break;
                case "4":
                    RemoverEMostrar();
                    break;
                case "0":
                    rodando = false;
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n--- Cadastro de produtos ---");
        Console.WriteLine("1 - Listar");
        Console.WriteLine("2 - Adicionar");
        Console.WriteLine("3 - Buscar por nome");
        Console.WriteLine("4 - Remover por nome");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha: ");
    }

    static void CadastrarNovoProduto()
    {
        Console.Write("Nome: ");
        var nome = Console.ReadLine() ?? "";

        Console.Write("Preco: ");
        decimal.TryParse(Console.ReadLine(), out decimal preco);

        Console.Write("Quantidade: ");
        int.TryParse(Console.ReadLine(), out int quantidade);

        AdicionarProduto(nome, preco, quantidade);
        Console.WriteLine("Produto adicionado");
    }

    static void BuscarEMostrar()
    {
        Console.Write("Nome a buscar: ");
        var nome = Console.ReadLine() ?? "";

        var produto = BuscarPorNome(nome);
        Console.WriteLine(produto != null ? produto.ToString() : "Nao encontrado");
    }

    static void RemoverEMostrar()
    {
        Console.Write("Nome a remover: ");
        var nome = Console.ReadLine() ?? "";

        var removeu = RemoverPorNome(nome);
        Console.WriteLine(removeu ? "Removido" : "Nao encontrado");
    }

    static void AdicionarProduto(string nome, decimal preco, int quantidade)
    {
        produtos.Add(new Produto(nome, preco, quantidade));
    }

    static void ListarProdutos()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado");
        }
        foreach (var p in produtos)
        {
            Console.WriteLine(p);
        }
    }

    static Produto? BuscarPorNome(string nome)
    {
        foreach (var p in produtos)
        {
            if (p.Nome.Equals(nome.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return p;
            }
        }
        return null;
    }

    static bool RemoverPorNome(string nome)
    {
        var produto = BuscarPorNome(nome);
        if (produto == null)
        {
            return false;
        }
        produtos.Remove(produto);
        return true;
    }
}

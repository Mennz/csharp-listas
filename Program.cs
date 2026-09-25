namespace CadastroProdutos;

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de produtos");

        AdicionarProduto("Caneta", 2.50m, 100);
        AdicionarProduto("Caderno", 15.90m, 30);

        foreach (var p in produtos)
        {
            Console.WriteLine(p);
        }
    }

    static void AdicionarProduto(string nome, decimal preco, int quantidade)
    {
        produtos.Add(new Produto(nome, preco, quantidade));
    }
}

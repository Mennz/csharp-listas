namespace CadastroProdutos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de produtos");

        var produto = new Produto("Caneta", 2.50m, 100);
        Console.WriteLine(produto);
    }
}

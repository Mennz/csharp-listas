namespace CadastroProdutos;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"{Nome} - R$ {Preco:0.00} - {Quantidade} un.";
    }
}

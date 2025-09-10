namespace Projeto_Estoque_2.Classes;

public class Produto_Vestuario : Produto
{
    public string modelo { get; set; }
    public string cor { get; set; }
    public string tamanho { get; set; }
    public Produto_Vestuario(string Nome, double Preco, int Quantidade, string sku, string Modelo, string Cor, string Tamanho) : base(Nome, Preco, Quantidade, sku)
    {
        modelo = Modelo;
        cor = Cor;
        tamanho = Tamanho;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($@"| Modelo: {modelo}
| Cor: {cor}
| Tamanho: {tamanho}
|---------------------------------------");
    }
}
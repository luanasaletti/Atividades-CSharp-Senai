﻿namespace Projeto_Estoque_2.Classes;

public class Produto_Eletronico : Produto
{
    public string voltagem { get; set; }
    public bool bateria { get; set; }
    public Produto_Eletronico(string Nome, double Preco, int Quantidade, string sku, string Voltagem, bool Bateria) : base(Nome, Preco, Quantidade, sku)
    {
        voltagem = Voltagem;
        bateria = Bateria;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($@"| Voltagem: {voltagem}
| Bateria: {(bateria ? "Sim" : "Não")}
|---------------------------------------");
    }
}
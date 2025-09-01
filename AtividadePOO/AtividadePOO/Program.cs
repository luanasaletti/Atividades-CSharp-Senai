using System;
using AtividadePOO;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();

        // Entrada de dados pelo usuário
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        pessoa1.SetNome(nome);

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());
        pessoa1.SetIdade(idade); // Aqui já faz a validação

        Console.WriteLine();
        pessoa1.ExibirDados();

        Console.ReadLine();
    }
}

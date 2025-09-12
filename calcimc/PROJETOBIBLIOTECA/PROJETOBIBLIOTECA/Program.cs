using System;
using PROJETOBIBLIOTECA;

namespace BibliotecaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("\n===== Menu da Biblioteca =====");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Pesquisar por Título");
                Console.WriteLine("4 - Pesquisar por Autor");
                Console.WriteLine("5 - Emprestar Livro");
                Console.WriteLine("6 - Devolver Livro");
                Console.WriteLine("7 - Listar Todos os Livros");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ano de publicação: ");
                        int ano = int.Parse(Console.ReadLine());
                        biblioteca.AdicionarLivro(new Livro(titulo, autor, ano));
                        break;

                    case 2:
                        Console.Write("Digite o título do livro a remover: ");
                        biblioteca.RemoverLivro(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Digite o título para pesquisar: ");
                        biblioteca.PesquisarPorTitulo(Console.ReadLine());
                        break;

                    case 4:
                        Console.Write("Digite o autor para pesquisar: ");
                        biblioteca.PesquisarPorAutor(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Digite o título do livro a emprestar: ");
                        biblioteca.EmprestarLivro(Console.ReadLine());
                        break;

                    case 6:
                        Console.Write("Digite o título do livro a devolver: ");
                        biblioteca.DevolverLivro(Console.ReadLine());
                        break;

                    case 7:
                        biblioteca.listartodos();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
);
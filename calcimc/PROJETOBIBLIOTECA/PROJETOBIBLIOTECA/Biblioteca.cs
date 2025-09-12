
namespace PROJETOBIBLIOTECA;

    public class Biblioteca
{
    private List<Livro> livros;

    public Biblioteca()
    {
        livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro \"{livro.titulo}\" adicionado ao catálogo.");
    }

    public void RemoverLivro(string titulo)
    {
        var livro = livros.FirstOrDefault(l => l.titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livros.Remove(livro);
            Console.WriteLine($"Livro \"{titulo}\" removido do catálogo.");
        }
        else
        {
            Console.WriteLine($"Livro \"{titulo}\" não encontrado.");
        }
    }

    public void PesquisarPorTitulo(string titulo)
    {
        var resultados = livros.Where(l => l.titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
        MostrarResultados(resultados);
    }

    public void PesquisarPorAutor(string autor)
    {
        var resultados = livros.Where(l => l.autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
        MostrarResultados(resultados);
    }

    public void EmprestarLivro(string titulo)
    {
        var livro = livros.FirstOrDefault(l => l.titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livro.Emprestar();
        }
        else
        {
            Console.WriteLine($"Livro \"{titulo}\" não encontrado.");
        }
    }

    public void DevolverLivro(string titulo)
    {
        var livro = livros.FirstOrDefault(l => l.titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine($"Livro \"{titulo}\" não encontrado.");
        }
    }

    private void MostrarResultados(List<Livro> resultados)
    {
        if (resultados.Any())
        {
            Console.WriteLine("\nResultados da pesquisa:");
            foreach (var livro in resultados)
            {
                Console.WriteLine(livro);
            }
        }
        else
        {
            Console.WriteLine("Nenhum livro encontrado.");
        }
    }

    public void listartodos()
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro no catálogo.");
            return;
        }

        Console.WriteLine("\nCatálogo de livros:");
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
    }


    class Programk
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Adicionando livros
            biblioteca.AdicionarLivro(new Livro( "E assim que acaba", "Coleen Hoover", 2020));;
            biblioteca.AdicionarLivro(new Livro("1984", "George Orwell", 1949));

            biblioteca.listartodos();

            // Pesquisa
            biblioteca.PesquisarPorTitulo("Dom");
            biblioteca.PesquisarPorAutor("Orwell");

            // Empréstimo
            biblioteca.EmprestarLivro("O Hobbit");
            biblioteca.EmprestarLivro("O Hobbit"); // Tentativa de emprestar novamente

            biblioteca.listartodos();

            // Devolução
            biblioteca.DevolverLivro("O Hobbit");
            biblioteca.listartodos(  );

            // Remoção
            biblioteca.RemoverLivro("1984");
            biblioteca.listartodos();

            Console.ReadKey();
        }
 
    }
}


namespace PROJETOBIBLIOTECA
{
    public class Livro
    {

        public string titulo { get;  set; }
        public string autor { get;  set; }
        public int anoPublicacao { get;  set; }
        public bool estado { get; private set; }


        public Livro(string Titulo, string Autor, int AnoPublicacao, bool Estado)
        {
            titulo = Titulo;
            autor = Autor;
            anoPublicacao = AnoPublicacao;
            estado = true;
        }

        public Livro(string v1, string v2, int v3)
        {
            
        }

        public void Emprestar()
        {
            if (estado)
            {
                estado = false;
                Console.WriteLine($"Livro \"{titulo}\" emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Livro \"{titulo}\" não está disponível para empréstimo.");
            }
        }

        public void Devolver()
        {
            if (!estado)
            {
                estado = true;
                Console.WriteLine($"Livro \"{titulo}\" devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Livro \"{titulo}\" já está disponível.");
            }
        }

        public override string ToString()
        {
            return $"{titulo} - {autor} ({anoPublicacao}) | {(estado ? "Disponível" : "Emprestado")}";
        }
    }

}

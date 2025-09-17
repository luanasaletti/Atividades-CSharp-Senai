using JogodaVelha;

internal class Program
{
    private static void Main(string[] args)
    {
        Tabuleiro tabuleiro = new Tabuleiro();
        Jogador jogadorAtual = jogador1;
        bool jogoTerminou = false;


        Console.WriteLine("=== Bem-Vindo(a) ao Jogo da Velha!! ===");

        Console.Write("Insira o seu nome: ");
        string v = ColetarNome();
        string jogador1 = v;
        Console.Write("Insira o seu nome: ");
        string jogador2 = ColetarNome();

        string ColetarNome()
        {
            while (true)
            {
                string entrada = Console.ReadLine();
                bool apenasLetras = true;

                // verifica cada caractere digitado
                foreach (char c in entrada)
                {
                    if (!char.IsLetter(c))
                    {
                        apenasLetras = false;
                        break;
                    }
                }

                if (apenasLetras && entrada != "")
                {
                    return entrada;
                }
                else
                {
                    Console.Write("Entrada inválida! Digite apenas letras: ");
                }
            }
        }

        while (!jogoTerminou)
        {
            //desenhar tabuleiro para o usuario
            tabuleiro.Desenhar();

            //Pedir a jogada do jogador atual
            Console.WriteLine($"\n{jogadorAtual.Nome}, sua vez! Escolha uma posicao: (1-9)");
            Console.ReadLine();
            int posicao = int.Parse(Console.ReadLine());

            //marcar jogada
            if (tabuleiro.MarcarJogada(posicao, jogadorAtual.Simbolo))
            {
                if (tabuleiro.VerificarVencedor(jogadorAtual.Simbolo))
                {
                    tabuleiro.Desenhar();
                    Console.WriteLine($"\nParabens {jogadorAtual.Nome} venceu!");
                    jogoTerminou = true;
                }
                else if (tabuleiro.VerificarEmpate())
                {
                    tabuleiro.Desenhar();
                    Console.WriteLine("\nO Jogo terminou em Empate!");
                    jogoTerminou = true;
                }
                else
                {
                    jogadorAtual = jogadorAtual == jogador1 ? jogador2 : jogador1;
                }
            }
            else
            {
                Console.WriteLine("Jogada incorreta! Pressione Enter para tentar novamente!");
                Console.ReadKey();
            }
        }
    }
}
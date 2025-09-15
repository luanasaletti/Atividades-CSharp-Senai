using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem heroi = new Personagem("Arthas", "Guerreiro", 50, 12);
            Monstro monstro = new Monstro("Grommash", "Orc", 40, 8);

            Batalha batalha = new Batalha();
            batalha.IniciarBatalha(heroi, monstro);

            Console.WriteLine("\nFim do jogo!");
            Console.ReadKey();
        }
    }
}

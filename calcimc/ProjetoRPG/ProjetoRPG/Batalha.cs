using System;

namespace JogoRPG
{
    public class Batalha
    {
        public void IniciarBatalha(Personagem heroi, Monstro monstro)
        {
            Console.WriteLine($"⚔️ Batalha iniciada! {heroi.Nome} ({heroi.Classe}) vs {monstro.Nome} ({monstro.Tipo})");
            Console.WriteLine();

            while (heroi.EstaVivo && monstro.EstaVivo)
            {
                Console.WriteLine("\nEscolha sua ação:");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Curar");

                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    heroi.Atacar(monstro);
                }
                else if (escolha == "2")
                {
                    heroi.Curar();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Você perdeu a vez!");
                }

                // Verificar se o monstro morreu
                if (!monstro.EstaVivo)
                {
                    Console.WriteLine($"\n🎉 {heroi.Nome} derrotou {monstro.Nome}!");
                    break;
                }

                // Turno do monstro
                monstro.Atacar(heroi);

                if (!heroi.EstaVivo)
                {
                    Console.WriteLine($"\n💀 {heroi.Nome} foi derrotado por {monstro.Nome}...");
                    break;
                }
            }
        }
    }
}
